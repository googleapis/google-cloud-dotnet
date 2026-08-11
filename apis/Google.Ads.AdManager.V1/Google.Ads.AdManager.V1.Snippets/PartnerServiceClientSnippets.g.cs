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
    public sealed class AllGeneratedPartnerServiceClientSnippets
    {
        /// <summary>Snippet for GetPartner</summary>
        public void GetPartnerRequestObject()
        {
            // Snippet: GetPartner(GetPartnerRequest, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            GetPartnerRequest request = new GetPartnerRequest
            {
                PartnerName = PartnerName.FromNetworkCodePartner("[NETWORK_CODE]", "[PARTNER]"),
            };
            // Make the request
            Partner response = partnerServiceClient.GetPartner(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerAsync</summary>
        public async Task GetPartnerRequestObjectAsync()
        {
            // Snippet: GetPartnerAsync(GetPartnerRequest, CallSettings)
            // Additional: GetPartnerAsync(GetPartnerRequest, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPartnerRequest request = new GetPartnerRequest
            {
                PartnerName = PartnerName.FromNetworkCodePartner("[NETWORK_CODE]", "[PARTNER]"),
            };
            // Make the request
            Partner response = await partnerServiceClient.GetPartnerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartner</summary>
        public void GetPartner()
        {
            // Snippet: GetPartner(string, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/partners/[PARTNER]";
            // Make the request
            Partner response = partnerServiceClient.GetPartner(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerAsync</summary>
        public async Task GetPartnerAsync()
        {
            // Snippet: GetPartnerAsync(string, CallSettings)
            // Additional: GetPartnerAsync(string, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/partners/[PARTNER]";
            // Make the request
            Partner response = await partnerServiceClient.GetPartnerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartner</summary>
        public void GetPartnerResourceNames()
        {
            // Snippet: GetPartner(PartnerName, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            PartnerName name = PartnerName.FromNetworkCodePartner("[NETWORK_CODE]", "[PARTNER]");
            // Make the request
            Partner response = partnerServiceClient.GetPartner(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerAsync</summary>
        public async Task GetPartnerResourceNamesAsync()
        {
            // Snippet: GetPartnerAsync(PartnerName, CallSettings)
            // Additional: GetPartnerAsync(PartnerName, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            PartnerName name = PartnerName.FromNetworkCodePartner("[NETWORK_CODE]", "[PARTNER]");
            // Make the request
            Partner response = await partnerServiceClient.GetPartnerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPartners</summary>
        public void ListPartnersRequestObject()
        {
            // Snippet: ListPartners(ListPartnersRequest, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            ListPartnersRequest request = new ListPartnersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListPartnersResponse, Partner> response = partnerServiceClient.ListPartners(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Partner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partner> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartnersAsync</summary>
        public async Task ListPartnersRequestObjectAsync()
        {
            // Snippet: ListPartnersAsync(ListPartnersRequest, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPartnersRequest request = new ListPartnersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListPartnersResponse, Partner> response = partnerServiceClient.ListPartnersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Partner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partner> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartners</summary>
        public void ListPartners()
        {
            // Snippet: ListPartners(string, string, int?, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListPartnersResponse, Partner> response = partnerServiceClient.ListPartners(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Partner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partner> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartnersAsync</summary>
        public async Task ListPartnersAsync()
        {
            // Snippet: ListPartnersAsync(string, string, int?, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListPartnersResponse, Partner> response = partnerServiceClient.ListPartnersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Partner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partner> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartners</summary>
        public void ListPartnersResourceNames()
        {
            // Snippet: ListPartners(NetworkName, string, int?, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListPartnersResponse, Partner> response = partnerServiceClient.ListPartners(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Partner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partner> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPartnersAsync</summary>
        public async Task ListPartnersResourceNamesAsync()
        {
            // Snippet: ListPartnersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListPartnersResponse, Partner> response = partnerServiceClient.ListPartnersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Partner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Partner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Partner> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Partner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePartner</summary>
        public void UpdatePartnerRequestObject()
        {
            // Snippet: UpdatePartner(UpdatePartnerRequest, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            UpdatePartnerRequest request = new UpdatePartnerRequest
            {
                Partner = new Partner(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Partner response = partnerServiceClient.UpdatePartner(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePartnerAsync</summary>
        public async Task UpdatePartnerRequestObjectAsync()
        {
            // Snippet: UpdatePartnerAsync(UpdatePartnerRequest, CallSettings)
            // Additional: UpdatePartnerAsync(UpdatePartnerRequest, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePartnerRequest request = new UpdatePartnerRequest
            {
                Partner = new Partner(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Partner response = await partnerServiceClient.UpdatePartnerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePartner</summary>
        public void UpdatePartner()
        {
            // Snippet: UpdatePartner(Partner, FieldMask, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            Partner partner = new Partner();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Partner response = partnerServiceClient.UpdatePartner(partner, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePartnerAsync</summary>
        public async Task UpdatePartnerAsync()
        {
            // Snippet: UpdatePartnerAsync(Partner, FieldMask, CallSettings)
            // Additional: UpdatePartnerAsync(Partner, FieldMask, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            Partner partner = new Partner();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Partner response = await partnerServiceClient.UpdatePartnerAsync(partner, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePartners</summary>
        public void BatchUpdatePartnersRequestObject()
        {
            // Snippet: BatchUpdatePartners(BatchUpdatePartnersRequest, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdatePartnersRequest request = new BatchUpdatePartnersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdatePartnerRequest(),
                },
            };
            // Make the request
            BatchUpdatePartnersResponse response = partnerServiceClient.BatchUpdatePartners(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePartnersAsync</summary>
        public async Task BatchUpdatePartnersRequestObjectAsync()
        {
            // Snippet: BatchUpdatePartnersAsync(BatchUpdatePartnersRequest, CallSettings)
            // Additional: BatchUpdatePartnersAsync(BatchUpdatePartnersRequest, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdatePartnersRequest request = new BatchUpdatePartnersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdatePartnerRequest(),
                },
            };
            // Make the request
            BatchUpdatePartnersResponse response = await partnerServiceClient.BatchUpdatePartnersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePartners</summary>
        public void BatchUpdatePartners()
        {
            // Snippet: BatchUpdatePartners(string, IEnumerable<UpdatePartnerRequest>, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdatePartnerRequest> requests = new UpdatePartnerRequest[]
            {
                new UpdatePartnerRequest(),
            };
            // Make the request
            BatchUpdatePartnersResponse response = partnerServiceClient.BatchUpdatePartners(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePartnersAsync</summary>
        public async Task BatchUpdatePartnersAsync()
        {
            // Snippet: BatchUpdatePartnersAsync(string, IEnumerable<UpdatePartnerRequest>, CallSettings)
            // Additional: BatchUpdatePartnersAsync(string, IEnumerable<UpdatePartnerRequest>, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdatePartnerRequest> requests = new UpdatePartnerRequest[]
            {
                new UpdatePartnerRequest(),
            };
            // Make the request
            BatchUpdatePartnersResponse response = await partnerServiceClient.BatchUpdatePartnersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePartners</summary>
        public void BatchUpdatePartnersResourceNames()
        {
            // Snippet: BatchUpdatePartners(NetworkName, IEnumerable<UpdatePartnerRequest>, CallSettings)
            // Create client
            PartnerServiceClient partnerServiceClient = PartnerServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdatePartnerRequest> requests = new UpdatePartnerRequest[]
            {
                new UpdatePartnerRequest(),
            };
            // Make the request
            BatchUpdatePartnersResponse response = partnerServiceClient.BatchUpdatePartners(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePartnersAsync</summary>
        public async Task BatchUpdatePartnersResourceNamesAsync()
        {
            // Snippet: BatchUpdatePartnersAsync(NetworkName, IEnumerable<UpdatePartnerRequest>, CallSettings)
            // Additional: BatchUpdatePartnersAsync(NetworkName, IEnumerable<UpdatePartnerRequest>, CancellationToken)
            // Create client
            PartnerServiceClient partnerServiceClient = await PartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdatePartnerRequest> requests = new UpdatePartnerRequest[]
            {
                new UpdatePartnerRequest(),
            };
            // Make the request
            BatchUpdatePartnersResponse response = await partnerServiceClient.BatchUpdatePartnersAsync(parent, requests);
            // End snippet
        }
    }
}
