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
    using Google.Cloud.CommerceProducer.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCommerceTransactionClientSnippets
    {
        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = commerceTransactionClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = commerceTransactionClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = commerceTransactionClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = commerceTransactionClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames()
        {
            // Snippet: ListServices(LocationName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = commerceTransactionClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNamesAsync()
        {
            // Snippet: ListServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = commerceTransactionClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                View = ServiceView.Unspecified,
            };
            // Make the request
            Service response = commerceTransactionClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                View = ServiceView.Unspecified,
            };
            // Make the request
            Service response = await commerceTransactionClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Service response = commerceTransactionClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Service response = await commerceTransactionClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames()
        {
            // Snippet: GetService(ServiceName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Service response = commerceTransactionClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNamesAsync()
        {
            // Snippet: GetServiceAsync(ServiceName, CallSettings)
            // Additional: GetServiceAsync(ServiceName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Service response = await commerceTransactionClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOffers</summary>
        public void ListPrivateOffersRequestObject()
        {
            // Snippet: ListPrivateOffers(ListPrivateOffersRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ListPrivateOffersRequest request = new ListPrivateOffersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> response = commerceTransactionClient.ListPrivateOffers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOffersAsync</summary>
        public async Task ListPrivateOffersRequestObjectAsync()
        {
            // Snippet: ListPrivateOffersAsync(ListPrivateOffersRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateOffersRequest request = new ListPrivateOffersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> response = commerceTransactionClient.ListPrivateOffersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PrivateOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPrivateOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOffers</summary>
        public void ListPrivateOffers()
        {
            // Snippet: ListPrivateOffers(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> response = commerceTransactionClient.ListPrivateOffers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOffersAsync</summary>
        public async Task ListPrivateOffersAsync()
        {
            // Snippet: ListPrivateOffersAsync(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> response = commerceTransactionClient.ListPrivateOffersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PrivateOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPrivateOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOffers</summary>
        public void ListPrivateOffersResourceNames()
        {
            // Snippet: ListPrivateOffers(LocationName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> response = commerceTransactionClient.ListPrivateOffers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOffersAsync</summary>
        public async Task ListPrivateOffersResourceNamesAsync()
        {
            // Snippet: ListPrivateOffersAsync(LocationName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> response = commerceTransactionClient.ListPrivateOffersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PrivateOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPrivateOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOffer</summary>
        public void GetPrivateOfferRequestObject()
        {
            // Snippet: GetPrivateOffer(GetPrivateOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            GetPrivateOfferRequest request = new GetPrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                View = PrivateOfferView.Unspecified,
            };
            // Make the request
            PrivateOffer response = commerceTransactionClient.GetPrivateOffer(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferAsync</summary>
        public async Task GetPrivateOfferRequestObjectAsync()
        {
            // Snippet: GetPrivateOfferAsync(GetPrivateOfferRequest, CallSettings)
            // Additional: GetPrivateOfferAsync(GetPrivateOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateOfferRequest request = new GetPrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                View = PrivateOfferView.Unspecified,
            };
            // Make the request
            PrivateOffer response = await commerceTransactionClient.GetPrivateOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOffer</summary>
        public void GetPrivateOffer()
        {
            // Snippet: GetPrivateOffer(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PrivateOffer response = commerceTransactionClient.GetPrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferAsync</summary>
        public async Task GetPrivateOfferAsync()
        {
            // Snippet: GetPrivateOfferAsync(string, CallSettings)
            // Additional: GetPrivateOfferAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PrivateOffer response = await commerceTransactionClient.GetPrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOffer</summary>
        public void GetPrivateOfferResourceNames()
        {
            // Snippet: GetPrivateOffer(PrivateOfferName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PrivateOffer response = commerceTransactionClient.GetPrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferAsync</summary>
        public async Task GetPrivateOfferResourceNamesAsync()
        {
            // Snippet: GetPrivateOfferAsync(PrivateOfferName, CallSettings)
            // Additional: GetPrivateOfferAsync(PrivateOfferName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PrivateOffer response = await commerceTransactionClient.GetPrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResolveAmendmentTarget</summary>
        public void ResolveAmendmentTargetRequestObject()
        {
            // Snippet: ResolveAmendmentTarget(ResolveAmendmentTargetRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ResolveAmendmentTargetRequest request = new ResolveAmendmentTargetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TargetBillingAccountAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                BaseStandardOfferAsStandardOfferName = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]"),
            };
            // Make the request
            ResolveAmendmentTargetResponse response = commerceTransactionClient.ResolveAmendmentTarget(request);
            // End snippet
        }

        /// <summary>Snippet for ResolveAmendmentTargetAsync</summary>
        public async Task ResolveAmendmentTargetRequestObjectAsync()
        {
            // Snippet: ResolveAmendmentTargetAsync(ResolveAmendmentTargetRequest, CallSettings)
            // Additional: ResolveAmendmentTargetAsync(ResolveAmendmentTargetRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ResolveAmendmentTargetRequest request = new ResolveAmendmentTargetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TargetBillingAccountAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                BaseStandardOfferAsStandardOfferName = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]"),
            };
            // Make the request
            ResolveAmendmentTargetResponse response = await commerceTransactionClient.ResolveAmendmentTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResolveAmendmentTarget</summary>
        public void ResolveAmendmentTarget()
        {
            // Snippet: ResolveAmendmentTarget(string, string, string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string targetBillingAccount = "billingAccounts/[BILLING_ACCOUNT]";
            string baseStandardOffer = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/standardOffers/[STANDARD_OFFER]";
            // Make the request
            ResolveAmendmentTargetResponse response = commerceTransactionClient.ResolveAmendmentTarget(parent, targetBillingAccount, baseStandardOffer);
            // End snippet
        }

        /// <summary>Snippet for ResolveAmendmentTargetAsync</summary>
        public async Task ResolveAmendmentTargetAsync()
        {
            // Snippet: ResolveAmendmentTargetAsync(string, string, string, CallSettings)
            // Additional: ResolveAmendmentTargetAsync(string, string, string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string targetBillingAccount = "billingAccounts/[BILLING_ACCOUNT]";
            string baseStandardOffer = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/standardOffers/[STANDARD_OFFER]";
            // Make the request
            ResolveAmendmentTargetResponse response = await commerceTransactionClient.ResolveAmendmentTargetAsync(parent, targetBillingAccount, baseStandardOffer);
            // End snippet
        }

        /// <summary>Snippet for ResolveAmendmentTarget</summary>
        public void ResolveAmendmentTargetResourceNames()
        {
            // Snippet: ResolveAmendmentTarget(LocationName, BillingAccountName, StandardOfferName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BillingAccountName targetBillingAccount = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            StandardOfferName baseStandardOffer = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]");
            // Make the request
            ResolveAmendmentTargetResponse response = commerceTransactionClient.ResolveAmendmentTarget(parent, targetBillingAccount, baseStandardOffer);
            // End snippet
        }

        /// <summary>Snippet for ResolveAmendmentTargetAsync</summary>
        public async Task ResolveAmendmentTargetResourceNamesAsync()
        {
            // Snippet: ResolveAmendmentTargetAsync(LocationName, BillingAccountName, StandardOfferName, CallSettings)
            // Additional: ResolveAmendmentTargetAsync(LocationName, BillingAccountName, StandardOfferName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BillingAccountName targetBillingAccount = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            StandardOfferName baseStandardOffer = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]");
            // Make the request
            ResolveAmendmentTargetResponse response = await commerceTransactionClient.ResolveAmendmentTargetAsync(parent, targetBillingAccount, baseStandardOffer);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateOffer</summary>
        public void CreatePrivateOfferRequestObject()
        {
            // Snippet: CreatePrivateOffer(CreatePrivateOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            CreatePrivateOfferRequest request = new CreatePrivateOfferRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateOffer = new PrivateOffer(),
            };
            // Make the request
            PrivateOffer response = commerceTransactionClient.CreatePrivateOffer(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateOfferAsync</summary>
        public async Task CreatePrivateOfferRequestObjectAsync()
        {
            // Snippet: CreatePrivateOfferAsync(CreatePrivateOfferRequest, CallSettings)
            // Additional: CreatePrivateOfferAsync(CreatePrivateOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateOfferRequest request = new CreatePrivateOfferRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateOffer = new PrivateOffer(),
            };
            // Make the request
            PrivateOffer response = await commerceTransactionClient.CreatePrivateOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOffer</summary>
        public void UpdatePrivateOfferRequestObject()
        {
            // Snippet: UpdatePrivateOffer(UpdatePrivateOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            UpdatePrivateOfferRequest request = new UpdatePrivateOfferRequest
            {
                UpdateMask = new FieldMask(),
                PrivateOffer = new PrivateOffer(),
            };
            // Make the request
            PrivateOffer response = commerceTransactionClient.UpdatePrivateOffer(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOfferAsync</summary>
        public async Task UpdatePrivateOfferRequestObjectAsync()
        {
            // Snippet: UpdatePrivateOfferAsync(UpdatePrivateOfferRequest, CallSettings)
            // Additional: UpdatePrivateOfferAsync(UpdatePrivateOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrivateOfferRequest request = new UpdatePrivateOfferRequest
            {
                UpdateMask = new FieldMask(),
                PrivateOffer = new PrivateOffer(),
            };
            // Make the request
            PrivateOffer response = await commerceTransactionClient.UpdatePrivateOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOffer</summary>
        public void UpdatePrivateOffer()
        {
            // Snippet: UpdatePrivateOffer(PrivateOffer, FieldMask, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOffer privateOffer = new PrivateOffer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateOffer response = commerceTransactionClient.UpdatePrivateOffer(privateOffer, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOfferAsync</summary>
        public async Task UpdatePrivateOfferAsync()
        {
            // Snippet: UpdatePrivateOfferAsync(PrivateOffer, FieldMask, CallSettings)
            // Additional: UpdatePrivateOfferAsync(PrivateOffer, FieldMask, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOffer privateOffer = new PrivateOffer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateOffer response = await commerceTransactionClient.UpdatePrivateOfferAsync(privateOffer, updateMask);
            // End snippet
        }

        /// <summary>Snippet for PublishPrivateOffer</summary>
        public void PublishPrivateOfferRequestObject()
        {
            // Snippet: PublishPrivateOffer(PublishPrivateOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PublishPrivateOfferRequest request = new PublishPrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                ValidateOnly = false,
            };
            // Make the request
            PrivateOffer response = commerceTransactionClient.PublishPrivateOffer(request);
            // End snippet
        }

        /// <summary>Snippet for PublishPrivateOfferAsync</summary>
        public async Task PublishPrivateOfferRequestObjectAsync()
        {
            // Snippet: PublishPrivateOfferAsync(PublishPrivateOfferRequest, CallSettings)
            // Additional: PublishPrivateOfferAsync(PublishPrivateOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PublishPrivateOfferRequest request = new PublishPrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                ValidateOnly = false,
            };
            // Make the request
            PrivateOffer response = await commerceTransactionClient.PublishPrivateOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PublishPrivateOffer</summary>
        public void PublishPrivateOffer()
        {
            // Snippet: PublishPrivateOffer(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PrivateOffer response = commerceTransactionClient.PublishPrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for PublishPrivateOfferAsync</summary>
        public async Task PublishPrivateOfferAsync()
        {
            // Snippet: PublishPrivateOfferAsync(string, CallSettings)
            // Additional: PublishPrivateOfferAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PrivateOffer response = await commerceTransactionClient.PublishPrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PublishPrivateOffer</summary>
        public void PublishPrivateOfferResourceNames()
        {
            // Snippet: PublishPrivateOffer(PrivateOfferName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PrivateOffer response = commerceTransactionClient.PublishPrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for PublishPrivateOfferAsync</summary>
        public async Task PublishPrivateOfferResourceNamesAsync()
        {
            // Snippet: PublishPrivateOfferAsync(PrivateOfferName, CallSettings)
            // Additional: PublishPrivateOfferAsync(PrivateOfferName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PrivateOffer response = await commerceTransactionClient.PublishPrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPrivateOffer</summary>
        public void CancelPrivateOfferRequestObject()
        {
            // Snippet: CancelPrivateOffer(CancelPrivateOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            CancelPrivateOfferRequest request = new CancelPrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                CancellationNote = "",
            };
            // Make the request
            PrivateOffer response = commerceTransactionClient.CancelPrivateOffer(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPrivateOfferAsync</summary>
        public async Task CancelPrivateOfferRequestObjectAsync()
        {
            // Snippet: CancelPrivateOfferAsync(CancelPrivateOfferRequest, CallSettings)
            // Additional: CancelPrivateOfferAsync(CancelPrivateOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            CancelPrivateOfferRequest request = new CancelPrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                CancellationNote = "",
            };
            // Make the request
            PrivateOffer response = await commerceTransactionClient.CancelPrivateOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPrivateOffer</summary>
        public void CancelPrivateOffer()
        {
            // Snippet: CancelPrivateOffer(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PrivateOffer response = commerceTransactionClient.CancelPrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPrivateOfferAsync</summary>
        public async Task CancelPrivateOfferAsync()
        {
            // Snippet: CancelPrivateOfferAsync(string, CallSettings)
            // Additional: CancelPrivateOfferAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PrivateOffer response = await commerceTransactionClient.CancelPrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPrivateOffer</summary>
        public void CancelPrivateOfferResourceNames()
        {
            // Snippet: CancelPrivateOffer(PrivateOfferName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PrivateOffer response = commerceTransactionClient.CancelPrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPrivateOfferAsync</summary>
        public async Task CancelPrivateOfferResourceNamesAsync()
        {
            // Snippet: CancelPrivateOfferAsync(PrivateOfferName, CallSettings)
            // Additional: CancelPrivateOfferAsync(PrivateOfferName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PrivateOffer response = await commerceTransactionClient.CancelPrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOffer</summary>
        public void DeletePrivateOfferRequestObject()
        {
            // Snippet: DeletePrivateOffer(DeletePrivateOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            DeletePrivateOfferRequest request = new DeletePrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                Force = false,
            };
            // Make the request
            commerceTransactionClient.DeletePrivateOffer(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferAsync</summary>
        public async Task DeletePrivateOfferRequestObjectAsync()
        {
            // Snippet: DeletePrivateOfferAsync(DeletePrivateOfferRequest, CallSettings)
            // Additional: DeletePrivateOfferAsync(DeletePrivateOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrivateOfferRequest request = new DeletePrivateOfferRequest
            {
                PrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                Force = false,
            };
            // Make the request
            await commerceTransactionClient.DeletePrivateOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOffer</summary>
        public void DeletePrivateOffer()
        {
            // Snippet: DeletePrivateOffer(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            commerceTransactionClient.DeletePrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferAsync</summary>
        public async Task DeletePrivateOfferAsync()
        {
            // Snippet: DeletePrivateOfferAsync(string, CallSettings)
            // Additional: DeletePrivateOfferAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            await commerceTransactionClient.DeletePrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOffer</summary>
        public void DeletePrivateOfferResourceNames()
        {
            // Snippet: DeletePrivateOffer(PrivateOfferName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            commerceTransactionClient.DeletePrivateOffer(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferAsync</summary>
        public async Task DeletePrivateOfferResourceNamesAsync()
        {
            // Snippet: DeletePrivateOfferAsync(PrivateOfferName, CallSettings)
            // Additional: DeletePrivateOfferAsync(PrivateOfferName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferName name = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            await commerceTransactionClient.DeletePrivateOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOfferDocuments</summary>
        public void ListPrivateOfferDocumentsRequestObject()
        {
            // Snippet: ListPrivateOfferDocuments(ListPrivateOfferDocumentsRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ListPrivateOfferDocumentsRequest request = new ListPrivateOfferDocumentsRequest
            {
                ParentAsPrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
            };
            // Make the request
            PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> response = commerceTransactionClient.ListPrivateOfferDocuments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateOfferDocument item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateOfferDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOfferDocument item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOfferDocument> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOfferDocument item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOfferDocumentsAsync</summary>
        public async Task ListPrivateOfferDocumentsRequestObjectAsync()
        {
            // Snippet: ListPrivateOfferDocumentsAsync(ListPrivateOfferDocumentsRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateOfferDocumentsRequest request = new ListPrivateOfferDocumentsRequest
            {
                ParentAsPrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> response = commerceTransactionClient.ListPrivateOfferDocumentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PrivateOfferDocument item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPrivateOfferDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOfferDocument item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOfferDocument> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOfferDocument item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOfferDocuments</summary>
        public void ListPrivateOfferDocuments()
        {
            // Snippet: ListPrivateOfferDocuments(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> response = commerceTransactionClient.ListPrivateOfferDocuments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateOfferDocument item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateOfferDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOfferDocument item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOfferDocument> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOfferDocument item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOfferDocumentsAsync</summary>
        public async Task ListPrivateOfferDocumentsAsync()
        {
            // Snippet: ListPrivateOfferDocumentsAsync(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> response = commerceTransactionClient.ListPrivateOfferDocumentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PrivateOfferDocument item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPrivateOfferDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOfferDocument item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOfferDocument> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOfferDocument item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOfferDocuments</summary>
        public void ListPrivateOfferDocumentsResourceNames()
        {
            // Snippet: ListPrivateOfferDocuments(PrivateOfferName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferName parent = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> response = commerceTransactionClient.ListPrivateOfferDocuments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateOfferDocument item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateOfferDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOfferDocument item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOfferDocument> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOfferDocument item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateOfferDocumentsAsync</summary>
        public async Task ListPrivateOfferDocumentsResourceNamesAsync()
        {
            // Snippet: ListPrivateOfferDocumentsAsync(PrivateOfferName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferName parent = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> response = commerceTransactionClient.ListPrivateOfferDocumentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PrivateOfferDocument item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPrivateOfferDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateOfferDocument item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateOfferDocument> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateOfferDocument item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferDocument</summary>
        public void GetPrivateOfferDocumentRequestObject()
        {
            // Snippet: GetPrivateOfferDocument(GetPrivateOfferDocumentRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            GetPrivateOfferDocumentRequest request = new GetPrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]"),
            };
            // Make the request
            PrivateOfferDocument response = commerceTransactionClient.GetPrivateOfferDocument(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferDocumentAsync</summary>
        public async Task GetPrivateOfferDocumentRequestObjectAsync()
        {
            // Snippet: GetPrivateOfferDocumentAsync(GetPrivateOfferDocumentRequest, CallSettings)
            // Additional: GetPrivateOfferDocumentAsync(GetPrivateOfferDocumentRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateOfferDocumentRequest request = new GetPrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]"),
            };
            // Make the request
            PrivateOfferDocument response = await commerceTransactionClient.GetPrivateOfferDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferDocument</summary>
        public void GetPrivateOfferDocument()
        {
            // Snippet: GetPrivateOfferDocument(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]/documents/[DOCUMENT]";
            // Make the request
            PrivateOfferDocument response = commerceTransactionClient.GetPrivateOfferDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferDocumentAsync</summary>
        public async Task GetPrivateOfferDocumentAsync()
        {
            // Snippet: GetPrivateOfferDocumentAsync(string, CallSettings)
            // Additional: GetPrivateOfferDocumentAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]/documents/[DOCUMENT]";
            // Make the request
            PrivateOfferDocument response = await commerceTransactionClient.GetPrivateOfferDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferDocument</summary>
        public void GetPrivateOfferDocumentResourceNames()
        {
            // Snippet: GetPrivateOfferDocument(PrivateOfferDocumentName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferDocumentName name = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]");
            // Make the request
            PrivateOfferDocument response = commerceTransactionClient.GetPrivateOfferDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateOfferDocumentAsync</summary>
        public async Task GetPrivateOfferDocumentResourceNamesAsync()
        {
            // Snippet: GetPrivateOfferDocumentAsync(PrivateOfferDocumentName, CallSettings)
            // Additional: GetPrivateOfferDocumentAsync(PrivateOfferDocumentName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferDocumentName name = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]");
            // Make the request
            PrivateOfferDocument response = await commerceTransactionClient.GetPrivateOfferDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateOfferDocument</summary>
        public void CreatePrivateOfferDocumentRequestObject()
        {
            // Snippet: CreatePrivateOfferDocument(CreatePrivateOfferDocumentRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            CreatePrivateOfferDocumentRequest request = new CreatePrivateOfferDocumentRequest
            {
                ParentAsPrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                PrivateOfferDocument = new PrivateOfferDocument(),
            };
            // Make the request
            PrivateOfferDocument response = commerceTransactionClient.CreatePrivateOfferDocument(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateOfferDocumentAsync</summary>
        public async Task CreatePrivateOfferDocumentRequestObjectAsync()
        {
            // Snippet: CreatePrivateOfferDocumentAsync(CreatePrivateOfferDocumentRequest, CallSettings)
            // Additional: CreatePrivateOfferDocumentAsync(CreatePrivateOfferDocumentRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateOfferDocumentRequest request = new CreatePrivateOfferDocumentRequest
            {
                ParentAsPrivateOfferName = PrivateOfferName.FromProjectLocationPrivateOffer("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]"),
                PrivateOfferDocument = new PrivateOfferDocument(),
            };
            // Make the request
            PrivateOfferDocument response = await commerceTransactionClient.CreatePrivateOfferDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOfferDocument</summary>
        public void UpdatePrivateOfferDocumentRequestObject()
        {
            // Snippet: UpdatePrivateOfferDocument(UpdatePrivateOfferDocumentRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            UpdatePrivateOfferDocumentRequest request = new UpdatePrivateOfferDocumentRequest
            {
                PrivateOfferDocument = new PrivateOfferDocument(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PrivateOfferDocument response = commerceTransactionClient.UpdatePrivateOfferDocument(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOfferDocumentAsync</summary>
        public async Task UpdatePrivateOfferDocumentRequestObjectAsync()
        {
            // Snippet: UpdatePrivateOfferDocumentAsync(UpdatePrivateOfferDocumentRequest, CallSettings)
            // Additional: UpdatePrivateOfferDocumentAsync(UpdatePrivateOfferDocumentRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrivateOfferDocumentRequest request = new UpdatePrivateOfferDocumentRequest
            {
                PrivateOfferDocument = new PrivateOfferDocument(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PrivateOfferDocument response = await commerceTransactionClient.UpdatePrivateOfferDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOfferDocument</summary>
        public void UpdatePrivateOfferDocument()
        {
            // Snippet: UpdatePrivateOfferDocument(PrivateOfferDocument, FieldMask, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferDocument privateOfferDocument = new PrivateOfferDocument();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateOfferDocument response = commerceTransactionClient.UpdatePrivateOfferDocument(privateOfferDocument, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateOfferDocumentAsync</summary>
        public async Task UpdatePrivateOfferDocumentAsync()
        {
            // Snippet: UpdatePrivateOfferDocumentAsync(PrivateOfferDocument, FieldMask, CallSettings)
            // Additional: UpdatePrivateOfferDocumentAsync(PrivateOfferDocument, FieldMask, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferDocument privateOfferDocument = new PrivateOfferDocument();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateOfferDocument response = await commerceTransactionClient.UpdatePrivateOfferDocumentAsync(privateOfferDocument, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferDocument</summary>
        public void DeletePrivateOfferDocumentRequestObject()
        {
            // Snippet: DeletePrivateOfferDocument(DeletePrivateOfferDocumentRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            DeletePrivateOfferDocumentRequest request = new DeletePrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]"),
            };
            // Make the request
            commerceTransactionClient.DeletePrivateOfferDocument(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferDocumentAsync</summary>
        public async Task DeletePrivateOfferDocumentRequestObjectAsync()
        {
            // Snippet: DeletePrivateOfferDocumentAsync(DeletePrivateOfferDocumentRequest, CallSettings)
            // Additional: DeletePrivateOfferDocumentAsync(DeletePrivateOfferDocumentRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrivateOfferDocumentRequest request = new DeletePrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]"),
            };
            // Make the request
            await commerceTransactionClient.DeletePrivateOfferDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferDocument</summary>
        public void DeletePrivateOfferDocument()
        {
            // Snippet: DeletePrivateOfferDocument(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]/documents/[DOCUMENT]";
            // Make the request
            commerceTransactionClient.DeletePrivateOfferDocument(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferDocumentAsync</summary>
        public async Task DeletePrivateOfferDocumentAsync()
        {
            // Snippet: DeletePrivateOfferDocumentAsync(string, CallSettings)
            // Additional: DeletePrivateOfferDocumentAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateOffers/[PRIVATE_OFFER]/documents/[DOCUMENT]";
            // Make the request
            await commerceTransactionClient.DeletePrivateOfferDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferDocument</summary>
        public void DeletePrivateOfferDocumentResourceNames()
        {
            // Snippet: DeletePrivateOfferDocument(PrivateOfferDocumentName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            PrivateOfferDocumentName name = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]");
            // Make the request
            commerceTransactionClient.DeletePrivateOfferDocument(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateOfferDocumentAsync</summary>
        public async Task DeletePrivateOfferDocumentResourceNamesAsync()
        {
            // Snippet: DeletePrivateOfferDocumentAsync(PrivateOfferDocumentName, CallSettings)
            // Additional: DeletePrivateOfferDocumentAsync(PrivateOfferDocumentName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            PrivateOfferDocumentName name = PrivateOfferDocumentName.FromProjectLocationPrivateOfferDocument("[PROJECT]", "[LOCATION]", "[PRIVATE_OFFER]", "[DOCUMENT]");
            // Make the request
            await commerceTransactionClient.DeletePrivateOfferDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListStandardOffers</summary>
        public void ListStandardOffersRequestObject()
        {
            // Snippet: ListStandardOffers(ListStandardOffersRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ListStandardOffersRequest request = new ListStandardOffersRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListStandardOffersResponse, StandardOffer> response = commerceTransactionClient.ListStandardOffers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StandardOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStandardOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStandardOffersAsync</summary>
        public async Task ListStandardOffersRequestObjectAsync()
        {
            // Snippet: ListStandardOffersAsync(ListStandardOffersRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ListStandardOffersRequest request = new ListStandardOffersRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> response = commerceTransactionClient.ListStandardOffersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (StandardOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListStandardOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStandardOffers</summary>
        public void ListStandardOffers()
        {
            // Snippet: ListStandardOffers(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListStandardOffersResponse, StandardOffer> response = commerceTransactionClient.ListStandardOffers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StandardOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStandardOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStandardOffersAsync</summary>
        public async Task ListStandardOffersAsync()
        {
            // Snippet: ListStandardOffersAsync(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> response = commerceTransactionClient.ListStandardOffersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (StandardOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListStandardOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStandardOffers</summary>
        public void ListStandardOffersResourceNames()
        {
            // Snippet: ListStandardOffers(ServiceName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListStandardOffersResponse, StandardOffer> response = commerceTransactionClient.ListStandardOffers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StandardOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStandardOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardOffer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStandardOffersAsync</summary>
        public async Task ListStandardOffersResourceNamesAsync()
        {
            // Snippet: ListStandardOffersAsync(ServiceName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> response = commerceTransactionClient.ListStandardOffersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (StandardOffer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListStandardOffersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StandardOffer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StandardOffer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StandardOffer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetStandardOffer</summary>
        public void GetStandardOfferRequestObject()
        {
            // Snippet: GetStandardOffer(GetStandardOfferRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            GetStandardOfferRequest request = new GetStandardOfferRequest
            {
                StandardOfferName = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]"),
                View = StandardOfferView.Unspecified,
            };
            // Make the request
            StandardOffer response = commerceTransactionClient.GetStandardOffer(request);
            // End snippet
        }

        /// <summary>Snippet for GetStandardOfferAsync</summary>
        public async Task GetStandardOfferRequestObjectAsync()
        {
            // Snippet: GetStandardOfferAsync(GetStandardOfferRequest, CallSettings)
            // Additional: GetStandardOfferAsync(GetStandardOfferRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            GetStandardOfferRequest request = new GetStandardOfferRequest
            {
                StandardOfferName = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]"),
                View = StandardOfferView.Unspecified,
            };
            // Make the request
            StandardOffer response = await commerceTransactionClient.GetStandardOfferAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStandardOffer</summary>
        public void GetStandardOffer()
        {
            // Snippet: GetStandardOffer(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/standardOffers/[STANDARD_OFFER]";
            // Make the request
            StandardOffer response = commerceTransactionClient.GetStandardOffer(name);
            // End snippet
        }

        /// <summary>Snippet for GetStandardOfferAsync</summary>
        public async Task GetStandardOfferAsync()
        {
            // Snippet: GetStandardOfferAsync(string, CallSettings)
            // Additional: GetStandardOfferAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/standardOffers/[STANDARD_OFFER]";
            // Make the request
            StandardOffer response = await commerceTransactionClient.GetStandardOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStandardOffer</summary>
        public void GetStandardOfferResourceNames()
        {
            // Snippet: GetStandardOffer(StandardOfferName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            StandardOfferName name = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]");
            // Make the request
            StandardOffer response = commerceTransactionClient.GetStandardOffer(name);
            // End snippet
        }

        /// <summary>Snippet for GetStandardOfferAsync</summary>
        public async Task GetStandardOfferResourceNamesAsync()
        {
            // Snippet: GetStandardOfferAsync(StandardOfferName, CallSettings)
            // Additional: GetStandardOfferAsync(StandardOfferName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            StandardOfferName name = StandardOfferName.FromProjectLocationServiceStandardOffer("[PROJECT]", "[LOCATION]", "[SERVICE]", "[STANDARD_OFFER]");
            // Make the request
            StandardOffer response = await commerceTransactionClient.GetStandardOfferAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSku</summary>
        public void GetSkuRequestObject()
        {
            // Snippet: GetSku(GetSkuRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            GetSkuRequest request = new GetSkuRequest
            {
                SkuName = SkuName.FromProjectLocationServiceSku("[PROJECT]", "[LOCATION]", "[SERVICE]", "[SKU]"),
            };
            // Make the request
            Sku response = commerceTransactionClient.GetSku(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkuAsync</summary>
        public async Task GetSkuRequestObjectAsync()
        {
            // Snippet: GetSkuAsync(GetSkuRequest, CallSettings)
            // Additional: GetSkuAsync(GetSkuRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            GetSkuRequest request = new GetSkuRequest
            {
                SkuName = SkuName.FromProjectLocationServiceSku("[PROJECT]", "[LOCATION]", "[SERVICE]", "[SKU]"),
            };
            // Make the request
            Sku response = await commerceTransactionClient.GetSkuAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSku</summary>
        public void GetSku()
        {
            // Snippet: GetSku(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/skus/[SKU]";
            // Make the request
            Sku response = commerceTransactionClient.GetSku(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuAsync</summary>
        public async Task GetSkuAsync()
        {
            // Snippet: GetSkuAsync(string, CallSettings)
            // Additional: GetSkuAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/skus/[SKU]";
            // Make the request
            Sku response = await commerceTransactionClient.GetSkuAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSku</summary>
        public void GetSkuResourceNames()
        {
            // Snippet: GetSku(SkuName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            SkuName name = SkuName.FromProjectLocationServiceSku("[PROJECT]", "[LOCATION]", "[SERVICE]", "[SKU]");
            // Make the request
            Sku response = commerceTransactionClient.GetSku(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuAsync</summary>
        public async Task GetSkuResourceNamesAsync()
        {
            // Snippet: GetSkuAsync(SkuName, CallSettings)
            // Additional: GetSkuAsync(SkuName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            SkuName name = SkuName.FromProjectLocationServiceSku("[PROJECT]", "[LOCATION]", "[SERVICE]", "[SKU]");
            // Make the request
            Sku response = await commerceTransactionClient.GetSkuAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusRequestObject()
        {
            // Snippet: ListSkus(ListSkusRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = commerceTransactionClient.ListSkus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusRequestObjectAsync()
        {
            // Snippet: ListSkusAsync(ListSkusRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = commerceTransactionClient.ListSkusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkus()
        {
            // Snippet: ListSkus(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = commerceTransactionClient.ListSkus(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusAsync()
        {
            // Snippet: ListSkusAsync(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = commerceTransactionClient.ListSkusAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusResourceNames()
        {
            // Snippet: ListSkus(ServiceName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = commerceTransactionClient.ListSkus(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusResourceNamesAsync()
        {
            // Snippet: ListSkusAsync(ServiceName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = commerceTransactionClient.ListSkusAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSkuGroup</summary>
        public void GetSkuGroupRequestObject()
        {
            // Snippet: GetSkuGroup(GetSkuGroupRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            GetSkuGroupRequest request = new GetSkuGroupRequest
            {
                SkuGroupName = SkuGroupName.FromProjectLocationSkuGroup("[PROJECT]", "[LOCATION]", "[SKU_GROUP]"),
            };
            // Make the request
            SkuGroup response = commerceTransactionClient.GetSkuGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkuGroupAsync</summary>
        public async Task GetSkuGroupRequestObjectAsync()
        {
            // Snippet: GetSkuGroupAsync(GetSkuGroupRequest, CallSettings)
            // Additional: GetSkuGroupAsync(GetSkuGroupRequest, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            GetSkuGroupRequest request = new GetSkuGroupRequest
            {
                SkuGroupName = SkuGroupName.FromProjectLocationSkuGroup("[PROJECT]", "[LOCATION]", "[SKU_GROUP]"),
            };
            // Make the request
            SkuGroup response = await commerceTransactionClient.GetSkuGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkuGroup</summary>
        public void GetSkuGroup()
        {
            // Snippet: GetSkuGroup(string, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skuGroups/[SKU_GROUP]";
            // Make the request
            SkuGroup response = commerceTransactionClient.GetSkuGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuGroupAsync</summary>
        public async Task GetSkuGroupAsync()
        {
            // Snippet: GetSkuGroupAsync(string, CallSettings)
            // Additional: GetSkuGroupAsync(string, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skuGroups/[SKU_GROUP]";
            // Make the request
            SkuGroup response = await commerceTransactionClient.GetSkuGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuGroup</summary>
        public void GetSkuGroupResourceNames()
        {
            // Snippet: GetSkuGroup(SkuGroupName, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            SkuGroupName name = SkuGroupName.FromProjectLocationSkuGroup("[PROJECT]", "[LOCATION]", "[SKU_GROUP]");
            // Make the request
            SkuGroup response = commerceTransactionClient.GetSkuGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuGroupAsync</summary>
        public async Task GetSkuGroupResourceNamesAsync()
        {
            // Snippet: GetSkuGroupAsync(SkuGroupName, CallSettings)
            // Additional: GetSkuGroupAsync(SkuGroupName, CancellationToken)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            SkuGroupName name = SkuGroupName.FromProjectLocationSkuGroup("[PROJECT]", "[LOCATION]", "[SKU_GROUP]");
            // Make the request
            SkuGroup response = await commerceTransactionClient.GetSkuGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSkuGroups</summary>
        public void ListSkuGroupsRequestObject()
        {
            // Snippet: ListSkuGroups(ListSkuGroupsRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            ListSkuGroupsRequest request = new ListSkuGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSkuGroupsResponse, SkuGroup> response = commerceTransactionClient.ListSkuGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SkuGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkuGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkuGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkuGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkuGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkuGroupsAsync</summary>
        public async Task ListSkuGroupsRequestObjectAsync()
        {
            // Snippet: ListSkuGroupsAsync(ListSkuGroupsRequest, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            ListSkuGroupsRequest request = new ListSkuGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> response = commerceTransactionClient.ListSkuGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SkuGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkuGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkuGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkuGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkuGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkuGroups</summary>
        public void ListSkuGroups()
        {
            // Snippet: ListSkuGroups(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSkuGroupsResponse, SkuGroup> response = commerceTransactionClient.ListSkuGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SkuGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkuGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkuGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkuGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkuGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkuGroupsAsync</summary>
        public async Task ListSkuGroupsAsync()
        {
            // Snippet: ListSkuGroupsAsync(string, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> response = commerceTransactionClient.ListSkuGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SkuGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkuGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkuGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkuGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkuGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkuGroups</summary>
        public void ListSkuGroupsResourceNames()
        {
            // Snippet: ListSkuGroups(LocationName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = CommerceTransactionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSkuGroupsResponse, SkuGroup> response = commerceTransactionClient.ListSkuGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SkuGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkuGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkuGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkuGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkuGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkuGroupsAsync</summary>
        public async Task ListSkuGroupsResourceNamesAsync()
        {
            // Snippet: ListSkuGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CommerceTransactionClient commerceTransactionClient = await CommerceTransactionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> response = commerceTransactionClient.ListSkuGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SkuGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSkuGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SkuGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SkuGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SkuGroup item in singlePage)
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
