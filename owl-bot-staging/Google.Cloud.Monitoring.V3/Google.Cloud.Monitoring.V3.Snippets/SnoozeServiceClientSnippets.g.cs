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
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSnoozeServiceClientSnippets
    {
        /// <summary>Snippet for CreateSnooze</summary>
        public void CreateSnoozeRequestObject()
        {
            // Snippet: CreateSnooze(CreateSnoozeRequest, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            CreateSnoozeRequest request = new CreateSnoozeRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Snooze = new Snooze(),
            };
            // Make the request
            Snooze response = snoozeServiceClient.CreateSnooze(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnoozeAsync</summary>
        public async Task CreateSnoozeRequestObjectAsync()
        {
            // Snippet: CreateSnoozeAsync(CreateSnoozeRequest, CallSettings)
            // Additional: CreateSnoozeAsync(CreateSnoozeRequest, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnoozeRequest request = new CreateSnoozeRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Snooze = new Snooze(),
            };
            // Make the request
            Snooze response = await snoozeServiceClient.CreateSnoozeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSnooze</summary>
        public void CreateSnooze()
        {
            // Snippet: CreateSnooze(string, Snooze, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Snooze snooze = new Snooze();
            // Make the request
            Snooze response = snoozeServiceClient.CreateSnooze(parent, snooze);
            // End snippet
        }

        /// <summary>Snippet for CreateSnoozeAsync</summary>
        public async Task CreateSnoozeAsync()
        {
            // Snippet: CreateSnoozeAsync(string, Snooze, CallSettings)
            // Additional: CreateSnoozeAsync(string, Snooze, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Snooze snooze = new Snooze();
            // Make the request
            Snooze response = await snoozeServiceClient.CreateSnoozeAsync(parent, snooze);
            // End snippet
        }

        /// <summary>Snippet for CreateSnooze</summary>
        public void CreateSnoozeResourceNames()
        {
            // Snippet: CreateSnooze(ProjectName, Snooze, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Snooze snooze = new Snooze();
            // Make the request
            Snooze response = snoozeServiceClient.CreateSnooze(parent, snooze);
            // End snippet
        }

        /// <summary>Snippet for CreateSnoozeAsync</summary>
        public async Task CreateSnoozeResourceNamesAsync()
        {
            // Snippet: CreateSnoozeAsync(ProjectName, Snooze, CallSettings)
            // Additional: CreateSnoozeAsync(ProjectName, Snooze, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Snooze snooze = new Snooze();
            // Make the request
            Snooze response = await snoozeServiceClient.CreateSnoozeAsync(parent, snooze);
            // End snippet
        }

        /// <summary>Snippet for ListSnoozes</summary>
        public void ListSnoozesRequestObject()
        {
            // Snippet: ListSnoozes(ListSnoozesRequest, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            ListSnoozesRequest request = new ListSnoozesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSnoozesResponse, Snooze> response = snoozeServiceClient.ListSnoozes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snooze item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnoozesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snooze item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snooze> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snooze item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnoozesAsync</summary>
        public async Task ListSnoozesRequestObjectAsync()
        {
            // Snippet: ListSnoozesAsync(ListSnoozesRequest, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSnoozesRequest request = new ListSnoozesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSnoozesResponse, Snooze> response = snoozeServiceClient.ListSnoozesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snooze item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnoozesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snooze item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snooze> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snooze item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnoozes</summary>
        public void ListSnoozes()
        {
            // Snippet: ListSnoozes(string, string, int?, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSnoozesResponse, Snooze> response = snoozeServiceClient.ListSnoozes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snooze item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnoozesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snooze item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snooze> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snooze item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnoozesAsync</summary>
        public async Task ListSnoozesAsync()
        {
            // Snippet: ListSnoozesAsync(string, string, int?, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSnoozesResponse, Snooze> response = snoozeServiceClient.ListSnoozesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snooze item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnoozesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snooze item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snooze> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snooze item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnoozes</summary>
        public void ListSnoozesResourceNames()
        {
            // Snippet: ListSnoozes(ProjectName, string, int?, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSnoozesResponse, Snooze> response = snoozeServiceClient.ListSnoozes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snooze item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnoozesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snooze item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snooze> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snooze item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnoozesAsync</summary>
        public async Task ListSnoozesResourceNamesAsync()
        {
            // Snippet: ListSnoozesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSnoozesResponse, Snooze> response = snoozeServiceClient.ListSnoozesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snooze item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnoozesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snooze item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snooze> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snooze item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSnooze</summary>
        public void GetSnoozeRequestObject()
        {
            // Snippet: GetSnooze(GetSnoozeRequest, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            GetSnoozeRequest request = new GetSnoozeRequest
            {
                SnoozeName = SnoozeName.FromProjectSnooze("[PROJECT]", "[SNOOZE]"),
            };
            // Make the request
            Snooze response = snoozeServiceClient.GetSnooze(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnoozeAsync</summary>
        public async Task GetSnoozeRequestObjectAsync()
        {
            // Snippet: GetSnoozeAsync(GetSnoozeRequest, CallSettings)
            // Additional: GetSnoozeAsync(GetSnoozeRequest, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSnoozeRequest request = new GetSnoozeRequest
            {
                SnoozeName = SnoozeName.FromProjectSnooze("[PROJECT]", "[SNOOZE]"),
            };
            // Make the request
            Snooze response = await snoozeServiceClient.GetSnoozeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnooze</summary>
        public void GetSnooze()
        {
            // Snippet: GetSnooze(string, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/snoozes/[SNOOZE]";
            // Make the request
            Snooze response = snoozeServiceClient.GetSnooze(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnoozeAsync</summary>
        public async Task GetSnoozeAsync()
        {
            // Snippet: GetSnoozeAsync(string, CallSettings)
            // Additional: GetSnoozeAsync(string, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/snoozes/[SNOOZE]";
            // Make the request
            Snooze response = await snoozeServiceClient.GetSnoozeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnooze</summary>
        public void GetSnoozeResourceNames()
        {
            // Snippet: GetSnooze(SnoozeName, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            SnoozeName name = SnoozeName.FromProjectSnooze("[PROJECT]", "[SNOOZE]");
            // Make the request
            Snooze response = snoozeServiceClient.GetSnooze(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnoozeAsync</summary>
        public async Task GetSnoozeResourceNamesAsync()
        {
            // Snippet: GetSnoozeAsync(SnoozeName, CallSettings)
            // Additional: GetSnoozeAsync(SnoozeName, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            SnoozeName name = SnoozeName.FromProjectSnooze("[PROJECT]", "[SNOOZE]");
            // Make the request
            Snooze response = await snoozeServiceClient.GetSnoozeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnooze</summary>
        public void UpdateSnoozeRequestObject()
        {
            // Snippet: UpdateSnooze(UpdateSnoozeRequest, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            UpdateSnoozeRequest request = new UpdateSnoozeRequest
            {
                Snooze = new Snooze(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snooze response = snoozeServiceClient.UpdateSnooze(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnoozeAsync</summary>
        public async Task UpdateSnoozeRequestObjectAsync()
        {
            // Snippet: UpdateSnoozeAsync(UpdateSnoozeRequest, CallSettings)
            // Additional: UpdateSnoozeAsync(UpdateSnoozeRequest, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSnoozeRequest request = new UpdateSnoozeRequest
            {
                Snooze = new Snooze(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Snooze response = await snoozeServiceClient.UpdateSnoozeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnooze</summary>
        public void UpdateSnooze()
        {
            // Snippet: UpdateSnooze(Snooze, FieldMask, CallSettings)
            // Create client
            SnoozeServiceClient snoozeServiceClient = SnoozeServiceClient.Create();
            // Initialize request argument(s)
            Snooze snooze = new Snooze();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Snooze response = snoozeServiceClient.UpdateSnooze(snooze, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSnoozeAsync</summary>
        public async Task UpdateSnoozeAsync()
        {
            // Snippet: UpdateSnoozeAsync(Snooze, FieldMask, CallSettings)
            // Additional: UpdateSnoozeAsync(Snooze, FieldMask, CancellationToken)
            // Create client
            SnoozeServiceClient snoozeServiceClient = await SnoozeServiceClient.CreateAsync();
            // Initialize request argument(s)
            Snooze snooze = new Snooze();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Snooze response = await snoozeServiceClient.UpdateSnoozeAsync(snooze, updateMask);
            // End snippet
        }
    }
}
