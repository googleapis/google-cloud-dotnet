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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSipTrunksClientSnippets
    {
        /// <summary>Snippet for CreateSipTrunk</summary>
        public void CreateSipTrunkRequestObject()
        {
            // Snippet: CreateSipTrunk(CreateSipTrunkRequest, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            CreateSipTrunkRequest request = new CreateSipTrunkRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SipTrunk = new SipTrunk(),
            };
            // Make the request
            SipTrunk response = sipTrunksClient.CreateSipTrunk(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSipTrunkAsync</summary>
        public async Task CreateSipTrunkRequestObjectAsync()
        {
            // Snippet: CreateSipTrunkAsync(CreateSipTrunkRequest, CallSettings)
            // Additional: CreateSipTrunkAsync(CreateSipTrunkRequest, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            CreateSipTrunkRequest request = new CreateSipTrunkRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SipTrunk = new SipTrunk(),
            };
            // Make the request
            SipTrunk response = await sipTrunksClient.CreateSipTrunkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSipTrunk</summary>
        public void CreateSipTrunk()
        {
            // Snippet: CreateSipTrunk(string, SipTrunk, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SipTrunk sipTrunk = new SipTrunk();
            // Make the request
            SipTrunk response = sipTrunksClient.CreateSipTrunk(parent, sipTrunk);
            // End snippet
        }

        /// <summary>Snippet for CreateSipTrunkAsync</summary>
        public async Task CreateSipTrunkAsync()
        {
            // Snippet: CreateSipTrunkAsync(string, SipTrunk, CallSettings)
            // Additional: CreateSipTrunkAsync(string, SipTrunk, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SipTrunk sipTrunk = new SipTrunk();
            // Make the request
            SipTrunk response = await sipTrunksClient.CreateSipTrunkAsync(parent, sipTrunk);
            // End snippet
        }

        /// <summary>Snippet for CreateSipTrunk</summary>
        public void CreateSipTrunkResourceNames()
        {
            // Snippet: CreateSipTrunk(LocationName, SipTrunk, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SipTrunk sipTrunk = new SipTrunk();
            // Make the request
            SipTrunk response = sipTrunksClient.CreateSipTrunk(parent, sipTrunk);
            // End snippet
        }

        /// <summary>Snippet for CreateSipTrunkAsync</summary>
        public async Task CreateSipTrunkResourceNamesAsync()
        {
            // Snippet: CreateSipTrunkAsync(LocationName, SipTrunk, CallSettings)
            // Additional: CreateSipTrunkAsync(LocationName, SipTrunk, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SipTrunk sipTrunk = new SipTrunk();
            // Make the request
            SipTrunk response = await sipTrunksClient.CreateSipTrunkAsync(parent, sipTrunk);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipTrunk</summary>
        public void DeleteSipTrunkRequestObject()
        {
            // Snippet: DeleteSipTrunk(DeleteSipTrunkRequest, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            DeleteSipTrunkRequest request = new DeleteSipTrunkRequest
            {
                SipTrunkName = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]"),
            };
            // Make the request
            sipTrunksClient.DeleteSipTrunk(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipTrunkAsync</summary>
        public async Task DeleteSipTrunkRequestObjectAsync()
        {
            // Snippet: DeleteSipTrunkAsync(DeleteSipTrunkRequest, CallSettings)
            // Additional: DeleteSipTrunkAsync(DeleteSipTrunkRequest, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSipTrunkRequest request = new DeleteSipTrunkRequest
            {
                SipTrunkName = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]"),
            };
            // Make the request
            await sipTrunksClient.DeleteSipTrunkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipTrunk</summary>
        public void DeleteSipTrunk()
        {
            // Snippet: DeleteSipTrunk(string, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sipTrunks/[SIPTRUNK]";
            // Make the request
            sipTrunksClient.DeleteSipTrunk(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipTrunkAsync</summary>
        public async Task DeleteSipTrunkAsync()
        {
            // Snippet: DeleteSipTrunkAsync(string, CallSettings)
            // Additional: DeleteSipTrunkAsync(string, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sipTrunks/[SIPTRUNK]";
            // Make the request
            await sipTrunksClient.DeleteSipTrunkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipTrunk</summary>
        public void DeleteSipTrunkResourceNames()
        {
            // Snippet: DeleteSipTrunk(SipTrunkName, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            SipTrunkName name = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]");
            // Make the request
            sipTrunksClient.DeleteSipTrunk(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSipTrunkAsync</summary>
        public async Task DeleteSipTrunkResourceNamesAsync()
        {
            // Snippet: DeleteSipTrunkAsync(SipTrunkName, CallSettings)
            // Additional: DeleteSipTrunkAsync(SipTrunkName, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            SipTrunkName name = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]");
            // Make the request
            await sipTrunksClient.DeleteSipTrunkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSipTrunks</summary>
        public void ListSipTrunksRequestObject()
        {
            // Snippet: ListSipTrunks(ListSipTrunksRequest, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            ListSipTrunksRequest request = new ListSipTrunksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSipTrunksResponse, SipTrunk> response = sipTrunksClient.ListSipTrunks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SipTrunk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSipTrunksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipTrunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipTrunk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipTrunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipTrunksAsync</summary>
        public async Task ListSipTrunksRequestObjectAsync()
        {
            // Snippet: ListSipTrunksAsync(ListSipTrunksRequest, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            ListSipTrunksRequest request = new ListSipTrunksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> response = sipTrunksClient.ListSipTrunksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SipTrunk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSipTrunksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipTrunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipTrunk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipTrunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipTrunks</summary>
        public void ListSipTrunks()
        {
            // Snippet: ListSipTrunks(string, string, int?, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSipTrunksResponse, SipTrunk> response = sipTrunksClient.ListSipTrunks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SipTrunk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSipTrunksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipTrunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipTrunk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipTrunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipTrunksAsync</summary>
        public async Task ListSipTrunksAsync()
        {
            // Snippet: ListSipTrunksAsync(string, string, int?, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> response = sipTrunksClient.ListSipTrunksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SipTrunk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSipTrunksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipTrunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipTrunk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipTrunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipTrunks</summary>
        public void ListSipTrunksResourceNames()
        {
            // Snippet: ListSipTrunks(LocationName, string, int?, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSipTrunksResponse, SipTrunk> response = sipTrunksClient.ListSipTrunks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SipTrunk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSipTrunksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipTrunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipTrunk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipTrunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSipTrunksAsync</summary>
        public async Task ListSipTrunksResourceNamesAsync()
        {
            // Snippet: ListSipTrunksAsync(LocationName, string, int?, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> response = sipTrunksClient.ListSipTrunksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SipTrunk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSipTrunksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SipTrunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SipTrunk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SipTrunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSipTrunk</summary>
        public void GetSipTrunkRequestObject()
        {
            // Snippet: GetSipTrunk(GetSipTrunkRequest, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            GetSipTrunkRequest request = new GetSipTrunkRequest
            {
                SipTrunkName = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]"),
            };
            // Make the request
            SipTrunk response = sipTrunksClient.GetSipTrunk(request);
            // End snippet
        }

        /// <summary>Snippet for GetSipTrunkAsync</summary>
        public async Task GetSipTrunkRequestObjectAsync()
        {
            // Snippet: GetSipTrunkAsync(GetSipTrunkRequest, CallSettings)
            // Additional: GetSipTrunkAsync(GetSipTrunkRequest, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            GetSipTrunkRequest request = new GetSipTrunkRequest
            {
                SipTrunkName = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]"),
            };
            // Make the request
            SipTrunk response = await sipTrunksClient.GetSipTrunkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSipTrunk</summary>
        public void GetSipTrunk()
        {
            // Snippet: GetSipTrunk(string, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sipTrunks/[SIPTRUNK]";
            // Make the request
            SipTrunk response = sipTrunksClient.GetSipTrunk(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipTrunkAsync</summary>
        public async Task GetSipTrunkAsync()
        {
            // Snippet: GetSipTrunkAsync(string, CallSettings)
            // Additional: GetSipTrunkAsync(string, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sipTrunks/[SIPTRUNK]";
            // Make the request
            SipTrunk response = await sipTrunksClient.GetSipTrunkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipTrunk</summary>
        public void GetSipTrunkResourceNames()
        {
            // Snippet: GetSipTrunk(SipTrunkName, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            SipTrunkName name = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]");
            // Make the request
            SipTrunk response = sipTrunksClient.GetSipTrunk(name);
            // End snippet
        }

        /// <summary>Snippet for GetSipTrunkAsync</summary>
        public async Task GetSipTrunkResourceNamesAsync()
        {
            // Snippet: GetSipTrunkAsync(SipTrunkName, CallSettings)
            // Additional: GetSipTrunkAsync(SipTrunkName, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            SipTrunkName name = SipTrunkName.FromProjectLocationSiptrunk("[PROJECT]", "[LOCATION]", "[SIPTRUNK]");
            // Make the request
            SipTrunk response = await sipTrunksClient.GetSipTrunkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipTrunk</summary>
        public void UpdateSipTrunkRequestObject()
        {
            // Snippet: UpdateSipTrunk(UpdateSipTrunkRequest, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            UpdateSipTrunkRequest request = new UpdateSipTrunkRequest
            {
                SipTrunk = new SipTrunk(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SipTrunk response = sipTrunksClient.UpdateSipTrunk(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipTrunkAsync</summary>
        public async Task UpdateSipTrunkRequestObjectAsync()
        {
            // Snippet: UpdateSipTrunkAsync(UpdateSipTrunkRequest, CallSettings)
            // Additional: UpdateSipTrunkAsync(UpdateSipTrunkRequest, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSipTrunkRequest request = new UpdateSipTrunkRequest
            {
                SipTrunk = new SipTrunk(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SipTrunk response = await sipTrunksClient.UpdateSipTrunkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipTrunk</summary>
        public void UpdateSipTrunk()
        {
            // Snippet: UpdateSipTrunk(SipTrunk, FieldMask, CallSettings)
            // Create client
            SipTrunksClient sipTrunksClient = SipTrunksClient.Create();
            // Initialize request argument(s)
            SipTrunk sipTrunk = new SipTrunk();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SipTrunk response = sipTrunksClient.UpdateSipTrunk(sipTrunk, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSipTrunkAsync</summary>
        public async Task UpdateSipTrunkAsync()
        {
            // Snippet: UpdateSipTrunkAsync(SipTrunk, FieldMask, CallSettings)
            // Additional: UpdateSipTrunkAsync(SipTrunk, FieldMask, CancellationToken)
            // Create client
            SipTrunksClient sipTrunksClient = await SipTrunksClient.CreateAsync();
            // Initialize request argument(s)
            SipTrunk sipTrunk = new SipTrunk();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SipTrunk response = await sipTrunksClient.UpdateSipTrunkAsync(sipTrunk, updateMask);
            // End snippet
        }
    }
}
