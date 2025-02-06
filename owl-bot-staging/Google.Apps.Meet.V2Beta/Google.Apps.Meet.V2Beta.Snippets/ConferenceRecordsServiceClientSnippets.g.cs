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
    using Google.Apps.Meet.V2Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConferenceRecordsServiceClientSnippets
    {
        /// <summary>Snippet for GetConferenceRecord</summary>
        public void GetConferenceRecordRequestObject()
        {
            // Snippet: GetConferenceRecord(GetConferenceRecordRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            GetConferenceRecordRequest request = new GetConferenceRecordRequest
            {
                ConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
            };
            // Make the request
            ConferenceRecord response = conferenceRecordsServiceClient.GetConferenceRecord(request);
            // End snippet
        }

        /// <summary>Snippet for GetConferenceRecordAsync</summary>
        public async Task GetConferenceRecordRequestObjectAsync()
        {
            // Snippet: GetConferenceRecordAsync(GetConferenceRecordRequest, CallSettings)
            // Additional: GetConferenceRecordAsync(GetConferenceRecordRequest, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConferenceRecordRequest request = new GetConferenceRecordRequest
            {
                ConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
            };
            // Make the request
            ConferenceRecord response = await conferenceRecordsServiceClient.GetConferenceRecordAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConferenceRecord</summary>
        public void GetConferenceRecord()
        {
            // Snippet: GetConferenceRecord(string, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            ConferenceRecord response = conferenceRecordsServiceClient.GetConferenceRecord(name);
            // End snippet
        }

        /// <summary>Snippet for GetConferenceRecordAsync</summary>
        public async Task GetConferenceRecordAsync()
        {
            // Snippet: GetConferenceRecordAsync(string, CallSettings)
            // Additional: GetConferenceRecordAsync(string, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            ConferenceRecord response = await conferenceRecordsServiceClient.GetConferenceRecordAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConferenceRecord</summary>
        public void GetConferenceRecordResourceNames()
        {
            // Snippet: GetConferenceRecord(ConferenceRecordName, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ConferenceRecordName name = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            ConferenceRecord response = conferenceRecordsServiceClient.GetConferenceRecord(name);
            // End snippet
        }

        /// <summary>Snippet for GetConferenceRecordAsync</summary>
        public async Task GetConferenceRecordResourceNamesAsync()
        {
            // Snippet: GetConferenceRecordAsync(ConferenceRecordName, CallSettings)
            // Additional: GetConferenceRecordAsync(ConferenceRecordName, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConferenceRecordName name = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            ConferenceRecord response = await conferenceRecordsServiceClient.GetConferenceRecordAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConferenceRecords</summary>
        public void ListConferenceRecordsRequestObject()
        {
            // Snippet: ListConferenceRecords(ListConferenceRecordsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ListConferenceRecordsRequest request = new ListConferenceRecordsRequest { Filter = "", };
            // Make the request
            PagedEnumerable<ListConferenceRecordsResponse, ConferenceRecord> response = conferenceRecordsServiceClient.ListConferenceRecords(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConferenceRecord item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConferenceRecordsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConferenceRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConferenceRecord> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConferenceRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConferenceRecordsAsync</summary>
        public async Task ListConferenceRecordsRequestObjectAsync()
        {
            // Snippet: ListConferenceRecordsAsync(ListConferenceRecordsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConferenceRecordsRequest request = new ListConferenceRecordsRequest { Filter = "", };
            // Make the request
            PagedAsyncEnumerable<ListConferenceRecordsResponse, ConferenceRecord> response = conferenceRecordsServiceClient.ListConferenceRecordsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConferenceRecord item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConferenceRecordsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConferenceRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConferenceRecord> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConferenceRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetParticipant</summary>
        public void GetParticipantRequestObject()
        {
            // Snippet: GetParticipant(GetParticipantRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]"),
            };
            // Make the request
            Participant response = conferenceRecordsServiceClient.GetParticipant(request);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantAsync</summary>
        public async Task GetParticipantRequestObjectAsync()
        {
            // Snippet: GetParticipantAsync(GetParticipantRequest, CallSettings)
            // Additional: GetParticipantAsync(GetParticipantRequest, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]"),
            };
            // Make the request
            Participant response = await conferenceRecordsServiceClient.GetParticipantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetParticipant</summary>
        public void GetParticipant()
        {
            // Snippet: GetParticipant(string, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/participants/[PARTICIPANT]";
            // Make the request
            Participant response = conferenceRecordsServiceClient.GetParticipant(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantAsync</summary>
        public async Task GetParticipantAsync()
        {
            // Snippet: GetParticipantAsync(string, CallSettings)
            // Additional: GetParticipantAsync(string, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/participants/[PARTICIPANT]";
            // Make the request
            Participant response = await conferenceRecordsServiceClient.GetParticipantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipant</summary>
        public void GetParticipantResourceNames()
        {
            // Snippet: GetParticipant(ParticipantName, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ParticipantName name = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]");
            // Make the request
            Participant response = conferenceRecordsServiceClient.GetParticipant(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantAsync</summary>
        public async Task GetParticipantResourceNamesAsync()
        {
            // Snippet: GetParticipantAsync(ParticipantName, CallSettings)
            // Additional: GetParticipantAsync(ParticipantName, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName name = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]");
            // Make the request
            Participant response = await conferenceRecordsServiceClient.GetParticipantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListParticipants</summary>
        public void ListParticipantsRequestObject()
        {
            // Snippet: ListParticipants(ListParticipantsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ListParticipantsRequest request = new ListParticipantsRequest
            {
                ParentAsConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListParticipantsResponse, Participant> response = conferenceRecordsServiceClient.ListParticipants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Participant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantsAsync</summary>
        public async Task ListParticipantsRequestObjectAsync()
        {
            // Snippet: ListParticipantsAsync(ListParticipantsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListParticipantsRequest request = new ListParticipantsRequest
            {
                ParentAsConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListParticipantsResponse, Participant> response = conferenceRecordsServiceClient.ListParticipantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Participant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipants</summary>
        public void ListParticipants()
        {
            // Snippet: ListParticipants(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            PagedEnumerable<ListParticipantsResponse, Participant> response = conferenceRecordsServiceClient.ListParticipants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Participant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantsAsync</summary>
        public async Task ListParticipantsAsync()
        {
            // Snippet: ListParticipantsAsync(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            PagedAsyncEnumerable<ListParticipantsResponse, Participant> response = conferenceRecordsServiceClient.ListParticipantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Participant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipants</summary>
        public void ListParticipantsResourceNames()
        {
            // Snippet: ListParticipants(ConferenceRecordName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ConferenceRecordName parent = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            PagedEnumerable<ListParticipantsResponse, Participant> response = conferenceRecordsServiceClient.ListParticipants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Participant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantsAsync</summary>
        public async Task ListParticipantsResourceNamesAsync()
        {
            // Snippet: ListParticipantsAsync(ConferenceRecordName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConferenceRecordName parent = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            PagedAsyncEnumerable<ListParticipantsResponse, Participant> response = conferenceRecordsServiceClient.ListParticipantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Participant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetParticipantSession</summary>
        public void GetParticipantSessionRequestObject()
        {
            // Snippet: GetParticipantSession(GetParticipantSessionRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            GetParticipantSessionRequest request = new GetParticipantSessionRequest
            {
                ParticipantSessionName = ParticipantSessionName.FromConferenceRecordParticipantParticipantSession("[CONFERENCE_RECORD]", "[PARTICIPANT]", "[PARTICIPANT_SESSION]"),
            };
            // Make the request
            ParticipantSession response = conferenceRecordsServiceClient.GetParticipantSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantSessionAsync</summary>
        public async Task GetParticipantSessionRequestObjectAsync()
        {
            // Snippet: GetParticipantSessionAsync(GetParticipantSessionRequest, CallSettings)
            // Additional: GetParticipantSessionAsync(GetParticipantSessionRequest, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetParticipantSessionRequest request = new GetParticipantSessionRequest
            {
                ParticipantSessionName = ParticipantSessionName.FromConferenceRecordParticipantParticipantSession("[CONFERENCE_RECORD]", "[PARTICIPANT]", "[PARTICIPANT_SESSION]"),
            };
            // Make the request
            ParticipantSession response = await conferenceRecordsServiceClient.GetParticipantSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantSession</summary>
        public void GetParticipantSession()
        {
            // Snippet: GetParticipantSession(string, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/participants/[PARTICIPANT]/participantSessions/[PARTICIPANT_SESSION]";
            // Make the request
            ParticipantSession response = conferenceRecordsServiceClient.GetParticipantSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantSessionAsync</summary>
        public async Task GetParticipantSessionAsync()
        {
            // Snippet: GetParticipantSessionAsync(string, CallSettings)
            // Additional: GetParticipantSessionAsync(string, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/participants/[PARTICIPANT]/participantSessions/[PARTICIPANT_SESSION]";
            // Make the request
            ParticipantSession response = await conferenceRecordsServiceClient.GetParticipantSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantSession</summary>
        public void GetParticipantSessionResourceNames()
        {
            // Snippet: GetParticipantSession(ParticipantSessionName, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ParticipantSessionName name = ParticipantSessionName.FromConferenceRecordParticipantParticipantSession("[CONFERENCE_RECORD]", "[PARTICIPANT]", "[PARTICIPANT_SESSION]");
            // Make the request
            ParticipantSession response = conferenceRecordsServiceClient.GetParticipantSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantSessionAsync</summary>
        public async Task GetParticipantSessionResourceNamesAsync()
        {
            // Snippet: GetParticipantSessionAsync(ParticipantSessionName, CallSettings)
            // Additional: GetParticipantSessionAsync(ParticipantSessionName, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantSessionName name = ParticipantSessionName.FromConferenceRecordParticipantParticipantSession("[CONFERENCE_RECORD]", "[PARTICIPANT]", "[PARTICIPANT_SESSION]");
            // Make the request
            ParticipantSession response = await conferenceRecordsServiceClient.GetParticipantSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListParticipantSessions</summary>
        public void ListParticipantSessionsRequestObject()
        {
            // Snippet: ListParticipantSessions(ListParticipantSessionsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ListParticipantSessionsRequest request = new ListParticipantSessionsRequest
            {
                ParentAsParticipantName = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> response = conferenceRecordsServiceClient.ListParticipantSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ParticipantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParticipantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParticipantSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParticipantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantSessionsAsync</summary>
        public async Task ListParticipantSessionsRequestObjectAsync()
        {
            // Snippet: ListParticipantSessionsAsync(ListParticipantSessionsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListParticipantSessionsRequest request = new ListParticipantSessionsRequest
            {
                ParentAsParticipantName = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> response = conferenceRecordsServiceClient.ListParticipantSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ParticipantSession item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParticipantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParticipantSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParticipantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantSessions</summary>
        public void ListParticipantSessions()
        {
            // Snippet: ListParticipantSessions(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]/participants/[PARTICIPANT]";
            // Make the request
            PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> response = conferenceRecordsServiceClient.ListParticipantSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ParticipantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParticipantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParticipantSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParticipantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantSessionsAsync</summary>
        public async Task ListParticipantSessionsAsync()
        {
            // Snippet: ListParticipantSessionsAsync(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]/participants/[PARTICIPANT]";
            // Make the request
            PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> response = conferenceRecordsServiceClient.ListParticipantSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ParticipantSession item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParticipantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParticipantSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParticipantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantSessions</summary>
        public void ListParticipantSessionsResourceNames()
        {
            // Snippet: ListParticipantSessions(ParticipantName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]");
            // Make the request
            PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> response = conferenceRecordsServiceClient.ListParticipantSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ParticipantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParticipantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParticipantSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParticipantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantSessionsAsync</summary>
        public async Task ListParticipantSessionsResourceNamesAsync()
        {
            // Snippet: ListParticipantSessionsAsync(ParticipantName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromConferenceRecordParticipant("[CONFERENCE_RECORD]", "[PARTICIPANT]");
            // Make the request
            PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> response = conferenceRecordsServiceClient.ListParticipantSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ParticipantSession item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParticipantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParticipantSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParticipantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRecording</summary>
        public void GetRecordingRequestObject()
        {
            // Snippet: GetRecording(GetRecordingRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromConferenceRecordRecording("[CONFERENCE_RECORD]", "[RECORDING]"),
            };
            // Make the request
            Recording response = conferenceRecordsServiceClient.GetRecording(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecordingAsync</summary>
        public async Task GetRecordingRequestObjectAsync()
        {
            // Snippet: GetRecordingAsync(GetRecordingRequest, CallSettings)
            // Additional: GetRecordingAsync(GetRecordingRequest, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRecordingRequest request = new GetRecordingRequest
            {
                RecordingName = RecordingName.FromConferenceRecordRecording("[CONFERENCE_RECORD]", "[RECORDING]"),
            };
            // Make the request
            Recording response = await conferenceRecordsServiceClient.GetRecordingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRecording</summary>
        public void GetRecording()
        {
            // Snippet: GetRecording(string, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/recordings/[RECORDING]";
            // Make the request
            Recording response = conferenceRecordsServiceClient.GetRecording(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecordingAsync</summary>
        public async Task GetRecordingAsync()
        {
            // Snippet: GetRecordingAsync(string, CallSettings)
            // Additional: GetRecordingAsync(string, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/recordings/[RECORDING]";
            // Make the request
            Recording response = await conferenceRecordsServiceClient.GetRecordingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecording</summary>
        public void GetRecordingResourceNames()
        {
            // Snippet: GetRecording(RecordingName, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            RecordingName name = RecordingName.FromConferenceRecordRecording("[CONFERENCE_RECORD]", "[RECORDING]");
            // Make the request
            Recording response = conferenceRecordsServiceClient.GetRecording(name);
            // End snippet
        }

        /// <summary>Snippet for GetRecordingAsync</summary>
        public async Task GetRecordingResourceNamesAsync()
        {
            // Snippet: GetRecordingAsync(RecordingName, CallSettings)
            // Additional: GetRecordingAsync(RecordingName, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RecordingName name = RecordingName.FromConferenceRecordRecording("[CONFERENCE_RECORD]", "[RECORDING]");
            // Make the request
            Recording response = await conferenceRecordsServiceClient.GetRecordingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRecordings</summary>
        public void ListRecordingsRequestObject()
        {
            // Snippet: ListRecordings(ListRecordingsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ListRecordingsRequest request = new ListRecordingsRequest
            {
                ParentAsConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
            };
            // Make the request
            PagedEnumerable<ListRecordingsResponse, Recording> response = conferenceRecordsServiceClient.ListRecordings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recording item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecordingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordingsAsync</summary>
        public async Task ListRecordingsRequestObjectAsync()
        {
            // Snippet: ListRecordingsAsync(ListRecordingsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRecordingsRequest request = new ListRecordingsRequest
            {
                ParentAsConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRecordingsResponse, Recording> response = conferenceRecordsServiceClient.ListRecordingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recording item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecordingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordings</summary>
        public void ListRecordings()
        {
            // Snippet: ListRecordings(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            PagedEnumerable<ListRecordingsResponse, Recording> response = conferenceRecordsServiceClient.ListRecordings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recording item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecordingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordingsAsync</summary>
        public async Task ListRecordingsAsync()
        {
            // Snippet: ListRecordingsAsync(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            PagedAsyncEnumerable<ListRecordingsResponse, Recording> response = conferenceRecordsServiceClient.ListRecordingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recording item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecordingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordings</summary>
        public void ListRecordingsResourceNames()
        {
            // Snippet: ListRecordings(ConferenceRecordName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ConferenceRecordName parent = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            PagedEnumerable<ListRecordingsResponse, Recording> response = conferenceRecordsServiceClient.ListRecordings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Recording item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRecordingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRecordingsAsync</summary>
        public async Task ListRecordingsResourceNamesAsync()
        {
            // Snippet: ListRecordingsAsync(ConferenceRecordName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConferenceRecordName parent = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            PagedAsyncEnumerable<ListRecordingsResponse, Recording> response = conferenceRecordsServiceClient.ListRecordingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Recording item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRecordingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Recording item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Recording> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Recording item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTranscript</summary>
        public void GetTranscriptRequestObject()
        {
            // Snippet: GetTranscript(GetTranscriptRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            GetTranscriptRequest request = new GetTranscriptRequest
            {
                TranscriptName = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]"),
            };
            // Make the request
            Transcript response = conferenceRecordsServiceClient.GetTranscript(request);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptAsync</summary>
        public async Task GetTranscriptRequestObjectAsync()
        {
            // Snippet: GetTranscriptAsync(GetTranscriptRequest, CallSettings)
            // Additional: GetTranscriptAsync(GetTranscriptRequest, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTranscriptRequest request = new GetTranscriptRequest
            {
                TranscriptName = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]"),
            };
            // Make the request
            Transcript response = await conferenceRecordsServiceClient.GetTranscriptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTranscript</summary>
        public void GetTranscript()
        {
            // Snippet: GetTranscript(string, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/transcripts/[TRANSCRIPT]";
            // Make the request
            Transcript response = conferenceRecordsServiceClient.GetTranscript(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptAsync</summary>
        public async Task GetTranscriptAsync()
        {
            // Snippet: GetTranscriptAsync(string, CallSettings)
            // Additional: GetTranscriptAsync(string, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/transcripts/[TRANSCRIPT]";
            // Make the request
            Transcript response = await conferenceRecordsServiceClient.GetTranscriptAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscript</summary>
        public void GetTranscriptResourceNames()
        {
            // Snippet: GetTranscript(TranscriptName, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            TranscriptName name = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]");
            // Make the request
            Transcript response = conferenceRecordsServiceClient.GetTranscript(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptAsync</summary>
        public async Task GetTranscriptResourceNamesAsync()
        {
            // Snippet: GetTranscriptAsync(TranscriptName, CallSettings)
            // Additional: GetTranscriptAsync(TranscriptName, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            TranscriptName name = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]");
            // Make the request
            Transcript response = await conferenceRecordsServiceClient.GetTranscriptAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTranscripts</summary>
        public void ListTranscriptsRequestObject()
        {
            // Snippet: ListTranscripts(ListTranscriptsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ListTranscriptsRequest request = new ListTranscriptsRequest
            {
                ParentAsConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
            };
            // Make the request
            PagedEnumerable<ListTranscriptsResponse, Transcript> response = conferenceRecordsServiceClient.ListTranscripts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transcript item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcript item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcript> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcript item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptsAsync</summary>
        public async Task ListTranscriptsRequestObjectAsync()
        {
            // Snippet: ListTranscriptsAsync(ListTranscriptsRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTranscriptsRequest request = new ListTranscriptsRequest
            {
                ParentAsConferenceRecordName = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> response = conferenceRecordsServiceClient.ListTranscriptsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Transcript item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcript item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcript> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcript item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscripts</summary>
        public void ListTranscripts()
        {
            // Snippet: ListTranscripts(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            PagedEnumerable<ListTranscriptsResponse, Transcript> response = conferenceRecordsServiceClient.ListTranscripts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transcript item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcript item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcript> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcript item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptsAsync</summary>
        public async Task ListTranscriptsAsync()
        {
            // Snippet: ListTranscriptsAsync(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]";
            // Make the request
            PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> response = conferenceRecordsServiceClient.ListTranscriptsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Transcript item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcript item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcript> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcript item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscripts</summary>
        public void ListTranscriptsResourceNames()
        {
            // Snippet: ListTranscripts(ConferenceRecordName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ConferenceRecordName parent = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            PagedEnumerable<ListTranscriptsResponse, Transcript> response = conferenceRecordsServiceClient.ListTranscripts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transcript item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcript item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcript> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcript item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptsAsync</summary>
        public async Task ListTranscriptsResourceNamesAsync()
        {
            // Snippet: ListTranscriptsAsync(ConferenceRecordName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConferenceRecordName parent = ConferenceRecordName.FromConferenceRecord("[CONFERENCE_RECORD]");
            // Make the request
            PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> response = conferenceRecordsServiceClient.ListTranscriptsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Transcript item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transcript item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transcript> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transcript item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptEntry</summary>
        public void GetTranscriptEntryRequestObject()
        {
            // Snippet: GetTranscriptEntry(GetTranscriptEntryRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            GetTranscriptEntryRequest request = new GetTranscriptEntryRequest
            {
                TranscriptEntryName = TranscriptEntryName.FromConferenceRecordTranscriptEntry("[CONFERENCE_RECORD]", "[TRANSCRIPT]", "[ENTRY]"),
            };
            // Make the request
            TranscriptEntry response = conferenceRecordsServiceClient.GetTranscriptEntry(request);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptEntryAsync</summary>
        public async Task GetTranscriptEntryRequestObjectAsync()
        {
            // Snippet: GetTranscriptEntryAsync(GetTranscriptEntryRequest, CallSettings)
            // Additional: GetTranscriptEntryAsync(GetTranscriptEntryRequest, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTranscriptEntryRequest request = new GetTranscriptEntryRequest
            {
                TranscriptEntryName = TranscriptEntryName.FromConferenceRecordTranscriptEntry("[CONFERENCE_RECORD]", "[TRANSCRIPT]", "[ENTRY]"),
            };
            // Make the request
            TranscriptEntry response = await conferenceRecordsServiceClient.GetTranscriptEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptEntry</summary>
        public void GetTranscriptEntry()
        {
            // Snippet: GetTranscriptEntry(string, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/transcripts/[TRANSCRIPT]/entries/[ENTRY]";
            // Make the request
            TranscriptEntry response = conferenceRecordsServiceClient.GetTranscriptEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptEntryAsync</summary>
        public async Task GetTranscriptEntryAsync()
        {
            // Snippet: GetTranscriptEntryAsync(string, CallSettings)
            // Additional: GetTranscriptEntryAsync(string, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "conferenceRecords/[CONFERENCE_RECORD]/transcripts/[TRANSCRIPT]/entries/[ENTRY]";
            // Make the request
            TranscriptEntry response = await conferenceRecordsServiceClient.GetTranscriptEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptEntry</summary>
        public void GetTranscriptEntryResourceNames()
        {
            // Snippet: GetTranscriptEntry(TranscriptEntryName, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            TranscriptEntryName name = TranscriptEntryName.FromConferenceRecordTranscriptEntry("[CONFERENCE_RECORD]", "[TRANSCRIPT]", "[ENTRY]");
            // Make the request
            TranscriptEntry response = conferenceRecordsServiceClient.GetTranscriptEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetTranscriptEntryAsync</summary>
        public async Task GetTranscriptEntryResourceNamesAsync()
        {
            // Snippet: GetTranscriptEntryAsync(TranscriptEntryName, CallSettings)
            // Additional: GetTranscriptEntryAsync(TranscriptEntryName, CancellationToken)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            TranscriptEntryName name = TranscriptEntryName.FromConferenceRecordTranscriptEntry("[CONFERENCE_RECORD]", "[TRANSCRIPT]", "[ENTRY]");
            // Make the request
            TranscriptEntry response = await conferenceRecordsServiceClient.GetTranscriptEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptEntries</summary>
        public void ListTranscriptEntriesRequestObject()
        {
            // Snippet: ListTranscriptEntries(ListTranscriptEntriesRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            ListTranscriptEntriesRequest request = new ListTranscriptEntriesRequest
            {
                ParentAsTranscriptName = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]"),
            };
            // Make the request
            PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> response = conferenceRecordsServiceClient.ListTranscriptEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TranscriptEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TranscriptEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TranscriptEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TranscriptEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptEntriesAsync</summary>
        public async Task ListTranscriptEntriesRequestObjectAsync()
        {
            // Snippet: ListTranscriptEntriesAsync(ListTranscriptEntriesRequest, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTranscriptEntriesRequest request = new ListTranscriptEntriesRequest
            {
                ParentAsTranscriptName = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> response = conferenceRecordsServiceClient.ListTranscriptEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TranscriptEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TranscriptEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TranscriptEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TranscriptEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptEntries</summary>
        public void ListTranscriptEntries()
        {
            // Snippet: ListTranscriptEntries(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]/transcripts/[TRANSCRIPT]";
            // Make the request
            PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> response = conferenceRecordsServiceClient.ListTranscriptEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TranscriptEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TranscriptEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TranscriptEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TranscriptEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptEntriesAsync</summary>
        public async Task ListTranscriptEntriesAsync()
        {
            // Snippet: ListTranscriptEntriesAsync(string, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "conferenceRecords/[CONFERENCE_RECORD]/transcripts/[TRANSCRIPT]";
            // Make the request
            PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> response = conferenceRecordsServiceClient.ListTranscriptEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TranscriptEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TranscriptEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TranscriptEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TranscriptEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptEntries</summary>
        public void ListTranscriptEntriesResourceNames()
        {
            // Snippet: ListTranscriptEntries(TranscriptName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = ConferenceRecordsServiceClient.Create();
            // Initialize request argument(s)
            TranscriptName parent = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]");
            // Make the request
            PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> response = conferenceRecordsServiceClient.ListTranscriptEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TranscriptEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTranscriptEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TranscriptEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TranscriptEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TranscriptEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTranscriptEntriesAsync</summary>
        public async Task ListTranscriptEntriesResourceNamesAsync()
        {
            // Snippet: ListTranscriptEntriesAsync(TranscriptName, string, int?, CallSettings)
            // Create client
            ConferenceRecordsServiceClient conferenceRecordsServiceClient = await ConferenceRecordsServiceClient.CreateAsync();
            // Initialize request argument(s)
            TranscriptName parent = TranscriptName.FromConferenceRecordTranscript("[CONFERENCE_RECORD]", "[TRANSCRIPT]");
            // Make the request
            PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> response = conferenceRecordsServiceClient.ListTranscriptEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TranscriptEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTranscriptEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TranscriptEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TranscriptEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TranscriptEntry item in singlePage)
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
