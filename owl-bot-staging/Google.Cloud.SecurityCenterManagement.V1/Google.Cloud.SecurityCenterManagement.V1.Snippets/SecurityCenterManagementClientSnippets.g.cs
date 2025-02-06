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
    using Google.Cloud.SecurityCenterManagement.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecurityCenterManagementClientSnippets
    {
        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModules</summary>
        public void ListEffectiveSecurityHealthAnalyticsCustomModulesRequestObject()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModules(ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListEffectiveSecurityHealthAnalyticsCustomModulesRequestObjectAsync()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveSecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModules</summary>
        public void ListEffectiveSecurityHealthAnalyticsCustomModules()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModules(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListEffectiveSecurityHealthAnalyticsCustomModulesAsync()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveSecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModules</summary>
        public void ListEffectiveSecurityHealthAnalyticsCustomModulesResourceNames1()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModules(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListEffectiveSecurityHealthAnalyticsCustomModulesResourceNames1Async()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveSecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModules</summary>
        public void ListEffectiveSecurityHealthAnalyticsCustomModulesResourceNames2()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModules(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListEffectiveSecurityHealthAnalyticsCustomModulesResourceNames2Async()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveSecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModules</summary>
        public void ListEffectiveSecurityHealthAnalyticsCustomModulesResourceNames3()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModules(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListEffectiveSecurityHealthAnalyticsCustomModulesResourceNames3Async()
        {
            // Snippet: ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveSecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveSecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveSecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveSecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveSecurityHealthAnalyticsCustomModule</summary>
        public void GetEffectiveSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Snippet: GetEffectiveSecurityHealthAnalyticsCustomModule(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request = new GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
            {
                EffectiveSecurityHealthAnalyticsCustomModuleName = EffectiveSecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
            };
            // Make the request
            EffectiveSecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task GetEffectiveSecurityHealthAnalyticsCustomModuleRequestObjectAsync()
        {
            // Snippet: GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Additional: GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request = new GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
            {
                EffectiveSecurityHealthAnalyticsCustomModuleName = EffectiveSecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
            };
            // Make the request
            EffectiveSecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveSecurityHealthAnalyticsCustomModule</summary>
        public void GetEffectiveSecurityHealthAnalyticsCustomModule()
        {
            // Snippet: GetEffectiveSecurityHealthAnalyticsCustomModule(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/effectiveSecurityHealthAnalyticsCustomModules/[EFFECTIVE_SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]";
            // Make the request
            EffectiveSecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task GetEffectiveSecurityHealthAnalyticsCustomModuleAsync()
        {
            // Snippet: GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(string, CallSettings)
            // Additional: GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/effectiveSecurityHealthAnalyticsCustomModules/[EFFECTIVE_SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]";
            // Make the request
            EffectiveSecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveSecurityHealthAnalyticsCustomModule</summary>
        public void GetEffectiveSecurityHealthAnalyticsCustomModuleResourceNames()
        {
            // Snippet: GetEffectiveSecurityHealthAnalyticsCustomModule(EffectiveSecurityHealthAnalyticsCustomModuleName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            EffectiveSecurityHealthAnalyticsCustomModuleName name = EffectiveSecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]");
            // Make the request
            EffectiveSecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task GetEffectiveSecurityHealthAnalyticsCustomModuleResourceNamesAsync()
        {
            // Snippet: GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(EffectiveSecurityHealthAnalyticsCustomModuleName, CallSettings)
            // Additional: GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(EffectiveSecurityHealthAnalyticsCustomModuleName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            EffectiveSecurityHealthAnalyticsCustomModuleName name = EffectiveSecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]");
            // Make the request
            EffectiveSecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModules</summary>
        public void ListSecurityHealthAnalyticsCustomModulesRequestObject()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModules(ListSecurityHealthAnalyticsCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListSecurityHealthAnalyticsCustomModulesRequestObjectAsync()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModulesAsync(ListSecurityHealthAnalyticsCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModules</summary>
        public void ListSecurityHealthAnalyticsCustomModules()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModules(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListSecurityHealthAnalyticsCustomModulesAsync()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModulesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModules</summary>
        public void ListSecurityHealthAnalyticsCustomModulesResourceNames1()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModules(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListSecurityHealthAnalyticsCustomModulesResourceNames1Async()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModulesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModules</summary>
        public void ListSecurityHealthAnalyticsCustomModulesResourceNames2()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModules(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListSecurityHealthAnalyticsCustomModulesResourceNames2Async()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModules</summary>
        public void ListSecurityHealthAnalyticsCustomModulesResourceNames3()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModules(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListSecurityHealthAnalyticsCustomModulesResourceNames3Async()
        {
            // Snippet: ListSecurityHealthAnalyticsCustomModulesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModules</summary>
        public void ListDescendantSecurityHealthAnalyticsCustomModulesRequestObject()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModules(ListDescendantSecurityHealthAnalyticsCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListDescendantSecurityHealthAnalyticsCustomModulesRequestObjectAsync()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModulesAsync(ListDescendantSecurityHealthAnalyticsCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModules</summary>
        public void ListDescendantSecurityHealthAnalyticsCustomModules()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModules(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListDescendantSecurityHealthAnalyticsCustomModulesAsync()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModulesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModules</summary>
        public void ListDescendantSecurityHealthAnalyticsCustomModulesResourceNames1()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModules(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListDescendantSecurityHealthAnalyticsCustomModulesResourceNames1Async()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModulesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModules</summary>
        public void ListDescendantSecurityHealthAnalyticsCustomModulesResourceNames2()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModules(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListDescendantSecurityHealthAnalyticsCustomModulesResourceNames2Async()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModules</summary>
        public void ListDescendantSecurityHealthAnalyticsCustomModulesResourceNames3()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModules(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityHealthAnalyticsCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantSecurityHealthAnalyticsCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantSecurityHealthAnalyticsCustomModulesAsync</summary>
        public async Task ListDescendantSecurityHealthAnalyticsCustomModulesResourceNames3Async()
        {
            // Snippet: ListDescendantSecurityHealthAnalyticsCustomModulesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> response = securityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityHealthAnalyticsCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantSecurityHealthAnalyticsCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityHealthAnalyticsCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityHealthAnalyticsCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityHealthAnalyticsCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSecurityHealthAnalyticsCustomModule</summary>
        public void GetSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Snippet: GetSecurityHealthAnalyticsCustomModule(GetSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            GetSecurityHealthAnalyticsCustomModuleRequest request = new GetSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
            };
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.GetSecurityHealthAnalyticsCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task GetSecurityHealthAnalyticsCustomModuleRequestObjectAsync()
        {
            // Snippet: GetSecurityHealthAnalyticsCustomModuleAsync(GetSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Additional: GetSecurityHealthAnalyticsCustomModuleAsync(GetSecurityHealthAnalyticsCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetSecurityHealthAnalyticsCustomModuleRequest request = new GetSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
            };
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.GetSecurityHealthAnalyticsCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityHealthAnalyticsCustomModule</summary>
        public void GetSecurityHealthAnalyticsCustomModule()
        {
            // Snippet: GetSecurityHealthAnalyticsCustomModule(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityHealthAnalyticsCustomModules/[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]";
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.GetSecurityHealthAnalyticsCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task GetSecurityHealthAnalyticsCustomModuleAsync()
        {
            // Snippet: GetSecurityHealthAnalyticsCustomModuleAsync(string, CallSettings)
            // Additional: GetSecurityHealthAnalyticsCustomModuleAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityHealthAnalyticsCustomModules/[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]";
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.GetSecurityHealthAnalyticsCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityHealthAnalyticsCustomModule</summary>
        public void GetSecurityHealthAnalyticsCustomModuleResourceNames()
        {
            // Snippet: GetSecurityHealthAnalyticsCustomModule(SecurityHealthAnalyticsCustomModuleName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            SecurityHealthAnalyticsCustomModuleName name = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]");
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.GetSecurityHealthAnalyticsCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task GetSecurityHealthAnalyticsCustomModuleResourceNamesAsync()
        {
            // Snippet: GetSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName, CallSettings)
            // Additional: GetSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            SecurityHealthAnalyticsCustomModuleName name = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]");
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.GetSecurityHealthAnalyticsCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModule</summary>
        public void CreateSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModule(CreateSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            CreateSecurityHealthAnalyticsCustomModuleRequest request = new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                SecurityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task CreateSecurityHealthAnalyticsCustomModuleRequestObjectAsync()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModuleAsync(CreateSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Additional: CreateSecurityHealthAnalyticsCustomModuleAsync(CreateSecurityHealthAnalyticsCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecurityHealthAnalyticsCustomModuleRequest request = new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                SecurityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModule</summary>
        public void CreateSecurityHealthAnalyticsCustomModule()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModule(string, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModule(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task CreateSecurityHealthAnalyticsCustomModuleAsync()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModuleAsync(string, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Additional: CreateSecurityHealthAnalyticsCustomModuleAsync(string, SecurityHealthAnalyticsCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModule</summary>
        public void CreateSecurityHealthAnalyticsCustomModuleResourceNames1()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModule(OrganizationLocationName, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModule(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task CreateSecurityHealthAnalyticsCustomModuleResourceNames1Async()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModuleAsync(OrganizationLocationName, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Additional: CreateSecurityHealthAnalyticsCustomModuleAsync(OrganizationLocationName, SecurityHealthAnalyticsCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModule</summary>
        public void CreateSecurityHealthAnalyticsCustomModuleResourceNames2()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModule(LocationName, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModule(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task CreateSecurityHealthAnalyticsCustomModuleResourceNames2Async()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModuleAsync(LocationName, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Additional: CreateSecurityHealthAnalyticsCustomModuleAsync(LocationName, SecurityHealthAnalyticsCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModule</summary>
        public void CreateSecurityHealthAnalyticsCustomModuleResourceNames3()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModule(FolderLocationName, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModule(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task CreateSecurityHealthAnalyticsCustomModuleResourceNames3Async()
        {
            // Snippet: CreateSecurityHealthAnalyticsCustomModuleAsync(FolderLocationName, SecurityHealthAnalyticsCustomModule, CallSettings)
            // Additional: CreateSecurityHealthAnalyticsCustomModuleAsync(FolderLocationName, SecurityHealthAnalyticsCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityHealthAnalyticsCustomModule</summary>
        public void UpdateSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Snippet: UpdateSecurityHealthAnalyticsCustomModule(UpdateSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            UpdateSecurityHealthAnalyticsCustomModuleRequest request = new UpdateSecurityHealthAnalyticsCustomModuleRequest
            {
                UpdateMask = new FieldMask(),
                SecurityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.UpdateSecurityHealthAnalyticsCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task UpdateSecurityHealthAnalyticsCustomModuleRequestObjectAsync()
        {
            // Snippet: UpdateSecurityHealthAnalyticsCustomModuleAsync(UpdateSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Additional: UpdateSecurityHealthAnalyticsCustomModuleAsync(UpdateSecurityHealthAnalyticsCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityHealthAnalyticsCustomModuleRequest request = new UpdateSecurityHealthAnalyticsCustomModuleRequest
            {
                UpdateMask = new FieldMask(),
                SecurityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.UpdateSecurityHealthAnalyticsCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityHealthAnalyticsCustomModule</summary>
        public void UpdateSecurityHealthAnalyticsCustomModule()
        {
            // Snippet: UpdateSecurityHealthAnalyticsCustomModule(SecurityHealthAnalyticsCustomModule, FieldMask, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = securityCenterManagementClient.UpdateSecurityHealthAnalyticsCustomModule(securityHealthAnalyticsCustomModule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task UpdateSecurityHealthAnalyticsCustomModuleAsync()
        {
            // Snippet: UpdateSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModule, FieldMask, CallSettings)
            // Additional: UpdateSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModule, FieldMask, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule = new SecurityHealthAnalyticsCustomModule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecurityHealthAnalyticsCustomModule response = await securityCenterManagementClient.UpdateSecurityHealthAnalyticsCustomModuleAsync(securityHealthAnalyticsCustomModule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModule</summary>
        public void DeleteSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Snippet: DeleteSecurityHealthAnalyticsCustomModule(DeleteSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            DeleteSecurityHealthAnalyticsCustomModuleRequest request = new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
                ValidateOnly = false,
            };
            // Make the request
            securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task DeleteSecurityHealthAnalyticsCustomModuleRequestObjectAsync()
        {
            // Snippet: DeleteSecurityHealthAnalyticsCustomModuleAsync(DeleteSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Additional: DeleteSecurityHealthAnalyticsCustomModuleAsync(DeleteSecurityHealthAnalyticsCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSecurityHealthAnalyticsCustomModuleRequest request = new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
                ValidateOnly = false,
            };
            // Make the request
            await securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModule</summary>
        public void DeleteSecurityHealthAnalyticsCustomModule()
        {
            // Snippet: DeleteSecurityHealthAnalyticsCustomModule(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityHealthAnalyticsCustomModules/[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]";
            // Make the request
            securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task DeleteSecurityHealthAnalyticsCustomModuleAsync()
        {
            // Snippet: DeleteSecurityHealthAnalyticsCustomModuleAsync(string, CallSettings)
            // Additional: DeleteSecurityHealthAnalyticsCustomModuleAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityHealthAnalyticsCustomModules/[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]";
            // Make the request
            await securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModule</summary>
        public void DeleteSecurityHealthAnalyticsCustomModuleResourceNames()
        {
            // Snippet: DeleteSecurityHealthAnalyticsCustomModule(SecurityHealthAnalyticsCustomModuleName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            SecurityHealthAnalyticsCustomModuleName name = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]");
            // Make the request
            securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task DeleteSecurityHealthAnalyticsCustomModuleResourceNamesAsync()
        {
            // Snippet: DeleteSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName, CallSettings)
            // Additional: DeleteSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            SecurityHealthAnalyticsCustomModuleName name = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]");
            // Make the request
            await securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SimulateSecurityHealthAnalyticsCustomModule</summary>
        public void SimulateSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Snippet: SimulateSecurityHealthAnalyticsCustomModule(SimulateSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            SimulateSecurityHealthAnalyticsCustomModuleRequest request = new SimulateSecurityHealthAnalyticsCustomModuleRequest
            {
                Parent = "",
                CustomConfig = new CustomConfig(),
                Resource = new SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource(),
            };
            // Make the request
            SimulateSecurityHealthAnalyticsCustomModuleResponse response = securityCenterManagementClient.SimulateSecurityHealthAnalyticsCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for SimulateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task SimulateSecurityHealthAnalyticsCustomModuleRequestObjectAsync()
        {
            // Snippet: SimulateSecurityHealthAnalyticsCustomModuleAsync(SimulateSecurityHealthAnalyticsCustomModuleRequest, CallSettings)
            // Additional: SimulateSecurityHealthAnalyticsCustomModuleAsync(SimulateSecurityHealthAnalyticsCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            SimulateSecurityHealthAnalyticsCustomModuleRequest request = new SimulateSecurityHealthAnalyticsCustomModuleRequest
            {
                Parent = "",
                CustomConfig = new CustomConfig(),
                Resource = new SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource(),
            };
            // Make the request
            SimulateSecurityHealthAnalyticsCustomModuleResponse response = await securityCenterManagementClient.SimulateSecurityHealthAnalyticsCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SimulateSecurityHealthAnalyticsCustomModule</summary>
        public void SimulateSecurityHealthAnalyticsCustomModule()
        {
            // Snippet: SimulateSecurityHealthAnalyticsCustomModule(string, CustomConfig, SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "";
            CustomConfig customConfig = new CustomConfig();
            SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource resource = new SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource();
            // Make the request
            SimulateSecurityHealthAnalyticsCustomModuleResponse response = securityCenterManagementClient.SimulateSecurityHealthAnalyticsCustomModule(parent, customConfig, resource);
            // End snippet
        }

        /// <summary>Snippet for SimulateSecurityHealthAnalyticsCustomModuleAsync</summary>
        public async Task SimulateSecurityHealthAnalyticsCustomModuleAsync()
        {
            // Snippet: SimulateSecurityHealthAnalyticsCustomModuleAsync(string, CustomConfig, SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource, CallSettings)
            // Additional: SimulateSecurityHealthAnalyticsCustomModuleAsync(string, CustomConfig, SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            CustomConfig customConfig = new CustomConfig();
            SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource resource = new SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource();
            // Make the request
            SimulateSecurityHealthAnalyticsCustomModuleResponse response = await securityCenterManagementClient.SimulateSecurityHealthAnalyticsCustomModuleAsync(parent, customConfig, resource);
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModules</summary>
        public void ListEffectiveEventThreatDetectionCustomModulesRequestObject()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModules(ListEffectiveEventThreatDetectionCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveEventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEffectiveEventThreatDetectionCustomModulesRequestObjectAsync()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModulesAsync(ListEffectiveEventThreatDetectionCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveEventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModules</summary>
        public void ListEffectiveEventThreatDetectionCustomModules()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModules(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveEventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEffectiveEventThreatDetectionCustomModulesAsync()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModulesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveEventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModules</summary>
        public void ListEffectiveEventThreatDetectionCustomModulesResourceNames1()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModules(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveEventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEffectiveEventThreatDetectionCustomModulesResourceNames1Async()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModulesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveEventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModules</summary>
        public void ListEffectiveEventThreatDetectionCustomModulesResourceNames2()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModules(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveEventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEffectiveEventThreatDetectionCustomModulesResourceNames2Async()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveEventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModules</summary>
        public void ListEffectiveEventThreatDetectionCustomModulesResourceNames3()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModules(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EffectiveEventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEffectiveEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEffectiveEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEffectiveEventThreatDetectionCustomModulesResourceNames3Async()
        {
            // Snippet: ListEffectiveEventThreatDetectionCustomModulesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EffectiveEventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEffectiveEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EffectiveEventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EffectiveEventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EffectiveEventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveEventThreatDetectionCustomModule</summary>
        public void GetEffectiveEventThreatDetectionCustomModuleRequestObject()
        {
            // Snippet: GetEffectiveEventThreatDetectionCustomModule(GetEffectiveEventThreatDetectionCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            GetEffectiveEventThreatDetectionCustomModuleRequest request = new GetEffectiveEventThreatDetectionCustomModuleRequest
            {
                EffectiveEventThreatDetectionCustomModuleName = EffectiveEventThreatDetectionCustomModuleName.FromOrganizationLocationEffectiveEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_EVENT_THREAT_DETECTION_CUSTOM_MODULE]"),
            };
            // Make the request
            EffectiveEventThreatDetectionCustomModule response = securityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveEventThreatDetectionCustomModuleAsync</summary>
        public async Task GetEffectiveEventThreatDetectionCustomModuleRequestObjectAsync()
        {
            // Snippet: GetEffectiveEventThreatDetectionCustomModuleAsync(GetEffectiveEventThreatDetectionCustomModuleRequest, CallSettings)
            // Additional: GetEffectiveEventThreatDetectionCustomModuleAsync(GetEffectiveEventThreatDetectionCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetEffectiveEventThreatDetectionCustomModuleRequest request = new GetEffectiveEventThreatDetectionCustomModuleRequest
            {
                EffectiveEventThreatDetectionCustomModuleName = EffectiveEventThreatDetectionCustomModuleName.FromOrganizationLocationEffectiveEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_EVENT_THREAT_DETECTION_CUSTOM_MODULE]"),
            };
            // Make the request
            EffectiveEventThreatDetectionCustomModule response = await securityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveEventThreatDetectionCustomModule</summary>
        public void GetEffectiveEventThreatDetectionCustomModule()
        {
            // Snippet: GetEffectiveEventThreatDetectionCustomModule(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/effectiveEventThreatDetectionCustomModules/[EFFECTIVE_EVENT_THREAT_DETECTION_CUSTOM_MODULE]";
            // Make the request
            EffectiveEventThreatDetectionCustomModule response = securityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveEventThreatDetectionCustomModuleAsync</summary>
        public async Task GetEffectiveEventThreatDetectionCustomModuleAsync()
        {
            // Snippet: GetEffectiveEventThreatDetectionCustomModuleAsync(string, CallSettings)
            // Additional: GetEffectiveEventThreatDetectionCustomModuleAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/effectiveEventThreatDetectionCustomModules/[EFFECTIVE_EVENT_THREAT_DETECTION_CUSTOM_MODULE]";
            // Make the request
            EffectiveEventThreatDetectionCustomModule response = await securityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveEventThreatDetectionCustomModule</summary>
        public void GetEffectiveEventThreatDetectionCustomModuleResourceNames()
        {
            // Snippet: GetEffectiveEventThreatDetectionCustomModule(EffectiveEventThreatDetectionCustomModuleName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            EffectiveEventThreatDetectionCustomModuleName name = EffectiveEventThreatDetectionCustomModuleName.FromOrganizationLocationEffectiveEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_EVENT_THREAT_DETECTION_CUSTOM_MODULE]");
            // Make the request
            EffectiveEventThreatDetectionCustomModule response = securityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveEventThreatDetectionCustomModuleAsync</summary>
        public async Task GetEffectiveEventThreatDetectionCustomModuleResourceNamesAsync()
        {
            // Snippet: GetEffectiveEventThreatDetectionCustomModuleAsync(EffectiveEventThreatDetectionCustomModuleName, CallSettings)
            // Additional: GetEffectiveEventThreatDetectionCustomModuleAsync(EffectiveEventThreatDetectionCustomModuleName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            EffectiveEventThreatDetectionCustomModuleName name = EffectiveEventThreatDetectionCustomModuleName.FromOrganizationLocationEffectiveEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EFFECTIVE_EVENT_THREAT_DETECTION_CUSTOM_MODULE]");
            // Make the request
            EffectiveEventThreatDetectionCustomModule response = await securityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModules</summary>
        public void ListEventThreatDetectionCustomModulesRequestObject()
        {
            // Snippet: ListEventThreatDetectionCustomModules(ListEventThreatDetectionCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEventThreatDetectionCustomModulesRequestObjectAsync()
        {
            // Snippet: ListEventThreatDetectionCustomModulesAsync(ListEventThreatDetectionCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModules</summary>
        public void ListEventThreatDetectionCustomModules()
        {
            // Snippet: ListEventThreatDetectionCustomModules(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEventThreatDetectionCustomModulesAsync()
        {
            // Snippet: ListEventThreatDetectionCustomModulesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModules</summary>
        public void ListEventThreatDetectionCustomModulesResourceNames1()
        {
            // Snippet: ListEventThreatDetectionCustomModules(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEventThreatDetectionCustomModulesResourceNames1Async()
        {
            // Snippet: ListEventThreatDetectionCustomModulesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModules</summary>
        public void ListEventThreatDetectionCustomModulesResourceNames2()
        {
            // Snippet: ListEventThreatDetectionCustomModules(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEventThreatDetectionCustomModulesResourceNames2Async()
        {
            // Snippet: ListEventThreatDetectionCustomModulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModules</summary>
        public void ListEventThreatDetectionCustomModulesResourceNames3()
        {
            // Snippet: ListEventThreatDetectionCustomModules(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListEventThreatDetectionCustomModulesResourceNames3Async()
        {
            // Snippet: ListEventThreatDetectionCustomModulesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModules</summary>
        public void ListDescendantEventThreatDetectionCustomModulesRequestObject()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModules(ListDescendantEventThreatDetectionCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListDescendantEventThreatDetectionCustomModulesRequestObjectAsync()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModulesAsync(ListDescendantEventThreatDetectionCustomModulesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModules</summary>
        public void ListDescendantEventThreatDetectionCustomModules()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModules(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListDescendantEventThreatDetectionCustomModulesAsync()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModulesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModules</summary>
        public void ListDescendantEventThreatDetectionCustomModulesResourceNames1()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModules(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListDescendantEventThreatDetectionCustomModulesResourceNames1Async()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModulesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModules</summary>
        public void ListDescendantEventThreatDetectionCustomModulesResourceNames2()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModules(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListDescendantEventThreatDetectionCustomModulesResourceNames2Async()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModulesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModules</summary>
        public void ListDescendantEventThreatDetectionCustomModulesResourceNames3()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModules(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventThreatDetectionCustomModule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDescendantEventThreatDetectionCustomModulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDescendantEventThreatDetectionCustomModulesAsync</summary>
        public async Task ListDescendantEventThreatDetectionCustomModulesResourceNames3Async()
        {
            // Snippet: ListDescendantEventThreatDetectionCustomModulesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> response = securityCenterManagementClient.ListDescendantEventThreatDetectionCustomModulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventThreatDetectionCustomModule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDescendantEventThreatDetectionCustomModulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventThreatDetectionCustomModule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventThreatDetectionCustomModule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventThreatDetectionCustomModule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEventThreatDetectionCustomModule</summary>
        public void GetEventThreatDetectionCustomModuleRequestObject()
        {
            // Snippet: GetEventThreatDetectionCustomModule(GetEventThreatDetectionCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            GetEventThreatDetectionCustomModuleRequest request = new GetEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]"),
            };
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.GetEventThreatDetectionCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventThreatDetectionCustomModuleAsync</summary>
        public async Task GetEventThreatDetectionCustomModuleRequestObjectAsync()
        {
            // Snippet: GetEventThreatDetectionCustomModuleAsync(GetEventThreatDetectionCustomModuleRequest, CallSettings)
            // Additional: GetEventThreatDetectionCustomModuleAsync(GetEventThreatDetectionCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetEventThreatDetectionCustomModuleRequest request = new GetEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]"),
            };
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.GetEventThreatDetectionCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventThreatDetectionCustomModule</summary>
        public void GetEventThreatDetectionCustomModule()
        {
            // Snippet: GetEventThreatDetectionCustomModule(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/eventThreatDetectionCustomModules/[EVENT_THREAT_DETECTION_CUSTOM_MODULE]";
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.GetEventThreatDetectionCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventThreatDetectionCustomModuleAsync</summary>
        public async Task GetEventThreatDetectionCustomModuleAsync()
        {
            // Snippet: GetEventThreatDetectionCustomModuleAsync(string, CallSettings)
            // Additional: GetEventThreatDetectionCustomModuleAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/eventThreatDetectionCustomModules/[EVENT_THREAT_DETECTION_CUSTOM_MODULE]";
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.GetEventThreatDetectionCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventThreatDetectionCustomModule</summary>
        public void GetEventThreatDetectionCustomModuleResourceNames()
        {
            // Snippet: GetEventThreatDetectionCustomModule(EventThreatDetectionCustomModuleName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            EventThreatDetectionCustomModuleName name = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]");
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.GetEventThreatDetectionCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventThreatDetectionCustomModuleAsync</summary>
        public async Task GetEventThreatDetectionCustomModuleResourceNamesAsync()
        {
            // Snippet: GetEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName, CallSettings)
            // Additional: GetEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            EventThreatDetectionCustomModuleName name = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]");
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.GetEventThreatDetectionCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModule</summary>
        public void CreateEventThreatDetectionCustomModuleRequestObject()
        {
            // Snippet: CreateEventThreatDetectionCustomModule(CreateEventThreatDetectionCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            CreateEventThreatDetectionCustomModuleRequest request = new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                EventThreatDetectionCustomModule = new EventThreatDetectionCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.CreateEventThreatDetectionCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModuleAsync</summary>
        public async Task CreateEventThreatDetectionCustomModuleRequestObjectAsync()
        {
            // Snippet: CreateEventThreatDetectionCustomModuleAsync(CreateEventThreatDetectionCustomModuleRequest, CallSettings)
            // Additional: CreateEventThreatDetectionCustomModuleAsync(CreateEventThreatDetectionCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateEventThreatDetectionCustomModuleRequest request = new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                EventThreatDetectionCustomModule = new EventThreatDetectionCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.CreateEventThreatDetectionCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModule</summary>
        public void CreateEventThreatDetectionCustomModule()
        {
            // Snippet: CreateEventThreatDetectionCustomModule(string, EventThreatDetectionCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.CreateEventThreatDetectionCustomModule(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModuleAsync</summary>
        public async Task CreateEventThreatDetectionCustomModuleAsync()
        {
            // Snippet: CreateEventThreatDetectionCustomModuleAsync(string, EventThreatDetectionCustomModule, CallSettings)
            // Additional: CreateEventThreatDetectionCustomModuleAsync(string, EventThreatDetectionCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModule</summary>
        public void CreateEventThreatDetectionCustomModuleResourceNames1()
        {
            // Snippet: CreateEventThreatDetectionCustomModule(OrganizationLocationName, EventThreatDetectionCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.CreateEventThreatDetectionCustomModule(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModuleAsync</summary>
        public async Task CreateEventThreatDetectionCustomModuleResourceNames1Async()
        {
            // Snippet: CreateEventThreatDetectionCustomModuleAsync(OrganizationLocationName, EventThreatDetectionCustomModule, CallSettings)
            // Additional: CreateEventThreatDetectionCustomModuleAsync(OrganizationLocationName, EventThreatDetectionCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModule</summary>
        public void CreateEventThreatDetectionCustomModuleResourceNames2()
        {
            // Snippet: CreateEventThreatDetectionCustomModule(LocationName, EventThreatDetectionCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.CreateEventThreatDetectionCustomModule(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModuleAsync</summary>
        public async Task CreateEventThreatDetectionCustomModuleResourceNames2Async()
        {
            // Snippet: CreateEventThreatDetectionCustomModuleAsync(LocationName, EventThreatDetectionCustomModule, CallSettings)
            // Additional: CreateEventThreatDetectionCustomModuleAsync(LocationName, EventThreatDetectionCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModule</summary>
        public void CreateEventThreatDetectionCustomModuleResourceNames3()
        {
            // Snippet: CreateEventThreatDetectionCustomModule(FolderLocationName, EventThreatDetectionCustomModule, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.CreateEventThreatDetectionCustomModule(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventThreatDetectionCustomModuleAsync</summary>
        public async Task CreateEventThreatDetectionCustomModuleResourceNames3Async()
        {
            // Snippet: CreateEventThreatDetectionCustomModuleAsync(FolderLocationName, EventThreatDetectionCustomModule, CallSettings)
            // Additional: CreateEventThreatDetectionCustomModuleAsync(FolderLocationName, EventThreatDetectionCustomModule, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventThreatDetectionCustomModule</summary>
        public void UpdateEventThreatDetectionCustomModuleRequestObject()
        {
            // Snippet: UpdateEventThreatDetectionCustomModule(UpdateEventThreatDetectionCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            UpdateEventThreatDetectionCustomModuleRequest request = new UpdateEventThreatDetectionCustomModuleRequest
            {
                UpdateMask = new FieldMask(),
                EventThreatDetectionCustomModule = new EventThreatDetectionCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.UpdateEventThreatDetectionCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventThreatDetectionCustomModuleAsync</summary>
        public async Task UpdateEventThreatDetectionCustomModuleRequestObjectAsync()
        {
            // Snippet: UpdateEventThreatDetectionCustomModuleAsync(UpdateEventThreatDetectionCustomModuleRequest, CallSettings)
            // Additional: UpdateEventThreatDetectionCustomModuleAsync(UpdateEventThreatDetectionCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEventThreatDetectionCustomModuleRequest request = new UpdateEventThreatDetectionCustomModuleRequest
            {
                UpdateMask = new FieldMask(),
                EventThreatDetectionCustomModule = new EventThreatDetectionCustomModule(),
                ValidateOnly = false,
            };
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.UpdateEventThreatDetectionCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventThreatDetectionCustomModule</summary>
        public void UpdateEventThreatDetectionCustomModule()
        {
            // Snippet: UpdateEventThreatDetectionCustomModule(EventThreatDetectionCustomModule, FieldMask, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EventThreatDetectionCustomModule response = securityCenterManagementClient.UpdateEventThreatDetectionCustomModule(eventThreatDetectionCustomModule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventThreatDetectionCustomModuleAsync</summary>
        public async Task UpdateEventThreatDetectionCustomModuleAsync()
        {
            // Snippet: UpdateEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModule, FieldMask, CallSettings)
            // Additional: UpdateEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModule, FieldMask, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            EventThreatDetectionCustomModule eventThreatDetectionCustomModule = new EventThreatDetectionCustomModule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EventThreatDetectionCustomModule response = await securityCenterManagementClient.UpdateEventThreatDetectionCustomModuleAsync(eventThreatDetectionCustomModule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventThreatDetectionCustomModule</summary>
        public void DeleteEventThreatDetectionCustomModuleRequestObject()
        {
            // Snippet: DeleteEventThreatDetectionCustomModule(DeleteEventThreatDetectionCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            DeleteEventThreatDetectionCustomModuleRequest request = new DeleteEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]"),
                ValidateOnly = false,
            };
            // Make the request
            securityCenterManagementClient.DeleteEventThreatDetectionCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventThreatDetectionCustomModuleAsync</summary>
        public async Task DeleteEventThreatDetectionCustomModuleRequestObjectAsync()
        {
            // Snippet: DeleteEventThreatDetectionCustomModuleAsync(DeleteEventThreatDetectionCustomModuleRequest, CallSettings)
            // Additional: DeleteEventThreatDetectionCustomModuleAsync(DeleteEventThreatDetectionCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEventThreatDetectionCustomModuleRequest request = new DeleteEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]"),
                ValidateOnly = false,
            };
            // Make the request
            await securityCenterManagementClient.DeleteEventThreatDetectionCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventThreatDetectionCustomModule</summary>
        public void DeleteEventThreatDetectionCustomModule()
        {
            // Snippet: DeleteEventThreatDetectionCustomModule(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/eventThreatDetectionCustomModules/[EVENT_THREAT_DETECTION_CUSTOM_MODULE]";
            // Make the request
            securityCenterManagementClient.DeleteEventThreatDetectionCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventThreatDetectionCustomModuleAsync</summary>
        public async Task DeleteEventThreatDetectionCustomModuleAsync()
        {
            // Snippet: DeleteEventThreatDetectionCustomModuleAsync(string, CallSettings)
            // Additional: DeleteEventThreatDetectionCustomModuleAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/eventThreatDetectionCustomModules/[EVENT_THREAT_DETECTION_CUSTOM_MODULE]";
            // Make the request
            await securityCenterManagementClient.DeleteEventThreatDetectionCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventThreatDetectionCustomModule</summary>
        public void DeleteEventThreatDetectionCustomModuleResourceNames()
        {
            // Snippet: DeleteEventThreatDetectionCustomModule(EventThreatDetectionCustomModuleName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            EventThreatDetectionCustomModuleName name = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]");
            // Make the request
            securityCenterManagementClient.DeleteEventThreatDetectionCustomModule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventThreatDetectionCustomModuleAsync</summary>
        public async Task DeleteEventThreatDetectionCustomModuleResourceNamesAsync()
        {
            // Snippet: DeleteEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName, CallSettings)
            // Additional: DeleteEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            EventThreatDetectionCustomModuleName name = EventThreatDetectionCustomModuleName.FromOrganizationLocationEventThreatDetectionCustomModule("[ORGANIZATION]", "[LOCATION]", "[EVENT_THREAT_DETECTION_CUSTOM_MODULE]");
            // Make the request
            await securityCenterManagementClient.DeleteEventThreatDetectionCustomModuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ValidateEventThreatDetectionCustomModule</summary>
        public void ValidateEventThreatDetectionCustomModuleRequestObject()
        {
            // Snippet: ValidateEventThreatDetectionCustomModule(ValidateEventThreatDetectionCustomModuleRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ValidateEventThreatDetectionCustomModuleRequest request = new ValidateEventThreatDetectionCustomModuleRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                RawText = "",
                Type = "",
            };
            // Make the request
            ValidateEventThreatDetectionCustomModuleResponse response = securityCenterManagementClient.ValidateEventThreatDetectionCustomModule(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateEventThreatDetectionCustomModuleAsync</summary>
        public async Task ValidateEventThreatDetectionCustomModuleRequestObjectAsync()
        {
            // Snippet: ValidateEventThreatDetectionCustomModuleAsync(ValidateEventThreatDetectionCustomModuleRequest, CallSettings)
            // Additional: ValidateEventThreatDetectionCustomModuleAsync(ValidateEventThreatDetectionCustomModuleRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ValidateEventThreatDetectionCustomModuleRequest request = new ValidateEventThreatDetectionCustomModuleRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                RawText = "",
                Type = "",
            };
            // Make the request
            ValidateEventThreatDetectionCustomModuleResponse response = await securityCenterManagementClient.ValidateEventThreatDetectionCustomModuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityCenterService</summary>
        public void GetSecurityCenterServiceRequestObject()
        {
            // Snippet: GetSecurityCenterService(GetSecurityCenterServiceRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            GetSecurityCenterServiceRequest request = new GetSecurityCenterServiceRequest
            {
                SecurityCenterServiceName = SecurityCenterServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                ShowEligibleModulesOnly = false,
            };
            // Make the request
            SecurityCenterService response = securityCenterManagementClient.GetSecurityCenterService(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityCenterServiceAsync</summary>
        public async Task GetSecurityCenterServiceRequestObjectAsync()
        {
            // Snippet: GetSecurityCenterServiceAsync(GetSecurityCenterServiceRequest, CallSettings)
            // Additional: GetSecurityCenterServiceAsync(GetSecurityCenterServiceRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetSecurityCenterServiceRequest request = new GetSecurityCenterServiceRequest
            {
                SecurityCenterServiceName = SecurityCenterServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                ShowEligibleModulesOnly = false,
            };
            // Make the request
            SecurityCenterService response = await securityCenterManagementClient.GetSecurityCenterServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityCenterService</summary>
        public void GetSecurityCenterService()
        {
            // Snippet: GetSecurityCenterService(string, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/securityCenterServices/[SERVICE]";
            // Make the request
            SecurityCenterService response = securityCenterManagementClient.GetSecurityCenterService(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityCenterServiceAsync</summary>
        public async Task GetSecurityCenterServiceAsync()
        {
            // Snippet: GetSecurityCenterServiceAsync(string, CallSettings)
            // Additional: GetSecurityCenterServiceAsync(string, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/securityCenterServices/[SERVICE]";
            // Make the request
            SecurityCenterService response = await securityCenterManagementClient.GetSecurityCenterServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityCenterService</summary>
        public void GetSecurityCenterServiceResourceNames()
        {
            // Snippet: GetSecurityCenterService(SecurityCenterServiceName, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            SecurityCenterServiceName name = SecurityCenterServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            SecurityCenterService response = securityCenterManagementClient.GetSecurityCenterService(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityCenterServiceAsync</summary>
        public async Task GetSecurityCenterServiceResourceNamesAsync()
        {
            // Snippet: GetSecurityCenterServiceAsync(SecurityCenterServiceName, CallSettings)
            // Additional: GetSecurityCenterServiceAsync(SecurityCenterServiceName, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            SecurityCenterServiceName name = SecurityCenterServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            SecurityCenterService response = await securityCenterManagementClient.GetSecurityCenterServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServices</summary>
        public void ListSecurityCenterServicesRequestObject()
        {
            // Snippet: ListSecurityCenterServices(ListSecurityCenterServicesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowEligibleModulesOnly = false,
            };
            // Make the request
            PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityCenterService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityCenterServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServicesAsync</summary>
        public async Task ListSecurityCenterServicesRequestObjectAsync()
        {
            // Snippet: ListSecurityCenterServicesAsync(ListSecurityCenterServicesRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowEligibleModulesOnly = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityCenterService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityCenterServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServices</summary>
        public void ListSecurityCenterServices()
        {
            // Snippet: ListSecurityCenterServices(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityCenterService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityCenterServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServicesAsync</summary>
        public async Task ListSecurityCenterServicesAsync()
        {
            // Snippet: ListSecurityCenterServicesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityCenterService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityCenterServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServices</summary>
        public void ListSecurityCenterServicesResourceNames1()
        {
            // Snippet: ListSecurityCenterServices(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityCenterService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityCenterServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServicesAsync</summary>
        public async Task ListSecurityCenterServicesResourceNames1Async()
        {
            // Snippet: ListSecurityCenterServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityCenterService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityCenterServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServices</summary>
        public void ListSecurityCenterServicesResourceNames2()
        {
            // Snippet: ListSecurityCenterServices(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityCenterService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityCenterServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServicesAsync</summary>
        public async Task ListSecurityCenterServicesResourceNames2Async()
        {
            // Snippet: ListSecurityCenterServicesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityCenterService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityCenterServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServices</summary>
        public void ListSecurityCenterServicesResourceNames3()
        {
            // Snippet: ListSecurityCenterServices(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityCenterService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityCenterServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityCenterServicesAsync</summary>
        public async Task ListSecurityCenterServicesResourceNames3Async()
        {
            // Snippet: ListSecurityCenterServicesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> response = securityCenterManagementClient.ListSecurityCenterServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityCenterService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecurityCenterServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityCenterService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityCenterService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityCenterService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityCenterService</summary>
        public void UpdateSecurityCenterServiceRequestObject()
        {
            // Snippet: UpdateSecurityCenterService(UpdateSecurityCenterServiceRequest, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            UpdateSecurityCenterServiceRequest request = new UpdateSecurityCenterServiceRequest
            {
                SecurityCenterService = new SecurityCenterService(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            SecurityCenterService response = securityCenterManagementClient.UpdateSecurityCenterService(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityCenterServiceAsync</summary>
        public async Task UpdateSecurityCenterServiceRequestObjectAsync()
        {
            // Snippet: UpdateSecurityCenterServiceAsync(UpdateSecurityCenterServiceRequest, CallSettings)
            // Additional: UpdateSecurityCenterServiceAsync(UpdateSecurityCenterServiceRequest, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityCenterServiceRequest request = new UpdateSecurityCenterServiceRequest
            {
                SecurityCenterService = new SecurityCenterService(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            SecurityCenterService response = await securityCenterManagementClient.UpdateSecurityCenterServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityCenterService</summary>
        public void UpdateSecurityCenterService()
        {
            // Snippet: UpdateSecurityCenterService(SecurityCenterService, FieldMask, CallSettings)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            SecurityCenterService securityCenterService = new SecurityCenterService();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecurityCenterService response = securityCenterManagementClient.UpdateSecurityCenterService(securityCenterService, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityCenterServiceAsync</summary>
        public async Task UpdateSecurityCenterServiceAsync()
        {
            // Snippet: UpdateSecurityCenterServiceAsync(SecurityCenterService, FieldMask, CallSettings)
            // Additional: UpdateSecurityCenterServiceAsync(SecurityCenterService, FieldMask, CancellationToken)
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = await SecurityCenterManagementClient.CreateAsync();
            // Initialize request argument(s)
            SecurityCenterService securityCenterService = new SecurityCenterService();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SecurityCenterService response = await securityCenterManagementClient.UpdateSecurityCenterServiceAsync(securityCenterService, updateMask);
            // End snippet
        }
    }
}
