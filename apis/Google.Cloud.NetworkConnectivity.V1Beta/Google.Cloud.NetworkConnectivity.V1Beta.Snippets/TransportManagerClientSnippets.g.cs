// Copyright 2026 Google LLC
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
    using Google.Cloud.NetworkConnectivity.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTransportManagerClientSnippets
    {
        /// <summary>Snippet for ListRemoteTransportProfiles</summary>
        public void ListRemoteTransportProfilesRequestObject()
        {
            // Snippet: ListRemoteTransportProfiles(ListRemoteTransportProfilesRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            ListRemoteTransportProfilesRequest request = new ListRemoteTransportProfilesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> response = transportManagerClient.ListRemoteTransportProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RemoteTransportProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRemoteTransportProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RemoteTransportProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RemoteTransportProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RemoteTransportProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRemoteTransportProfilesAsync</summary>
        public async Task ListRemoteTransportProfilesRequestObjectAsync()
        {
            // Snippet: ListRemoteTransportProfilesAsync(ListRemoteTransportProfilesRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListRemoteTransportProfilesRequest request = new ListRemoteTransportProfilesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> response = transportManagerClient.ListRemoteTransportProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RemoteTransportProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRemoteTransportProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RemoteTransportProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RemoteTransportProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RemoteTransportProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRemoteTransportProfiles</summary>
        public void ListRemoteTransportProfiles()
        {
            // Snippet: ListRemoteTransportProfiles(string, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> response = transportManagerClient.ListRemoteTransportProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RemoteTransportProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRemoteTransportProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RemoteTransportProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RemoteTransportProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RemoteTransportProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRemoteTransportProfilesAsync</summary>
        public async Task ListRemoteTransportProfilesAsync()
        {
            // Snippet: ListRemoteTransportProfilesAsync(string, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> response = transportManagerClient.ListRemoteTransportProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RemoteTransportProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRemoteTransportProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RemoteTransportProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RemoteTransportProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RemoteTransportProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRemoteTransportProfiles</summary>
        public void ListRemoteTransportProfilesResourceNames()
        {
            // Snippet: ListRemoteTransportProfiles(LocationName, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> response = transportManagerClient.ListRemoteTransportProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RemoteTransportProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRemoteTransportProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RemoteTransportProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RemoteTransportProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RemoteTransportProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRemoteTransportProfilesAsync</summary>
        public async Task ListRemoteTransportProfilesResourceNamesAsync()
        {
            // Snippet: ListRemoteTransportProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRemoteTransportProfilesResponse, RemoteTransportProfile> response = transportManagerClient.ListRemoteTransportProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RemoteTransportProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRemoteTransportProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RemoteTransportProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RemoteTransportProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RemoteTransportProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRemoteTransportProfile</summary>
        public void GetRemoteTransportProfileRequestObject()
        {
            // Snippet: GetRemoteTransportProfile(GetRemoteTransportProfileRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            GetRemoteTransportProfileRequest request = new GetRemoteTransportProfileRequest
            {
                RemoteTransportProfileName = RemoteTransportProfileName.FromProjectLocationRemoteTransportProfile("[PROJECT]", "[LOCATION]", "[REMOTE_TRANSPORT_PROFILE]"),
            };
            // Make the request
            RemoteTransportProfile response = transportManagerClient.GetRemoteTransportProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetRemoteTransportProfileAsync</summary>
        public async Task GetRemoteTransportProfileRequestObjectAsync()
        {
            // Snippet: GetRemoteTransportProfileAsync(GetRemoteTransportProfileRequest, CallSettings)
            // Additional: GetRemoteTransportProfileAsync(GetRemoteTransportProfileRequest, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetRemoteTransportProfileRequest request = new GetRemoteTransportProfileRequest
            {
                RemoteTransportProfileName = RemoteTransportProfileName.FromProjectLocationRemoteTransportProfile("[PROJECT]", "[LOCATION]", "[REMOTE_TRANSPORT_PROFILE]"),
            };
            // Make the request
            RemoteTransportProfile response = await transportManagerClient.GetRemoteTransportProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRemoteTransportProfile</summary>
        public void GetRemoteTransportProfile()
        {
            // Snippet: GetRemoteTransportProfile(string, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/remoteTransportProfiles/[REMOTE_TRANSPORT_PROFILE]";
            // Make the request
            RemoteTransportProfile response = transportManagerClient.GetRemoteTransportProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetRemoteTransportProfileAsync</summary>
        public async Task GetRemoteTransportProfileAsync()
        {
            // Snippet: GetRemoteTransportProfileAsync(string, CallSettings)
            // Additional: GetRemoteTransportProfileAsync(string, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/remoteTransportProfiles/[REMOTE_TRANSPORT_PROFILE]";
            // Make the request
            RemoteTransportProfile response = await transportManagerClient.GetRemoteTransportProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRemoteTransportProfile</summary>
        public void GetRemoteTransportProfileResourceNames()
        {
            // Snippet: GetRemoteTransportProfile(RemoteTransportProfileName, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            RemoteTransportProfileName name = RemoteTransportProfileName.FromProjectLocationRemoteTransportProfile("[PROJECT]", "[LOCATION]", "[REMOTE_TRANSPORT_PROFILE]");
            // Make the request
            RemoteTransportProfile response = transportManagerClient.GetRemoteTransportProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetRemoteTransportProfileAsync</summary>
        public async Task GetRemoteTransportProfileResourceNamesAsync()
        {
            // Snippet: GetRemoteTransportProfileAsync(RemoteTransportProfileName, CallSettings)
            // Additional: GetRemoteTransportProfileAsync(RemoteTransportProfileName, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            RemoteTransportProfileName name = RemoteTransportProfileName.FromProjectLocationRemoteTransportProfile("[PROJECT]", "[LOCATION]", "[REMOTE_TRANSPORT_PROFILE]");
            // Make the request
            RemoteTransportProfile response = await transportManagerClient.GetRemoteTransportProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTransports</summary>
        public void ListTransportsRequestObject()
        {
            // Snippet: ListTransports(ListTransportsRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            ListTransportsRequest request = new ListTransportsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTransportsResponse, Transport> response = transportManagerClient.ListTransports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransportsAsync</summary>
        public async Task ListTransportsRequestObjectAsync()
        {
            // Snippet: ListTransportsAsync(ListTransportsRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListTransportsRequest request = new ListTransportsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTransportsResponse, Transport> response = transportManagerClient.ListTransportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Transport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTransportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransports</summary>
        public void ListTransports()
        {
            // Snippet: ListTransports(string, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTransportsResponse, Transport> response = transportManagerClient.ListTransports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransportsAsync</summary>
        public async Task ListTransportsAsync()
        {
            // Snippet: ListTransportsAsync(string, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTransportsResponse, Transport> response = transportManagerClient.ListTransportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Transport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTransportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransports</summary>
        public void ListTransportsResourceNames()
        {
            // Snippet: ListTransports(LocationName, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTransportsResponse, Transport> response = transportManagerClient.ListTransports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Transport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransportsAsync</summary>
        public async Task ListTransportsResourceNamesAsync()
        {
            // Snippet: ListTransportsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTransportsResponse, Transport> response = transportManagerClient.ListTransportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Transport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTransportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Transport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Transport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Transport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTransport</summary>
        public void GetTransportRequestObject()
        {
            // Snippet: GetTransport(GetTransportRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            GetTransportRequest request = new GetTransportRequest
            {
                TransportName = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]"),
            };
            // Make the request
            Transport response = transportManagerClient.GetTransport(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransportAsync</summary>
        public async Task GetTransportRequestObjectAsync()
        {
            // Snippet: GetTransportAsync(GetTransportRequest, CallSettings)
            // Additional: GetTransportAsync(GetTransportRequest, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetTransportRequest request = new GetTransportRequest
            {
                TransportName = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]"),
            };
            // Make the request
            Transport response = await transportManagerClient.GetTransportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransport</summary>
        public void GetTransport()
        {
            // Snippet: GetTransport(string, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/transports/[TRANSPORT]";
            // Make the request
            Transport response = transportManagerClient.GetTransport(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransportAsync</summary>
        public async Task GetTransportAsync()
        {
            // Snippet: GetTransportAsync(string, CallSettings)
            // Additional: GetTransportAsync(string, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/transports/[TRANSPORT]";
            // Make the request
            Transport response = await transportManagerClient.GetTransportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransport</summary>
        public void GetTransportResourceNames()
        {
            // Snippet: GetTransport(TransportName, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            TransportName name = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]");
            // Make the request
            Transport response = transportManagerClient.GetTransport(name);
            // End snippet
        }

        /// <summary>Snippet for GetTransportAsync</summary>
        public async Task GetTransportResourceNamesAsync()
        {
            // Snippet: GetTransportAsync(TransportName, CallSettings)
            // Additional: GetTransportAsync(TransportName, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            TransportName name = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]");
            // Make the request
            Transport response = await transportManagerClient.GetTransportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatusRequestObject()
        {
            // Snippet: GetStatus(GetStatusRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            GetStatusRequest request = new GetStatusRequest
            {
                TransportName = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]"),
            };
            // Make the request
            GetStatusResponse response = transportManagerClient.GetStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusRequestObjectAsync()
        {
            // Snippet: GetStatusAsync(GetStatusRequest, CallSettings)
            // Additional: GetStatusAsync(GetStatusRequest, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetStatusRequest request = new GetStatusRequest
            {
                TransportName = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]"),
            };
            // Make the request
            GetStatusResponse response = await transportManagerClient.GetStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatus()
        {
            // Snippet: GetStatus(string, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/transports/[TRANSPORT]";
            // Make the request
            GetStatusResponse response = transportManagerClient.GetStatus(name);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusAsync()
        {
            // Snippet: GetStatusAsync(string, CallSettings)
            // Additional: GetStatusAsync(string, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/transports/[TRANSPORT]";
            // Make the request
            GetStatusResponse response = await transportManagerClient.GetStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatusResourceNames()
        {
            // Snippet: GetStatus(TransportName, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            TransportName name = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]");
            // Make the request
            GetStatusResponse response = transportManagerClient.GetStatus(name);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusResourceNamesAsync()
        {
            // Snippet: GetStatusAsync(TransportName, CallSettings)
            // Additional: GetStatusAsync(TransportName, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            TransportName name = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]");
            // Make the request
            GetStatusResponse response = await transportManagerClient.GetStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTransport</summary>
        public void CreateTransportRequestObject()
        {
            // Snippet: CreateTransport(CreateTransportRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            CreateTransportRequest request = new CreateTransportRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TransportId = "",
                Transport = new Transport(),
                RequestId = "",
            };
            // Make the request
            Operation<Transport, OperationMetadata> response = transportManagerClient.CreateTransport(request);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceCreateTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTransportAsync</summary>
        public async Task CreateTransportRequestObjectAsync()
        {
            // Snippet: CreateTransportAsync(CreateTransportRequest, CallSettings)
            // Additional: CreateTransportAsync(CreateTransportRequest, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransportRequest request = new CreateTransportRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TransportId = "",
                Transport = new Transport(),
                RequestId = "",
            };
            // Make the request
            Operation<Transport, OperationMetadata> response = await transportManagerClient.CreateTransportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceCreateTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTransport</summary>
        public void CreateTransport()
        {
            // Snippet: CreateTransport(string, Transport, string, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Transport transport = new Transport();
            string transportId = "";
            // Make the request
            Operation<Transport, OperationMetadata> response = transportManagerClient.CreateTransport(parent, transport, transportId);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceCreateTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTransportAsync</summary>
        public async Task CreateTransportAsync()
        {
            // Snippet: CreateTransportAsync(string, Transport, string, CallSettings)
            // Additional: CreateTransportAsync(string, Transport, string, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Transport transport = new Transport();
            string transportId = "";
            // Make the request
            Operation<Transport, OperationMetadata> response = await transportManagerClient.CreateTransportAsync(parent, transport, transportId);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceCreateTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTransport</summary>
        public void CreateTransportResourceNames()
        {
            // Snippet: CreateTransport(LocationName, Transport, string, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Transport transport = new Transport();
            string transportId = "";
            // Make the request
            Operation<Transport, OperationMetadata> response = transportManagerClient.CreateTransport(parent, transport, transportId);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceCreateTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTransportAsync</summary>
        public async Task CreateTransportResourceNamesAsync()
        {
            // Snippet: CreateTransportAsync(LocationName, Transport, string, CallSettings)
            // Additional: CreateTransportAsync(LocationName, Transport, string, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Transport transport = new Transport();
            string transportId = "";
            // Make the request
            Operation<Transport, OperationMetadata> response = await transportManagerClient.CreateTransportAsync(parent, transport, transportId);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceCreateTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTransport</summary>
        public void UpdateTransportRequestObject()
        {
            // Snippet: UpdateTransport(UpdateTransportRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            UpdateTransportRequest request = new UpdateTransportRequest
            {
                UpdateMask = new FieldMask(),
                Transport = new Transport(),
                RequestId = "",
            };
            // Make the request
            Operation<Transport, OperationMetadata> response = transportManagerClient.UpdateTransport(request);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceUpdateTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTransportAsync</summary>
        public async Task UpdateTransportRequestObjectAsync()
        {
            // Snippet: UpdateTransportAsync(UpdateTransportRequest, CallSettings)
            // Additional: UpdateTransportAsync(UpdateTransportRequest, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransportRequest request = new UpdateTransportRequest
            {
                UpdateMask = new FieldMask(),
                Transport = new Transport(),
                RequestId = "",
            };
            // Make the request
            Operation<Transport, OperationMetadata> response = await transportManagerClient.UpdateTransportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceUpdateTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTransport</summary>
        public void UpdateTransport()
        {
            // Snippet: UpdateTransport(Transport, FieldMask, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            Transport transport = new Transport();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Transport, OperationMetadata> response = transportManagerClient.UpdateTransport(transport, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceUpdateTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTransportAsync</summary>
        public async Task UpdateTransportAsync()
        {
            // Snippet: UpdateTransportAsync(Transport, FieldMask, CallSettings)
            // Additional: UpdateTransportAsync(Transport, FieldMask, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            Transport transport = new Transport();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Transport, OperationMetadata> response = await transportManagerClient.UpdateTransportAsync(transport, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Transport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Transport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Transport, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceUpdateTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Transport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransport</summary>
        public void DeleteTransportRequestObject()
        {
            // Snippet: DeleteTransport(DeleteTransportRequest, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            DeleteTransportRequest request = new DeleteTransportRequest
            {
                TransportName = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = transportManagerClient.DeleteTransport(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceDeleteTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransportAsync</summary>
        public async Task DeleteTransportRequestObjectAsync()
        {
            // Snippet: DeleteTransportAsync(DeleteTransportRequest, CallSettings)
            // Additional: DeleteTransportAsync(DeleteTransportRequest, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransportRequest request = new DeleteTransportRequest
            {
                TransportName = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await transportManagerClient.DeleteTransportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceDeleteTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransport</summary>
        public void DeleteTransport()
        {
            // Snippet: DeleteTransport(string, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/transports/[TRANSPORT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = transportManagerClient.DeleteTransport(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceDeleteTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransportAsync</summary>
        public async Task DeleteTransportAsync()
        {
            // Snippet: DeleteTransportAsync(string, CallSettings)
            // Additional: DeleteTransportAsync(string, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/transports/[TRANSPORT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await transportManagerClient.DeleteTransportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceDeleteTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransport</summary>
        public void DeleteTransportResourceNames()
        {
            // Snippet: DeleteTransport(TransportName, CallSettings)
            // Create client
            TransportManagerClient transportManagerClient = TransportManagerClient.Create();
            // Initialize request argument(s)
            TransportName name = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = transportManagerClient.DeleteTransport(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = transportManagerClient.PollOnceDeleteTransport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransportAsync</summary>
        public async Task DeleteTransportResourceNamesAsync()
        {
            // Snippet: DeleteTransportAsync(TransportName, CallSettings)
            // Additional: DeleteTransportAsync(TransportName, CancellationToken)
            // Create client
            TransportManagerClient transportManagerClient = await TransportManagerClient.CreateAsync();
            // Initialize request argument(s)
            TransportName name = TransportName.FromProjectLocationTransport("[PROJECT]", "[LOCATION]", "[TRANSPORT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await transportManagerClient.DeleteTransportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await transportManagerClient.PollOnceDeleteTransportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
