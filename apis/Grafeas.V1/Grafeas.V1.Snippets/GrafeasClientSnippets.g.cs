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
    using Google.Protobuf.WellKnownTypes;
    using Grafeas.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGrafeasClientSnippets
    {
        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrenceRequestObject()
        {
            string endpoint = "";
            // Snippet: GetOccurrence(GetOccurrenceRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Occurrence response = grafeasClient.GetOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceAsync(GetOccurrenceRequest, CallSettings)
            // Additional: GetOccurrenceAsync(GetOccurrenceRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Occurrence response = await grafeasClient.GetOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrence()
        {
            string endpoint = "";
            // Snippet: GetOccurrence(string, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            // Make the request
            Occurrence response = grafeasClient.GetOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceAsync()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceAsync(string, CallSettings)
            // Additional: GetOccurrenceAsync(string, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            // Make the request
            Occurrence response = await grafeasClient.GetOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrenceResourceNames()
        {
            string endpoint = "";
            // Snippet: GetOccurrence(OccurrenceName, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Occurrence response = grafeasClient.GetOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceAsync(OccurrenceName, CallSettings)
            // Additional: GetOccurrenceAsync(OccurrenceName, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Occurrence response = await grafeasClient.GetOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrencesRequestObject()
        {
            string endpoint = "";
            // Snippet: ListOccurrences(ListOccurrencesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response = grafeasClient.ListOccurrences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: ListOccurrencesAsync(ListOccurrencesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response = grafeasClient.ListOccurrencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrences()
        {
            string endpoint = "";
            // Snippet: ListOccurrences(string, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response = grafeasClient.ListOccurrences(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesAsync()
        {
            string endpoint = "";
            // Snippet: ListOccurrencesAsync(string, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response = grafeasClient.ListOccurrencesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrencesResourceNames()
        {
            string endpoint = "";
            // Snippet: ListOccurrences(ProjectName, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response = grafeasClient.ListOccurrences(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: ListOccurrencesAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response = grafeasClient.ListOccurrencesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrenceRequestObject()
        {
            string endpoint = "";
            // Snippet: DeleteOccurrence(DeleteOccurrenceRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            grafeasClient.DeleteOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: DeleteOccurrenceAsync(DeleteOccurrenceRequest, CallSettings)
            // Additional: DeleteOccurrenceAsync(DeleteOccurrenceRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            await grafeasClient.DeleteOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrence()
        {
            string endpoint = "";
            // Snippet: DeleteOccurrence(string, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            // Make the request
            grafeasClient.DeleteOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceAsync()
        {
            string endpoint = "";
            // Snippet: DeleteOccurrenceAsync(string, CallSettings)
            // Additional: DeleteOccurrenceAsync(string, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            // Make the request
            await grafeasClient.DeleteOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrenceResourceNames()
        {
            string endpoint = "";
            // Snippet: DeleteOccurrence(OccurrenceName, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            grafeasClient.DeleteOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: DeleteOccurrenceAsync(OccurrenceName, CallSettings)
            // Additional: DeleteOccurrenceAsync(OccurrenceName, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            await grafeasClient.DeleteOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrenceRequestObject()
        {
            string endpoint = "";
            // Snippet: CreateOccurrence(CreateOccurrenceRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = grafeasClient.CreateOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: CreateOccurrenceAsync(CreateOccurrenceRequest, CallSettings)
            // Additional: CreateOccurrenceAsync(CreateOccurrenceRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = await grafeasClient.CreateOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrence()
        {
            string endpoint = "";
            // Snippet: CreateOccurrence(string, Occurrence, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = grafeasClient.CreateOccurrence(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceAsync()
        {
            string endpoint = "";
            // Snippet: CreateOccurrenceAsync(string, Occurrence, CallSettings)
            // Additional: CreateOccurrenceAsync(string, Occurrence, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = await grafeasClient.CreateOccurrenceAsync(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrenceResourceNames()
        {
            string endpoint = "";
            // Snippet: CreateOccurrence(ProjectName, Occurrence, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = grafeasClient.CreateOccurrence(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: CreateOccurrenceAsync(ProjectName, Occurrence, CallSettings)
            // Additional: CreateOccurrenceAsync(ProjectName, Occurrence, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = await grafeasClient.CreateOccurrenceAsync(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrencesRequestObject()
        {
            string endpoint = "";
            // Snippet: BatchCreateOccurrences(BatchCreateOccurrencesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasClient.BatchCreateOccurrences(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest, CallSettings)
            // Additional: BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Occurrences = { new Occurrence(), },
            };
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasClient.BatchCreateOccurrencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrences()
        {
            string endpoint = "";
            // Snippet: BatchCreateOccurrences(string, IEnumerable<Occurrence>, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IEnumerable<Occurrence> occurrences = new Occurrence[] { new Occurrence(), };
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasClient.BatchCreateOccurrences(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesAsync()
        {
            string endpoint = "";
            // Snippet: BatchCreateOccurrencesAsync(string, IEnumerable<Occurrence>, CallSettings)
            // Additional: BatchCreateOccurrencesAsync(string, IEnumerable<Occurrence>, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IEnumerable<Occurrence> occurrences = new Occurrence[] { new Occurrence(), };
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasClient.BatchCreateOccurrencesAsync(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrencesResourceNames()
        {
            string endpoint = "";
            // Snippet: BatchCreateOccurrences(ProjectName, IEnumerable<Occurrence>, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new Occurrence[] { new Occurrence(), };
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasClient.BatchCreateOccurrences(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: BatchCreateOccurrencesAsync(ProjectName, IEnumerable<Occurrence>, CallSettings)
            // Additional: BatchCreateOccurrencesAsync(ProjectName, IEnumerable<Occurrence>, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new Occurrence[] { new Occurrence(), };
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasClient.BatchCreateOccurrencesAsync(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrenceRequestObject()
        {
            string endpoint = "";
            // Snippet: UpdateOccurrence(UpdateOccurrenceRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Occurrence response = grafeasClient.UpdateOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: UpdateOccurrenceAsync(UpdateOccurrenceRequest, CallSettings)
            // Additional: UpdateOccurrenceAsync(UpdateOccurrenceRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Occurrence response = await grafeasClient.UpdateOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrence()
        {
            string endpoint = "";
            // Snippet: UpdateOccurrence(string, Occurrence, FieldMask, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = grafeasClient.UpdateOccurrence(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceAsync()
        {
            string endpoint = "";
            // Snippet: UpdateOccurrenceAsync(string, Occurrence, FieldMask, CallSettings)
            // Additional: UpdateOccurrenceAsync(string, Occurrence, FieldMask, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = await grafeasClient.UpdateOccurrenceAsync(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrenceResourceNames()
        {
            string endpoint = "";
            // Snippet: UpdateOccurrence(OccurrenceName, Occurrence, FieldMask, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = grafeasClient.UpdateOccurrence(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: UpdateOccurrenceAsync(OccurrenceName, Occurrence, FieldMask, CallSettings)
            // Additional: UpdateOccurrenceAsync(OccurrenceName, Occurrence, FieldMask, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = await grafeasClient.UpdateOccurrenceAsync(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNoteRequestObject()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceNote(GetOccurrenceNoteRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Note response = grafeasClient.GetOccurrenceNote(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceNoteAsync(GetOccurrenceNoteRequest, CallSettings)
            // Additional: GetOccurrenceNoteAsync(GetOccurrenceNoteRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Note response = await grafeasClient.GetOccurrenceNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNote()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceNote(string, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            // Make the request
            Note response = grafeasClient.GetOccurrenceNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteAsync()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceNoteAsync(string, CallSettings)
            // Additional: GetOccurrenceNoteAsync(string, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/occurrences/[OCCURRENCE]";
            // Make the request
            Note response = await grafeasClient.GetOccurrenceNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNoteResourceNames()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceNote(OccurrenceName, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Note response = grafeasClient.GetOccurrenceNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: GetOccurrenceNoteAsync(OccurrenceName, CallSettings)
            // Additional: GetOccurrenceNoteAsync(OccurrenceName, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            OccurrenceName name = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Note response = await grafeasClient.GetOccurrenceNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNoteRequestObject()
        {
            string endpoint = "";
            // Snippet: GetNote(GetNoteRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            Note response = grafeasClient.GetNote(request);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: GetNoteAsync(GetNoteRequest, CallSettings)
            // Additional: GetNoteAsync(GetNoteRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            Note response = await grafeasClient.GetNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNote()
        {
            string endpoint = "";
            // Snippet: GetNote(string, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            // Make the request
            Note response = grafeasClient.GetNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteAsync()
        {
            string endpoint = "";
            // Snippet: GetNoteAsync(string, CallSettings)
            // Additional: GetNoteAsync(string, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            // Make the request
            Note response = await grafeasClient.GetNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNoteResourceNames()
        {
            string endpoint = "";
            // Snippet: GetNote(NoteName, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            // Make the request
            Note response = grafeasClient.GetNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: GetNoteAsync(NoteName, CallSettings)
            // Additional: GetNoteAsync(NoteName, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            // Make the request
            Note response = await grafeasClient.GetNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotesRequestObject()
        {
            string endpoint = "";
            // Snippet: ListNotes(ListNotesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response = grafeasClient.ListNotes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Note item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: ListNotesAsync(ListNotesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response = grafeasClient.ListNotesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Note item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotes()
        {
            string endpoint = "";
            // Snippet: ListNotes(string, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response = grafeasClient.ListNotes(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Note item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesAsync()
        {
            string endpoint = "";
            // Snippet: ListNotesAsync(string, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response = grafeasClient.ListNotesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Note item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotesResourceNames()
        {
            string endpoint = "";
            // Snippet: ListNotes(ProjectName, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response = grafeasClient.ListNotes(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Note item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNotesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: ListNotesAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response = grafeasClient.ListNotesAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Note item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNotesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Note item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Note> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Note item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNoteRequestObject()
        {
            string endpoint = "";
            // Snippet: DeleteNote(DeleteNoteRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            grafeasClient.DeleteNote(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: DeleteNoteAsync(DeleteNoteRequest, CallSettings)
            // Additional: DeleteNoteAsync(DeleteNoteRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            await grafeasClient.DeleteNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNote()
        {
            string endpoint = "";
            // Snippet: DeleteNote(string, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            // Make the request
            grafeasClient.DeleteNote(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteAsync()
        {
            string endpoint = "";
            // Snippet: DeleteNoteAsync(string, CallSettings)
            // Additional: DeleteNoteAsync(string, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            // Make the request
            await grafeasClient.DeleteNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNoteResourceNames()
        {
            string endpoint = "";
            // Snippet: DeleteNote(NoteName, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            // Make the request
            grafeasClient.DeleteNote(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: DeleteNoteAsync(NoteName, CallSettings)
            // Additional: DeleteNoteAsync(NoteName, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            // Make the request
            await grafeasClient.DeleteNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNoteRequestObject()
        {
            string endpoint = "";
            // Snippet: CreateNote(CreateNoteRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "",
                Note = new Note(),
            };
            // Make the request
            Note response = grafeasClient.CreateNote(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: CreateNoteAsync(CreateNoteRequest, CallSettings)
            // Additional: CreateNoteAsync(CreateNoteRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                NoteId = "",
                Note = new Note(),
            };
            // Make the request
            Note response = await grafeasClient.CreateNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNote()
        {
            string endpoint = "";
            // Snippet: CreateNote(string, string, Note, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = grafeasClient.CreateNote(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteAsync()
        {
            string endpoint = "";
            // Snippet: CreateNoteAsync(string, string, Note, CallSettings)
            // Additional: CreateNoteAsync(string, string, Note, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = await grafeasClient.CreateNoteAsync(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNoteResourceNames()
        {
            string endpoint = "";
            // Snippet: CreateNote(ProjectName, string, Note, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = grafeasClient.CreateNote(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: CreateNoteAsync(ProjectName, string, Note, CallSettings)
            // Additional: CreateNoteAsync(ProjectName, string, Note, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = await grafeasClient.CreateNoteAsync(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotesRequestObject()
        {
            string endpoint = "";
            // Snippet: BatchCreateNotes(BatchCreateNotesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes = { { "", new Note() }, },
            };
            // Make the request
            BatchCreateNotesResponse response = grafeasClient.BatchCreateNotes(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: BatchCreateNotesAsync(BatchCreateNotesRequest, CallSettings)
            // Additional: BatchCreateNotesAsync(BatchCreateNotesRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Notes = { { "", new Note() }, },
            };
            // Make the request
            BatchCreateNotesResponse response = await grafeasClient.BatchCreateNotesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotes()
        {
            string endpoint = "";
            // Snippet: BatchCreateNotes(string, IDictionary<string,Note>, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IDictionary<string, Note> notes = new Dictionary<string, Note> { { "", new Note() }, };
            // Make the request
            BatchCreateNotesResponse response = grafeasClient.BatchCreateNotes(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesAsync()
        {
            string endpoint = "";
            // Snippet: BatchCreateNotesAsync(string, IDictionary<string,Note>, CallSettings)
            // Additional: BatchCreateNotesAsync(string, IDictionary<string,Note>, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IDictionary<string, Note> notes = new Dictionary<string, Note> { { "", new Note() }, };
            // Make the request
            BatchCreateNotesResponse response = await grafeasClient.BatchCreateNotesAsync(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotesResourceNames()
        {
            string endpoint = "";
            // Snippet: BatchCreateNotes(ProjectName, IDictionary<string,Note>, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note> { { "", new Note() }, };
            // Make the request
            BatchCreateNotesResponse response = grafeasClient.BatchCreateNotes(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: BatchCreateNotesAsync(ProjectName, IDictionary<string,Note>, CallSettings)
            // Additional: BatchCreateNotesAsync(ProjectName, IDictionary<string,Note>, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note> { { "", new Note() }, };
            // Make the request
            BatchCreateNotesResponse response = await grafeasClient.BatchCreateNotesAsync(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNoteRequestObject()
        {
            string endpoint = "";
            // Snippet: UpdateNote(UpdateNoteRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Note response = grafeasClient.UpdateNote(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: UpdateNoteAsync(UpdateNoteRequest, CallSettings)
            // Additional: UpdateNoteAsync(UpdateNoteRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Note response = await grafeasClient.UpdateNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNote()
        {
            string endpoint = "";
            // Snippet: UpdateNote(string, Note, FieldMask, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = grafeasClient.UpdateNote(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteAsync()
        {
            string endpoint = "";
            // Snippet: UpdateNoteAsync(string, Note, FieldMask, CallSettings)
            // Additional: UpdateNoteAsync(string, Note, FieldMask, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = await grafeasClient.UpdateNoteAsync(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNoteResourceNames()
        {
            string endpoint = "";
            // Snippet: UpdateNote(NoteName, Note, FieldMask, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = grafeasClient.UpdateNote(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: UpdateNoteAsync(NoteName, Note, FieldMask, CallSettings)
            // Additional: UpdateNoteAsync(NoteName, Note, FieldMask, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = await grafeasClient.UpdateNoteAsync(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrencesRequestObject()
        {
            string endpoint = "";
            // Snippet: ListNoteOccurrences(ListNoteOccurrencesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response = grafeasClient.ListNoteOccurrences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNoteOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesRequestObjectAsync()
        {
            string endpoint = "";
            // Snippet: ListNoteOccurrencesAsync(ListNoteOccurrencesRequest, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response = grafeasClient.ListNoteOccurrencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNoteOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrences()
        {
            string endpoint = "";
            // Snippet: ListNoteOccurrences(string, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response = grafeasClient.ListNoteOccurrences(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNoteOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesAsync()
        {
            string endpoint = "";
            // Snippet: ListNoteOccurrencesAsync(string, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/notes/[NOTE]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response = grafeasClient.ListNoteOccurrencesAsync(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNoteOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrencesResourceNames()
        {
            string endpoint = "";
            // Snippet: ListNoteOccurrences(NoteName, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response = grafeasClient.ListNoteOccurrences(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Occurrence item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNoteOccurrencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesResourceNamesAsync()
        {
            string endpoint = "";
            // Snippet: ListNoteOccurrencesAsync(NoteName, string, string, int?, CallSettings)
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            NoteName name = NoteName.FromProjectNote("[PROJECT]", "[NOTE]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response = grafeasClient.ListNoteOccurrencesAsync(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Occurrence item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNoteOccurrencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Occurrence item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Occurrence> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Occurrence item in singlePage)
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
