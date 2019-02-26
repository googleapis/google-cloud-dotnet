// Copyright 2019 Google LLC
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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Talent.V4Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedTenantServiceClientSnippets
    {
        /// <summary>Snippet for CreateTenantAsync</summary>
        public async Task CreateTenantAsync()
        {
            // Snippet: CreateTenantAsync(ProjectName,Tenant,CallSettings)
            // Additional: CreateTenantAsync(ProjectName,Tenant,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Tenant tenant = new Tenant();
            // Make the request
            Tenant response = await tenantServiceClient.CreateTenantAsync(parent, tenant);
            // End snippet
        }

        /// <summary>Snippet for CreateTenant</summary>
        public void CreateTenant()
        {
            // Snippet: CreateTenant(ProjectName,Tenant,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Tenant tenant = new Tenant();
            // Make the request
            Tenant response = tenantServiceClient.CreateTenant(parent, tenant);
            // End snippet
        }

        /// <summary>Snippet for CreateTenantAsync</summary>
        public async Task CreateTenantAsync_RequestObject()
        {
            // Snippet: CreateTenantAsync(CreateTenantRequest,CallSettings)
            // Additional: CreateTenantAsync(CreateTenantRequest,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Tenant = new Tenant(),
            };
            // Make the request
            Tenant response = await tenantServiceClient.CreateTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTenant</summary>
        public void CreateTenant_RequestObject()
        {
            // Snippet: CreateTenant(CreateTenantRequest,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Tenant = new Tenant(),
            };
            // Make the request
            Tenant response = tenantServiceClient.CreateTenant(request);
            // End snippet
        }

        /// <summary>Snippet for GetTenantAsync</summary>
        public async Task GetTenantAsync()
        {
            // Snippet: GetTenantAsync(TenantName,CallSettings)
            // Additional: GetTenantAsync(TenantName,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            // Make the request
            Tenant response = await tenantServiceClient.GetTenantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTenant</summary>
        public void GetTenant()
        {
            // Snippet: GetTenant(TenantName,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            // Make the request
            Tenant response = tenantServiceClient.GetTenant(name);
            // End snippet
        }

        /// <summary>Snippet for GetTenantAsync</summary>
        public async Task GetTenantAsync_RequestObject()
        {
            // Snippet: GetTenantAsync(GetTenantRequest,CallSettings)
            // Additional: GetTenantAsync(GetTenantRequest,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            // Make the request
            Tenant response = await tenantServiceClient.GetTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTenant</summary>
        public void GetTenant_RequestObject()
        {
            // Snippet: GetTenant(GetTenantRequest,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            // Make the request
            Tenant response = tenantServiceClient.GetTenant(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenantAsync</summary>
        public async Task UpdateTenantAsync()
        {
            // Snippet: UpdateTenantAsync(Tenant,CallSettings)
            // Additional: UpdateTenantAsync(Tenant,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            Tenant tenant = new Tenant();
            // Make the request
            Tenant response = await tenantServiceClient.UpdateTenantAsync(tenant);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenant</summary>
        public void UpdateTenant()
        {
            // Snippet: UpdateTenant(Tenant,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            Tenant tenant = new Tenant();
            // Make the request
            Tenant response = tenantServiceClient.UpdateTenant(tenant);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenantAsync</summary>
        public async Task UpdateTenantAsync_RequestObject()
        {
            // Snippet: UpdateTenantAsync(UpdateTenantRequest,CallSettings)
            // Additional: UpdateTenantAsync(UpdateTenantRequest,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            // Make the request
            Tenant response = await tenantServiceClient.UpdateTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenant</summary>
        public void UpdateTenant_RequestObject()
        {
            // Snippet: UpdateTenant(UpdateTenantRequest,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                Tenant = new Tenant(),
            };
            // Make the request
            Tenant response = tenantServiceClient.UpdateTenant(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenantAsync</summary>
        public async Task DeleteTenantAsync()
        {
            // Snippet: DeleteTenantAsync(TenantName,CallSettings)
            // Additional: DeleteTenantAsync(TenantName,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            // Make the request
            await tenantServiceClient.DeleteTenantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenant</summary>
        public void DeleteTenant()
        {
            // Snippet: DeleteTenant(TenantName,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            TenantName name = new TenantName("[PROJECT]", "[TENANT]");
            // Make the request
            tenantServiceClient.DeleteTenant(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenantAsync</summary>
        public async Task DeleteTenantAsync_RequestObject()
        {
            // Snippet: DeleteTenantAsync(DeleteTenantRequest,CallSettings)
            // Additional: DeleteTenantAsync(DeleteTenantRequest,CancellationToken)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            // Make the request
            await tenantServiceClient.DeleteTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenant</summary>
        public void DeleteTenant_RequestObject()
        {
            // Snippet: DeleteTenant(DeleteTenantRequest,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = new TenantName("[PROJECT]", "[TENANT]"),
            };
            // Make the request
            tenantServiceClient.DeleteTenant(request);
            // End snippet
        }

        /// <summary>Snippet for ListTenantsAsync</summary>
        public async Task ListTenantsAsync()
        {
            // Snippet: ListTenantsAsync(ProjectName,string,int?,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListTenantsResponse, Tenant> response =
                tenantServiceClient.ListTenantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tenant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTenantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tenant item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tenant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tenant item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenants</summary>
        public void ListTenants()
        {
            // Snippet: ListTenants(ProjectName,string,int?,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListTenantsResponse, Tenant> response =
                tenantServiceClient.ListTenants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tenant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTenantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tenant item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tenant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tenant item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenantsAsync</summary>
        public async Task ListTenantsAsync_RequestObject()
        {
            // Snippet: ListTenantsAsync(ListTenantsRequest,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = await TenantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTenantsRequest request = new ListTenantsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTenantsResponse, Tenant> response =
                tenantServiceClient.ListTenantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tenant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTenantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tenant item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tenant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tenant item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenants</summary>
        public void ListTenants_RequestObject()
        {
            // Snippet: ListTenants(ListTenantsRequest,CallSettings)
            // Create client
            TenantServiceClient tenantServiceClient = TenantServiceClient.Create();
            // Initialize request argument(s)
            ListTenantsRequest request = new ListTenantsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListTenantsResponse, Tenant> response =
                tenantServiceClient.ListTenants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tenant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTenantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tenant item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tenant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tenant item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
