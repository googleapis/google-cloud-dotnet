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
    using Google.Cloud.BinaryAuthorization.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBinauthzManagementServiceV1ClientSnippets
    {
        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyRequestObject()
        {
            // Snippet: GetPolicy(GetPolicyRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            // Make the request
            Policy response = binauthzManagementServiceV1Client.GetPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyRequestObjectAsync()
        {
            // Snippet: GetPolicyAsync(GetPolicyRequest, CallSettings)
            // Additional: GetPolicyAsync(GetPolicyRequest, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProject("[PROJECT]"),
            };
            // Make the request
            Policy response = await binauthzManagementServiceV1Client.GetPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicy()
        {
            // Snippet: GetPolicy(string, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policy";
            // Make the request
            Policy response = binauthzManagementServiceV1Client.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyAsync()
        {
            // Snippet: GetPolicyAsync(string, CallSettings)
            // Additional: GetPolicyAsync(string, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policy";
            // Make the request
            Policy response = await binauthzManagementServiceV1Client.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyResourceNames()
        {
            // Snippet: GetPolicy(PolicyName, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProject("[PROJECT]");
            // Make the request
            Policy response = binauthzManagementServiceV1Client.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyResourceNamesAsync()
        {
            // Snippet: GetPolicyAsync(PolicyName, CallSettings)
            // Additional: GetPolicyAsync(PolicyName, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProject("[PROJECT]");
            // Make the request
            Policy response = await binauthzManagementServiceV1Client.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicyRequestObject()
        {
            // Snippet: UpdatePolicy(UpdatePolicyRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Policy response = binauthzManagementServiceV1Client.UpdatePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyRequestObjectAsync()
        {
            // Snippet: UpdatePolicyAsync(UpdatePolicyRequest, CallSettings)
            // Additional: UpdatePolicyAsync(UpdatePolicyRequest, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await binauthzManagementServiceV1Client.UpdatePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicy()
        {
            // Snippet: UpdatePolicy(Policy, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            Policy policy = new Policy();
            // Make the request
            Policy response = binauthzManagementServiceV1Client.UpdatePolicy(policy);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyAsync()
        {
            // Snippet: UpdatePolicyAsync(Policy, CallSettings)
            // Additional: UpdatePolicyAsync(Policy, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            Policy policy = new Policy();
            // Make the request
            Policy response = await binauthzManagementServiceV1Client.UpdatePolicyAsync(policy);
            // End snippet
        }

        /// <summary>Snippet for CreateAttestor</summary>
        public void CreateAttestorRequestObject()
        {
            // Snippet: CreateAttestor(CreateAttestorRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AttestorId = "",
                Attestor = new Attestor(),
            };
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.CreateAttestor(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAttestorAsync</summary>
        public async Task CreateAttestorRequestObjectAsync()
        {
            // Snippet: CreateAttestorAsync(CreateAttestorRequest, CallSettings)
            // Additional: CreateAttestorAsync(CreateAttestorRequest, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            CreateAttestorRequest request = new CreateAttestorRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AttestorId = "",
                Attestor = new Attestor(),
            };
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.CreateAttestorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAttestor</summary>
        public void CreateAttestor()
        {
            // Snippet: CreateAttestor(string, string, Attestor, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string attestorId = "";
            Attestor attestor = new Attestor();
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.CreateAttestor(parent, attestorId, attestor);
            // End snippet
        }

        /// <summary>Snippet for CreateAttestorAsync</summary>
        public async Task CreateAttestorAsync()
        {
            // Snippet: CreateAttestorAsync(string, string, Attestor, CallSettings)
            // Additional: CreateAttestorAsync(string, string, Attestor, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string attestorId = "";
            Attestor attestor = new Attestor();
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.CreateAttestorAsync(parent, attestorId, attestor);
            // End snippet
        }

        /// <summary>Snippet for CreateAttestor</summary>
        public void CreateAttestorResourceNames()
        {
            // Snippet: CreateAttestor(ProjectName, string, Attestor, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string attestorId = "";
            Attestor attestor = new Attestor();
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.CreateAttestor(parent, attestorId, attestor);
            // End snippet
        }

        /// <summary>Snippet for CreateAttestorAsync</summary>
        public async Task CreateAttestorResourceNamesAsync()
        {
            // Snippet: CreateAttestorAsync(ProjectName, string, Attestor, CallSettings)
            // Additional: CreateAttestorAsync(ProjectName, string, Attestor, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string attestorId = "";
            Attestor attestor = new Attestor();
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.CreateAttestorAsync(parent, attestorId, attestor);
            // End snippet
        }

        /// <summary>Snippet for GetAttestor</summary>
        public void GetAttestorRequestObject()
        {
            // Snippet: GetAttestor(GetAttestorRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.GetAttestor(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttestorAsync</summary>
        public async Task GetAttestorRequestObjectAsync()
        {
            // Snippet: GetAttestorAsync(GetAttestorRequest, CallSettings)
            // Additional: GetAttestorAsync(GetAttestorRequest, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            GetAttestorRequest request = new GetAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.GetAttestorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttestor</summary>
        public void GetAttestor()
        {
            // Snippet: GetAttestor(string, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/attestors/[ATTESTOR]";
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.GetAttestor(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttestorAsync</summary>
        public async Task GetAttestorAsync()
        {
            // Snippet: GetAttestorAsync(string, CallSettings)
            // Additional: GetAttestorAsync(string, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/attestors/[ATTESTOR]";
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.GetAttestorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttestor</summary>
        public void GetAttestorResourceNames()
        {
            // Snippet: GetAttestor(AttestorName, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            AttestorName name = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]");
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.GetAttestor(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttestorAsync</summary>
        public async Task GetAttestorResourceNamesAsync()
        {
            // Snippet: GetAttestorAsync(AttestorName, CallSettings)
            // Additional: GetAttestorAsync(AttestorName, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            AttestorName name = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]");
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.GetAttestorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttestor</summary>
        public void UpdateAttestorRequestObject()
        {
            // Snippet: UpdateAttestor(UpdateAttestorRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            UpdateAttestorRequest request = new UpdateAttestorRequest
            {
                Attestor = new Attestor(),
            };
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.UpdateAttestor(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttestorAsync</summary>
        public async Task UpdateAttestorRequestObjectAsync()
        {
            // Snippet: UpdateAttestorAsync(UpdateAttestorRequest, CallSettings)
            // Additional: UpdateAttestorAsync(UpdateAttestorRequest, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            UpdateAttestorRequest request = new UpdateAttestorRequest
            {
                Attestor = new Attestor(),
            };
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.UpdateAttestorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttestor</summary>
        public void UpdateAttestor()
        {
            // Snippet: UpdateAttestor(Attestor, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            Attestor attestor = new Attestor();
            // Make the request
            Attestor response = binauthzManagementServiceV1Client.UpdateAttestor(attestor);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttestorAsync</summary>
        public async Task UpdateAttestorAsync()
        {
            // Snippet: UpdateAttestorAsync(Attestor, CallSettings)
            // Additional: UpdateAttestorAsync(Attestor, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            Attestor attestor = new Attestor();
            // Make the request
            Attestor response = await binauthzManagementServiceV1Client.UpdateAttestorAsync(attestor);
            // End snippet
        }

        /// <summary>Snippet for ListAttestors</summary>
        public void ListAttestorsRequestObject()
        {
            // Snippet: ListAttestors(ListAttestorsRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            ListAttestorsRequest request = new ListAttestorsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListAttestorsResponse, Attestor> response = binauthzManagementServiceV1Client.ListAttestors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Attestor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttestorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attestor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attestor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attestor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttestorsAsync</summary>
        public async Task ListAttestorsRequestObjectAsync()
        {
            // Snippet: ListAttestorsAsync(ListAttestorsRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            ListAttestorsRequest request = new ListAttestorsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAttestorsResponse, Attestor> response = binauthzManagementServiceV1Client.ListAttestorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Attestor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttestorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attestor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attestor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attestor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttestors</summary>
        public void ListAttestors()
        {
            // Snippet: ListAttestors(string, string, int?, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListAttestorsResponse, Attestor> response = binauthzManagementServiceV1Client.ListAttestors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Attestor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttestorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attestor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attestor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attestor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttestorsAsync</summary>
        public async Task ListAttestorsAsync()
        {
            // Snippet: ListAttestorsAsync(string, string, int?, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListAttestorsResponse, Attestor> response = binauthzManagementServiceV1Client.ListAttestorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Attestor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttestorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attestor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attestor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attestor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttestors</summary>
        public void ListAttestorsResourceNames()
        {
            // Snippet: ListAttestors(ProjectName, string, int?, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListAttestorsResponse, Attestor> response = binauthzManagementServiceV1Client.ListAttestors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Attestor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttestorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attestor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attestor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attestor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttestorsAsync</summary>
        public async Task ListAttestorsResourceNamesAsync()
        {
            // Snippet: ListAttestorsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListAttestorsResponse, Attestor> response = binauthzManagementServiceV1Client.ListAttestorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Attestor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttestorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Attestor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Attestor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Attestor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAttestor</summary>
        public void DeleteAttestorRequestObject()
        {
            // Snippet: DeleteAttestor(DeleteAttestorRequest, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            // Make the request
            binauthzManagementServiceV1Client.DeleteAttestor(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttestorAsync</summary>
        public async Task DeleteAttestorRequestObjectAsync()
        {
            // Snippet: DeleteAttestorAsync(DeleteAttestorRequest, CallSettings)
            // Additional: DeleteAttestorAsync(DeleteAttestorRequest, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            DeleteAttestorRequest request = new DeleteAttestorRequest
            {
                AttestorName = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]"),
            };
            // Make the request
            await binauthzManagementServiceV1Client.DeleteAttestorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttestor</summary>
        public void DeleteAttestor()
        {
            // Snippet: DeleteAttestor(string, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/attestors/[ATTESTOR]";
            // Make the request
            binauthzManagementServiceV1Client.DeleteAttestor(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttestorAsync</summary>
        public async Task DeleteAttestorAsync()
        {
            // Snippet: DeleteAttestorAsync(string, CallSettings)
            // Additional: DeleteAttestorAsync(string, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/attestors/[ATTESTOR]";
            // Make the request
            await binauthzManagementServiceV1Client.DeleteAttestorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttestor</summary>
        public void DeleteAttestorResourceNames()
        {
            // Snippet: DeleteAttestor(AttestorName, CallSettings)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = BinauthzManagementServiceV1Client.Create();
            // Initialize request argument(s)
            AttestorName name = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]");
            // Make the request
            binauthzManagementServiceV1Client.DeleteAttestor(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAttestorAsync</summary>
        public async Task DeleteAttestorResourceNamesAsync()
        {
            // Snippet: DeleteAttestorAsync(AttestorName, CallSettings)
            // Additional: DeleteAttestorAsync(AttestorName, CancellationToken)
            // Create client
            BinauthzManagementServiceV1Client binauthzManagementServiceV1Client = await BinauthzManagementServiceV1Client.CreateAsync();
            // Initialize request argument(s)
            AttestorName name = AttestorName.FromProjectAttestor("[PROJECT]", "[ATTESTOR]");
            // Make the request
            await binauthzManagementServiceV1Client.DeleteAttestorAsync(name);
            // End snippet
        }
    }
}
