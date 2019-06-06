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

namespace Grafeas.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using apis = global::Grafeas.V1;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedGrafeasClientSnippets
    {
        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceAsync()
        {
            Channel channel = null;
            // Snippet: GetOccurrenceAsync(OccurrenceName,CallSettings)
            // Additional: GetOccurrenceAsync(OccurrenceName,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Occurrence response = await grafeasClient.GetOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrence()
        {
            Channel channel = null;
            // Snippet: GetOccurrence(OccurrenceName,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Occurrence response = grafeasClient.GetOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceAsync</summary>
        public async Task GetOccurrenceAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: GetOccurrenceAsync(GetOccurrenceRequest,CallSettings)
            // Additional: GetOccurrenceAsync(GetOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Occurrence response = await grafeasClient.GetOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrence</summary>
        public void GetOccurrence_RequestObject()
        {
            Channel channel = null;
            // Snippet: GetOccurrence(GetOccurrenceRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            GetOccurrenceRequest request = new GetOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Occurrence response = grafeasClient.GetOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesAsync()
        {
            Channel channel = null;
            // Snippet: ListOccurrencesAsync(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasClient.ListOccurrencesAsync(parent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrences()
        {
            Channel channel = null;
            // Snippet: ListOccurrences(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasClient.ListOccurrences(parent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrencesAsync</summary>
        public async Task ListOccurrencesAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: ListOccurrencesAsync(ListOccurrencesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasClient.ListOccurrencesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOccurrences</summary>
        public void ListOccurrences_RequestObject()
        {
            Channel channel = null;
            // Snippet: ListOccurrences(ListOccurrencesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListOccurrencesResponse, Occurrence> response =
                grafeasClient.ListOccurrences(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceAsync()
        {
            Channel channel = null;
            // Snippet: DeleteOccurrenceAsync(OccurrenceName,CallSettings)
            // Additional: DeleteOccurrenceAsync(OccurrenceName,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            await grafeasClient.DeleteOccurrenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrence()
        {
            Channel channel = null;
            // Snippet: DeleteOccurrence(OccurrenceName,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            grafeasClient.DeleteOccurrence(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrenceAsync</summary>
        public async Task DeleteOccurrenceAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: DeleteOccurrenceAsync(DeleteOccurrenceRequest,CallSettings)
            // Additional: DeleteOccurrenceAsync(DeleteOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            await grafeasClient.DeleteOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOccurrence</summary>
        public void DeleteOccurrence_RequestObject()
        {
            Channel channel = null;
            // Snippet: DeleteOccurrence(DeleteOccurrenceRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            DeleteOccurrenceRequest request = new DeleteOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            grafeasClient.DeleteOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceAsync()
        {
            Channel channel = null;
            // Snippet: CreateOccurrenceAsync(ProjectName,Occurrence,CallSettings)
            // Additional: CreateOccurrenceAsync(ProjectName,Occurrence,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = await grafeasClient.CreateOccurrenceAsync(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrence()
        {
            Channel channel = null;
            // Snippet: CreateOccurrence(ProjectName,Occurrence,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Occurrence occurrence = new Occurrence();
            // Make the request
            Occurrence response = grafeasClient.CreateOccurrence(parent, occurrence);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrenceAsync</summary>
        public async Task CreateOccurrenceAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: CreateOccurrenceAsync(CreateOccurrenceRequest,CallSettings)
            // Additional: CreateOccurrenceAsync(CreateOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = await grafeasClient.CreateOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOccurrence</summary>
        public void CreateOccurrence_RequestObject()
        {
            Channel channel = null;
            // Snippet: CreateOccurrence(CreateOccurrenceRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            CreateOccurrenceRequest request = new CreateOccurrenceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = grafeasClient.CreateOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesAsync()
        {
            Channel channel = null;
            // Snippet: BatchCreateOccurrencesAsync(ProjectName,IEnumerable<Occurrence>,CallSettings)
            // Additional: BatchCreateOccurrencesAsync(ProjectName,IEnumerable<Occurrence>,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new List<Occurrence>();
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasClient.BatchCreateOccurrencesAsync(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrences()
        {
            Channel channel = null;
            // Snippet: BatchCreateOccurrences(ProjectName,IEnumerable<Occurrence>,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IEnumerable<Occurrence> occurrences = new List<Occurrence>();
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasClient.BatchCreateOccurrences(parent, occurrences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest,CallSettings)
            // Additional: BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasClient.BatchCreateOccurrencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOccurrences</summary>
        public void BatchCreateOccurrences_RequestObject()
        {
            Channel channel = null;
            // Snippet: BatchCreateOccurrences(BatchCreateOccurrencesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            BatchCreateOccurrencesRequest request = new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Occurrences = { },
            };
            // Make the request
            BatchCreateOccurrencesResponse response = grafeasClient.BatchCreateOccurrences(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceAsync()
        {
            Channel channel = null;
            // Snippet: UpdateOccurrenceAsync(OccurrenceName,Occurrence,FieldMask,CallSettings)
            // Additional: UpdateOccurrenceAsync(OccurrenceName,Occurrence,FieldMask,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = await grafeasClient.UpdateOccurrenceAsync(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrence()
        {
            Channel channel = null;
            // Snippet: UpdateOccurrence(OccurrenceName,Occurrence,FieldMask,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            Occurrence occurrence = new Occurrence();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Occurrence response = grafeasClient.UpdateOccurrence(name, occurrence, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: UpdateOccurrenceAsync(UpdateOccurrenceRequest,CallSettings)
            // Additional: UpdateOccurrenceAsync(UpdateOccurrenceRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = await grafeasClient.UpdateOccurrenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOccurrence</summary>
        public void UpdateOccurrence_RequestObject()
        {
            Channel channel = null;
            // Snippet: UpdateOccurrence(UpdateOccurrenceRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
            };
            // Make the request
            Occurrence response = grafeasClient.UpdateOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteAsync()
        {
            Channel channel = null;
            // Snippet: GetOccurrenceNoteAsync(OccurrenceName,CallSettings)
            // Additional: GetOccurrenceNoteAsync(OccurrenceName,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Note response = await grafeasClient.GetOccurrenceNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNote()
        {
            Channel channel = null;
            // Snippet: GetOccurrenceNote(OccurrenceName,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            OccurrenceName name = new OccurrenceName("[PROJECT]", "[OCCURRENCE]");
            // Make the request
            Note response = grafeasClient.GetOccurrenceNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNoteAsync</summary>
        public async Task GetOccurrenceNoteAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: GetOccurrenceNoteAsync(GetOccurrenceNoteRequest,CallSettings)
            // Additional: GetOccurrenceNoteAsync(GetOccurrenceNoteRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Note response = await grafeasClient.GetOccurrenceNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOccurrenceNote</summary>
        public void GetOccurrenceNote_RequestObject()
        {
            Channel channel = null;
            // Snippet: GetOccurrenceNote(GetOccurrenceNoteRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            GetOccurrenceNoteRequest request = new GetOccurrenceNoteRequest
            {
                OccurrenceName = new OccurrenceName("[PROJECT]", "[OCCURRENCE]"),
            };
            // Make the request
            Note response = grafeasClient.GetOccurrenceNote(request);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteAsync()
        {
            Channel channel = null;
            // Snippet: GetNoteAsync(NoteName,CallSettings)
            // Additional: GetNoteAsync(NoteName,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            Note response = await grafeasClient.GetNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNote()
        {
            Channel channel = null;
            // Snippet: GetNote(NoteName,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            Note response = grafeasClient.GetNote(name);
            // End snippet
        }

        /// <summary>Snippet for GetNoteAsync</summary>
        public async Task GetNoteAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: GetNoteAsync(GetNoteRequest,CallSettings)
            // Additional: GetNoteAsync(GetNoteRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            Note response = await grafeasClient.GetNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNote</summary>
        public void GetNote_RequestObject()
        {
            Channel channel = null;
            // Snippet: GetNote(GetNoteRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            GetNoteRequest request = new GetNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            Note response = grafeasClient.GetNote(request);
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesAsync()
        {
            Channel channel = null;
            // Snippet: ListNotesAsync(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response =
                grafeasClient.ListNotesAsync(parent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotes()
        {
            Channel channel = null;
            // Snippet: ListNotes(ProjectName,string,string,int?,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response =
                grafeasClient.ListNotes(parent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotesAsync</summary>
        public async Task ListNotesAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: ListNotesAsync(ListNotesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNotesResponse, Note> response =
                grafeasClient.ListNotesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNotes</summary>
        public void ListNotes_RequestObject()
        {
            Channel channel = null;
            // Snippet: ListNotes(ListNotesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListNotesResponse, Note> response =
                grafeasClient.ListNotes(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteAsync()
        {
            Channel channel = null;
            // Snippet: DeleteNoteAsync(NoteName,CallSettings)
            // Additional: DeleteNoteAsync(NoteName,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            await grafeasClient.DeleteNoteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNote()
        {
            Channel channel = null;
            // Snippet: DeleteNote(NoteName,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            // Make the request
            grafeasClient.DeleteNote(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNoteAsync</summary>
        public async Task DeleteNoteAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: DeleteNoteAsync(DeleteNoteRequest,CallSettings)
            // Additional: DeleteNoteAsync(DeleteNoteRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            await grafeasClient.DeleteNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNote</summary>
        public void DeleteNote_RequestObject()
        {
            Channel channel = null;
            // Snippet: DeleteNote(DeleteNoteRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            DeleteNoteRequest request = new DeleteNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            grafeasClient.DeleteNote(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteAsync()
        {
            Channel channel = null;
            // Snippet: CreateNoteAsync(ProjectName,string,Note,CallSettings)
            // Additional: CreateNoteAsync(ProjectName,string,Note,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = await grafeasClient.CreateNoteAsync(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNote()
        {
            Channel channel = null;
            // Snippet: CreateNote(ProjectName,string,Note,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string noteId = "";
            Note note = new Note();
            // Make the request
            Note response = grafeasClient.CreateNote(parent, noteId, note);
            // End snippet
        }

        /// <summary>Snippet for CreateNoteAsync</summary>
        public async Task CreateNoteAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: CreateNoteAsync(CreateNoteRequest,CallSettings)
            // Additional: CreateNoteAsync(CreateNoteRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "",
                Note = new Note(),
            };
            // Make the request
            Note response = await grafeasClient.CreateNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNote</summary>
        public void CreateNote_RequestObject()
        {
            Channel channel = null;
            // Snippet: CreateNote(CreateNoteRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            CreateNoteRequest request = new CreateNoteRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                NoteId = "",
                Note = new Note(),
            };
            // Make the request
            Note response = grafeasClient.CreateNote(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesAsync()
        {
            Channel channel = null;
            // Snippet: BatchCreateNotesAsync(ProjectName,IDictionary<string, Note>,CallSettings)
            // Additional: BatchCreateNotesAsync(ProjectName,IDictionary<string, Note>,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note>();
            // Make the request
            BatchCreateNotesResponse response = await grafeasClient.BatchCreateNotesAsync(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotes()
        {
            Channel channel = null;
            // Snippet: BatchCreateNotes(ProjectName,IDictionary<string, Note>,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note>();
            // Make the request
            BatchCreateNotesResponse response = grafeasClient.BatchCreateNotes(parent, notes);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: BatchCreateNotesAsync(BatchCreateNotesRequest,CallSettings)
            // Additional: BatchCreateNotesAsync(BatchCreateNotesRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            // Make the request
            BatchCreateNotesResponse response = await grafeasClient.BatchCreateNotesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateNotes</summary>
        public void BatchCreateNotes_RequestObject()
        {
            Channel channel = null;
            // Snippet: BatchCreateNotes(BatchCreateNotesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            BatchCreateNotesRequest request = new BatchCreateNotesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Notes = { },
            };
            // Make the request
            BatchCreateNotesResponse response = grafeasClient.BatchCreateNotes(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteAsync()
        {
            Channel channel = null;
            // Snippet: UpdateNoteAsync(NoteName,Note,FieldMask,CallSettings)
            // Additional: UpdateNoteAsync(NoteName,Note,FieldMask,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = await grafeasClient.UpdateNoteAsync(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNote()
        {
            Channel channel = null;
            // Snippet: UpdateNote(NoteName,Note,FieldMask,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            Note note = new Note();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Note response = grafeasClient.UpdateNote(name, note, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNoteAsync</summary>
        public async Task UpdateNoteAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: UpdateNoteAsync(UpdateNoteRequest,CallSettings)
            // Additional: UpdateNoteAsync(UpdateNoteRequest,CancellationToken)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
            };
            // Make the request
            Note response = await grafeasClient.UpdateNoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNote</summary>
        public void UpdateNote_RequestObject()
        {
            Channel channel = null;
            // Snippet: UpdateNote(UpdateNoteRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
                Note = new Note(),
            };
            // Make the request
            Note response = grafeasClient.UpdateNote(request);
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesAsync()
        {
            Channel channel = null;
            // Snippet: ListNoteOccurrencesAsync(NoteName,string,string,int?,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasClient.ListNoteOccurrencesAsync(name, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrences()
        {
            Channel channel = null;
            // Snippet: ListNoteOccurrences(NoteName,string,string,int?,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            NoteName name = new NoteName("[PROJECT]", "[NOTE]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasClient.ListNoteOccurrences(name, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrencesAsync</summary>
        public async Task ListNoteOccurrencesAsync_RequestObject()
        {
            Channel channel = null;
            // Snippet: ListNoteOccurrencesAsync(ListNoteOccurrencesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasClient.ListNoteOccurrencesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNoteOccurrences</summary>
        public void ListNoteOccurrences_RequestObject()
        {
            Channel channel = null;
            // Snippet: ListNoteOccurrences(ListNoteOccurrencesRequest,CallSettings)
            // Create client
            GrafeasClient grafeasClient = GrafeasClient.Create(channel);
            // Initialize request argument(s)
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = new NoteName("[PROJECT]", "[NOTE]"),
            };
            // Make the request
            PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> response =
                grafeasClient.ListNoteOccurrences(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
