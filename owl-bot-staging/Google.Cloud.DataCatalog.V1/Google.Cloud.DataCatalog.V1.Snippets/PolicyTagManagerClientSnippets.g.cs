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
    using Google.Cloud.DataCatalog.V1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPolicyTagManagerClientSnippets
    {
        /// <summary>Snippet for CreateTaxonomy</summary>
        public void CreateTaxonomyRequestObject()
        {
            // Snippet: CreateTaxonomy(CreateTaxonomyRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            // Make the request
            Taxonomy response = policyTagManagerClient.CreateTaxonomy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaxonomyAsync</summary>
        public async Task CreateTaxonomyRequestObjectAsync()
        {
            // Snippet: CreateTaxonomyAsync(CreateTaxonomyRequest, CallSettings)
            // Additional: CreateTaxonomyAsync(CreateTaxonomyRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateTaxonomyRequest request = new CreateTaxonomyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Taxonomy = new Taxonomy(),
            };
            // Make the request
            Taxonomy response = await policyTagManagerClient.CreateTaxonomyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTaxonomy</summary>
        public void CreateTaxonomy()
        {
            // Snippet: CreateTaxonomy(string, Taxonomy, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Taxonomy taxonomy = new Taxonomy();
            // Make the request
            Taxonomy response = policyTagManagerClient.CreateTaxonomy(parent, taxonomy);
            // End snippet
        }

        /// <summary>Snippet for CreateTaxonomyAsync</summary>
        public async Task CreateTaxonomyAsync()
        {
            // Snippet: CreateTaxonomyAsync(string, Taxonomy, CallSettings)
            // Additional: CreateTaxonomyAsync(string, Taxonomy, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Taxonomy taxonomy = new Taxonomy();
            // Make the request
            Taxonomy response = await policyTagManagerClient.CreateTaxonomyAsync(parent, taxonomy);
            // End snippet
        }

        /// <summary>Snippet for CreateTaxonomy</summary>
        public void CreateTaxonomyResourceNames()
        {
            // Snippet: CreateTaxonomy(LocationName, Taxonomy, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Taxonomy taxonomy = new Taxonomy();
            // Make the request
            Taxonomy response = policyTagManagerClient.CreateTaxonomy(parent, taxonomy);
            // End snippet
        }

        /// <summary>Snippet for CreateTaxonomyAsync</summary>
        public async Task CreateTaxonomyResourceNamesAsync()
        {
            // Snippet: CreateTaxonomyAsync(LocationName, Taxonomy, CallSettings)
            // Additional: CreateTaxonomyAsync(LocationName, Taxonomy, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Taxonomy taxonomy = new Taxonomy();
            // Make the request
            Taxonomy response = await policyTagManagerClient.CreateTaxonomyAsync(parent, taxonomy);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaxonomy</summary>
        public void DeleteTaxonomyRequestObject()
        {
            // Snippet: DeleteTaxonomy(DeleteTaxonomyRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            // Make the request
            policyTagManagerClient.DeleteTaxonomy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaxonomyAsync</summary>
        public async Task DeleteTaxonomyRequestObjectAsync()
        {
            // Snippet: DeleteTaxonomyAsync(DeleteTaxonomyRequest, CallSettings)
            // Additional: DeleteTaxonomyAsync(DeleteTaxonomyRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTaxonomyRequest request = new DeleteTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            // Make the request
            await policyTagManagerClient.DeleteTaxonomyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaxonomy</summary>
        public void DeleteTaxonomy()
        {
            // Snippet: DeleteTaxonomy(string, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            // Make the request
            policyTagManagerClient.DeleteTaxonomy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaxonomyAsync</summary>
        public async Task DeleteTaxonomyAsync()
        {
            // Snippet: DeleteTaxonomyAsync(string, CallSettings)
            // Additional: DeleteTaxonomyAsync(string, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            // Make the request
            await policyTagManagerClient.DeleteTaxonomyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaxonomy</summary>
        public void DeleteTaxonomyResourceNames()
        {
            // Snippet: DeleteTaxonomy(TaxonomyName, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            TaxonomyName name = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            // Make the request
            policyTagManagerClient.DeleteTaxonomy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTaxonomyAsync</summary>
        public async Task DeleteTaxonomyResourceNamesAsync()
        {
            // Snippet: DeleteTaxonomyAsync(TaxonomyName, CallSettings)
            // Additional: DeleteTaxonomyAsync(TaxonomyName, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            TaxonomyName name = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            // Make the request
            await policyTagManagerClient.DeleteTaxonomyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTaxonomy</summary>
        public void UpdateTaxonomyRequestObject()
        {
            // Snippet: UpdateTaxonomy(UpdateTaxonomyRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            UpdateTaxonomyRequest request = new UpdateTaxonomyRequest
            {
                Taxonomy = new Taxonomy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Taxonomy response = policyTagManagerClient.UpdateTaxonomy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTaxonomyAsync</summary>
        public async Task UpdateTaxonomyRequestObjectAsync()
        {
            // Snippet: UpdateTaxonomyAsync(UpdateTaxonomyRequest, CallSettings)
            // Additional: UpdateTaxonomyAsync(UpdateTaxonomyRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTaxonomyRequest request = new UpdateTaxonomyRequest
            {
                Taxonomy = new Taxonomy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Taxonomy response = await policyTagManagerClient.UpdateTaxonomyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTaxonomy</summary>
        public void UpdateTaxonomy()
        {
            // Snippet: UpdateTaxonomy(Taxonomy, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            Taxonomy taxonomy = new Taxonomy();
            // Make the request
            Taxonomy response = policyTagManagerClient.UpdateTaxonomy(taxonomy);
            // End snippet
        }

        /// <summary>Snippet for UpdateTaxonomyAsync</summary>
        public async Task UpdateTaxonomyAsync()
        {
            // Snippet: UpdateTaxonomyAsync(Taxonomy, CallSettings)
            // Additional: UpdateTaxonomyAsync(Taxonomy, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            Taxonomy taxonomy = new Taxonomy();
            // Make the request
            Taxonomy response = await policyTagManagerClient.UpdateTaxonomyAsync(taxonomy);
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomies</summary>
        public void ListTaxonomiesRequestObject()
        {
            // Snippet: ListTaxonomies(ListTaxonomiesRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            ListTaxonomiesRequest request = new ListTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListTaxonomiesResponse, Taxonomy> response = policyTagManagerClient.ListTaxonomies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Taxonomy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTaxonomiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Taxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Taxonomy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Taxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomiesAsync</summary>
        public async Task ListTaxonomiesRequestObjectAsync()
        {
            // Snippet: ListTaxonomiesAsync(ListTaxonomiesRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListTaxonomiesRequest request = new ListTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> response = policyTagManagerClient.ListTaxonomiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Taxonomy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTaxonomiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Taxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Taxonomy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Taxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomies</summary>
        public void ListTaxonomies()
        {
            // Snippet: ListTaxonomies(string, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTaxonomiesResponse, Taxonomy> response = policyTagManagerClient.ListTaxonomies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Taxonomy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTaxonomiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Taxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Taxonomy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Taxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomiesAsync</summary>
        public async Task ListTaxonomiesAsync()
        {
            // Snippet: ListTaxonomiesAsync(string, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> response = policyTagManagerClient.ListTaxonomiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Taxonomy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTaxonomiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Taxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Taxonomy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Taxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomies</summary>
        public void ListTaxonomiesResourceNames()
        {
            // Snippet: ListTaxonomies(LocationName, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTaxonomiesResponse, Taxonomy> response = policyTagManagerClient.ListTaxonomies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Taxonomy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTaxonomiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Taxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Taxonomy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Taxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomiesAsync</summary>
        public async Task ListTaxonomiesResourceNamesAsync()
        {
            // Snippet: ListTaxonomiesAsync(LocationName, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> response = policyTagManagerClient.ListTaxonomiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Taxonomy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTaxonomiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Taxonomy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Taxonomy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Taxonomy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomy</summary>
        public void GetTaxonomyRequestObject()
        {
            // Snippet: GetTaxonomy(GetTaxonomyRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            // Make the request
            Taxonomy response = policyTagManagerClient.GetTaxonomy(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyAsync</summary>
        public async Task GetTaxonomyRequestObjectAsync()
        {
            // Snippet: GetTaxonomyAsync(GetTaxonomyRequest, CallSettings)
            // Additional: GetTaxonomyAsync(GetTaxonomyRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetTaxonomyRequest request = new GetTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            // Make the request
            Taxonomy response = await policyTagManagerClient.GetTaxonomyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomy</summary>
        public void GetTaxonomy()
        {
            // Snippet: GetTaxonomy(string, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            // Make the request
            Taxonomy response = policyTagManagerClient.GetTaxonomy(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyAsync</summary>
        public async Task GetTaxonomyAsync()
        {
            // Snippet: GetTaxonomyAsync(string, CallSettings)
            // Additional: GetTaxonomyAsync(string, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            // Make the request
            Taxonomy response = await policyTagManagerClient.GetTaxonomyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomy</summary>
        public void GetTaxonomyResourceNames()
        {
            // Snippet: GetTaxonomy(TaxonomyName, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            TaxonomyName name = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            // Make the request
            Taxonomy response = policyTagManagerClient.GetTaxonomy(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyAsync</summary>
        public async Task GetTaxonomyResourceNamesAsync()
        {
            // Snippet: GetTaxonomyAsync(TaxonomyName, CallSettings)
            // Additional: GetTaxonomyAsync(TaxonomyName, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            TaxonomyName name = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            // Make the request
            Taxonomy response = await policyTagManagerClient.GetTaxonomyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyTag</summary>
        public void CreatePolicyTagRequestObject()
        {
            // Snippet: CreatePolicyTag(CreatePolicyTagRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            // Make the request
            PolicyTag response = policyTagManagerClient.CreatePolicyTag(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyTagAsync</summary>
        public async Task CreatePolicyTagRequestObjectAsync()
        {
            // Snippet: CreatePolicyTagAsync(CreatePolicyTagRequest, CallSettings)
            // Additional: CreatePolicyTagAsync(CreatePolicyTagRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreatePolicyTagRequest request = new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                PolicyTag = new PolicyTag(),
            };
            // Make the request
            PolicyTag response = await policyTagManagerClient.CreatePolicyTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyTag</summary>
        public void CreatePolicyTag()
        {
            // Snippet: CreatePolicyTag(string, PolicyTag, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = policyTagManagerClient.CreatePolicyTag(parent, policyTag);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyTagAsync</summary>
        public async Task CreatePolicyTagAsync()
        {
            // Snippet: CreatePolicyTagAsync(string, PolicyTag, CallSettings)
            // Additional: CreatePolicyTagAsync(string, PolicyTag, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = await policyTagManagerClient.CreatePolicyTagAsync(parent, policyTag);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyTag</summary>
        public void CreatePolicyTagResourceNames()
        {
            // Snippet: CreatePolicyTag(TaxonomyName, PolicyTag, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            TaxonomyName parent = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = policyTagManagerClient.CreatePolicyTag(parent, policyTag);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyTagAsync</summary>
        public async Task CreatePolicyTagResourceNamesAsync()
        {
            // Snippet: CreatePolicyTagAsync(TaxonomyName, PolicyTag, CallSettings)
            // Additional: CreatePolicyTagAsync(TaxonomyName, PolicyTag, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            TaxonomyName parent = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = await policyTagManagerClient.CreatePolicyTagAsync(parent, policyTag);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyTag</summary>
        public void DeletePolicyTagRequestObject()
        {
            // Snippet: DeletePolicyTag(DeletePolicyTagRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            // Make the request
            policyTagManagerClient.DeletePolicyTag(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyTagAsync</summary>
        public async Task DeletePolicyTagRequestObjectAsync()
        {
            // Snippet: DeletePolicyTagAsync(DeletePolicyTagRequest, CallSettings)
            // Additional: DeletePolicyTagAsync(DeletePolicyTagRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeletePolicyTagRequest request = new DeletePolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            // Make the request
            await policyTagManagerClient.DeletePolicyTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyTag</summary>
        public void DeletePolicyTag()
        {
            // Snippet: DeletePolicyTag(string, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]/policyTags/[POLICY_TAG]";
            // Make the request
            policyTagManagerClient.DeletePolicyTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyTagAsync</summary>
        public async Task DeletePolicyTagAsync()
        {
            // Snippet: DeletePolicyTagAsync(string, CallSettings)
            // Additional: DeletePolicyTagAsync(string, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]/policyTags/[POLICY_TAG]";
            // Make the request
            await policyTagManagerClient.DeletePolicyTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyTag</summary>
        public void DeletePolicyTagResourceNames()
        {
            // Snippet: DeletePolicyTag(PolicyTagName, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            PolicyTagName name = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]");
            // Make the request
            policyTagManagerClient.DeletePolicyTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyTagAsync</summary>
        public async Task DeletePolicyTagResourceNamesAsync()
        {
            // Snippet: DeletePolicyTagAsync(PolicyTagName, CallSettings)
            // Additional: DeletePolicyTagAsync(PolicyTagName, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            PolicyTagName name = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]");
            // Make the request
            await policyTagManagerClient.DeletePolicyTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyTag</summary>
        public void UpdatePolicyTagRequestObject()
        {
            // Snippet: UpdatePolicyTag(UpdatePolicyTagRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            UpdatePolicyTagRequest request = new UpdatePolicyTagRequest
            {
                PolicyTag = new PolicyTag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PolicyTag response = policyTagManagerClient.UpdatePolicyTag(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyTagAsync</summary>
        public async Task UpdatePolicyTagRequestObjectAsync()
        {
            // Snippet: UpdatePolicyTagAsync(UpdatePolicyTagRequest, CallSettings)
            // Additional: UpdatePolicyTagAsync(UpdatePolicyTagRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyTagRequest request = new UpdatePolicyTagRequest
            {
                PolicyTag = new PolicyTag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PolicyTag response = await policyTagManagerClient.UpdatePolicyTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyTag</summary>
        public void UpdatePolicyTag()
        {
            // Snippet: UpdatePolicyTag(PolicyTag, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = policyTagManagerClient.UpdatePolicyTag(policyTag);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyTagAsync</summary>
        public async Task UpdatePolicyTagAsync()
        {
            // Snippet: UpdatePolicyTagAsync(PolicyTag, CallSettings)
            // Additional: UpdatePolicyTagAsync(PolicyTag, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            PolicyTag policyTag = new PolicyTag();
            // Make the request
            PolicyTag response = await policyTagManagerClient.UpdatePolicyTagAsync(policyTag);
            // End snippet
        }

        /// <summary>Snippet for ListPolicyTags</summary>
        public void ListPolicyTagsRequestObject()
        {
            // Snippet: ListPolicyTags(ListPolicyTagsRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            ListPolicyTagsRequest request = new ListPolicyTagsRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            // Make the request
            PagedEnumerable<ListPolicyTagsResponse, PolicyTag> response = policyTagManagerClient.ListPolicyTags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyTag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyTag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyTagsAsync</summary>
        public async Task ListPolicyTagsRequestObjectAsync()
        {
            // Snippet: ListPolicyTagsAsync(ListPolicyTagsRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListPolicyTagsRequest request = new ListPolicyTagsRequest
            {
                ParentAsTaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> response = policyTagManagerClient.ListPolicyTagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyTag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyTag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyTags</summary>
        public void ListPolicyTags()
        {
            // Snippet: ListPolicyTags(string, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            // Make the request
            PagedEnumerable<ListPolicyTagsResponse, PolicyTag> response = policyTagManagerClient.ListPolicyTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyTag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyTag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyTagsAsync</summary>
        public async Task ListPolicyTagsAsync()
        {
            // Snippet: ListPolicyTagsAsync(string, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]";
            // Make the request
            PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> response = policyTagManagerClient.ListPolicyTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyTag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyTag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyTags</summary>
        public void ListPolicyTagsResourceNames()
        {
            // Snippet: ListPolicyTags(TaxonomyName, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            TaxonomyName parent = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            // Make the request
            PagedEnumerable<ListPolicyTagsResponse, PolicyTag> response = policyTagManagerClient.ListPolicyTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyTag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyTag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicyTagsAsync</summary>
        public async Task ListPolicyTagsResourceNamesAsync()
        {
            // Snippet: ListPolicyTagsAsync(TaxonomyName, string, int?, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            TaxonomyName parent = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]");
            // Make the request
            PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> response = policyTagManagerClient.ListPolicyTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyTag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyTag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyTag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyTag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPolicyTag</summary>
        public void GetPolicyTagRequestObject()
        {
            // Snippet: GetPolicyTag(GetPolicyTagRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            // Make the request
            PolicyTag response = policyTagManagerClient.GetPolicyTag(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyTagAsync</summary>
        public async Task GetPolicyTagRequestObjectAsync()
        {
            // Snippet: GetPolicyTagAsync(GetPolicyTagRequest, CallSettings)
            // Additional: GetPolicyTagAsync(GetPolicyTagRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetPolicyTagRequest request = new GetPolicyTagRequest
            {
                PolicyTagName = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]"),
            };
            // Make the request
            PolicyTag response = await policyTagManagerClient.GetPolicyTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyTag</summary>
        public void GetPolicyTag()
        {
            // Snippet: GetPolicyTag(string, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]/policyTags/[POLICY_TAG]";
            // Make the request
            PolicyTag response = policyTagManagerClient.GetPolicyTag(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyTagAsync</summary>
        public async Task GetPolicyTagAsync()
        {
            // Snippet: GetPolicyTagAsync(string, CallSettings)
            // Additional: GetPolicyTagAsync(string, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/taxonomies/[TAXONOMY]/policyTags/[POLICY_TAG]";
            // Make the request
            PolicyTag response = await policyTagManagerClient.GetPolicyTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyTag</summary>
        public void GetPolicyTagResourceNames()
        {
            // Snippet: GetPolicyTag(PolicyTagName, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            PolicyTagName name = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]");
            // Make the request
            PolicyTag response = policyTagManagerClient.GetPolicyTag(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyTagAsync</summary>
        public async Task GetPolicyTagResourceNamesAsync()
        {
            // Snippet: GetPolicyTagAsync(PolicyTagName, CallSettings)
            // Additional: GetPolicyTagAsync(PolicyTagName, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            PolicyTagName name = PolicyTagName.FromProjectLocationTaxonomyPolicyTag("[PROJECT]", "[LOCATION]", "[TAXONOMY]", "[POLICY_TAG]");
            // Make the request
            PolicyTag response = await policyTagManagerClient.GetPolicyTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = policyTagManagerClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await policyTagManagerClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = policyTagManagerClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await policyTagManagerClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = PolicyTagManagerClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = policyTagManagerClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            PolicyTagManagerClient policyTagManagerClient = await PolicyTagManagerClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await policyTagManagerClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
