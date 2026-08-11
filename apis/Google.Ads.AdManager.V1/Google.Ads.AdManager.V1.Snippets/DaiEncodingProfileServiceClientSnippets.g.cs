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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDaiEncodingProfileServiceClientSnippets
    {
        /// <summary>Snippet for GetDaiEncodingProfile</summary>
        public void GetDaiEncodingProfileRequestObject()
        {
            // Snippet: GetDaiEncodingProfile(GetDaiEncodingProfileRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            GetDaiEncodingProfileRequest request = new GetDaiEncodingProfileRequest
            {
                DaiEncodingProfileName = DaiEncodingProfileName.FromNetworkCodeDaiEncodingProfile("[NETWORK_CODE]", "[DAI_ENCODING_PROFILE]"),
            };
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.GetDaiEncodingProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetDaiEncodingProfileAsync</summary>
        public async Task GetDaiEncodingProfileRequestObjectAsync()
        {
            // Snippet: GetDaiEncodingProfileAsync(GetDaiEncodingProfileRequest, CallSettings)
            // Additional: GetDaiEncodingProfileAsync(GetDaiEncodingProfileRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDaiEncodingProfileRequest request = new GetDaiEncodingProfileRequest
            {
                DaiEncodingProfileName = DaiEncodingProfileName.FromNetworkCodeDaiEncodingProfile("[NETWORK_CODE]", "[DAI_ENCODING_PROFILE]"),
            };
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.GetDaiEncodingProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDaiEncodingProfile</summary>
        public void GetDaiEncodingProfile()
        {
            // Snippet: GetDaiEncodingProfile(string, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/daiEncodingProfiles/[DAI_ENCODING_PROFILE]";
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.GetDaiEncodingProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiEncodingProfileAsync</summary>
        public async Task GetDaiEncodingProfileAsync()
        {
            // Snippet: GetDaiEncodingProfileAsync(string, CallSettings)
            // Additional: GetDaiEncodingProfileAsync(string, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/daiEncodingProfiles/[DAI_ENCODING_PROFILE]";
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.GetDaiEncodingProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiEncodingProfile</summary>
        public void GetDaiEncodingProfileResourceNames()
        {
            // Snippet: GetDaiEncodingProfile(DaiEncodingProfileName, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            DaiEncodingProfileName name = DaiEncodingProfileName.FromNetworkCodeDaiEncodingProfile("[NETWORK_CODE]", "[DAI_ENCODING_PROFILE]");
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.GetDaiEncodingProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiEncodingProfileAsync</summary>
        public async Task GetDaiEncodingProfileResourceNamesAsync()
        {
            // Snippet: GetDaiEncodingProfileAsync(DaiEncodingProfileName, CallSettings)
            // Additional: GetDaiEncodingProfileAsync(DaiEncodingProfileName, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            DaiEncodingProfileName name = DaiEncodingProfileName.FromNetworkCodeDaiEncodingProfile("[NETWORK_CODE]", "[DAI_ENCODING_PROFILE]");
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.GetDaiEncodingProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDaiEncodingProfiles</summary>
        public void ListDaiEncodingProfilesRequestObject()
        {
            // Snippet: ListDaiEncodingProfiles(ListDaiEncodingProfilesRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            ListDaiEncodingProfilesRequest request = new ListDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> response = daiEncodingProfileServiceClient.ListDaiEncodingProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DaiEncodingProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDaiEncodingProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiEncodingProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiEncodingProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiEncodingProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiEncodingProfilesAsync</summary>
        public async Task ListDaiEncodingProfilesRequestObjectAsync()
        {
            // Snippet: ListDaiEncodingProfilesAsync(ListDaiEncodingProfilesRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDaiEncodingProfilesRequest request = new ListDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> response = daiEncodingProfileServiceClient.ListDaiEncodingProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DaiEncodingProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDaiEncodingProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiEncodingProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiEncodingProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiEncodingProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiEncodingProfiles</summary>
        public void ListDaiEncodingProfiles()
        {
            // Snippet: ListDaiEncodingProfiles(string, string, int?, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> response = daiEncodingProfileServiceClient.ListDaiEncodingProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DaiEncodingProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDaiEncodingProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiEncodingProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiEncodingProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiEncodingProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiEncodingProfilesAsync</summary>
        public async Task ListDaiEncodingProfilesAsync()
        {
            // Snippet: ListDaiEncodingProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> response = daiEncodingProfileServiceClient.ListDaiEncodingProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DaiEncodingProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDaiEncodingProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiEncodingProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiEncodingProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiEncodingProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiEncodingProfiles</summary>
        public void ListDaiEncodingProfilesResourceNames()
        {
            // Snippet: ListDaiEncodingProfiles(NetworkName, string, int?, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> response = daiEncodingProfileServiceClient.ListDaiEncodingProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DaiEncodingProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDaiEncodingProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiEncodingProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiEncodingProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiEncodingProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiEncodingProfilesAsync</summary>
        public async Task ListDaiEncodingProfilesResourceNamesAsync()
        {
            // Snippet: ListDaiEncodingProfilesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> response = daiEncodingProfileServiceClient.ListDaiEncodingProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DaiEncodingProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDaiEncodingProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiEncodingProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiEncodingProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiEncodingProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDaiEncodingProfile</summary>
        public void CreateDaiEncodingProfileRequestObject()
        {
            // Snippet: CreateDaiEncodingProfile(CreateDaiEncodingProfileRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            CreateDaiEncodingProfileRequest request = new CreateDaiEncodingProfileRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiEncodingProfile = new DaiEncodingProfile(),
            };
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.CreateDaiEncodingProfile(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiEncodingProfileAsync</summary>
        public async Task CreateDaiEncodingProfileRequestObjectAsync()
        {
            // Snippet: CreateDaiEncodingProfileAsync(CreateDaiEncodingProfileRequest, CallSettings)
            // Additional: CreateDaiEncodingProfileAsync(CreateDaiEncodingProfileRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDaiEncodingProfileRequest request = new CreateDaiEncodingProfileRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiEncodingProfile = new DaiEncodingProfile(),
            };
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.CreateDaiEncodingProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiEncodingProfile</summary>
        public void CreateDaiEncodingProfile()
        {
            // Snippet: CreateDaiEncodingProfile(string, DaiEncodingProfile, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            DaiEncodingProfile daiEncodingProfile = new DaiEncodingProfile();
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.CreateDaiEncodingProfile(parent, daiEncodingProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiEncodingProfileAsync</summary>
        public async Task CreateDaiEncodingProfileAsync()
        {
            // Snippet: CreateDaiEncodingProfileAsync(string, DaiEncodingProfile, CallSettings)
            // Additional: CreateDaiEncodingProfileAsync(string, DaiEncodingProfile, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            DaiEncodingProfile daiEncodingProfile = new DaiEncodingProfile();
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.CreateDaiEncodingProfileAsync(parent, daiEncodingProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiEncodingProfile</summary>
        public void CreateDaiEncodingProfileResourceNames()
        {
            // Snippet: CreateDaiEncodingProfile(NetworkName, DaiEncodingProfile, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            DaiEncodingProfile daiEncodingProfile = new DaiEncodingProfile();
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.CreateDaiEncodingProfile(parent, daiEncodingProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiEncodingProfileAsync</summary>
        public async Task CreateDaiEncodingProfileResourceNamesAsync()
        {
            // Snippet: CreateDaiEncodingProfileAsync(NetworkName, DaiEncodingProfile, CallSettings)
            // Additional: CreateDaiEncodingProfileAsync(NetworkName, DaiEncodingProfile, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            DaiEncodingProfile daiEncodingProfile = new DaiEncodingProfile();
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.CreateDaiEncodingProfileAsync(parent, daiEncodingProfile);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiEncodingProfiles</summary>
        public void BatchCreateDaiEncodingProfilesRequestObject()
        {
            // Snippet: BatchCreateDaiEncodingProfiles(BatchCreateDaiEncodingProfilesRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateDaiEncodingProfilesRequest request = new BatchCreateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchCreateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchCreateDaiEncodingProfiles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiEncodingProfilesAsync</summary>
        public async Task BatchCreateDaiEncodingProfilesRequestObjectAsync()
        {
            // Snippet: BatchCreateDaiEncodingProfilesAsync(BatchCreateDaiEncodingProfilesRequest, CallSettings)
            // Additional: BatchCreateDaiEncodingProfilesAsync(BatchCreateDaiEncodingProfilesRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateDaiEncodingProfilesRequest request = new BatchCreateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchCreateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchCreateDaiEncodingProfilesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiEncodingProfiles</summary>
        public void BatchCreateDaiEncodingProfiles()
        {
            // Snippet: BatchCreateDaiEncodingProfiles(string, IEnumerable<CreateDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateDaiEncodingProfileRequest> requests = new CreateDaiEncodingProfileRequest[]
            {
                new CreateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchCreateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchCreateDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiEncodingProfilesAsync</summary>
        public async Task BatchCreateDaiEncodingProfilesAsync()
        {
            // Snippet: BatchCreateDaiEncodingProfilesAsync(string, IEnumerable<CreateDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchCreateDaiEncodingProfilesAsync(string, IEnumerable<CreateDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateDaiEncodingProfileRequest> requests = new CreateDaiEncodingProfileRequest[]
            {
                new CreateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchCreateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchCreateDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiEncodingProfiles</summary>
        public void BatchCreateDaiEncodingProfilesResourceNames()
        {
            // Snippet: BatchCreateDaiEncodingProfiles(NetworkName, IEnumerable<CreateDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateDaiEncodingProfileRequest> requests = new CreateDaiEncodingProfileRequest[]
            {
                new CreateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchCreateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchCreateDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiEncodingProfilesAsync</summary>
        public async Task BatchCreateDaiEncodingProfilesResourceNamesAsync()
        {
            // Snippet: BatchCreateDaiEncodingProfilesAsync(NetworkName, IEnumerable<CreateDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchCreateDaiEncodingProfilesAsync(NetworkName, IEnumerable<CreateDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateDaiEncodingProfileRequest> requests = new CreateDaiEncodingProfileRequest[]
            {
                new CreateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchCreateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchCreateDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiEncodingProfile</summary>
        public void UpdateDaiEncodingProfileRequestObject()
        {
            // Snippet: UpdateDaiEncodingProfile(UpdateDaiEncodingProfileRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            UpdateDaiEncodingProfileRequest request = new UpdateDaiEncodingProfileRequest
            {
                DaiEncodingProfile = new DaiEncodingProfile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.UpdateDaiEncodingProfile(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiEncodingProfileAsync</summary>
        public async Task UpdateDaiEncodingProfileRequestObjectAsync()
        {
            // Snippet: UpdateDaiEncodingProfileAsync(UpdateDaiEncodingProfileRequest, CallSettings)
            // Additional: UpdateDaiEncodingProfileAsync(UpdateDaiEncodingProfileRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDaiEncodingProfileRequest request = new UpdateDaiEncodingProfileRequest
            {
                DaiEncodingProfile = new DaiEncodingProfile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.UpdateDaiEncodingProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiEncodingProfile</summary>
        public void UpdateDaiEncodingProfile()
        {
            // Snippet: UpdateDaiEncodingProfile(DaiEncodingProfile, FieldMask, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            DaiEncodingProfile daiEncodingProfile = new DaiEncodingProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DaiEncodingProfile response = daiEncodingProfileServiceClient.UpdateDaiEncodingProfile(daiEncodingProfile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiEncodingProfileAsync</summary>
        public async Task UpdateDaiEncodingProfileAsync()
        {
            // Snippet: UpdateDaiEncodingProfileAsync(DaiEncodingProfile, FieldMask, CallSettings)
            // Additional: UpdateDaiEncodingProfileAsync(DaiEncodingProfile, FieldMask, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            DaiEncodingProfile daiEncodingProfile = new DaiEncodingProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DaiEncodingProfile response = await daiEncodingProfileServiceClient.UpdateDaiEncodingProfileAsync(daiEncodingProfile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiEncodingProfiles</summary>
        public void BatchUpdateDaiEncodingProfilesRequestObject()
        {
            // Snippet: BatchUpdateDaiEncodingProfiles(BatchUpdateDaiEncodingProfilesRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateDaiEncodingProfilesRequest request = new BatchUpdateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchUpdateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfiles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiEncodingProfilesAsync</summary>
        public async Task BatchUpdateDaiEncodingProfilesRequestObjectAsync()
        {
            // Snippet: BatchUpdateDaiEncodingProfilesAsync(BatchUpdateDaiEncodingProfilesRequest, CallSettings)
            // Additional: BatchUpdateDaiEncodingProfilesAsync(BatchUpdateDaiEncodingProfilesRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateDaiEncodingProfilesRequest request = new BatchUpdateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchUpdateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfilesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiEncodingProfiles</summary>
        public void BatchUpdateDaiEncodingProfiles()
        {
            // Snippet: BatchUpdateDaiEncodingProfiles(string, IEnumerable<UpdateDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateDaiEncodingProfileRequest> requests = new UpdateDaiEncodingProfileRequest[]
            {
                new UpdateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchUpdateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiEncodingProfilesAsync</summary>
        public async Task BatchUpdateDaiEncodingProfilesAsync()
        {
            // Snippet: BatchUpdateDaiEncodingProfilesAsync(string, IEnumerable<UpdateDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchUpdateDaiEncodingProfilesAsync(string, IEnumerable<UpdateDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateDaiEncodingProfileRequest> requests = new UpdateDaiEncodingProfileRequest[]
            {
                new UpdateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchUpdateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiEncodingProfiles</summary>
        public void BatchUpdateDaiEncodingProfilesResourceNames()
        {
            // Snippet: BatchUpdateDaiEncodingProfiles(NetworkName, IEnumerable<UpdateDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateDaiEncodingProfileRequest> requests = new UpdateDaiEncodingProfileRequest[]
            {
                new UpdateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchUpdateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiEncodingProfilesAsync</summary>
        public async Task BatchUpdateDaiEncodingProfilesResourceNamesAsync()
        {
            // Snippet: BatchUpdateDaiEncodingProfilesAsync(NetworkName, IEnumerable<UpdateDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchUpdateDaiEncodingProfilesAsync(NetworkName, IEnumerable<UpdateDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateDaiEncodingProfileRequest> requests = new UpdateDaiEncodingProfileRequest[]
            {
                new UpdateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchUpdateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiEncodingProfiles</summary>
        public void BatchActivateDaiEncodingProfilesRequestObject()
        {
            // Snippet: BatchActivateDaiEncodingProfiles(BatchActivateDaiEncodingProfilesRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateDaiEncodingProfilesRequest request = new BatchActivateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new ActivateDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchActivateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchActivateDaiEncodingProfiles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiEncodingProfilesAsync</summary>
        public async Task BatchActivateDaiEncodingProfilesRequestObjectAsync()
        {
            // Snippet: BatchActivateDaiEncodingProfilesAsync(BatchActivateDaiEncodingProfilesRequest, CallSettings)
            // Additional: BatchActivateDaiEncodingProfilesAsync(BatchActivateDaiEncodingProfilesRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateDaiEncodingProfilesRequest request = new BatchActivateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new ActivateDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchActivateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchActivateDaiEncodingProfilesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiEncodingProfiles</summary>
        public void BatchActivateDaiEncodingProfiles()
        {
            // Snippet: BatchActivateDaiEncodingProfiles(string, IEnumerable<ActivateDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<ActivateDaiEncodingProfileRequest> requests = new ActivateDaiEncodingProfileRequest[]
            {
                new ActivateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchActivateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchActivateDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiEncodingProfilesAsync</summary>
        public async Task BatchActivateDaiEncodingProfilesAsync()
        {
            // Snippet: BatchActivateDaiEncodingProfilesAsync(string, IEnumerable<ActivateDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchActivateDaiEncodingProfilesAsync(string, IEnumerable<ActivateDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<ActivateDaiEncodingProfileRequest> requests = new ActivateDaiEncodingProfileRequest[]
            {
                new ActivateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchActivateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchActivateDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiEncodingProfiles</summary>
        public void BatchActivateDaiEncodingProfilesResourceNames()
        {
            // Snippet: BatchActivateDaiEncodingProfiles(NetworkName, IEnumerable<ActivateDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ActivateDaiEncodingProfileRequest> requests = new ActivateDaiEncodingProfileRequest[]
            {
                new ActivateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchActivateDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchActivateDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiEncodingProfilesAsync</summary>
        public async Task BatchActivateDaiEncodingProfilesResourceNamesAsync()
        {
            // Snippet: BatchActivateDaiEncodingProfilesAsync(NetworkName, IEnumerable<ActivateDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchActivateDaiEncodingProfilesAsync(NetworkName, IEnumerable<ActivateDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ActivateDaiEncodingProfileRequest> requests = new ActivateDaiEncodingProfileRequest[]
            {
                new ActivateDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchActivateDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchActivateDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveDaiEncodingProfiles</summary>
        public void BatchArchiveDaiEncodingProfilesRequestObject()
        {
            // Snippet: BatchArchiveDaiEncodingProfiles(BatchArchiveDaiEncodingProfilesRequest, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveDaiEncodingProfilesRequest request = new BatchArchiveDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new ArchiveDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchArchiveDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfiles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveDaiEncodingProfilesAsync</summary>
        public async Task BatchArchiveDaiEncodingProfilesRequestObjectAsync()
        {
            // Snippet: BatchArchiveDaiEncodingProfilesAsync(BatchArchiveDaiEncodingProfilesRequest, CallSettings)
            // Additional: BatchArchiveDaiEncodingProfilesAsync(BatchArchiveDaiEncodingProfilesRequest, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveDaiEncodingProfilesRequest request = new BatchArchiveDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new ArchiveDaiEncodingProfileRequest(),
                },
            };
            // Make the request
            BatchArchiveDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfilesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveDaiEncodingProfiles</summary>
        public void BatchArchiveDaiEncodingProfiles()
        {
            // Snippet: BatchArchiveDaiEncodingProfiles(string, IEnumerable<ArchiveDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<ArchiveDaiEncodingProfileRequest> requests = new ArchiveDaiEncodingProfileRequest[]
            {
                new ArchiveDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchArchiveDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveDaiEncodingProfilesAsync</summary>
        public async Task BatchArchiveDaiEncodingProfilesAsync()
        {
            // Snippet: BatchArchiveDaiEncodingProfilesAsync(string, IEnumerable<ArchiveDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchArchiveDaiEncodingProfilesAsync(string, IEnumerable<ArchiveDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<ArchiveDaiEncodingProfileRequest> requests = new ArchiveDaiEncodingProfileRequest[]
            {
                new ArchiveDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchArchiveDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveDaiEncodingProfiles</summary>
        public void BatchArchiveDaiEncodingProfilesResourceNames()
        {
            // Snippet: BatchArchiveDaiEncodingProfiles(NetworkName, IEnumerable<ArchiveDaiEncodingProfileRequest>, CallSettings)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = DaiEncodingProfileServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ArchiveDaiEncodingProfileRequest> requests = new ArchiveDaiEncodingProfileRequest[]
            {
                new ArchiveDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchArchiveDaiEncodingProfilesResponse response = daiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfiles(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveDaiEncodingProfilesAsync</summary>
        public async Task BatchArchiveDaiEncodingProfilesResourceNamesAsync()
        {
            // Snippet: BatchArchiveDaiEncodingProfilesAsync(NetworkName, IEnumerable<ArchiveDaiEncodingProfileRequest>, CallSettings)
            // Additional: BatchArchiveDaiEncodingProfilesAsync(NetworkName, IEnumerable<ArchiveDaiEncodingProfileRequest>, CancellationToken)
            // Create client
            DaiEncodingProfileServiceClient daiEncodingProfileServiceClient = await DaiEncodingProfileServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ArchiveDaiEncodingProfileRequest> requests = new ArchiveDaiEncodingProfileRequest[]
            {
                new ArchiveDaiEncodingProfileRequest(),
            };
            // Make the request
            BatchArchiveDaiEncodingProfilesResponse response = await daiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfilesAsync(parent, requests);
            // End snippet
        }
    }
}
