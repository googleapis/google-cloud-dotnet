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
    using Google.Cloud.Support.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCaseServiceClientSnippets
    {
        /// <summary>Snippet for GetCase</summary>
        public void GetCaseRequestObject()
        {
            // Snippet: GetCase(GetCaseRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            GetCaseRequest request = new GetCaseRequest
            {
                CaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            Case response = caseServiceClient.GetCase(request);
            // End snippet
        }

        /// <summary>Snippet for GetCaseAsync</summary>
        public async Task GetCaseRequestObjectAsync()
        {
            // Snippet: GetCaseAsync(GetCaseRequest, CallSettings)
            // Additional: GetCaseAsync(GetCaseRequest, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCaseRequest request = new GetCaseRequest
            {
                CaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            Case response = await caseServiceClient.GetCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCase</summary>
        public void GetCase()
        {
            // Snippet: GetCase(string, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/cases/[CASE]";
            // Make the request
            Case response = caseServiceClient.GetCase(name);
            // End snippet
        }

        /// <summary>Snippet for GetCaseAsync</summary>
        public async Task GetCaseAsync()
        {
            // Snippet: GetCaseAsync(string, CallSettings)
            // Additional: GetCaseAsync(string, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/cases/[CASE]";
            // Make the request
            Case response = await caseServiceClient.GetCaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCase</summary>
        public void GetCaseResourceNames()
        {
            // Snippet: GetCase(CaseName, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            CaseName name = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            // Make the request
            Case response = caseServiceClient.GetCase(name);
            // End snippet
        }

        /// <summary>Snippet for GetCaseAsync</summary>
        public async Task GetCaseResourceNamesAsync()
        {
            // Snippet: GetCaseAsync(CaseName, CallSettings)
            // Additional: GetCaseAsync(CaseName, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaseName name = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]");
            // Make the request
            Case response = await caseServiceClient.GetCaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCases</summary>
        public void ListCasesRequestObject()
        {
            // Snippet: ListCases(ListCasesRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            ListCasesRequest request = new ListCasesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Case item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCasesAsync</summary>
        public async Task ListCasesRequestObjectAsync()
        {
            // Snippet: ListCasesAsync(ListCasesRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCasesRequest request = new ListCasesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Case item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCases</summary>
        public void ListCases()
        {
            // Snippet: ListCases(string, string, int?, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Case item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCasesAsync</summary>
        public async Task ListCasesAsync()
        {
            // Snippet: ListCasesAsync(string, string, int?, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Case item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCases</summary>
        public void ListCasesResourceNames1()
        {
            // Snippet: ListCases(OrganizationName, string, int?, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Case item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCasesAsync</summary>
        public async Task ListCasesResourceNames1Async()
        {
            // Snippet: ListCasesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Case item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCases</summary>
        public void ListCasesResourceNames2()
        {
            // Snippet: ListCases(ProjectName, string, int?, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Case item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCasesAsync</summary>
        public async Task ListCasesResourceNames2Async()
        {
            // Snippet: ListCasesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListCasesResponse, Case> response = caseServiceClient.ListCasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Case item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCases</summary>
        public void SearchCasesRequestObject()
        {
            // Snippet: SearchCases(SearchCasesRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            SearchCasesRequest request = new SearchCasesRequest
            {
                Query = "",
                Parent = "",
            };
            // Make the request
            PagedEnumerable<SearchCasesResponse, Case> response = caseServiceClient.SearchCases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Case item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCasesAsync</summary>
        public async Task SearchCasesRequestObjectAsync()
        {
            // Snippet: SearchCasesAsync(SearchCasesRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchCasesRequest request = new SearchCasesRequest
            {
                Query = "",
                Parent = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchCasesResponse, Case> response = caseServiceClient.SearchCasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Case item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Case item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Case> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Case item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCase</summary>
        public void CreateCaseRequestObject()
        {
            // Snippet: CreateCase(CreateCaseRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            CreateCaseRequest request = new CreateCaseRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Case = new Case(),
            };
            // Make the request
            Case response = caseServiceClient.CreateCase(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCaseAsync</summary>
        public async Task CreateCaseRequestObjectAsync()
        {
            // Snippet: CreateCaseAsync(CreateCaseRequest, CallSettings)
            // Additional: CreateCaseAsync(CreateCaseRequest, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCaseRequest request = new CreateCaseRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Case = new Case(),
            };
            // Make the request
            Case response = await caseServiceClient.CreateCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCase</summary>
        public void CreateCase()
        {
            // Snippet: CreateCase(string, Case, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            Case @case = new Case();
            // Make the request
            Case response = caseServiceClient.CreateCase(parent, @case);
            // End snippet
        }

        /// <summary>Snippet for CreateCaseAsync</summary>
        public async Task CreateCaseAsync()
        {
            // Snippet: CreateCaseAsync(string, Case, CallSettings)
            // Additional: CreateCaseAsync(string, Case, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            Case @case = new Case();
            // Make the request
            Case response = await caseServiceClient.CreateCaseAsync(parent, @case);
            // End snippet
        }

        /// <summary>Snippet for CreateCase</summary>
        public void CreateCaseResourceNames1()
        {
            // Snippet: CreateCase(OrganizationName, Case, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Case @case = new Case();
            // Make the request
            Case response = caseServiceClient.CreateCase(parent, @case);
            // End snippet
        }

        /// <summary>Snippet for CreateCaseAsync</summary>
        public async Task CreateCaseResourceNames1Async()
        {
            // Snippet: CreateCaseAsync(OrganizationName, Case, CallSettings)
            // Additional: CreateCaseAsync(OrganizationName, Case, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Case @case = new Case();
            // Make the request
            Case response = await caseServiceClient.CreateCaseAsync(parent, @case);
            // End snippet
        }

        /// <summary>Snippet for CreateCase</summary>
        public void CreateCaseResourceNames2()
        {
            // Snippet: CreateCase(ProjectName, Case, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Case @case = new Case();
            // Make the request
            Case response = caseServiceClient.CreateCase(parent, @case);
            // End snippet
        }

        /// <summary>Snippet for CreateCaseAsync</summary>
        public async Task CreateCaseResourceNames2Async()
        {
            // Snippet: CreateCaseAsync(ProjectName, Case, CallSettings)
            // Additional: CreateCaseAsync(ProjectName, Case, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Case @case = new Case();
            // Make the request
            Case response = await caseServiceClient.CreateCaseAsync(parent, @case);
            // End snippet
        }

        /// <summary>Snippet for UpdateCase</summary>
        public void UpdateCaseRequestObject()
        {
            // Snippet: UpdateCase(UpdateCaseRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            UpdateCaseRequest request = new UpdateCaseRequest
            {
                Case = new Case(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Case response = caseServiceClient.UpdateCase(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCaseAsync</summary>
        public async Task UpdateCaseRequestObjectAsync()
        {
            // Snippet: UpdateCaseAsync(UpdateCaseRequest, CallSettings)
            // Additional: UpdateCaseAsync(UpdateCaseRequest, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCaseRequest request = new UpdateCaseRequest
            {
                Case = new Case(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Case response = await caseServiceClient.UpdateCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCase</summary>
        public void UpdateCase()
        {
            // Snippet: UpdateCase(Case, FieldMask, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            Case @case = new Case();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Case response = caseServiceClient.UpdateCase(@case, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCaseAsync</summary>
        public async Task UpdateCaseAsync()
        {
            // Snippet: UpdateCaseAsync(Case, FieldMask, CallSettings)
            // Additional: UpdateCaseAsync(Case, FieldMask, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            Case @case = new Case();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Case response = await caseServiceClient.UpdateCaseAsync(@case, updateMask);
            // End snippet
        }

        /// <summary>Snippet for EscalateCase</summary>
        public void EscalateCaseRequestObject()
        {
            // Snippet: EscalateCase(EscalateCaseRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            EscalateCaseRequest request = new EscalateCaseRequest
            {
                CaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
                Escalation = new Escalation(),
            };
            // Make the request
            Case response = caseServiceClient.EscalateCase(request);
            // End snippet
        }

        /// <summary>Snippet for EscalateCaseAsync</summary>
        public async Task EscalateCaseRequestObjectAsync()
        {
            // Snippet: EscalateCaseAsync(EscalateCaseRequest, CallSettings)
            // Additional: EscalateCaseAsync(EscalateCaseRequest, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            EscalateCaseRequest request = new EscalateCaseRequest
            {
                CaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
                Escalation = new Escalation(),
            };
            // Make the request
            Case response = await caseServiceClient.EscalateCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CloseCase</summary>
        public void CloseCaseRequestObject()
        {
            // Snippet: CloseCase(CloseCaseRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            CloseCaseRequest request = new CloseCaseRequest
            {
                CaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            Case response = caseServiceClient.CloseCase(request);
            // End snippet
        }

        /// <summary>Snippet for CloseCaseAsync</summary>
        public async Task CloseCaseRequestObjectAsync()
        {
            // Snippet: CloseCaseAsync(CloseCaseRequest, CallSettings)
            // Additional: CloseCaseAsync(CloseCaseRequest, CancellationToken)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CloseCaseRequest request = new CloseCaseRequest
            {
                CaseName = CaseName.FromOrganizationCase("[ORGANIZATION]", "[CASE]"),
            };
            // Make the request
            Case response = await caseServiceClient.CloseCaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchCaseClassifications</summary>
        public void SearchCaseClassificationsRequestObject()
        {
            // Snippet: SearchCaseClassifications(SearchCaseClassificationsRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = CaseServiceClient.Create();
            // Initialize request argument(s)
            SearchCaseClassificationsRequest request = new SearchCaseClassificationsRequest { Query = "", };
            // Make the request
            PagedEnumerable<SearchCaseClassificationsResponse, CaseClassification> response = caseServiceClient.SearchCaseClassifications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CaseClassification item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCaseClassificationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaseClassification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaseClassification> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaseClassification item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCaseClassificationsAsync</summary>
        public async Task SearchCaseClassificationsRequestObjectAsync()
        {
            // Snippet: SearchCaseClassificationsAsync(SearchCaseClassificationsRequest, CallSettings)
            // Create client
            CaseServiceClient caseServiceClient = await CaseServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchCaseClassificationsRequest request = new SearchCaseClassificationsRequest { Query = "", };
            // Make the request
            PagedAsyncEnumerable<SearchCaseClassificationsResponse, CaseClassification> response = caseServiceClient.SearchCaseClassificationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CaseClassification item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCaseClassificationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaseClassification item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaseClassification> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaseClassification item in singlePage)
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
