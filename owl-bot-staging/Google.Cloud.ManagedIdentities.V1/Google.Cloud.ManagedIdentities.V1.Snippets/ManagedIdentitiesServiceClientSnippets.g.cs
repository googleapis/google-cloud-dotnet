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
    using Google.Cloud.ManagedIdentities.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedManagedIdentitiesServiceClientSnippets
    {
        /// <summary>Snippet for CreateMicrosoftAdDomain</summary>
        public void CreateMicrosoftAdDomainRequestObject()
        {
            // Snippet: CreateMicrosoftAdDomain(CreateMicrosoftAdDomainRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            CreateMicrosoftAdDomainRequest request = new CreateMicrosoftAdDomainRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DomainName = "",
                Domain = new Domain(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.CreateMicrosoftAdDomain(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceCreateMicrosoftAdDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMicrosoftAdDomainAsync</summary>
        public async Task CreateMicrosoftAdDomainRequestObjectAsync()
        {
            // Snippet: CreateMicrosoftAdDomainAsync(CreateMicrosoftAdDomainRequest, CallSettings)
            // Additional: CreateMicrosoftAdDomainAsync(CreateMicrosoftAdDomainRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMicrosoftAdDomainRequest request = new CreateMicrosoftAdDomainRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DomainName = "",
                Domain = new Domain(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.CreateMicrosoftAdDomainAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceCreateMicrosoftAdDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMicrosoftAdDomain</summary>
        public void CreateMicrosoftAdDomain()
        {
            // Snippet: CreateMicrosoftAdDomain(string, string, Domain, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            Domain domain = new Domain();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.CreateMicrosoftAdDomain(parent, domainName, domain);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceCreateMicrosoftAdDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMicrosoftAdDomainAsync</summary>
        public async Task CreateMicrosoftAdDomainAsync()
        {
            // Snippet: CreateMicrosoftAdDomainAsync(string, string, Domain, CallSettings)
            // Additional: CreateMicrosoftAdDomainAsync(string, string, Domain, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            Domain domain = new Domain();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.CreateMicrosoftAdDomainAsync(parent, domainName, domain);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceCreateMicrosoftAdDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMicrosoftAdDomain</summary>
        public void CreateMicrosoftAdDomainResourceNames()
        {
            // Snippet: CreateMicrosoftAdDomain(LocationName, string, Domain, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string domainName = "";
            Domain domain = new Domain();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.CreateMicrosoftAdDomain(parent, domainName, domain);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceCreateMicrosoftAdDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMicrosoftAdDomainAsync</summary>
        public async Task CreateMicrosoftAdDomainResourceNamesAsync()
        {
            // Snippet: CreateMicrosoftAdDomainAsync(LocationName, string, Domain, CallSettings)
            // Additional: CreateMicrosoftAdDomainAsync(LocationName, string, Domain, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string domainName = "";
            Domain domain = new Domain();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.CreateMicrosoftAdDomainAsync(parent, domainName, domain);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceCreateMicrosoftAdDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetAdminPassword</summary>
        public void ResetAdminPasswordRequestObject()
        {
            // Snippet: ResetAdminPassword(ResetAdminPasswordRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            ResetAdminPasswordResponse response = managedIdentitiesServiceClient.ResetAdminPassword(request);
            // End snippet
        }

        /// <summary>Snippet for ResetAdminPasswordAsync</summary>
        public async Task ResetAdminPasswordRequestObjectAsync()
        {
            // Snippet: ResetAdminPasswordAsync(ResetAdminPasswordRequest, CallSettings)
            // Additional: ResetAdminPasswordAsync(ResetAdminPasswordRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetAdminPasswordRequest request = new ResetAdminPasswordRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            ResetAdminPasswordResponse response = await managedIdentitiesServiceClient.ResetAdminPasswordAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetAdminPassword</summary>
        public void ResetAdminPassword()
        {
            // Snippet: ResetAdminPassword(string, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            ResetAdminPasswordResponse response = managedIdentitiesServiceClient.ResetAdminPassword(name);
            // End snippet
        }

        /// <summary>Snippet for ResetAdminPasswordAsync</summary>
        public async Task ResetAdminPasswordAsync()
        {
            // Snippet: ResetAdminPasswordAsync(string, CallSettings)
            // Additional: ResetAdminPasswordAsync(string, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            ResetAdminPasswordResponse response = await managedIdentitiesServiceClient.ResetAdminPasswordAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResetAdminPassword</summary>
        public void ResetAdminPasswordResourceNames()
        {
            // Snippet: ResetAdminPassword(DomainName, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            ResetAdminPasswordResponse response = managedIdentitiesServiceClient.ResetAdminPassword(name);
            // End snippet
        }

        /// <summary>Snippet for ResetAdminPasswordAsync</summary>
        public async Task ResetAdminPasswordResourceNamesAsync()
        {
            // Snippet: ResetAdminPasswordAsync(DomainName, CallSettings)
            // Additional: ResetAdminPasswordAsync(DomainName, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            ResetAdminPasswordResponse response = await managedIdentitiesServiceClient.ResetAdminPasswordAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDomains</summary>
        public void ListDomainsRequestObject()
        {
            // Snippet: ListDomains(ListDomainsRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            ListDomainsRequest request = new ListDomainsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDomainsResponse, Domain> response = managedIdentitiesServiceClient.ListDomains(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainsAsync</summary>
        public async Task ListDomainsRequestObjectAsync()
        {
            // Snippet: ListDomainsAsync(ListDomainsRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDomainsRequest request = new ListDomainsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDomainsResponse, Domain> response = managedIdentitiesServiceClient.ListDomainsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Domain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomains</summary>
        public void ListDomains()
        {
            // Snippet: ListDomains(string, string, int?, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDomainsResponse, Domain> response = managedIdentitiesServiceClient.ListDomains(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainsAsync</summary>
        public async Task ListDomainsAsync()
        {
            // Snippet: ListDomainsAsync(string, string, int?, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDomainsResponse, Domain> response = managedIdentitiesServiceClient.ListDomainsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Domain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomains</summary>
        public void ListDomainsResourceNames()
        {
            // Snippet: ListDomains(LocationName, string, int?, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDomainsResponse, Domain> response = managedIdentitiesServiceClient.ListDomains(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Domain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDomainsAsync</summary>
        public async Task ListDomainsResourceNamesAsync()
        {
            // Snippet: ListDomainsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDomainsResponse, Domain> response = managedIdentitiesServiceClient.ListDomainsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Domain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Domain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Domain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Domain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDomain</summary>
        public void GetDomainRequestObject()
        {
            // Snippet: GetDomain(GetDomainRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Domain response = managedIdentitiesServiceClient.GetDomain(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomainAsync</summary>
        public async Task GetDomainRequestObjectAsync()
        {
            // Snippet: GetDomainAsync(GetDomainRequest, CallSettings)
            // Additional: GetDomainAsync(GetDomainRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDomainRequest request = new GetDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Domain response = await managedIdentitiesServiceClient.GetDomainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDomain</summary>
        public void GetDomain()
        {
            // Snippet: GetDomain(string, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            Domain response = managedIdentitiesServiceClient.GetDomain(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomainAsync</summary>
        public async Task GetDomainAsync()
        {
            // Snippet: GetDomainAsync(string, CallSettings)
            // Additional: GetDomainAsync(string, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            Domain response = await managedIdentitiesServiceClient.GetDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomain</summary>
        public void GetDomainResourceNames()
        {
            // Snippet: GetDomain(DomainName, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Domain response = managedIdentitiesServiceClient.GetDomain(name);
            // End snippet
        }

        /// <summary>Snippet for GetDomainAsync</summary>
        public async Task GetDomainResourceNamesAsync()
        {
            // Snippet: GetDomainAsync(DomainName, CallSettings)
            // Additional: GetDomainAsync(DomainName, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Domain response = await managedIdentitiesServiceClient.GetDomainAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDomain</summary>
        public void UpdateDomainRequestObject()
        {
            // Snippet: UpdateDomain(UpdateDomainRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            UpdateDomainRequest request = new UpdateDomainRequest
            {
                UpdateMask = new FieldMask(),
                Domain = new Domain(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.UpdateDomain(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceUpdateDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDomainAsync</summary>
        public async Task UpdateDomainRequestObjectAsync()
        {
            // Snippet: UpdateDomainAsync(UpdateDomainRequest, CallSettings)
            // Additional: UpdateDomainAsync(UpdateDomainRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDomainRequest request = new UpdateDomainRequest
            {
                UpdateMask = new FieldMask(),
                Domain = new Domain(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.UpdateDomainAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceUpdateDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDomain</summary>
        public void UpdateDomain()
        {
            // Snippet: UpdateDomain(Domain, FieldMask, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            Domain domain = new Domain();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.UpdateDomain(domain, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceUpdateDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDomainAsync</summary>
        public async Task UpdateDomainAsync()
        {
            // Snippet: UpdateDomainAsync(Domain, FieldMask, CallSettings)
            // Additional: UpdateDomainAsync(Domain, FieldMask, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            Domain domain = new Domain();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.UpdateDomainAsync(domain, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceUpdateDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomain</summary>
        public void DeleteDomainRequestObject()
        {
            // Snippet: DeleteDomain(DeleteDomainRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DeleteDomainRequest request = new DeleteDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Operation<Empty, OpMetadata> response = managedIdentitiesServiceClient.DeleteDomain(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceDeleteDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomainAsync</summary>
        public async Task DeleteDomainRequestObjectAsync()
        {
            // Snippet: DeleteDomainAsync(DeleteDomainRequest, CallSettings)
            // Additional: DeleteDomainAsync(DeleteDomainRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDomainRequest request = new DeleteDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Operation<Empty, OpMetadata> response = await managedIdentitiesServiceClient.DeleteDomainAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDeleteDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomain</summary>
        public void DeleteDomain()
        {
            // Snippet: DeleteDomain(string, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            Operation<Empty, OpMetadata> response = managedIdentitiesServiceClient.DeleteDomain(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceDeleteDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomainAsync</summary>
        public async Task DeleteDomainAsync()
        {
            // Snippet: DeleteDomainAsync(string, CallSettings)
            // Additional: DeleteDomainAsync(string, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            // Make the request
            Operation<Empty, OpMetadata> response = await managedIdentitiesServiceClient.DeleteDomainAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDeleteDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomain</summary>
        public void DeleteDomainResourceNames()
        {
            // Snippet: DeleteDomain(DomainName, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Operation<Empty, OpMetadata> response = managedIdentitiesServiceClient.DeleteDomain(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceDeleteDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDomainAsync</summary>
        public async Task DeleteDomainResourceNamesAsync()
        {
            // Snippet: DeleteDomainAsync(DomainName, CallSettings)
            // Additional: DeleteDomainAsync(DomainName, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            // Make the request
            Operation<Empty, OpMetadata> response = await managedIdentitiesServiceClient.DeleteDomainAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDeleteDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachTrust</summary>
        public void AttachTrustRequestObject()
        {
            // Snippet: AttachTrust(AttachTrustRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            AttachTrustRequest request = new AttachTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Trust = new Trust(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.AttachTrust(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceAttachTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachTrustAsync</summary>
        public async Task AttachTrustRequestObjectAsync()
        {
            // Snippet: AttachTrustAsync(AttachTrustRequest, CallSettings)
            // Additional: AttachTrustAsync(AttachTrustRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AttachTrustRequest request = new AttachTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Trust = new Trust(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.AttachTrustAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceAttachTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachTrust</summary>
        public void AttachTrust()
        {
            // Snippet: AttachTrust(string, Trust, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.AttachTrust(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceAttachTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachTrustAsync</summary>
        public async Task AttachTrustAsync()
        {
            // Snippet: AttachTrustAsync(string, Trust, CallSettings)
            // Additional: AttachTrustAsync(string, Trust, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.AttachTrustAsync(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceAttachTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachTrust</summary>
        public void AttachTrustResourceNames()
        {
            // Snippet: AttachTrust(DomainName, Trust, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.AttachTrust(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceAttachTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachTrustAsync</summary>
        public async Task AttachTrustResourceNamesAsync()
        {
            // Snippet: AttachTrustAsync(DomainName, Trust, CallSettings)
            // Additional: AttachTrustAsync(DomainName, Trust, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.AttachTrustAsync(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceAttachTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconfigureTrust</summary>
        public void ReconfigureTrustRequestObject()
        {
            // Snippet: ReconfigureTrust(ReconfigureTrustRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            ReconfigureTrustRequest request = new ReconfigureTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                TargetDomainName = "",
                TargetDnsIpAddresses = { "", },
            };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.ReconfigureTrust(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceReconfigureTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconfigureTrustAsync</summary>
        public async Task ReconfigureTrustRequestObjectAsync()
        {
            // Snippet: ReconfigureTrustAsync(ReconfigureTrustRequest, CallSettings)
            // Additional: ReconfigureTrustAsync(ReconfigureTrustRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReconfigureTrustRequest request = new ReconfigureTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                TargetDomainName = "",
                TargetDnsIpAddresses = { "", },
            };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.ReconfigureTrustAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceReconfigureTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconfigureTrust</summary>
        public void ReconfigureTrust()
        {
            // Snippet: ReconfigureTrust(string, string, IEnumerable<string>, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            string targetDomainName = "";
            IEnumerable<string> targetDnsIpAddresses = new string[] { "", };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.ReconfigureTrust(name, targetDomainName, targetDnsIpAddresses);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceReconfigureTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconfigureTrustAsync</summary>
        public async Task ReconfigureTrustAsync()
        {
            // Snippet: ReconfigureTrustAsync(string, string, IEnumerable<string>, CallSettings)
            // Additional: ReconfigureTrustAsync(string, string, IEnumerable<string>, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            string targetDomainName = "";
            IEnumerable<string> targetDnsIpAddresses = new string[] { "", };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.ReconfigureTrustAsync(name, targetDomainName, targetDnsIpAddresses);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceReconfigureTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconfigureTrust</summary>
        public void ReconfigureTrustResourceNames()
        {
            // Snippet: ReconfigureTrust(DomainName, string, IEnumerable<string>, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            string targetDomainName = "";
            IEnumerable<string> targetDnsIpAddresses = new string[] { "", };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.ReconfigureTrust(name, targetDomainName, targetDnsIpAddresses);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceReconfigureTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconfigureTrustAsync</summary>
        public async Task ReconfigureTrustResourceNamesAsync()
        {
            // Snippet: ReconfigureTrustAsync(DomainName, string, IEnumerable<string>, CallSettings)
            // Additional: ReconfigureTrustAsync(DomainName, string, IEnumerable<string>, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            string targetDomainName = "";
            IEnumerable<string> targetDnsIpAddresses = new string[] { "", };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.ReconfigureTrustAsync(name, targetDomainName, targetDnsIpAddresses);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceReconfigureTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachTrust</summary>
        public void DetachTrustRequestObject()
        {
            // Snippet: DetachTrust(DetachTrustRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DetachTrustRequest request = new DetachTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Trust = new Trust(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.DetachTrust(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceDetachTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachTrustAsync</summary>
        public async Task DetachTrustRequestObjectAsync()
        {
            // Snippet: DetachTrustAsync(DetachTrustRequest, CallSettings)
            // Additional: DetachTrustAsync(DetachTrustRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DetachTrustRequest request = new DetachTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Trust = new Trust(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.DetachTrustAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDetachTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachTrust</summary>
        public void DetachTrust()
        {
            // Snippet: DetachTrust(string, Trust, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.DetachTrust(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceDetachTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachTrustAsync</summary>
        public async Task DetachTrustAsync()
        {
            // Snippet: DetachTrustAsync(string, Trust, CallSettings)
            // Additional: DetachTrustAsync(string, Trust, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.DetachTrustAsync(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDetachTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachTrust</summary>
        public void DetachTrustResourceNames()
        {
            // Snippet: DetachTrust(DomainName, Trust, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.DetachTrust(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceDetachTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachTrustAsync</summary>
        public async Task DetachTrustResourceNamesAsync()
        {
            // Snippet: DetachTrustAsync(DomainName, Trust, CallSettings)
            // Additional: DetachTrustAsync(DomainName, Trust, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.DetachTrustAsync(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDetachTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateTrust</summary>
        public void ValidateTrustRequestObject()
        {
            // Snippet: ValidateTrust(ValidateTrustRequest, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            ValidateTrustRequest request = new ValidateTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Trust = new Trust(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.ValidateTrust(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceValidateTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateTrustAsync</summary>
        public async Task ValidateTrustRequestObjectAsync()
        {
            // Snippet: ValidateTrustAsync(ValidateTrustRequest, CallSettings)
            // Additional: ValidateTrustAsync(ValidateTrustRequest, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ValidateTrustRequest request = new ValidateTrustRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
                Trust = new Trust(),
            };
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.ValidateTrustAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceValidateTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateTrust</summary>
        public void ValidateTrust()
        {
            // Snippet: ValidateTrust(string, Trust, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.ValidateTrust(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceValidateTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateTrustAsync</summary>
        public async Task ValidateTrustAsync()
        {
            // Snippet: ValidateTrustAsync(string, Trust, CallSettings)
            // Additional: ValidateTrustAsync(string, Trust, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/domains/[DOMAIN]";
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.ValidateTrustAsync(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceValidateTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateTrust</summary>
        public void ValidateTrustResourceNames()
        {
            // Snippet: ValidateTrust(DomainName, Trust, CallSettings)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = ManagedIdentitiesServiceClient.Create();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = managedIdentitiesServiceClient.ValidateTrust(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = managedIdentitiesServiceClient.PollOnceValidateTrust(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ValidateTrustAsync</summary>
        public async Task ValidateTrustResourceNamesAsync()
        {
            // Snippet: ValidateTrustAsync(DomainName, Trust, CallSettings)
            // Additional: ValidateTrustAsync(DomainName, Trust, CancellationToken)
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DomainName name = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]");
            Trust trust = new Trust();
            // Make the request
            Operation<Domain, OpMetadata> response = await managedIdentitiesServiceClient.ValidateTrustAsync(name, trust);

            // Poll until the returned long-running operation is complete
            Operation<Domain, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Domain result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Domain, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceValidateTrustAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Domain retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
