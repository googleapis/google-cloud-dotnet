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
    using Google.Api;
    using Google.Api.Gax;
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserEventServiceClientSnippets
    {
        /// <summary>Snippet for WriteUserEvent</summary>
        public void WriteUserEventRequestObject()
        {
            // Snippet: WriteUserEvent(WriteUserEventRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent(),
            };
            // Make the request
            UserEvent response = userEventServiceClient.WriteUserEvent(request);
            // End snippet
        }

        /// <summary>Snippet for WriteUserEventAsync</summary>
        public async Task WriteUserEventRequestObjectAsync()
        {
            // Snippet: WriteUserEventAsync(WriteUserEventRequest, CallSettings)
            // Additional: WriteUserEventAsync(WriteUserEventRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent(),
            };
            // Make the request
            UserEvent response = await userEventServiceClient.WriteUserEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteUserEvent</summary>
        public void WriteUserEvent()
        {
            // Snippet: WriteUserEvent(string, UserEvent, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            UserEvent userEvent = new UserEvent();
            // Make the request
            UserEvent response = userEventServiceClient.WriteUserEvent(parent, userEvent);
            // End snippet
        }

        /// <summary>Snippet for WriteUserEventAsync</summary>
        public async Task WriteUserEventAsync()
        {
            // Snippet: WriteUserEventAsync(string, UserEvent, CallSettings)
            // Additional: WriteUserEventAsync(string, UserEvent, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            UserEvent userEvent = new UserEvent();
            // Make the request
            UserEvent response = await userEventServiceClient.WriteUserEventAsync(parent, userEvent);
            // End snippet
        }

        /// <summary>Snippet for WriteUserEvent</summary>
        public void WriteUserEventResourceNames()
        {
            // Snippet: WriteUserEvent(EventStoreName, UserEvent, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            UserEvent userEvent = new UserEvent();
            // Make the request
            UserEvent response = userEventServiceClient.WriteUserEvent(parent, userEvent);
            // End snippet
        }

        /// <summary>Snippet for WriteUserEventAsync</summary>
        public async Task WriteUserEventResourceNamesAsync()
        {
            // Snippet: WriteUserEventAsync(EventStoreName, UserEvent, CallSettings)
            // Additional: WriteUserEventAsync(EventStoreName, UserEvent, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            UserEvent userEvent = new UserEvent();
            // Make the request
            UserEvent response = await userEventServiceClient.WriteUserEventAsync(parent, userEvent);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEvent</summary>
        public void CollectUserEventRequestObject()
        {
            // Snippet: CollectUserEvent(CollectUserEventRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "",
                Uri = "",
                Ets = 0L,
            };
            // Make the request
            HttpBody response = userEventServiceClient.CollectUserEvent(request);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEventAsync</summary>
        public async Task CollectUserEventRequestObjectAsync()
        {
            // Snippet: CollectUserEventAsync(CollectUserEventRequest, CallSettings)
            // Additional: CollectUserEventAsync(CollectUserEventRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "",
                Uri = "",
                Ets = 0L,
            };
            // Make the request
            HttpBody response = await userEventServiceClient.CollectUserEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEvent</summary>
        public void CollectUserEvent()
        {
            // Snippet: CollectUserEvent(string, string, string, long, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string userEvent = "";
            string uri = "";
            long ets = 0L;
            // Make the request
            HttpBody response = userEventServiceClient.CollectUserEvent(parent, userEvent, uri, ets);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEventAsync</summary>
        public async Task CollectUserEventAsync()
        {
            // Snippet: CollectUserEventAsync(string, string, string, long, CallSettings)
            // Additional: CollectUserEventAsync(string, string, string, long, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string userEvent = "";
            string uri = "";
            long ets = 0L;
            // Make the request
            HttpBody response = await userEventServiceClient.CollectUserEventAsync(parent, userEvent, uri, ets);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEvent</summary>
        public void CollectUserEventResourceNames()
        {
            // Snippet: CollectUserEvent(EventStoreName, string, string, long, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string userEvent = "";
            string uri = "";
            long ets = 0L;
            // Make the request
            HttpBody response = userEventServiceClient.CollectUserEvent(parent, userEvent, uri, ets);
            // End snippet
        }

        /// <summary>Snippet for CollectUserEventAsync</summary>
        public async Task CollectUserEventResourceNamesAsync()
        {
            // Snippet: CollectUserEventAsync(EventStoreName, string, string, long, CallSettings)
            // Additional: CollectUserEventAsync(EventStoreName, string, string, long, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string userEvent = "";
            string uri = "";
            long ets = 0L;
            // Make the request
            HttpBody response = await userEventServiceClient.CollectUserEventAsync(parent, userEvent, uri, ets);
            // End snippet
        }

        /// <summary>Snippet for ListUserEvents</summary>
        public void ListUserEventsRequestObject()
        {
            // Snippet: ListUserEvents(ListUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            ListUserEventsRequest request = new ListUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUserEventsResponse, UserEvent> response = userEventServiceClient.ListUserEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserEventsAsync</summary>
        public async Task ListUserEventsRequestObjectAsync()
        {
            // Snippet: ListUserEventsAsync(ListUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserEventsRequest request = new ListUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> response = userEventServiceClient.ListUserEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserEvents</summary>
        public void ListUserEvents()
        {
            // Snippet: ListUserEvents(string, string, string, int?, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListUserEventsResponse, UserEvent> response = userEventServiceClient.ListUserEvents(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserEventsAsync</summary>
        public async Task ListUserEventsAsync()
        {
            // Snippet: ListUserEventsAsync(string, string, string, int?, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> response = userEventServiceClient.ListUserEventsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserEvents</summary>
        public void ListUserEventsResourceNames()
        {
            // Snippet: ListUserEvents(EventStoreName, string, string, int?, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListUserEventsResponse, UserEvent> response = userEventServiceClient.ListUserEvents(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserEventsAsync</summary>
        public async Task ListUserEventsResourceNamesAsync()
        {
            // Snippet: ListUserEventsAsync(EventStoreName, string, string, int?, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> response = userEventServiceClient.ListUserEventsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEvents</summary>
        public void PurgeUserEventsRequestObject()
        {
            // Snippet: PurgeUserEvents(PurgeUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            PurgeUserEventsRequest request = new PurgeUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = userEventServiceClient.PurgeUserEvents(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = userEventServiceClient.PollOncePurgeUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEventsAsync</summary>
        public async Task PurgeUserEventsRequestObjectAsync()
        {
            // Snippet: PurgeUserEventsAsync(PurgeUserEventsRequest, CallSettings)
            // Additional: PurgeUserEventsAsync(PurgeUserEventsRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeUserEventsRequest request = new PurgeUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = await userEventServiceClient.PurgeUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = await userEventServiceClient.PollOncePurgeUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEvents</summary>
        public void PurgeUserEvents()
        {
            // Snippet: PurgeUserEvents(string, string, bool, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string filter = "";
            bool force = false;
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = userEventServiceClient.PurgeUserEvents(parent, filter, force);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = userEventServiceClient.PollOncePurgeUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEventsAsync</summary>
        public async Task PurgeUserEventsAsync()
        {
            // Snippet: PurgeUserEventsAsync(string, string, bool, CallSettings)
            // Additional: PurgeUserEventsAsync(string, string, bool, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string filter = "";
            bool force = false;
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = await userEventServiceClient.PurgeUserEventsAsync(parent, filter, force);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = await userEventServiceClient.PollOncePurgeUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEvents</summary>
        public void PurgeUserEventsResourceNames()
        {
            // Snippet: PurgeUserEvents(EventStoreName, string, bool, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string filter = "";
            bool force = false;
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = userEventServiceClient.PurgeUserEvents(parent, filter, force);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = userEventServiceClient.PollOncePurgeUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeUserEventsAsync</summary>
        public async Task PurgeUserEventsResourceNamesAsync()
        {
            // Snippet: PurgeUserEventsAsync(EventStoreName, string, bool, CallSettings)
            // Additional: PurgeUserEventsAsync(EventStoreName, string, bool, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string filter = "";
            bool force = false;
            // Make the request
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> response = await userEventServiceClient.PurgeUserEventsAsync(parent, filter, force);

            // Poll until the returned long-running operation is complete
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> retrievedResponse = await userEventServiceClient.PollOncePurgeUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEvents</summary>
        public void ImportUserEventsRequestObject()
        {
            // Snippet: ImportUserEvents(ImportUserEventsRequest, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            ImportUserEventsRequest request = new ImportUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                RequestId = "",
                InputConfig = new InputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
            };
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = userEventServiceClient.ImportUserEvents(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = userEventServiceClient.PollOnceImportUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEventsAsync</summary>
        public async Task ImportUserEventsRequestObjectAsync()
        {
            // Snippet: ImportUserEventsAsync(ImportUserEventsRequest, CallSettings)
            // Additional: ImportUserEventsAsync(ImportUserEventsRequest, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportUserEventsRequest request = new ImportUserEventsRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                RequestId = "",
                InputConfig = new InputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
            };
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = await userEventServiceClient.ImportUserEventsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = await userEventServiceClient.PollOnceImportUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEvents</summary>
        public void ImportUserEvents()
        {
            // Snippet: ImportUserEvents(string, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = userEventServiceClient.ImportUserEvents(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = userEventServiceClient.PollOnceImportUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEventsAsync</summary>
        public async Task ImportUserEventsAsync()
        {
            // Snippet: ImportUserEventsAsync(string, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Additional: ImportUserEventsAsync(string, string, InputConfig, ImportErrorsConfig, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/eventStores/[EVENT_STORE]";
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = await userEventServiceClient.ImportUserEventsAsync(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = await userEventServiceClient.PollOnceImportUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEvents</summary>
        public void ImportUserEventsResourceNames()
        {
            // Snippet: ImportUserEvents(EventStoreName, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Create client
            UserEventServiceClient userEventServiceClient = UserEventServiceClient.Create();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = userEventServiceClient.ImportUserEvents(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = userEventServiceClient.PollOnceImportUserEvents(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportUserEventsAsync</summary>
        public async Task ImportUserEventsResourceNamesAsync()
        {
            // Snippet: ImportUserEventsAsync(EventStoreName, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Additional: ImportUserEventsAsync(EventStoreName, string, InputConfig, ImportErrorsConfig, CancellationToken)
            // Create client
            UserEventServiceClient userEventServiceClient = await UserEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventStoreName parent = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]");
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportUserEventsResponse, ImportMetadata> response = await userEventServiceClient.ImportUserEventsAsync(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportUserEventsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportUserEventsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportUserEventsResponse, ImportMetadata> retrievedResponse = await userEventServiceClient.PollOnceImportUserEventsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportUserEventsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
