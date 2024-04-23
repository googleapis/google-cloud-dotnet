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
    using Google.Cloud.ServiceHealth.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServiceHealthClientSnippets
    {
        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsRequestObject()
        {
            // Snippet: ListEvents(ListEventsRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                View = EventView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = serviceHealthClient.ListEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsRequestObjectAsync()
        {
            // Snippet: ListEventsAsync(ListEventsRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                View = EventView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = serviceHealthClient.ListEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEvents()
        {
            // Snippet: ListEvents(string, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = serviceHealthClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsAsync()
        {
            // Snippet: ListEventsAsync(string, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = serviceHealthClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsResourceNames()
        {
            // Snippet: ListEvents(LocationName, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = serviceHealthClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsResourceNamesAsync()
        {
            // Snippet: ListEventsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = serviceHealthClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEventRequestObject()
        {
            // Snippet: GetEvent(GetEventRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationEvent("[PROJECT]", "[LOCATION]", "[EVENT]"),
            };
            // Make the request
            Event response = serviceHealthClient.GetEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventRequestObjectAsync()
        {
            // Snippet: GetEventAsync(GetEventRequest, CallSettings)
            // Additional: GetEventAsync(GetEventRequest, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationEvent("[PROJECT]", "[LOCATION]", "[EVENT]"),
            };
            // Make the request
            Event response = await serviceHealthClient.GetEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEvent()
        {
            // Snippet: GetEvent(string, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/events/[EVENT]";
            // Make the request
            Event response = serviceHealthClient.GetEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventAsync()
        {
            // Snippet: GetEventAsync(string, CallSettings)
            // Additional: GetEventAsync(string, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/events/[EVENT]";
            // Make the request
            Event response = await serviceHealthClient.GetEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEventResourceNames()
        {
            // Snippet: GetEvent(EventName, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationEvent("[PROJECT]", "[LOCATION]", "[EVENT]");
            // Make the request
            Event response = serviceHealthClient.GetEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventResourceNamesAsync()
        {
            // Snippet: GetEventAsync(EventName, CallSettings)
            // Additional: GetEventAsync(EventName, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationEvent("[PROJECT]", "[LOCATION]", "[EVENT]");
            // Make the request
            Event response = await serviceHealthClient.GetEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationEvents</summary>
        public void ListOrganizationEventsRequestObject()
        {
            // Snippet: ListOrganizationEvents(ListOrganizationEventsRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            ListOrganizationEventsRequest request = new ListOrganizationEventsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                View = OrganizationEventView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> response = serviceHealthClient.ListOrganizationEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrganizationEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationEventsAsync</summary>
        public async Task ListOrganizationEventsRequestObjectAsync()
        {
            // Snippet: ListOrganizationEventsAsync(ListOrganizationEventsRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            ListOrganizationEventsRequest request = new ListOrganizationEventsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                View = OrganizationEventView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> response = serviceHealthClient.ListOrganizationEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrganizationEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrganizationEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationEvents</summary>
        public void ListOrganizationEvents()
        {
            // Snippet: ListOrganizationEvents(string, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> response = serviceHealthClient.ListOrganizationEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrganizationEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationEventsAsync</summary>
        public async Task ListOrganizationEventsAsync()
        {
            // Snippet: ListOrganizationEventsAsync(string, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> response = serviceHealthClient.ListOrganizationEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrganizationEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrganizationEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationEvents</summary>
        public void ListOrganizationEventsResourceNames()
        {
            // Snippet: ListOrganizationEvents(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> response = serviceHealthClient.ListOrganizationEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrganizationEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationEventsAsync</summary>
        public async Task ListOrganizationEventsResourceNamesAsync()
        {
            // Snippet: ListOrganizationEventsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> response = serviceHealthClient.ListOrganizationEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrganizationEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrganizationEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationEvent</summary>
        public void GetOrganizationEventRequestObject()
        {
            // Snippet: GetOrganizationEvent(GetOrganizationEventRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            GetOrganizationEventRequest request = new GetOrganizationEventRequest
            {
                OrganizationEventName = OrganizationEventName.FromOrganizationLocationEvent("[ORGANIZATION]", "[LOCATION]", "[EVENT]"),
            };
            // Make the request
            OrganizationEvent response = serviceHealthClient.GetOrganizationEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationEventAsync</summary>
        public async Task GetOrganizationEventRequestObjectAsync()
        {
            // Snippet: GetOrganizationEventAsync(GetOrganizationEventRequest, CallSettings)
            // Additional: GetOrganizationEventAsync(GetOrganizationEventRequest, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            GetOrganizationEventRequest request = new GetOrganizationEventRequest
            {
                OrganizationEventName = OrganizationEventName.FromOrganizationLocationEvent("[ORGANIZATION]", "[LOCATION]", "[EVENT]"),
            };
            // Make the request
            OrganizationEvent response = await serviceHealthClient.GetOrganizationEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationEvent</summary>
        public void GetOrganizationEvent()
        {
            // Snippet: GetOrganizationEvent(string, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/organizationEvents/[EVENT]";
            // Make the request
            OrganizationEvent response = serviceHealthClient.GetOrganizationEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationEventAsync</summary>
        public async Task GetOrganizationEventAsync()
        {
            // Snippet: GetOrganizationEventAsync(string, CallSettings)
            // Additional: GetOrganizationEventAsync(string, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/organizationEvents/[EVENT]";
            // Make the request
            OrganizationEvent response = await serviceHealthClient.GetOrganizationEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationEvent</summary>
        public void GetOrganizationEventResourceNames()
        {
            // Snippet: GetOrganizationEvent(OrganizationEventName, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            OrganizationEventName name = OrganizationEventName.FromOrganizationLocationEvent("[ORGANIZATION]", "[LOCATION]", "[EVENT]");
            // Make the request
            OrganizationEvent response = serviceHealthClient.GetOrganizationEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationEventAsync</summary>
        public async Task GetOrganizationEventResourceNamesAsync()
        {
            // Snippet: GetOrganizationEventAsync(OrganizationEventName, CallSettings)
            // Additional: GetOrganizationEventAsync(OrganizationEventName, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationEventName name = OrganizationEventName.FromOrganizationLocationEvent("[ORGANIZATION]", "[LOCATION]", "[EVENT]");
            // Make the request
            OrganizationEvent response = await serviceHealthClient.GetOrganizationEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationImpacts</summary>
        public void ListOrganizationImpactsRequestObject()
        {
            // Snippet: ListOrganizationImpacts(ListOrganizationImpactsRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            ListOrganizationImpactsRequest request = new ListOrganizationImpactsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> response = serviceHealthClient.ListOrganizationImpacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrganizationImpact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationImpactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationImpact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationImpact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationImpact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationImpactsAsync</summary>
        public async Task ListOrganizationImpactsRequestObjectAsync()
        {
            // Snippet: ListOrganizationImpactsAsync(ListOrganizationImpactsRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            ListOrganizationImpactsRequest request = new ListOrganizationImpactsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> response = serviceHealthClient.ListOrganizationImpactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrganizationImpact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrganizationImpactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationImpact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationImpact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationImpact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationImpacts</summary>
        public void ListOrganizationImpacts()
        {
            // Snippet: ListOrganizationImpacts(string, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> response = serviceHealthClient.ListOrganizationImpacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrganizationImpact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationImpactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationImpact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationImpact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationImpact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationImpactsAsync</summary>
        public async Task ListOrganizationImpactsAsync()
        {
            // Snippet: ListOrganizationImpactsAsync(string, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> response = serviceHealthClient.ListOrganizationImpactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrganizationImpact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrganizationImpactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationImpact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationImpact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationImpact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationImpacts</summary>
        public void ListOrganizationImpactsResourceNames()
        {
            // Snippet: ListOrganizationImpacts(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> response = serviceHealthClient.ListOrganizationImpacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrganizationImpact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationImpactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationImpact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationImpact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationImpact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationImpactsAsync</summary>
        public async Task ListOrganizationImpactsResourceNamesAsync()
        {
            // Snippet: ListOrganizationImpactsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> response = serviceHealthClient.ListOrganizationImpactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrganizationImpact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrganizationImpactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrganizationImpact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrganizationImpact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrganizationImpact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationImpact</summary>
        public void GetOrganizationImpactRequestObject()
        {
            // Snippet: GetOrganizationImpact(GetOrganizationImpactRequest, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            GetOrganizationImpactRequest request = new GetOrganizationImpactRequest
            {
                OrganizationImpactName = OrganizationImpactName.FromOrganizationLocationOrganizationImpact("[ORGANIZATION]", "[LOCATION]", "[ORGANIZATION_IMPACT]"),
            };
            // Make the request
            OrganizationImpact response = serviceHealthClient.GetOrganizationImpact(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationImpactAsync</summary>
        public async Task GetOrganizationImpactRequestObjectAsync()
        {
            // Snippet: GetOrganizationImpactAsync(GetOrganizationImpactRequest, CallSettings)
            // Additional: GetOrganizationImpactAsync(GetOrganizationImpactRequest, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            GetOrganizationImpactRequest request = new GetOrganizationImpactRequest
            {
                OrganizationImpactName = OrganizationImpactName.FromOrganizationLocationOrganizationImpact("[ORGANIZATION]", "[LOCATION]", "[ORGANIZATION_IMPACT]"),
            };
            // Make the request
            OrganizationImpact response = await serviceHealthClient.GetOrganizationImpactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationImpact</summary>
        public void GetOrganizationImpact()
        {
            // Snippet: GetOrganizationImpact(string, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/organizationImpacts/[ORGANIZATION_IMPACT]";
            // Make the request
            OrganizationImpact response = serviceHealthClient.GetOrganizationImpact(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationImpactAsync</summary>
        public async Task GetOrganizationImpactAsync()
        {
            // Snippet: GetOrganizationImpactAsync(string, CallSettings)
            // Additional: GetOrganizationImpactAsync(string, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/organizationImpacts/[ORGANIZATION_IMPACT]";
            // Make the request
            OrganizationImpact response = await serviceHealthClient.GetOrganizationImpactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationImpact</summary>
        public void GetOrganizationImpactResourceNames()
        {
            // Snippet: GetOrganizationImpact(OrganizationImpactName, CallSettings)
            // Create client
            ServiceHealthClient serviceHealthClient = ServiceHealthClient.Create();
            // Initialize request argument(s)
            OrganizationImpactName name = OrganizationImpactName.FromOrganizationLocationOrganizationImpact("[ORGANIZATION]", "[LOCATION]", "[ORGANIZATION_IMPACT]");
            // Make the request
            OrganizationImpact response = serviceHealthClient.GetOrganizationImpact(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationImpactAsync</summary>
        public async Task GetOrganizationImpactResourceNamesAsync()
        {
            // Snippet: GetOrganizationImpactAsync(OrganizationImpactName, CallSettings)
            // Additional: GetOrganizationImpactAsync(OrganizationImpactName, CancellationToken)
            // Create client
            ServiceHealthClient serviceHealthClient = await ServiceHealthClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationImpactName name = OrganizationImpactName.FromOrganizationLocationOrganizationImpact("[ORGANIZATION]", "[LOCATION]", "[ORGANIZATION_IMPACT]");
            // Make the request
            OrganizationImpact response = await serviceHealthClient.GetOrganizationImpactAsync(name);
            // End snippet
        }
    }
}
