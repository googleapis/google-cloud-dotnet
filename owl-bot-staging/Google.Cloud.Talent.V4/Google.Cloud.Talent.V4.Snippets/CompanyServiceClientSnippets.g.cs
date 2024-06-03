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
    using Google.Cloud.Talent.V4;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCompanyServiceClientSnippets
    {
        /// <summary>Snippet for CreateCompany</summary>
        public void CreateCompanyRequestObject()
        {
            // Snippet: CreateCompany(CreateCompanyRequest, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company(),
            };
            // Make the request
            Company response = companyServiceClient.CreateCompany(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompanyAsync</summary>
        public async Task CreateCompanyRequestObjectAsync()
        {
            // Snippet: CreateCompanyAsync(CreateCompanyRequest, CallSettings)
            // Additional: CreateCompanyAsync(CreateCompanyRequest, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Company = new Company(),
            };
            // Make the request
            Company response = await companyServiceClient.CreateCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompany</summary>
        public void CreateCompany()
        {
            // Snippet: CreateCompany(string, Company, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            Company company = new Company();
            // Make the request
            Company response = companyServiceClient.CreateCompany(parent, company);
            // End snippet
        }

        /// <summary>Snippet for CreateCompanyAsync</summary>
        public async Task CreateCompanyAsync()
        {
            // Snippet: CreateCompanyAsync(string, Company, CallSettings)
            // Additional: CreateCompanyAsync(string, Company, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            Company company = new Company();
            // Make the request
            Company response = await companyServiceClient.CreateCompanyAsync(parent, company);
            // End snippet
        }

        /// <summary>Snippet for CreateCompany</summary>
        public void CreateCompanyResourceNames()
        {
            // Snippet: CreateCompany(TenantName, Company, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            Company company = new Company();
            // Make the request
            Company response = companyServiceClient.CreateCompany(parent, company);
            // End snippet
        }

        /// <summary>Snippet for CreateCompanyAsync</summary>
        public async Task CreateCompanyResourceNamesAsync()
        {
            // Snippet: CreateCompanyAsync(TenantName, Company, CallSettings)
            // Additional: CreateCompanyAsync(TenantName, Company, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            Company company = new Company();
            // Make the request
            Company response = await companyServiceClient.CreateCompanyAsync(parent, company);
            // End snippet
        }

        /// <summary>Snippet for GetCompany</summary>
        public void GetCompanyRequestObject()
        {
            // Snippet: GetCompany(GetCompanyRequest, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            // Make the request
            Company response = companyServiceClient.GetCompany(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompanyAsync</summary>
        public async Task GetCompanyRequestObjectAsync()
        {
            // Snippet: GetCompanyAsync(GetCompanyRequest, CallSettings)
            // Additional: GetCompanyAsync(GetCompanyRequest, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCompanyRequest request = new GetCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            // Make the request
            Company response = await companyServiceClient.GetCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompany</summary>
        public void GetCompany()
        {
            // Snippet: GetCompany(string, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/companies/[COMPANY]";
            // Make the request
            Company response = companyServiceClient.GetCompany(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompanyAsync</summary>
        public async Task GetCompanyAsync()
        {
            // Snippet: GetCompanyAsync(string, CallSettings)
            // Additional: GetCompanyAsync(string, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/companies/[COMPANY]";
            // Make the request
            Company response = await companyServiceClient.GetCompanyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompany</summary>
        public void GetCompanyResourceNames()
        {
            // Snippet: GetCompany(CompanyName, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            CompanyName name = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]");
            // Make the request
            Company response = companyServiceClient.GetCompany(name);
            // End snippet
        }

        /// <summary>Snippet for GetCompanyAsync</summary>
        public async Task GetCompanyResourceNamesAsync()
        {
            // Snippet: GetCompanyAsync(CompanyName, CallSettings)
            // Additional: GetCompanyAsync(CompanyName, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CompanyName name = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]");
            // Make the request
            Company response = await companyServiceClient.GetCompanyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompany</summary>
        public void UpdateCompanyRequestObject()
        {
            // Snippet: UpdateCompany(UpdateCompanyRequest, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Company response = companyServiceClient.UpdateCompany(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompanyAsync</summary>
        public async Task UpdateCompanyRequestObjectAsync()
        {
            // Snippet: UpdateCompanyAsync(UpdateCompanyRequest, CallSettings)
            // Additional: UpdateCompanyAsync(UpdateCompanyRequest, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Company response = await companyServiceClient.UpdateCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompany</summary>
        public void UpdateCompany()
        {
            // Snippet: UpdateCompany(Company, FieldMask, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            Company company = new Company();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Company response = companyServiceClient.UpdateCompany(company, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompanyAsync</summary>
        public async Task UpdateCompanyAsync()
        {
            // Snippet: UpdateCompanyAsync(Company, FieldMask, CallSettings)
            // Additional: UpdateCompanyAsync(Company, FieldMask, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            Company company = new Company();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Company response = await companyServiceClient.UpdateCompanyAsync(company, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompany</summary>
        public void DeleteCompanyRequestObject()
        {
            // Snippet: DeleteCompany(DeleteCompanyRequest, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            // Make the request
            companyServiceClient.DeleteCompany(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompanyAsync</summary>
        public async Task DeleteCompanyRequestObjectAsync()
        {
            // Snippet: DeleteCompanyAsync(DeleteCompanyRequest, CallSettings)
            // Additional: DeleteCompanyAsync(DeleteCompanyRequest, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                CompanyName = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]"),
            };
            // Make the request
            await companyServiceClient.DeleteCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompany</summary>
        public void DeleteCompany()
        {
            // Snippet: DeleteCompany(string, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/companies/[COMPANY]";
            // Make the request
            companyServiceClient.DeleteCompany(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompanyAsync</summary>
        public async Task DeleteCompanyAsync()
        {
            // Snippet: DeleteCompanyAsync(string, CallSettings)
            // Additional: DeleteCompanyAsync(string, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/companies/[COMPANY]";
            // Make the request
            await companyServiceClient.DeleteCompanyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompany</summary>
        public void DeleteCompanyResourceNames()
        {
            // Snippet: DeleteCompany(CompanyName, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            CompanyName name = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]");
            // Make the request
            companyServiceClient.DeleteCompany(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompanyAsync</summary>
        public async Task DeleteCompanyResourceNamesAsync()
        {
            // Snippet: DeleteCompanyAsync(CompanyName, CallSettings)
            // Additional: DeleteCompanyAsync(CompanyName, CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CompanyName name = CompanyName.FromProjectTenantCompany("[PROJECT]", "[TENANT]", "[COMPANY]");
            // Make the request
            await companyServiceClient.DeleteCompanyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCompanies</summary>
        public void ListCompaniesRequestObject()
        {
            // Snippet: ListCompanies(ListCompaniesRequest, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            ListCompaniesRequest request = new ListCompaniesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                RequireOpenJobs = false,
            };
            // Make the request
            PagedEnumerable<ListCompaniesResponse, Company> response = companyServiceClient.ListCompanies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Company item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompaniesAsync</summary>
        public async Task ListCompaniesRequestObjectAsync()
        {
            // Snippet: ListCompaniesAsync(ListCompaniesRequest, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCompaniesRequest request = new ListCompaniesRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                RequireOpenJobs = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListCompaniesResponse, Company> response = companyServiceClient.ListCompaniesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Company item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompaniesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompanies</summary>
        public void ListCompanies()
        {
            // Snippet: ListCompanies(string, string, int?, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            // Make the request
            PagedEnumerable<ListCompaniesResponse, Company> response = companyServiceClient.ListCompanies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Company item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompaniesAsync</summary>
        public async Task ListCompaniesAsync()
        {
            // Snippet: ListCompaniesAsync(string, string, int?, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            // Make the request
            PagedAsyncEnumerable<ListCompaniesResponse, Company> response = companyServiceClient.ListCompaniesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Company item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompaniesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompanies</summary>
        public void ListCompaniesResourceNames()
        {
            // Snippet: ListCompanies(TenantName, string, int?, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            // Make the request
            PagedEnumerable<ListCompaniesResponse, Company> response = companyServiceClient.ListCompanies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Company item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompaniesAsync</summary>
        public async Task ListCompaniesResourceNamesAsync()
        {
            // Snippet: ListCompaniesAsync(TenantName, string, int?, CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            // Make the request
            PagedAsyncEnumerable<ListCompaniesResponse, Company> response = companyServiceClient.ListCompaniesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Company item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompaniesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
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
