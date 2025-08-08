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
    using Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSaasDeploymentsClientSnippets
    {
        /// <summary>Snippet for ListSaas</summary>
        public void ListSaasRequestObject()
        {
            // Snippet: ListSaas(ListSaasRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ListSaasRequest request = new ListSaasRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSaasResponse, Saas> response = saasDeploymentsClient.ListSaas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Saas item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSaasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Saas item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Saas> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Saas item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSaasAsync</summary>
        public async Task ListSaasRequestObjectAsync()
        {
            // Snippet: ListSaasAsync(ListSaasRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListSaasRequest request = new ListSaasRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSaasResponse, Saas> response = saasDeploymentsClient.ListSaasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Saas item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSaasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Saas item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Saas> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Saas item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSaas</summary>
        public void ListSaas()
        {
            // Snippet: ListSaas(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSaasResponse, Saas> response = saasDeploymentsClient.ListSaas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Saas item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSaasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Saas item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Saas> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Saas item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSaasAsync</summary>
        public async Task ListSaasAsync()
        {
            // Snippet: ListSaasAsync(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSaasResponse, Saas> response = saasDeploymentsClient.ListSaasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Saas item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSaasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Saas item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Saas> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Saas item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSaas</summary>
        public void ListSaasResourceNames()
        {
            // Snippet: ListSaas(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSaasResponse, Saas> response = saasDeploymentsClient.ListSaas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Saas item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSaasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Saas item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Saas> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Saas item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSaasAsync</summary>
        public async Task ListSaasResourceNamesAsync()
        {
            // Snippet: ListSaasAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSaasResponse, Saas> response = saasDeploymentsClient.ListSaasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Saas item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSaasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Saas item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Saas> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Saas item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSaas</summary>
        public void GetSaasRequestObject()
        {
            // Snippet: GetSaas(GetSaasRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            GetSaasRequest request = new GetSaasRequest
            {
                SaasName = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]"),
            };
            // Make the request
            Saas response = saasDeploymentsClient.GetSaas(request);
            // End snippet
        }

        /// <summary>Snippet for GetSaasAsync</summary>
        public async Task GetSaasRequestObjectAsync()
        {
            // Snippet: GetSaasAsync(GetSaasRequest, CallSettings)
            // Additional: GetSaasAsync(GetSaasRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetSaasRequest request = new GetSaasRequest
            {
                SaasName = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]"),
            };
            // Make the request
            Saas response = await saasDeploymentsClient.GetSaasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSaas</summary>
        public void GetSaas()
        {
            // Snippet: GetSaas(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/saas/[SAAS]";
            // Make the request
            Saas response = saasDeploymentsClient.GetSaas(name);
            // End snippet
        }

        /// <summary>Snippet for GetSaasAsync</summary>
        public async Task GetSaasAsync()
        {
            // Snippet: GetSaasAsync(string, CallSettings)
            // Additional: GetSaasAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/saas/[SAAS]";
            // Make the request
            Saas response = await saasDeploymentsClient.GetSaasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSaas</summary>
        public void GetSaasResourceNames()
        {
            // Snippet: GetSaas(SaasName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            SaasName name = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]");
            // Make the request
            Saas response = saasDeploymentsClient.GetSaas(name);
            // End snippet
        }

        /// <summary>Snippet for GetSaasAsync</summary>
        public async Task GetSaasResourceNamesAsync()
        {
            // Snippet: GetSaasAsync(SaasName, CallSettings)
            // Additional: GetSaasAsync(SaasName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            SaasName name = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]");
            // Make the request
            Saas response = await saasDeploymentsClient.GetSaasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSaas</summary>
        public void CreateSaasRequestObject()
        {
            // Snippet: CreateSaas(CreateSaasRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            CreateSaasRequest request = new CreateSaasRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                SaasId = "",
                Saas = new Saas(),
            };
            // Make the request
            Saas response = saasDeploymentsClient.CreateSaas(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSaasAsync</summary>
        public async Task CreateSaasRequestObjectAsync()
        {
            // Snippet: CreateSaasAsync(CreateSaasRequest, CallSettings)
            // Additional: CreateSaasAsync(CreateSaasRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateSaasRequest request = new CreateSaasRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                SaasId = "",
                Saas = new Saas(),
            };
            // Make the request
            Saas response = await saasDeploymentsClient.CreateSaasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSaas</summary>
        public void CreateSaas()
        {
            // Snippet: CreateSaas(string, Saas, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Saas saas = new Saas();
            string saasId = "";
            // Make the request
            Saas response = saasDeploymentsClient.CreateSaas(parent, saas, saasId);
            // End snippet
        }

        /// <summary>Snippet for CreateSaasAsync</summary>
        public async Task CreateSaasAsync()
        {
            // Snippet: CreateSaasAsync(string, Saas, string, CallSettings)
            // Additional: CreateSaasAsync(string, Saas, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Saas saas = new Saas();
            string saasId = "";
            // Make the request
            Saas response = await saasDeploymentsClient.CreateSaasAsync(parent, saas, saasId);
            // End snippet
        }

        /// <summary>Snippet for CreateSaas</summary>
        public void CreateSaasResourceNames()
        {
            // Snippet: CreateSaas(LocationName, Saas, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Saas saas = new Saas();
            string saasId = "";
            // Make the request
            Saas response = saasDeploymentsClient.CreateSaas(parent, saas, saasId);
            // End snippet
        }

        /// <summary>Snippet for CreateSaasAsync</summary>
        public async Task CreateSaasResourceNamesAsync()
        {
            // Snippet: CreateSaasAsync(LocationName, Saas, string, CallSettings)
            // Additional: CreateSaasAsync(LocationName, Saas, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Saas saas = new Saas();
            string saasId = "";
            // Make the request
            Saas response = await saasDeploymentsClient.CreateSaasAsync(parent, saas, saasId);
            // End snippet
        }

        /// <summary>Snippet for UpdateSaas</summary>
        public void UpdateSaasRequestObject()
        {
            // Snippet: UpdateSaas(UpdateSaasRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UpdateSaasRequest request = new UpdateSaasRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Saas = new Saas(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Saas response = saasDeploymentsClient.UpdateSaas(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSaasAsync</summary>
        public async Task UpdateSaasRequestObjectAsync()
        {
            // Snippet: UpdateSaasAsync(UpdateSaasRequest, CallSettings)
            // Additional: UpdateSaasAsync(UpdateSaasRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSaasRequest request = new UpdateSaasRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Saas = new Saas(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Saas response = await saasDeploymentsClient.UpdateSaasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSaas</summary>
        public void UpdateSaas()
        {
            // Snippet: UpdateSaas(Saas, FieldMask, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            Saas saas = new Saas();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Saas response = saasDeploymentsClient.UpdateSaas(saas, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSaasAsync</summary>
        public async Task UpdateSaasAsync()
        {
            // Snippet: UpdateSaasAsync(Saas, FieldMask, CallSettings)
            // Additional: UpdateSaasAsync(Saas, FieldMask, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            Saas saas = new Saas();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Saas response = await saasDeploymentsClient.UpdateSaasAsync(saas, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSaas</summary>
        public void DeleteSaasRequestObject()
        {
            // Snippet: DeleteSaas(DeleteSaasRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            DeleteSaasRequest request = new DeleteSaasRequest
            {
                SaasName = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasDeploymentsClient.DeleteSaas(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSaasAsync</summary>
        public async Task DeleteSaasRequestObjectAsync()
        {
            // Snippet: DeleteSaasAsync(DeleteSaasRequest, CallSettings)
            // Additional: DeleteSaasAsync(DeleteSaasRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSaasRequest request = new DeleteSaasRequest
            {
                SaasName = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasDeploymentsClient.DeleteSaasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSaas</summary>
        public void DeleteSaas()
        {
            // Snippet: DeleteSaas(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/saas/[SAAS]";
            // Make the request
            saasDeploymentsClient.DeleteSaas(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSaasAsync</summary>
        public async Task DeleteSaasAsync()
        {
            // Snippet: DeleteSaasAsync(string, CallSettings)
            // Additional: DeleteSaasAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/saas/[SAAS]";
            // Make the request
            await saasDeploymentsClient.DeleteSaasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSaas</summary>
        public void DeleteSaasResourceNames()
        {
            // Snippet: DeleteSaas(SaasName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            SaasName name = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]");
            // Make the request
            saasDeploymentsClient.DeleteSaas(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSaasAsync</summary>
        public async Task DeleteSaasResourceNamesAsync()
        {
            // Snippet: DeleteSaasAsync(SaasName, CallSettings)
            // Additional: DeleteSaasAsync(SaasName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            SaasName name = SaasName.FromProjectLocationSaas("[PROJECT]", "[LOCATION]", "[SAAS]");
            // Make the request
            await saasDeploymentsClient.DeleteSaasAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTenants</summary>
        public void ListTenantsRequestObject()
        {
            // Snippet: ListTenants(ListTenantsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ListTenantsRequest request = new ListTenantsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTenantsResponse, Tenant> response = saasDeploymentsClient.ListTenants(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenantsAsync</summary>
        public async Task ListTenantsRequestObjectAsync()
        {
            // Snippet: ListTenantsAsync(ListTenantsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListTenantsRequest request = new ListTenantsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTenantsResponse, Tenant> response = saasDeploymentsClient.ListTenantsAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenants</summary>
        public void ListTenants()
        {
            // Snippet: ListTenants(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTenantsResponse, Tenant> response = saasDeploymentsClient.ListTenants(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenantsAsync</summary>
        public async Task ListTenantsAsync()
        {
            // Snippet: ListTenantsAsync(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTenantsResponse, Tenant> response = saasDeploymentsClient.ListTenantsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenants</summary>
        public void ListTenantsResourceNames()
        {
            // Snippet: ListTenants(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTenantsResponse, Tenant> response = saasDeploymentsClient.ListTenants(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTenantsAsync</summary>
        public async Task ListTenantsResourceNamesAsync()
        {
            // Snippet: ListTenantsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTenantsResponse, Tenant> response = saasDeploymentsClient.ListTenantsAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTenant</summary>
        public void GetTenantRequestObject()
        {
            // Snippet: GetTenant(GetTenantRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]"),
            };
            // Make the request
            Tenant response = saasDeploymentsClient.GetTenant(request);
            // End snippet
        }

        /// <summary>Snippet for GetTenantAsync</summary>
        public async Task GetTenantRequestObjectAsync()
        {
            // Snippet: GetTenantAsync(GetTenantRequest, CallSettings)
            // Additional: GetTenantAsync(GetTenantRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetTenantRequest request = new GetTenantRequest
            {
                TenantName = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]"),
            };
            // Make the request
            Tenant response = await saasDeploymentsClient.GetTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTenant</summary>
        public void GetTenant()
        {
            // Snippet: GetTenant(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tenants/[TENANT]";
            // Make the request
            Tenant response = saasDeploymentsClient.GetTenant(name);
            // End snippet
        }

        /// <summary>Snippet for GetTenantAsync</summary>
        public async Task GetTenantAsync()
        {
            // Snippet: GetTenantAsync(string, CallSettings)
            // Additional: GetTenantAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tenants/[TENANT]";
            // Make the request
            Tenant response = await saasDeploymentsClient.GetTenantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTenant</summary>
        public void GetTenantResourceNames()
        {
            // Snippet: GetTenant(TenantName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            TenantName name = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]");
            // Make the request
            Tenant response = saasDeploymentsClient.GetTenant(name);
            // End snippet
        }

        /// <summary>Snippet for GetTenantAsync</summary>
        public async Task GetTenantResourceNamesAsync()
        {
            // Snippet: GetTenantAsync(TenantName, CallSettings)
            // Additional: GetTenantAsync(TenantName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            TenantName name = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]");
            // Make the request
            Tenant response = await saasDeploymentsClient.GetTenantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTenant</summary>
        public void CreateTenantRequestObject()
        {
            // Snippet: CreateTenant(CreateTenantRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                TenantId = "",
                Tenant = new Tenant(),
            };
            // Make the request
            Tenant response = saasDeploymentsClient.CreateTenant(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTenantAsync</summary>
        public async Task CreateTenantRequestObjectAsync()
        {
            // Snippet: CreateTenantAsync(CreateTenantRequest, CallSettings)
            // Additional: CreateTenantAsync(CreateTenantRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateTenantRequest request = new CreateTenantRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                TenantId = "",
                Tenant = new Tenant(),
            };
            // Make the request
            Tenant response = await saasDeploymentsClient.CreateTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTenant</summary>
        public void CreateTenant()
        {
            // Snippet: CreateTenant(string, Tenant, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Tenant tenant = new Tenant();
            string tenantId = "";
            // Make the request
            Tenant response = saasDeploymentsClient.CreateTenant(parent, tenant, tenantId);
            // End snippet
        }

        /// <summary>Snippet for CreateTenantAsync</summary>
        public async Task CreateTenantAsync()
        {
            // Snippet: CreateTenantAsync(string, Tenant, string, CallSettings)
            // Additional: CreateTenantAsync(string, Tenant, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Tenant tenant = new Tenant();
            string tenantId = "";
            // Make the request
            Tenant response = await saasDeploymentsClient.CreateTenantAsync(parent, tenant, tenantId);
            // End snippet
        }

        /// <summary>Snippet for CreateTenant</summary>
        public void CreateTenantResourceNames()
        {
            // Snippet: CreateTenant(LocationName, Tenant, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Tenant tenant = new Tenant();
            string tenantId = "";
            // Make the request
            Tenant response = saasDeploymentsClient.CreateTenant(parent, tenant, tenantId);
            // End snippet
        }

        /// <summary>Snippet for CreateTenantAsync</summary>
        public async Task CreateTenantResourceNamesAsync()
        {
            // Snippet: CreateTenantAsync(LocationName, Tenant, string, CallSettings)
            // Additional: CreateTenantAsync(LocationName, Tenant, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Tenant tenant = new Tenant();
            string tenantId = "";
            // Make the request
            Tenant response = await saasDeploymentsClient.CreateTenantAsync(parent, tenant, tenantId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenant</summary>
        public void UpdateTenantRequestObject()
        {
            // Snippet: UpdateTenant(UpdateTenantRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Tenant = new Tenant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tenant response = saasDeploymentsClient.UpdateTenant(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenantAsync</summary>
        public async Task UpdateTenantRequestObjectAsync()
        {
            // Snippet: UpdateTenantAsync(UpdateTenantRequest, CallSettings)
            // Additional: UpdateTenantAsync(UpdateTenantRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTenantRequest request = new UpdateTenantRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Tenant = new Tenant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tenant response = await saasDeploymentsClient.UpdateTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenant</summary>
        public void UpdateTenant()
        {
            // Snippet: UpdateTenant(Tenant, FieldMask, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            Tenant tenant = new Tenant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tenant response = saasDeploymentsClient.UpdateTenant(tenant, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTenantAsync</summary>
        public async Task UpdateTenantAsync()
        {
            // Snippet: UpdateTenantAsync(Tenant, FieldMask, CallSettings)
            // Additional: UpdateTenantAsync(Tenant, FieldMask, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            Tenant tenant = new Tenant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tenant response = await saasDeploymentsClient.UpdateTenantAsync(tenant, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenant</summary>
        public void DeleteTenantRequestObject()
        {
            // Snippet: DeleteTenant(DeleteTenantRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasDeploymentsClient.DeleteTenant(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenantAsync</summary>
        public async Task DeleteTenantRequestObjectAsync()
        {
            // Snippet: DeleteTenantAsync(DeleteTenantRequest, CallSettings)
            // Additional: DeleteTenantAsync(DeleteTenantRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTenantRequest request = new DeleteTenantRequest
            {
                TenantName = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasDeploymentsClient.DeleteTenantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenant</summary>
        public void DeleteTenant()
        {
            // Snippet: DeleteTenant(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tenants/[TENANT]";
            // Make the request
            saasDeploymentsClient.DeleteTenant(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenantAsync</summary>
        public async Task DeleteTenantAsync()
        {
            // Snippet: DeleteTenantAsync(string, CallSettings)
            // Additional: DeleteTenantAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tenants/[TENANT]";
            // Make the request
            await saasDeploymentsClient.DeleteTenantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenant</summary>
        public void DeleteTenantResourceNames()
        {
            // Snippet: DeleteTenant(TenantName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            TenantName name = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]");
            // Make the request
            saasDeploymentsClient.DeleteTenant(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTenantAsync</summary>
        public async Task DeleteTenantResourceNamesAsync()
        {
            // Snippet: DeleteTenantAsync(TenantName, CallSettings)
            // Additional: DeleteTenantAsync(TenantName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            TenantName name = TenantName.FromProjectLocationTenant("[PROJECT]", "[LOCATION]", "[TENANT]");
            // Make the request
            await saasDeploymentsClient.DeleteTenantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUnitKinds</summary>
        public void ListUnitKindsRequestObject()
        {
            // Snippet: ListUnitKinds(ListUnitKindsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ListUnitKindsRequest request = new ListUnitKindsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListUnitKindsResponse, UnitKind> response = saasDeploymentsClient.ListUnitKinds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UnitKind item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitKindsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitKind> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitKindsAsync</summary>
        public async Task ListUnitKindsRequestObjectAsync()
        {
            // Snippet: ListUnitKindsAsync(ListUnitKindsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListUnitKindsRequest request = new ListUnitKindsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> response = saasDeploymentsClient.ListUnitKindsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UnitKind item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitKindsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitKind> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitKinds</summary>
        public void ListUnitKinds()
        {
            // Snippet: ListUnitKinds(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListUnitKindsResponse, UnitKind> response = saasDeploymentsClient.ListUnitKinds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UnitKind item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitKindsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitKind> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitKindsAsync</summary>
        public async Task ListUnitKindsAsync()
        {
            // Snippet: ListUnitKindsAsync(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> response = saasDeploymentsClient.ListUnitKindsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UnitKind item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitKindsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitKind> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitKinds</summary>
        public void ListUnitKindsResourceNames()
        {
            // Snippet: ListUnitKinds(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListUnitKindsResponse, UnitKind> response = saasDeploymentsClient.ListUnitKinds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UnitKind item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitKindsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitKind> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitKindsAsync</summary>
        public async Task ListUnitKindsResourceNamesAsync()
        {
            // Snippet: ListUnitKindsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListUnitKindsResponse, UnitKind> response = saasDeploymentsClient.ListUnitKindsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UnitKind item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitKindsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitKind item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitKind> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitKind item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUnitKind</summary>
        public void GetUnitKindRequestObject()
        {
            // Snippet: GetUnitKind(GetUnitKindRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            GetUnitKindRequest request = new GetUnitKindRequest
            {
                UnitKindName = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]"),
            };
            // Make the request
            UnitKind response = saasDeploymentsClient.GetUnitKind(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnitKindAsync</summary>
        public async Task GetUnitKindRequestObjectAsync()
        {
            // Snippet: GetUnitKindAsync(GetUnitKindRequest, CallSettings)
            // Additional: GetUnitKindAsync(GetUnitKindRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetUnitKindRequest request = new GetUnitKindRequest
            {
                UnitKindName = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]"),
            };
            // Make the request
            UnitKind response = await saasDeploymentsClient.GetUnitKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnitKind</summary>
        public void GetUnitKind()
        {
            // Snippet: GetUnitKind(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitKinds/[UNITKIND]";
            // Make the request
            UnitKind response = saasDeploymentsClient.GetUnitKind(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitKindAsync</summary>
        public async Task GetUnitKindAsync()
        {
            // Snippet: GetUnitKindAsync(string, CallSettings)
            // Additional: GetUnitKindAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitKinds/[UNITKIND]";
            // Make the request
            UnitKind response = await saasDeploymentsClient.GetUnitKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitKind</summary>
        public void GetUnitKindResourceNames()
        {
            // Snippet: GetUnitKind(UnitKindName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitKindName name = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]");
            // Make the request
            UnitKind response = saasDeploymentsClient.GetUnitKind(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitKindAsync</summary>
        public async Task GetUnitKindResourceNamesAsync()
        {
            // Snippet: GetUnitKindAsync(UnitKindName, CallSettings)
            // Additional: GetUnitKindAsync(UnitKindName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitKindName name = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]");
            // Make the request
            UnitKind response = await saasDeploymentsClient.GetUnitKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitKind</summary>
        public void CreateUnitKindRequestObject()
        {
            // Snippet: CreateUnitKind(CreateUnitKindRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            CreateUnitKindRequest request = new CreateUnitKindRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                UnitKindId = "",
                UnitKind = new UnitKind(),
            };
            // Make the request
            UnitKind response = saasDeploymentsClient.CreateUnitKind(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitKindAsync</summary>
        public async Task CreateUnitKindRequestObjectAsync()
        {
            // Snippet: CreateUnitKindAsync(CreateUnitKindRequest, CallSettings)
            // Additional: CreateUnitKindAsync(CreateUnitKindRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateUnitKindRequest request = new CreateUnitKindRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                UnitKindId = "",
                UnitKind = new UnitKind(),
            };
            // Make the request
            UnitKind response = await saasDeploymentsClient.CreateUnitKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitKind</summary>
        public void CreateUnitKind()
        {
            // Snippet: CreateUnitKind(string, UnitKind, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            UnitKind unitKind = new UnitKind();
            string unitKindId = "";
            // Make the request
            UnitKind response = saasDeploymentsClient.CreateUnitKind(parent, unitKind, unitKindId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitKindAsync</summary>
        public async Task CreateUnitKindAsync()
        {
            // Snippet: CreateUnitKindAsync(string, UnitKind, string, CallSettings)
            // Additional: CreateUnitKindAsync(string, UnitKind, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            UnitKind unitKind = new UnitKind();
            string unitKindId = "";
            // Make the request
            UnitKind response = await saasDeploymentsClient.CreateUnitKindAsync(parent, unitKind, unitKindId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitKind</summary>
        public void CreateUnitKindResourceNames()
        {
            // Snippet: CreateUnitKind(LocationName, UnitKind, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            UnitKind unitKind = new UnitKind();
            string unitKindId = "";
            // Make the request
            UnitKind response = saasDeploymentsClient.CreateUnitKind(parent, unitKind, unitKindId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitKindAsync</summary>
        public async Task CreateUnitKindResourceNamesAsync()
        {
            // Snippet: CreateUnitKindAsync(LocationName, UnitKind, string, CallSettings)
            // Additional: CreateUnitKindAsync(LocationName, UnitKind, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            UnitKind unitKind = new UnitKind();
            string unitKindId = "";
            // Make the request
            UnitKind response = await saasDeploymentsClient.CreateUnitKindAsync(parent, unitKind, unitKindId);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitKind</summary>
        public void UpdateUnitKindRequestObject()
        {
            // Snippet: UpdateUnitKind(UpdateUnitKindRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UpdateUnitKindRequest request = new UpdateUnitKindRequest
            {
                ValidateOnly = false,
                RequestId = "",
                UnitKind = new UnitKind(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UnitKind response = saasDeploymentsClient.UpdateUnitKind(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitKindAsync</summary>
        public async Task UpdateUnitKindRequestObjectAsync()
        {
            // Snippet: UpdateUnitKindAsync(UpdateUnitKindRequest, CallSettings)
            // Additional: UpdateUnitKindAsync(UpdateUnitKindRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUnitKindRequest request = new UpdateUnitKindRequest
            {
                ValidateOnly = false,
                RequestId = "",
                UnitKind = new UnitKind(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UnitKind response = await saasDeploymentsClient.UpdateUnitKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitKind</summary>
        public void UpdateUnitKind()
        {
            // Snippet: UpdateUnitKind(UnitKind, FieldMask, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitKind unitKind = new UnitKind();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UnitKind response = saasDeploymentsClient.UpdateUnitKind(unitKind, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitKindAsync</summary>
        public async Task UpdateUnitKindAsync()
        {
            // Snippet: UpdateUnitKindAsync(UnitKind, FieldMask, CallSettings)
            // Additional: UpdateUnitKindAsync(UnitKind, FieldMask, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitKind unitKind = new UnitKind();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UnitKind response = await saasDeploymentsClient.UpdateUnitKindAsync(unitKind, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitKind</summary>
        public void DeleteUnitKindRequestObject()
        {
            // Snippet: DeleteUnitKind(DeleteUnitKindRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            DeleteUnitKindRequest request = new DeleteUnitKindRequest
            {
                UnitKindName = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasDeploymentsClient.DeleteUnitKind(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitKindAsync</summary>
        public async Task DeleteUnitKindRequestObjectAsync()
        {
            // Snippet: DeleteUnitKindAsync(DeleteUnitKindRequest, CallSettings)
            // Additional: DeleteUnitKindAsync(DeleteUnitKindRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUnitKindRequest request = new DeleteUnitKindRequest
            {
                UnitKindName = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasDeploymentsClient.DeleteUnitKindAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitKind</summary>
        public void DeleteUnitKind()
        {
            // Snippet: DeleteUnitKind(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitKinds/[UNITKIND]";
            // Make the request
            saasDeploymentsClient.DeleteUnitKind(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitKindAsync</summary>
        public async Task DeleteUnitKindAsync()
        {
            // Snippet: DeleteUnitKindAsync(string, CallSettings)
            // Additional: DeleteUnitKindAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitKinds/[UNITKIND]";
            // Make the request
            await saasDeploymentsClient.DeleteUnitKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitKind</summary>
        public void DeleteUnitKindResourceNames()
        {
            // Snippet: DeleteUnitKind(UnitKindName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitKindName name = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]");
            // Make the request
            saasDeploymentsClient.DeleteUnitKind(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitKindAsync</summary>
        public async Task DeleteUnitKindResourceNamesAsync()
        {
            // Snippet: DeleteUnitKindAsync(UnitKindName, CallSettings)
            // Additional: DeleteUnitKindAsync(UnitKindName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitKindName name = UnitKindName.FromProjectLocationUnitKind("[PROJECT]", "[LOCATION]", "[UNITKIND]");
            // Make the request
            await saasDeploymentsClient.DeleteUnitKindAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUnits</summary>
        public void ListUnitsRequestObject()
        {
            // Snippet: ListUnits(ListUnitsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ListUnitsRequest request = new ListUnitsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListUnitsResponse, Unit> response = saasDeploymentsClient.ListUnits(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Unit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitsAsync</summary>
        public async Task ListUnitsRequestObjectAsync()
        {
            // Snippet: ListUnitsAsync(ListUnitsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListUnitsRequest request = new ListUnitsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUnitsResponse, Unit> response = saasDeploymentsClient.ListUnitsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Unit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnits</summary>
        public void ListUnits()
        {
            // Snippet: ListUnits(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListUnitsResponse, Unit> response = saasDeploymentsClient.ListUnits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Unit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitsAsync</summary>
        public async Task ListUnitsAsync()
        {
            // Snippet: ListUnitsAsync(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListUnitsResponse, Unit> response = saasDeploymentsClient.ListUnitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Unit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnits</summary>
        public void ListUnitsResourceNames()
        {
            // Snippet: ListUnits(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListUnitsResponse, Unit> response = saasDeploymentsClient.ListUnits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Unit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitsAsync</summary>
        public async Task ListUnitsResourceNamesAsync()
        {
            // Snippet: ListUnitsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListUnitsResponse, Unit> response = saasDeploymentsClient.ListUnitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Unit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Unit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Unit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Unit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUnit</summary>
        public void GetUnitRequestObject()
        {
            // Snippet: GetUnit(GetUnitRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            GetUnitRequest request = new GetUnitRequest
            {
                UnitName = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]"),
            };
            // Make the request
            Unit response = saasDeploymentsClient.GetUnit(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnitAsync</summary>
        public async Task GetUnitRequestObjectAsync()
        {
            // Snippet: GetUnitAsync(GetUnitRequest, CallSettings)
            // Additional: GetUnitAsync(GetUnitRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetUnitRequest request = new GetUnitRequest
            {
                UnitName = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]"),
            };
            // Make the request
            Unit response = await saasDeploymentsClient.GetUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnit</summary>
        public void GetUnit()
        {
            // Snippet: GetUnit(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/units/[UNIT]";
            // Make the request
            Unit response = saasDeploymentsClient.GetUnit(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitAsync</summary>
        public async Task GetUnitAsync()
        {
            // Snippet: GetUnitAsync(string, CallSettings)
            // Additional: GetUnitAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/units/[UNIT]";
            // Make the request
            Unit response = await saasDeploymentsClient.GetUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnit</summary>
        public void GetUnitResourceNames()
        {
            // Snippet: GetUnit(UnitName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitName name = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]");
            // Make the request
            Unit response = saasDeploymentsClient.GetUnit(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitAsync</summary>
        public async Task GetUnitResourceNamesAsync()
        {
            // Snippet: GetUnitAsync(UnitName, CallSettings)
            // Additional: GetUnitAsync(UnitName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitName name = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]");
            // Make the request
            Unit response = await saasDeploymentsClient.GetUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUnit</summary>
        public void CreateUnitRequestObject()
        {
            // Snippet: CreateUnit(CreateUnitRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            CreateUnitRequest request = new CreateUnitRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                UnitId = "",
                Unit = new Unit(),
            };
            // Make the request
            Unit response = saasDeploymentsClient.CreateUnit(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitAsync</summary>
        public async Task CreateUnitRequestObjectAsync()
        {
            // Snippet: CreateUnitAsync(CreateUnitRequest, CallSettings)
            // Additional: CreateUnitAsync(CreateUnitRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateUnitRequest request = new CreateUnitRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                UnitId = "",
                Unit = new Unit(),
            };
            // Make the request
            Unit response = await saasDeploymentsClient.CreateUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnit</summary>
        public void CreateUnit()
        {
            // Snippet: CreateUnit(string, Unit, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Unit unit = new Unit();
            string unitId = "";
            // Make the request
            Unit response = saasDeploymentsClient.CreateUnit(parent, unit, unitId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitAsync</summary>
        public async Task CreateUnitAsync()
        {
            // Snippet: CreateUnitAsync(string, Unit, string, CallSettings)
            // Additional: CreateUnitAsync(string, Unit, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Unit unit = new Unit();
            string unitId = "";
            // Make the request
            Unit response = await saasDeploymentsClient.CreateUnitAsync(parent, unit, unitId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnit</summary>
        public void CreateUnitResourceNames()
        {
            // Snippet: CreateUnit(LocationName, Unit, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Unit unit = new Unit();
            string unitId = "";
            // Make the request
            Unit response = saasDeploymentsClient.CreateUnit(parent, unit, unitId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitAsync</summary>
        public async Task CreateUnitResourceNamesAsync()
        {
            // Snippet: CreateUnitAsync(LocationName, Unit, string, CallSettings)
            // Additional: CreateUnitAsync(LocationName, Unit, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Unit unit = new Unit();
            string unitId = "";
            // Make the request
            Unit response = await saasDeploymentsClient.CreateUnitAsync(parent, unit, unitId);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnit</summary>
        public void UpdateUnitRequestObject()
        {
            // Snippet: UpdateUnit(UpdateUnitRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UpdateUnitRequest request = new UpdateUnitRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Unit = new Unit(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Unit response = saasDeploymentsClient.UpdateUnit(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitAsync</summary>
        public async Task UpdateUnitRequestObjectAsync()
        {
            // Snippet: UpdateUnitAsync(UpdateUnitRequest, CallSettings)
            // Additional: UpdateUnitAsync(UpdateUnitRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUnitRequest request = new UpdateUnitRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Unit = new Unit(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Unit response = await saasDeploymentsClient.UpdateUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnit</summary>
        public void UpdateUnit()
        {
            // Snippet: UpdateUnit(Unit, FieldMask, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            Unit unit = new Unit();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Unit response = saasDeploymentsClient.UpdateUnit(unit, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitAsync</summary>
        public async Task UpdateUnitAsync()
        {
            // Snippet: UpdateUnitAsync(Unit, FieldMask, CallSettings)
            // Additional: UpdateUnitAsync(Unit, FieldMask, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            Unit unit = new Unit();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Unit response = await saasDeploymentsClient.UpdateUnitAsync(unit, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnit</summary>
        public void DeleteUnitRequestObject()
        {
            // Snippet: DeleteUnit(DeleteUnitRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            DeleteUnitRequest request = new DeleteUnitRequest
            {
                UnitName = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasDeploymentsClient.DeleteUnit(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitAsync</summary>
        public async Task DeleteUnitRequestObjectAsync()
        {
            // Snippet: DeleteUnitAsync(DeleteUnitRequest, CallSettings)
            // Additional: DeleteUnitAsync(DeleteUnitRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUnitRequest request = new DeleteUnitRequest
            {
                UnitName = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasDeploymentsClient.DeleteUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnit</summary>
        public void DeleteUnit()
        {
            // Snippet: DeleteUnit(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/units/[UNIT]";
            // Make the request
            saasDeploymentsClient.DeleteUnit(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitAsync</summary>
        public async Task DeleteUnitAsync()
        {
            // Snippet: DeleteUnitAsync(string, CallSettings)
            // Additional: DeleteUnitAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/units/[UNIT]";
            // Make the request
            await saasDeploymentsClient.DeleteUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnit</summary>
        public void DeleteUnitResourceNames()
        {
            // Snippet: DeleteUnit(UnitName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitName name = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]");
            // Make the request
            saasDeploymentsClient.DeleteUnit(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitAsync</summary>
        public async Task DeleteUnitResourceNamesAsync()
        {
            // Snippet: DeleteUnitAsync(UnitName, CallSettings)
            // Additional: DeleteUnitAsync(UnitName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitName name = UnitName.FromProjectLocationUnit("[PROJECT]", "[LOCATION]", "[UNIT]");
            // Make the request
            await saasDeploymentsClient.DeleteUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUnitOperations</summary>
        public void ListUnitOperationsRequestObject()
        {
            // Snippet: ListUnitOperations(ListUnitOperationsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ListUnitOperationsRequest request = new ListUnitOperationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListUnitOperationsResponse, UnitOperation> response = saasDeploymentsClient.ListUnitOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UnitOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitOperationsAsync</summary>
        public async Task ListUnitOperationsRequestObjectAsync()
        {
            // Snippet: ListUnitOperationsAsync(ListUnitOperationsRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListUnitOperationsRequest request = new ListUnitOperationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> response = saasDeploymentsClient.ListUnitOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UnitOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitOperations</summary>
        public void ListUnitOperations()
        {
            // Snippet: ListUnitOperations(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListUnitOperationsResponse, UnitOperation> response = saasDeploymentsClient.ListUnitOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UnitOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitOperationsAsync</summary>
        public async Task ListUnitOperationsAsync()
        {
            // Snippet: ListUnitOperationsAsync(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> response = saasDeploymentsClient.ListUnitOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UnitOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitOperations</summary>
        public void ListUnitOperationsResourceNames()
        {
            // Snippet: ListUnitOperations(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListUnitOperationsResponse, UnitOperation> response = saasDeploymentsClient.ListUnitOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UnitOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUnitOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUnitOperationsAsync</summary>
        public async Task ListUnitOperationsResourceNamesAsync()
        {
            // Snippet: ListUnitOperationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListUnitOperationsResponse, UnitOperation> response = saasDeploymentsClient.ListUnitOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UnitOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUnitOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UnitOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UnitOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UnitOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUnitOperation</summary>
        public void GetUnitOperationRequestObject()
        {
            // Snippet: GetUnitOperation(GetUnitOperationRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            GetUnitOperationRequest request = new GetUnitOperationRequest
            {
                UnitOperationName = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]"),
            };
            // Make the request
            UnitOperation response = saasDeploymentsClient.GetUnitOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnitOperationAsync</summary>
        public async Task GetUnitOperationRequestObjectAsync()
        {
            // Snippet: GetUnitOperationAsync(GetUnitOperationRequest, CallSettings)
            // Additional: GetUnitOperationAsync(GetUnitOperationRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetUnitOperationRequest request = new GetUnitOperationRequest
            {
                UnitOperationName = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]"),
            };
            // Make the request
            UnitOperation response = await saasDeploymentsClient.GetUnitOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUnitOperation</summary>
        public void GetUnitOperation()
        {
            // Snippet: GetUnitOperation(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitOperations/[UNITOPERATION]";
            // Make the request
            UnitOperation response = saasDeploymentsClient.GetUnitOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitOperationAsync</summary>
        public async Task GetUnitOperationAsync()
        {
            // Snippet: GetUnitOperationAsync(string, CallSettings)
            // Additional: GetUnitOperationAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitOperations/[UNITOPERATION]";
            // Make the request
            UnitOperation response = await saasDeploymentsClient.GetUnitOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitOperation</summary>
        public void GetUnitOperationResourceNames()
        {
            // Snippet: GetUnitOperation(UnitOperationName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitOperationName name = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]");
            // Make the request
            UnitOperation response = saasDeploymentsClient.GetUnitOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetUnitOperationAsync</summary>
        public async Task GetUnitOperationResourceNamesAsync()
        {
            // Snippet: GetUnitOperationAsync(UnitOperationName, CallSettings)
            // Additional: GetUnitOperationAsync(UnitOperationName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitOperationName name = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]");
            // Make the request
            UnitOperation response = await saasDeploymentsClient.GetUnitOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitOperation</summary>
        public void CreateUnitOperationRequestObject()
        {
            // Snippet: CreateUnitOperation(CreateUnitOperationRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            CreateUnitOperationRequest request = new CreateUnitOperationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                UnitOperationId = "",
                UnitOperation = new UnitOperation(),
            };
            // Make the request
            UnitOperation response = saasDeploymentsClient.CreateUnitOperation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitOperationAsync</summary>
        public async Task CreateUnitOperationRequestObjectAsync()
        {
            // Snippet: CreateUnitOperationAsync(CreateUnitOperationRequest, CallSettings)
            // Additional: CreateUnitOperationAsync(CreateUnitOperationRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateUnitOperationRequest request = new CreateUnitOperationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                UnitOperationId = "",
                UnitOperation = new UnitOperation(),
            };
            // Make the request
            UnitOperation response = await saasDeploymentsClient.CreateUnitOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitOperation</summary>
        public void CreateUnitOperation()
        {
            // Snippet: CreateUnitOperation(string, UnitOperation, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            UnitOperation unitOperation = new UnitOperation();
            string unitOperationId = "";
            // Make the request
            UnitOperation response = saasDeploymentsClient.CreateUnitOperation(parent, unitOperation, unitOperationId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitOperationAsync</summary>
        public async Task CreateUnitOperationAsync()
        {
            // Snippet: CreateUnitOperationAsync(string, UnitOperation, string, CallSettings)
            // Additional: CreateUnitOperationAsync(string, UnitOperation, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            UnitOperation unitOperation = new UnitOperation();
            string unitOperationId = "";
            // Make the request
            UnitOperation response = await saasDeploymentsClient.CreateUnitOperationAsync(parent, unitOperation, unitOperationId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitOperation</summary>
        public void CreateUnitOperationResourceNames()
        {
            // Snippet: CreateUnitOperation(LocationName, UnitOperation, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            UnitOperation unitOperation = new UnitOperation();
            string unitOperationId = "";
            // Make the request
            UnitOperation response = saasDeploymentsClient.CreateUnitOperation(parent, unitOperation, unitOperationId);
            // End snippet
        }

        /// <summary>Snippet for CreateUnitOperationAsync</summary>
        public async Task CreateUnitOperationResourceNamesAsync()
        {
            // Snippet: CreateUnitOperationAsync(LocationName, UnitOperation, string, CallSettings)
            // Additional: CreateUnitOperationAsync(LocationName, UnitOperation, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            UnitOperation unitOperation = new UnitOperation();
            string unitOperationId = "";
            // Make the request
            UnitOperation response = await saasDeploymentsClient.CreateUnitOperationAsync(parent, unitOperation, unitOperationId);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitOperation</summary>
        public void UpdateUnitOperationRequestObject()
        {
            // Snippet: UpdateUnitOperation(UpdateUnitOperationRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UpdateUnitOperationRequest request = new UpdateUnitOperationRequest
            {
                ValidateOnly = false,
                RequestId = "",
                UnitOperation = new UnitOperation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UnitOperation response = saasDeploymentsClient.UpdateUnitOperation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitOperationAsync</summary>
        public async Task UpdateUnitOperationRequestObjectAsync()
        {
            // Snippet: UpdateUnitOperationAsync(UpdateUnitOperationRequest, CallSettings)
            // Additional: UpdateUnitOperationAsync(UpdateUnitOperationRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUnitOperationRequest request = new UpdateUnitOperationRequest
            {
                ValidateOnly = false,
                RequestId = "",
                UnitOperation = new UnitOperation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UnitOperation response = await saasDeploymentsClient.UpdateUnitOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitOperation</summary>
        public void UpdateUnitOperation()
        {
            // Snippet: UpdateUnitOperation(UnitOperation, FieldMask, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitOperation unitOperation = new UnitOperation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UnitOperation response = saasDeploymentsClient.UpdateUnitOperation(unitOperation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUnitOperationAsync</summary>
        public async Task UpdateUnitOperationAsync()
        {
            // Snippet: UpdateUnitOperationAsync(UnitOperation, FieldMask, CallSettings)
            // Additional: UpdateUnitOperationAsync(UnitOperation, FieldMask, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitOperation unitOperation = new UnitOperation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UnitOperation response = await saasDeploymentsClient.UpdateUnitOperationAsync(unitOperation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitOperation</summary>
        public void DeleteUnitOperationRequestObject()
        {
            // Snippet: DeleteUnitOperation(DeleteUnitOperationRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            DeleteUnitOperationRequest request = new DeleteUnitOperationRequest
            {
                UnitOperationName = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasDeploymentsClient.DeleteUnitOperation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitOperationAsync</summary>
        public async Task DeleteUnitOperationRequestObjectAsync()
        {
            // Snippet: DeleteUnitOperationAsync(DeleteUnitOperationRequest, CallSettings)
            // Additional: DeleteUnitOperationAsync(DeleteUnitOperationRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUnitOperationRequest request = new DeleteUnitOperationRequest
            {
                UnitOperationName = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasDeploymentsClient.DeleteUnitOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitOperation</summary>
        public void DeleteUnitOperation()
        {
            // Snippet: DeleteUnitOperation(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitOperations/[UNITOPERATION]";
            // Make the request
            saasDeploymentsClient.DeleteUnitOperation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitOperationAsync</summary>
        public async Task DeleteUnitOperationAsync()
        {
            // Snippet: DeleteUnitOperationAsync(string, CallSettings)
            // Additional: DeleteUnitOperationAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/unitOperations/[UNITOPERATION]";
            // Make the request
            await saasDeploymentsClient.DeleteUnitOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitOperation</summary>
        public void DeleteUnitOperationResourceNames()
        {
            // Snippet: DeleteUnitOperation(UnitOperationName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UnitOperationName name = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]");
            // Make the request
            saasDeploymentsClient.DeleteUnitOperation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUnitOperationAsync</summary>
        public async Task DeleteUnitOperationResourceNamesAsync()
        {
            // Snippet: DeleteUnitOperationAsync(UnitOperationName, CallSettings)
            // Additional: DeleteUnitOperationAsync(UnitOperationName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UnitOperationName name = UnitOperationName.FromProjectLocationUnitOperation("[PROJECT]", "[LOCATION]", "[UNITOPERATION]");
            // Make the request
            await saasDeploymentsClient.DeleteUnitOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleasesRequestObject()
        {
            // Snippet: ListReleases(ListReleasesRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = saasDeploymentsClient.ListReleases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesRequestObjectAsync()
        {
            // Snippet: ListReleasesAsync(ListReleasesRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = saasDeploymentsClient.ListReleasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleases()
        {
            // Snippet: ListReleases(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = saasDeploymentsClient.ListReleases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesAsync()
        {
            // Snippet: ListReleasesAsync(string, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = saasDeploymentsClient.ListReleasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleasesResourceNames()
        {
            // Snippet: ListReleases(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = saasDeploymentsClient.ListReleases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesResourceNamesAsync()
        {
            // Snippet: ListReleasesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = saasDeploymentsClient.ListReleasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetReleaseRequestObject()
        {
            // Snippet: GetRelease(GetReleaseRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]"),
            };
            // Make the request
            Release response = saasDeploymentsClient.GetRelease(request);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseRequestObjectAsync()
        {
            // Snippet: GetReleaseAsync(GetReleaseRequest, CallSettings)
            // Additional: GetReleaseAsync(GetReleaseRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]"),
            };
            // Make the request
            Release response = await saasDeploymentsClient.GetReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetRelease()
        {
            // Snippet: GetRelease(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/releases/[RELEASE]";
            // Make the request
            Release response = saasDeploymentsClient.GetRelease(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseAsync()
        {
            // Snippet: GetReleaseAsync(string, CallSettings)
            // Additional: GetReleaseAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/releases/[RELEASE]";
            // Make the request
            Release response = await saasDeploymentsClient.GetReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetReleaseResourceNames()
        {
            // Snippet: GetRelease(ReleaseName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]");
            // Make the request
            Release response = saasDeploymentsClient.GetRelease(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseResourceNamesAsync()
        {
            // Snippet: GetReleaseAsync(ReleaseName, CallSettings)
            // Additional: GetReleaseAsync(ReleaseName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]");
            // Make the request
            Release response = await saasDeploymentsClient.GetReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateReleaseRequestObject()
        {
            // Snippet: CreateRelease(CreateReleaseRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            CreateReleaseRequest request = new CreateReleaseRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                ReleaseId = "",
                Release = new Release(),
            };
            // Make the request
            Release response = saasDeploymentsClient.CreateRelease(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseRequestObjectAsync()
        {
            // Snippet: CreateReleaseAsync(CreateReleaseRequest, CallSettings)
            // Additional: CreateReleaseAsync(CreateReleaseRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateReleaseRequest request = new CreateReleaseRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                RequestId = "",
                ReleaseId = "",
                Release = new Release(),
            };
            // Make the request
            Release response = await saasDeploymentsClient.CreateReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateRelease()
        {
            // Snippet: CreateRelease(string, Release, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Release response = saasDeploymentsClient.CreateRelease(parent, release, releaseId);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseAsync()
        {
            // Snippet: CreateReleaseAsync(string, Release, string, CallSettings)
            // Additional: CreateReleaseAsync(string, Release, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Release response = await saasDeploymentsClient.CreateReleaseAsync(parent, release, releaseId);
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateReleaseResourceNames()
        {
            // Snippet: CreateRelease(LocationName, Release, string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Release response = saasDeploymentsClient.CreateRelease(parent, release, releaseId);
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseResourceNamesAsync()
        {
            // Snippet: CreateReleaseAsync(LocationName, Release, string, CallSettings)
            // Additional: CreateReleaseAsync(LocationName, Release, string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Release response = await saasDeploymentsClient.CreateReleaseAsync(parent, release, releaseId);
            // End snippet
        }

        /// <summary>Snippet for UpdateRelease</summary>
        public void UpdateReleaseRequestObject()
        {
            // Snippet: UpdateRelease(UpdateReleaseRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            UpdateReleaseRequest request = new UpdateReleaseRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Release = new Release(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Release response = saasDeploymentsClient.UpdateRelease(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseAsync</summary>
        public async Task UpdateReleaseRequestObjectAsync()
        {
            // Snippet: UpdateReleaseAsync(UpdateReleaseRequest, CallSettings)
            // Additional: UpdateReleaseAsync(UpdateReleaseRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReleaseRequest request = new UpdateReleaseRequest
            {
                ValidateOnly = false,
                RequestId = "",
                Release = new Release(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Release response = await saasDeploymentsClient.UpdateReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRelease</summary>
        public void UpdateRelease()
        {
            // Snippet: UpdateRelease(Release, FieldMask, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            Release release = new Release();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Release response = saasDeploymentsClient.UpdateRelease(release, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReleaseAsync</summary>
        public async Task UpdateReleaseAsync()
        {
            // Snippet: UpdateReleaseAsync(Release, FieldMask, CallSettings)
            // Additional: UpdateReleaseAsync(Release, FieldMask, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            Release release = new Release();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Release response = await saasDeploymentsClient.UpdateReleaseAsync(release, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRelease</summary>
        public void DeleteReleaseRequestObject()
        {
            // Snippet: DeleteRelease(DeleteReleaseRequest, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            DeleteReleaseRequest request = new DeleteReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            saasDeploymentsClient.DeleteRelease(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseAsync</summary>
        public async Task DeleteReleaseRequestObjectAsync()
        {
            // Snippet: DeleteReleaseAsync(DeleteReleaseRequest, CallSettings)
            // Additional: DeleteReleaseAsync(DeleteReleaseRequest, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReleaseRequest request = new DeleteReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]"),
                Etag = "",
                ValidateOnly = false,
                RequestId = "",
            };
            // Make the request
            await saasDeploymentsClient.DeleteReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRelease</summary>
        public void DeleteRelease()
        {
            // Snippet: DeleteRelease(string, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/releases/[RELEASE]";
            // Make the request
            saasDeploymentsClient.DeleteRelease(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseAsync</summary>
        public async Task DeleteReleaseAsync()
        {
            // Snippet: DeleteReleaseAsync(string, CallSettings)
            // Additional: DeleteReleaseAsync(string, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/releases/[RELEASE]";
            // Make the request
            await saasDeploymentsClient.DeleteReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRelease</summary>
        public void DeleteReleaseResourceNames()
        {
            // Snippet: DeleteRelease(ReleaseName, CallSettings)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = SaasDeploymentsClient.Create();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]");
            // Make the request
            saasDeploymentsClient.DeleteRelease(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReleaseAsync</summary>
        public async Task DeleteReleaseResourceNamesAsync()
        {
            // Snippet: DeleteReleaseAsync(ReleaseName, CallSettings)
            // Additional: DeleteReleaseAsync(ReleaseName, CancellationToken)
            // Create client
            SaasDeploymentsClient saasDeploymentsClient = await SaasDeploymentsClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationRelease("[PROJECT]", "[LOCATION]", "[RELEASE]");
            // Make the request
            await saasDeploymentsClient.DeleteReleaseAsync(name);
            // End snippet
        }
    }
}
