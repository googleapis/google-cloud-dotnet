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
    using Google.Cloud.BigQuery.Reservation.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReservationServiceClientSnippets
    {
        /// <summary>Snippet for CreateReservation</summary>
        public void CreateReservationRequestObject()
        {
            // Snippet: CreateReservation(CreateReservationRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "",
                Reservation = new Reservation(),
            };
            // Make the request
            Reservation response = reservationServiceClient.CreateReservation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReservationAsync</summary>
        public async Task CreateReservationRequestObjectAsync()
        {
            // Snippet: CreateReservationAsync(CreateReservationRequest, CallSettings)
            // Additional: CreateReservationAsync(CreateReservationRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateReservationRequest request = new CreateReservationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReservationId = "",
                Reservation = new Reservation(),
            };
            // Make the request
            Reservation response = await reservationServiceClient.CreateReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReservation</summary>
        public void CreateReservation()
        {
            // Snippet: CreateReservation(string, Reservation, string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = reservationServiceClient.CreateReservation(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for CreateReservationAsync</summary>
        public async Task CreateReservationAsync()
        {
            // Snippet: CreateReservationAsync(string, Reservation, string, CallSettings)
            // Additional: CreateReservationAsync(string, Reservation, string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = await reservationServiceClient.CreateReservationAsync(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for CreateReservation</summary>
        public void CreateReservationResourceNames()
        {
            // Snippet: CreateReservation(LocationName, Reservation, string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = reservationServiceClient.CreateReservation(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for CreateReservationAsync</summary>
        public async Task CreateReservationResourceNamesAsync()
        {
            // Snippet: CreateReservationAsync(LocationName, Reservation, string, CallSettings)
            // Additional: CreateReservationAsync(LocationName, Reservation, string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Reservation reservation = new Reservation();
            string reservationId = "";
            // Make the request
            Reservation response = await reservationServiceClient.CreateReservationAsync(parent, reservation, reservationId);
            // End snippet
        }

        /// <summary>Snippet for ListReservations</summary>
        public void ListReservationsRequestObject()
        {
            // Snippet: ListReservations(ListReservationsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListReservationsResponse, Reservation> response = reservationServiceClient.ListReservations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationsAsync</summary>
        public async Task ListReservationsRequestObjectAsync()
        {
            // Snippet: ListReservationsAsync(ListReservationsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListReservationsResponse, Reservation> response = reservationServiceClient.ListReservationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservations</summary>
        public void ListReservations()
        {
            // Snippet: ListReservations(string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReservationsResponse, Reservation> response = reservationServiceClient.ListReservations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationsAsync</summary>
        public async Task ListReservationsAsync()
        {
            // Snippet: ListReservationsAsync(string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReservationsResponse, Reservation> response = reservationServiceClient.ListReservationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservations</summary>
        public void ListReservationsResourceNames()
        {
            // Snippet: ListReservations(LocationName, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReservationsResponse, Reservation> response = reservationServiceClient.ListReservations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReservationsAsync</summary>
        public async Task ListReservationsResourceNamesAsync()
        {
            // Snippet: ListReservationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReservationsResponse, Reservation> response = reservationServiceClient.ListReservationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReservation</summary>
        public void GetReservationRequestObject()
        {
            // Snippet: GetReservation(GetReservationRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            Reservation response = reservationServiceClient.GetReservation(request);
            // End snippet
        }

        /// <summary>Snippet for GetReservationAsync</summary>
        public async Task GetReservationRequestObjectAsync()
        {
            // Snippet: GetReservationAsync(GetReservationRequest, CallSettings)
            // Additional: GetReservationAsync(GetReservationRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            Reservation response = await reservationServiceClient.GetReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReservation</summary>
        public void GetReservation()
        {
            // Snippet: GetReservation(string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            Reservation response = reservationServiceClient.GetReservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetReservationAsync</summary>
        public async Task GetReservationAsync()
        {
            // Snippet: GetReservationAsync(string, CallSettings)
            // Additional: GetReservationAsync(string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            Reservation response = await reservationServiceClient.GetReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReservation</summary>
        public void GetReservationResourceNames()
        {
            // Snippet: GetReservation(ReservationName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            Reservation response = reservationServiceClient.GetReservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetReservationAsync</summary>
        public async Task GetReservationResourceNamesAsync()
        {
            // Snippet: GetReservationAsync(ReservationName, CallSettings)
            // Additional: GetReservationAsync(ReservationName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            Reservation response = await reservationServiceClient.GetReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservation</summary>
        public void DeleteReservationRequestObject()
        {
            // Snippet: DeleteReservation(DeleteReservationRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            reservationServiceClient.DeleteReservation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservationAsync</summary>
        public async Task DeleteReservationRequestObjectAsync()
        {
            // Snippet: DeleteReservationAsync(DeleteReservationRequest, CallSettings)
            // Additional: DeleteReservationAsync(DeleteReservationRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                ReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            await reservationServiceClient.DeleteReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservation</summary>
        public void DeleteReservation()
        {
            // Snippet: DeleteReservation(string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            reservationServiceClient.DeleteReservation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservationAsync</summary>
        public async Task DeleteReservationAsync()
        {
            // Snippet: DeleteReservationAsync(string, CallSettings)
            // Additional: DeleteReservationAsync(string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            await reservationServiceClient.DeleteReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservation</summary>
        public void DeleteReservationResourceNames()
        {
            // Snippet: DeleteReservation(ReservationName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            reservationServiceClient.DeleteReservation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReservationAsync</summary>
        public async Task DeleteReservationResourceNamesAsync()
        {
            // Snippet: DeleteReservationAsync(ReservationName, CallSettings)
            // Additional: DeleteReservationAsync(ReservationName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName name = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            await reservationServiceClient.DeleteReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservation</summary>
        public void UpdateReservationRequestObject()
        {
            // Snippet: UpdateReservation(UpdateReservationRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Reservation response = reservationServiceClient.UpdateReservation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservationAsync</summary>
        public async Task UpdateReservationRequestObjectAsync()
        {
            // Snippet: UpdateReservationAsync(UpdateReservationRequest, CallSettings)
            // Additional: UpdateReservationAsync(UpdateReservationRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Reservation = new Reservation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Reservation response = await reservationServiceClient.UpdateReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservation</summary>
        public void UpdateReservation()
        {
            // Snippet: UpdateReservation(Reservation, FieldMask, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            Reservation reservation = new Reservation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Reservation response = reservationServiceClient.UpdateReservation(reservation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReservationAsync</summary>
        public async Task UpdateReservationAsync()
        {
            // Snippet: UpdateReservationAsync(Reservation, FieldMask, CallSettings)
            // Additional: UpdateReservationAsync(Reservation, FieldMask, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Reservation reservation = new Reservation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Reservation response = await reservationServiceClient.UpdateReservationAsync(reservation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateCapacityCommitment</summary>
        public void CreateCapacityCommitmentRequestObject()
        {
            // Snippet: CreateCapacityCommitment(CreateCapacityCommitmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
                EnforceSingleAdminProjectPerOrg = false,
                CapacityCommitmentId = "",
            };
            // Make the request
            CapacityCommitment response = reservationServiceClient.CreateCapacityCommitment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCapacityCommitmentAsync</summary>
        public async Task CreateCapacityCommitmentRequestObjectAsync()
        {
            // Snippet: CreateCapacityCommitmentAsync(CreateCapacityCommitmentRequest, CallSettings)
            // Additional: CreateCapacityCommitmentAsync(CreateCapacityCommitmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCapacityCommitmentRequest request = new CreateCapacityCommitmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitment = new CapacityCommitment(),
                EnforceSingleAdminProjectPerOrg = false,
                CapacityCommitmentId = "",
            };
            // Make the request
            CapacityCommitment response = await reservationServiceClient.CreateCapacityCommitmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCapacityCommitment</summary>
        public void CreateCapacityCommitment()
        {
            // Snippet: CreateCapacityCommitment(string, CapacityCommitment, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CapacityCommitment capacityCommitment = new CapacityCommitment();
            // Make the request
            CapacityCommitment response = reservationServiceClient.CreateCapacityCommitment(parent, capacityCommitment);
            // End snippet
        }

        /// <summary>Snippet for CreateCapacityCommitmentAsync</summary>
        public async Task CreateCapacityCommitmentAsync()
        {
            // Snippet: CreateCapacityCommitmentAsync(string, CapacityCommitment, CallSettings)
            // Additional: CreateCapacityCommitmentAsync(string, CapacityCommitment, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CapacityCommitment capacityCommitment = new CapacityCommitment();
            // Make the request
            CapacityCommitment response = await reservationServiceClient.CreateCapacityCommitmentAsync(parent, capacityCommitment);
            // End snippet
        }

        /// <summary>Snippet for CreateCapacityCommitment</summary>
        public void CreateCapacityCommitmentResourceNames()
        {
            // Snippet: CreateCapacityCommitment(LocationName, CapacityCommitment, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CapacityCommitment capacityCommitment = new CapacityCommitment();
            // Make the request
            CapacityCommitment response = reservationServiceClient.CreateCapacityCommitment(parent, capacityCommitment);
            // End snippet
        }

        /// <summary>Snippet for CreateCapacityCommitmentAsync</summary>
        public async Task CreateCapacityCommitmentResourceNamesAsync()
        {
            // Snippet: CreateCapacityCommitmentAsync(LocationName, CapacityCommitment, CallSettings)
            // Additional: CreateCapacityCommitmentAsync(LocationName, CapacityCommitment, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CapacityCommitment capacityCommitment = new CapacityCommitment();
            // Make the request
            CapacityCommitment response = await reservationServiceClient.CreateCapacityCommitmentAsync(parent, capacityCommitment);
            // End snippet
        }

        /// <summary>Snippet for ListCapacityCommitments</summary>
        public void ListCapacityCommitmentsRequestObject()
        {
            // Snippet: ListCapacityCommitments(ListCapacityCommitmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ListCapacityCommitmentsRequest request = new ListCapacityCommitmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> response = reservationServiceClient.ListCapacityCommitments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CapacityCommitment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCapacityCommitmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityCommitment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityCommitment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityCommitment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCapacityCommitmentsAsync</summary>
        public async Task ListCapacityCommitmentsRequestObjectAsync()
        {
            // Snippet: ListCapacityCommitmentsAsync(ListCapacityCommitmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCapacityCommitmentsRequest request = new ListCapacityCommitmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> response = reservationServiceClient.ListCapacityCommitmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CapacityCommitment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCapacityCommitmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityCommitment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityCommitment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityCommitment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCapacityCommitments</summary>
        public void ListCapacityCommitments()
        {
            // Snippet: ListCapacityCommitments(string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> response = reservationServiceClient.ListCapacityCommitments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CapacityCommitment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCapacityCommitmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityCommitment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityCommitment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityCommitment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCapacityCommitmentsAsync</summary>
        public async Task ListCapacityCommitmentsAsync()
        {
            // Snippet: ListCapacityCommitmentsAsync(string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> response = reservationServiceClient.ListCapacityCommitmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CapacityCommitment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCapacityCommitmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityCommitment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityCommitment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityCommitment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCapacityCommitments</summary>
        public void ListCapacityCommitmentsResourceNames()
        {
            // Snippet: ListCapacityCommitments(LocationName, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> response = reservationServiceClient.ListCapacityCommitments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CapacityCommitment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCapacityCommitmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityCommitment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityCommitment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityCommitment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCapacityCommitmentsAsync</summary>
        public async Task ListCapacityCommitmentsResourceNamesAsync()
        {
            // Snippet: ListCapacityCommitmentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCapacityCommitmentsResponse, CapacityCommitment> response = reservationServiceClient.ListCapacityCommitmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CapacityCommitment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCapacityCommitmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityCommitment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityCommitment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityCommitment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCapacityCommitment</summary>
        public void GetCapacityCommitmentRequestObject()
        {
            // Snippet: GetCapacityCommitment(GetCapacityCommitmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            // Make the request
            CapacityCommitment response = reservationServiceClient.GetCapacityCommitment(request);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityCommitmentAsync</summary>
        public async Task GetCapacityCommitmentRequestObjectAsync()
        {
            // Snippet: GetCapacityCommitmentAsync(GetCapacityCommitmentRequest, CallSettings)
            // Additional: GetCapacityCommitmentAsync(GetCapacityCommitmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCapacityCommitmentRequest request = new GetCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
            };
            // Make the request
            CapacityCommitment response = await reservationServiceClient.GetCapacityCommitmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityCommitment</summary>
        public void GetCapacityCommitment()
        {
            // Snippet: GetCapacityCommitment(string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/capacityCommitments/[CAPACITY_COMMITMENT]";
            // Make the request
            CapacityCommitment response = reservationServiceClient.GetCapacityCommitment(name);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityCommitmentAsync</summary>
        public async Task GetCapacityCommitmentAsync()
        {
            // Snippet: GetCapacityCommitmentAsync(string, CallSettings)
            // Additional: GetCapacityCommitmentAsync(string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/capacityCommitments/[CAPACITY_COMMITMENT]";
            // Make the request
            CapacityCommitment response = await reservationServiceClient.GetCapacityCommitmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityCommitment</summary>
        public void GetCapacityCommitmentResourceNames()
        {
            // Snippet: GetCapacityCommitment(CapacityCommitmentName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CapacityCommitmentName name = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]");
            // Make the request
            CapacityCommitment response = reservationServiceClient.GetCapacityCommitment(name);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityCommitmentAsync</summary>
        public async Task GetCapacityCommitmentResourceNamesAsync()
        {
            // Snippet: GetCapacityCommitmentAsync(CapacityCommitmentName, CallSettings)
            // Additional: GetCapacityCommitmentAsync(CapacityCommitmentName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityCommitmentName name = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]");
            // Make the request
            CapacityCommitment response = await reservationServiceClient.GetCapacityCommitmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCapacityCommitment</summary>
        public void DeleteCapacityCommitmentRequestObject()
        {
            // Snippet: DeleteCapacityCommitment(DeleteCapacityCommitmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                Force = false,
            };
            // Make the request
            reservationServiceClient.DeleteCapacityCommitment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCapacityCommitmentAsync</summary>
        public async Task DeleteCapacityCommitmentRequestObjectAsync()
        {
            // Snippet: DeleteCapacityCommitmentAsync(DeleteCapacityCommitmentRequest, CallSettings)
            // Additional: DeleteCapacityCommitmentAsync(DeleteCapacityCommitmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCapacityCommitmentRequest request = new DeleteCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                Force = false,
            };
            // Make the request
            await reservationServiceClient.DeleteCapacityCommitmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCapacityCommitment</summary>
        public void DeleteCapacityCommitment()
        {
            // Snippet: DeleteCapacityCommitment(string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/capacityCommitments/[CAPACITY_COMMITMENT]";
            // Make the request
            reservationServiceClient.DeleteCapacityCommitment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCapacityCommitmentAsync</summary>
        public async Task DeleteCapacityCommitmentAsync()
        {
            // Snippet: DeleteCapacityCommitmentAsync(string, CallSettings)
            // Additional: DeleteCapacityCommitmentAsync(string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/capacityCommitments/[CAPACITY_COMMITMENT]";
            // Make the request
            await reservationServiceClient.DeleteCapacityCommitmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCapacityCommitment</summary>
        public void DeleteCapacityCommitmentResourceNames()
        {
            // Snippet: DeleteCapacityCommitment(CapacityCommitmentName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CapacityCommitmentName name = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]");
            // Make the request
            reservationServiceClient.DeleteCapacityCommitment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCapacityCommitmentAsync</summary>
        public async Task DeleteCapacityCommitmentResourceNamesAsync()
        {
            // Snippet: DeleteCapacityCommitmentAsync(CapacityCommitmentName, CallSettings)
            // Additional: DeleteCapacityCommitmentAsync(CapacityCommitmentName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityCommitmentName name = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]");
            // Make the request
            await reservationServiceClient.DeleteCapacityCommitmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCapacityCommitment</summary>
        public void UpdateCapacityCommitmentRequestObject()
        {
            // Snippet: UpdateCapacityCommitment(UpdateCapacityCommitmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            UpdateCapacityCommitmentRequest request = new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = new CapacityCommitment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CapacityCommitment response = reservationServiceClient.UpdateCapacityCommitment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCapacityCommitmentAsync</summary>
        public async Task UpdateCapacityCommitmentRequestObjectAsync()
        {
            // Snippet: UpdateCapacityCommitmentAsync(UpdateCapacityCommitmentRequest, CallSettings)
            // Additional: UpdateCapacityCommitmentAsync(UpdateCapacityCommitmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCapacityCommitmentRequest request = new UpdateCapacityCommitmentRequest
            {
                CapacityCommitment = new CapacityCommitment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CapacityCommitment response = await reservationServiceClient.UpdateCapacityCommitmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCapacityCommitment</summary>
        public void UpdateCapacityCommitment()
        {
            // Snippet: UpdateCapacityCommitment(CapacityCommitment, FieldMask, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CapacityCommitment capacityCommitment = new CapacityCommitment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CapacityCommitment response = reservationServiceClient.UpdateCapacityCommitment(capacityCommitment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCapacityCommitmentAsync</summary>
        public async Task UpdateCapacityCommitmentAsync()
        {
            // Snippet: UpdateCapacityCommitmentAsync(CapacityCommitment, FieldMask, CallSettings)
            // Additional: UpdateCapacityCommitmentAsync(CapacityCommitment, FieldMask, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityCommitment capacityCommitment = new CapacityCommitment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CapacityCommitment response = await reservationServiceClient.UpdateCapacityCommitmentAsync(capacityCommitment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for SplitCapacityCommitment</summary>
        public void SplitCapacityCommitmentRequestObject()
        {
            // Snippet: SplitCapacityCommitment(SplitCapacityCommitmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = 0L,
            };
            // Make the request
            SplitCapacityCommitmentResponse response = reservationServiceClient.SplitCapacityCommitment(request);
            // End snippet
        }

        /// <summary>Snippet for SplitCapacityCommitmentAsync</summary>
        public async Task SplitCapacityCommitmentRequestObjectAsync()
        {
            // Snippet: SplitCapacityCommitmentAsync(SplitCapacityCommitmentRequest, CallSettings)
            // Additional: SplitCapacityCommitmentAsync(SplitCapacityCommitmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SplitCapacityCommitmentRequest request = new SplitCapacityCommitmentRequest
            {
                CapacityCommitmentName = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]"),
                SlotCount = 0L,
            };
            // Make the request
            SplitCapacityCommitmentResponse response = await reservationServiceClient.SplitCapacityCommitmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SplitCapacityCommitment</summary>
        public void SplitCapacityCommitment()
        {
            // Snippet: SplitCapacityCommitment(string, long, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/capacityCommitments/[CAPACITY_COMMITMENT]";
            long slotCount = 0L;
            // Make the request
            SplitCapacityCommitmentResponse response = reservationServiceClient.SplitCapacityCommitment(name, slotCount);
            // End snippet
        }

        /// <summary>Snippet for SplitCapacityCommitmentAsync</summary>
        public async Task SplitCapacityCommitmentAsync()
        {
            // Snippet: SplitCapacityCommitmentAsync(string, long, CallSettings)
            // Additional: SplitCapacityCommitmentAsync(string, long, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/capacityCommitments/[CAPACITY_COMMITMENT]";
            long slotCount = 0L;
            // Make the request
            SplitCapacityCommitmentResponse response = await reservationServiceClient.SplitCapacityCommitmentAsync(name, slotCount);
            // End snippet
        }

        /// <summary>Snippet for SplitCapacityCommitment</summary>
        public void SplitCapacityCommitmentResourceNames()
        {
            // Snippet: SplitCapacityCommitment(CapacityCommitmentName, long, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CapacityCommitmentName name = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]");
            long slotCount = 0L;
            // Make the request
            SplitCapacityCommitmentResponse response = reservationServiceClient.SplitCapacityCommitment(name, slotCount);
            // End snippet
        }

        /// <summary>Snippet for SplitCapacityCommitmentAsync</summary>
        public async Task SplitCapacityCommitmentResourceNamesAsync()
        {
            // Snippet: SplitCapacityCommitmentAsync(CapacityCommitmentName, long, CallSettings)
            // Additional: SplitCapacityCommitmentAsync(CapacityCommitmentName, long, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityCommitmentName name = CapacityCommitmentName.FromProjectLocationCapacityCommitment("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]");
            long slotCount = 0L;
            // Make the request
            SplitCapacityCommitmentResponse response = await reservationServiceClient.SplitCapacityCommitmentAsync(name, slotCount);
            // End snippet
        }

        /// <summary>Snippet for MergeCapacityCommitments</summary>
        public void MergeCapacityCommitmentsRequestObject()
        {
            // Snippet: MergeCapacityCommitments(MergeCapacityCommitmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds = { "", },
            };
            // Make the request
            CapacityCommitment response = reservationServiceClient.MergeCapacityCommitments(request);
            // End snippet
        }

        /// <summary>Snippet for MergeCapacityCommitmentsAsync</summary>
        public async Task MergeCapacityCommitmentsRequestObjectAsync()
        {
            // Snippet: MergeCapacityCommitmentsAsync(MergeCapacityCommitmentsRequest, CallSettings)
            // Additional: MergeCapacityCommitmentsAsync(MergeCapacityCommitmentsRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MergeCapacityCommitmentsRequest request = new MergeCapacityCommitmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CapacityCommitmentIds = { "", },
            };
            // Make the request
            CapacityCommitment response = await reservationServiceClient.MergeCapacityCommitmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MergeCapacityCommitments</summary>
        public void MergeCapacityCommitments()
        {
            // Snippet: MergeCapacityCommitments(string, IEnumerable<string>, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> capacityCommitmentIds = new string[] { "", };
            // Make the request
            CapacityCommitment response = reservationServiceClient.MergeCapacityCommitments(parent, capacityCommitmentIds);
            // End snippet
        }

        /// <summary>Snippet for MergeCapacityCommitmentsAsync</summary>
        public async Task MergeCapacityCommitmentsAsync()
        {
            // Snippet: MergeCapacityCommitmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: MergeCapacityCommitmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> capacityCommitmentIds = new string[] { "", };
            // Make the request
            CapacityCommitment response = await reservationServiceClient.MergeCapacityCommitmentsAsync(parent, capacityCommitmentIds);
            // End snippet
        }

        /// <summary>Snippet for MergeCapacityCommitments</summary>
        public void MergeCapacityCommitmentsResourceNames()
        {
            // Snippet: MergeCapacityCommitments(LocationName, IEnumerable<string>, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> capacityCommitmentIds = new string[] { "", };
            // Make the request
            CapacityCommitment response = reservationServiceClient.MergeCapacityCommitments(parent, capacityCommitmentIds);
            // End snippet
        }

        /// <summary>Snippet for MergeCapacityCommitmentsAsync</summary>
        public async Task MergeCapacityCommitmentsResourceNamesAsync()
        {
            // Snippet: MergeCapacityCommitmentsAsync(LocationName, IEnumerable<string>, CallSettings)
            // Additional: MergeCapacityCommitmentsAsync(LocationName, IEnumerable<string>, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> capacityCommitmentIds = new string[] { "", };
            // Make the request
            CapacityCommitment response = await reservationServiceClient.MergeCapacityCommitmentsAsync(parent, capacityCommitmentIds);
            // End snippet
        }

        /// <summary>Snippet for CreateAssignment</summary>
        public void CreateAssignmentRequestObject()
        {
            // Snippet: CreateAssignment(CreateAssignmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
                AssignmentId = "",
            };
            // Make the request
            Assignment response = reservationServiceClient.CreateAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssignmentAsync</summary>
        public async Task CreateAssignmentRequestObjectAsync()
        {
            // Snippet: CreateAssignmentAsync(CreateAssignmentRequest, CallSettings)
            // Additional: CreateAssignmentAsync(CreateAssignmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
                AssignmentId = "",
            };
            // Make the request
            Assignment response = await reservationServiceClient.CreateAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssignment</summary>
        public void CreateAssignment()
        {
            // Snippet: CreateAssignment(string, Assignment, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            Assignment assignment = new Assignment();
            // Make the request
            Assignment response = reservationServiceClient.CreateAssignment(parent, assignment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssignmentAsync</summary>
        public async Task CreateAssignmentAsync()
        {
            // Snippet: CreateAssignmentAsync(string, Assignment, CallSettings)
            // Additional: CreateAssignmentAsync(string, Assignment, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            Assignment assignment = new Assignment();
            // Make the request
            Assignment response = await reservationServiceClient.CreateAssignmentAsync(parent, assignment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssignment</summary>
        public void CreateAssignmentResourceNames()
        {
            // Snippet: CreateAssignment(ReservationName, Assignment, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ReservationName parent = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            Assignment assignment = new Assignment();
            // Make the request
            Assignment response = reservationServiceClient.CreateAssignment(parent, assignment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssignmentAsync</summary>
        public async Task CreateAssignmentResourceNamesAsync()
        {
            // Snippet: CreateAssignmentAsync(ReservationName, Assignment, CallSettings)
            // Additional: CreateAssignmentAsync(ReservationName, Assignment, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName parent = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            Assignment assignment = new Assignment();
            // Make the request
            Assignment response = await reservationServiceClient.CreateAssignmentAsync(parent, assignment);
            // End snippet
        }

        /// <summary>Snippet for ListAssignments</summary>
        public void ListAssignmentsRequestObject()
        {
            // Snippet: ListAssignments(ListAssignmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ListAssignmentsRequest request = new ListAssignmentsRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            PagedEnumerable<ListAssignmentsResponse, Assignment> response = reservationServiceClient.ListAssignments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssignmentsAsync</summary>
        public async Task ListAssignmentsRequestObjectAsync()
        {
            // Snippet: ListAssignmentsAsync(ListAssignmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAssignmentsRequest request = new ListAssignmentsRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> response = reservationServiceClient.ListAssignmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssignments</summary>
        public void ListAssignments()
        {
            // Snippet: ListAssignments(string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            PagedEnumerable<ListAssignmentsResponse, Assignment> response = reservationServiceClient.ListAssignments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssignmentsAsync</summary>
        public async Task ListAssignmentsAsync()
        {
            // Snippet: ListAssignmentsAsync(string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> response = reservationServiceClient.ListAssignmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssignments</summary>
        public void ListAssignmentsResourceNames()
        {
            // Snippet: ListAssignments(ReservationName, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            ReservationName parent = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            PagedEnumerable<ListAssignmentsResponse, Assignment> response = reservationServiceClient.ListAssignments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssignmentsAsync</summary>
        public async Task ListAssignmentsResourceNamesAsync()
        {
            // Snippet: ListAssignmentsAsync(ReservationName, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReservationName parent = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            PagedAsyncEnumerable<ListAssignmentsResponse, Assignment> response = reservationServiceClient.ListAssignmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAssignment</summary>
        public void DeleteAssignmentRequestObject()
        {
            // Snippet: DeleteAssignment(DeleteAssignmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            // Make the request
            reservationServiceClient.DeleteAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssignmentAsync</summary>
        public async Task DeleteAssignmentRequestObjectAsync()
        {
            // Snippet: DeleteAssignmentAsync(DeleteAssignmentRequest, CallSettings)
            // Additional: DeleteAssignmentAsync(DeleteAssignmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAssignmentRequest request = new DeleteAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
            };
            // Make the request
            await reservationServiceClient.DeleteAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssignment</summary>
        public void DeleteAssignment()
        {
            // Snippet: DeleteAssignment(string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]/assignments/[ASSIGNMENT]";
            // Make the request
            reservationServiceClient.DeleteAssignment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssignmentAsync</summary>
        public async Task DeleteAssignmentAsync()
        {
            // Snippet: DeleteAssignmentAsync(string, CallSettings)
            // Additional: DeleteAssignmentAsync(string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]/assignments/[ASSIGNMENT]";
            // Make the request
            await reservationServiceClient.DeleteAssignmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssignment</summary>
        public void DeleteAssignmentResourceNames()
        {
            // Snippet: DeleteAssignment(AssignmentName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            AssignmentName name = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]");
            // Make the request
            reservationServiceClient.DeleteAssignment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssignmentAsync</summary>
        public async Task DeleteAssignmentResourceNamesAsync()
        {
            // Snippet: DeleteAssignmentAsync(AssignmentName, CallSettings)
            // Additional: DeleteAssignmentAsync(AssignmentName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssignmentName name = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]");
            // Make the request
            await reservationServiceClient.DeleteAssignmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchAssignments</summary>
        public void SearchAssignmentsRequestObject()
        {
            // Snippet: SearchAssignments(SearchAssignmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            SearchAssignmentsRequest request = new SearchAssignmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
            };
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<SearchAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAssignments(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssignmentsAsync</summary>
        public async Task SearchAssignmentsRequestObjectAsync()
        {
            // Snippet: SearchAssignmentsAsync(SearchAssignmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAssignmentsRequest request = new SearchAssignmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
            };
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAssignmentsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssignments</summary>
        public void SearchAssignments()
        {
            // Snippet: SearchAssignments(string, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<SearchAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAssignments(parent, query);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssignmentsAsync</summary>
        public async Task SearchAssignmentsAsync()
        {
            // Snippet: SearchAssignmentsAsync(string, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAssignmentsAsync(parent, query);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssignments</summary>
        public void SearchAssignmentsResourceNames()
        {
            // Snippet: SearchAssignments(LocationName, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<SearchAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAssignments(parent, query);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAssignmentsAsync</summary>
        public async Task SearchAssignmentsResourceNamesAsync()
        {
            // Snippet: SearchAssignmentsAsync(LocationName, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<SearchAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAssignmentsAsync(parent, query);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllAssignments</summary>
        public void SearchAllAssignmentsRequestObject()
        {
            // Snippet: SearchAllAssignments(SearchAllAssignmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            SearchAllAssignmentsRequest request = new SearchAllAssignmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchAllAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAllAssignments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllAssignmentsAsync</summary>
        public async Task SearchAllAssignmentsRequestObjectAsync()
        {
            // Snippet: SearchAllAssignmentsAsync(SearchAllAssignmentsRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAllAssignmentsRequest request = new SearchAllAssignmentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAllAssignmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllAssignments</summary>
        public void SearchAllAssignments()
        {
            // Snippet: SearchAllAssignments(string, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedEnumerable<SearchAllAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAllAssignments(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllAssignmentsAsync</summary>
        public async Task SearchAllAssignmentsAsync()
        {
            // Snippet: SearchAllAssignmentsAsync(string, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAllAssignmentsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllAssignments</summary>
        public void SearchAllAssignmentsResourceNames()
        {
            // Snippet: SearchAllAssignments(LocationName, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedEnumerable<SearchAllAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAllAssignments(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Assignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllAssignmentsAsync</summary>
        public async Task SearchAllAssignmentsResourceNamesAsync()
        {
            // Snippet: SearchAllAssignmentsAsync(LocationName, string, string, int?, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchAllAssignmentsResponse, Assignment> response = reservationServiceClient.SearchAllAssignmentsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Assignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Assignment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Assignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Assignment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for MoveAssignment</summary>
        public void MoveAssignmentRequestObject()
        {
            // Snippet: MoveAssignment(MoveAssignmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                AssignmentId = "",
            };
            // Make the request
            Assignment response = reservationServiceClient.MoveAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for MoveAssignmentAsync</summary>
        public async Task MoveAssignmentRequestObjectAsync()
        {
            // Snippet: MoveAssignmentAsync(MoveAssignmentRequest, CallSettings)
            // Additional: MoveAssignmentAsync(MoveAssignmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MoveAssignmentRequest request = new MoveAssignmentRequest
            {
                AssignmentName = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]"),
                DestinationIdAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                AssignmentId = "",
            };
            // Make the request
            Assignment response = await reservationServiceClient.MoveAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MoveAssignment</summary>
        public void MoveAssignment()
        {
            // Snippet: MoveAssignment(string, string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]/assignments/[ASSIGNMENT]";
            string destinationId = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            Assignment response = reservationServiceClient.MoveAssignment(name, destinationId);
            // End snippet
        }

        /// <summary>Snippet for MoveAssignmentAsync</summary>
        public async Task MoveAssignmentAsync()
        {
            // Snippet: MoveAssignmentAsync(string, string, CallSettings)
            // Additional: MoveAssignmentAsync(string, string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]/assignments/[ASSIGNMENT]";
            string destinationId = "projects/[PROJECT]/locations/[LOCATION]/reservations/[RESERVATION]";
            // Make the request
            Assignment response = await reservationServiceClient.MoveAssignmentAsync(name, destinationId);
            // End snippet
        }

        /// <summary>Snippet for MoveAssignment</summary>
        public void MoveAssignmentResourceNames()
        {
            // Snippet: MoveAssignment(AssignmentName, ReservationName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            AssignmentName name = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]");
            ReservationName destinationId = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            Assignment response = reservationServiceClient.MoveAssignment(name, destinationId);
            // End snippet
        }

        /// <summary>Snippet for MoveAssignmentAsync</summary>
        public async Task MoveAssignmentResourceNamesAsync()
        {
            // Snippet: MoveAssignmentAsync(AssignmentName, ReservationName, CallSettings)
            // Additional: MoveAssignmentAsync(AssignmentName, ReservationName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssignmentName name = AssignmentName.FromProjectLocationReservationAssignment("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]");
            ReservationName destinationId = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]");
            // Make the request
            Assignment response = await reservationServiceClient.MoveAssignmentAsync(name, destinationId);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssignment</summary>
        public void UpdateAssignmentRequestObject()
        {
            // Snippet: UpdateAssignment(UpdateAssignmentRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            UpdateAssignmentRequest request = new UpdateAssignmentRequest
            {
                Assignment = new Assignment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Assignment response = reservationServiceClient.UpdateAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssignmentAsync</summary>
        public async Task UpdateAssignmentRequestObjectAsync()
        {
            // Snippet: UpdateAssignmentAsync(UpdateAssignmentRequest, CallSettings)
            // Additional: UpdateAssignmentAsync(UpdateAssignmentRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAssignmentRequest request = new UpdateAssignmentRequest
            {
                Assignment = new Assignment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Assignment response = await reservationServiceClient.UpdateAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssignment</summary>
        public void UpdateAssignment()
        {
            // Snippet: UpdateAssignment(Assignment, FieldMask, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            Assignment assignment = new Assignment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Assignment response = reservationServiceClient.UpdateAssignment(assignment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAssignmentAsync</summary>
        public async Task UpdateAssignmentAsync()
        {
            // Snippet: UpdateAssignmentAsync(Assignment, FieldMask, CallSettings)
            // Additional: UpdateAssignmentAsync(Assignment, FieldMask, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Assignment assignment = new Assignment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Assignment response = await reservationServiceClient.UpdateAssignmentAsync(assignment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetBiReservation</summary>
        public void GetBiReservationRequestObject()
        {
            // Snippet: GetBiReservation(GetBiReservationRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            BiReservation response = reservationServiceClient.GetBiReservation(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiReservationAsync</summary>
        public async Task GetBiReservationRequestObjectAsync()
        {
            // Snippet: GetBiReservationAsync(GetBiReservationRequest, CallSettings)
            // Additional: GetBiReservationAsync(GetBiReservationRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBiReservationRequest request = new GetBiReservationRequest
            {
                BiReservationName = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            BiReservation response = await reservationServiceClient.GetBiReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBiReservation</summary>
        public void GetBiReservation()
        {
            // Snippet: GetBiReservation(string, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/biReservation";
            // Make the request
            BiReservation response = reservationServiceClient.GetBiReservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetBiReservationAsync</summary>
        public async Task GetBiReservationAsync()
        {
            // Snippet: GetBiReservationAsync(string, CallSettings)
            // Additional: GetBiReservationAsync(string, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/biReservation";
            // Make the request
            BiReservation response = await reservationServiceClient.GetBiReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBiReservation</summary>
        public void GetBiReservationResourceNames()
        {
            // Snippet: GetBiReservation(BiReservationName, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            BiReservationName name = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            BiReservation response = reservationServiceClient.GetBiReservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetBiReservationAsync</summary>
        public async Task GetBiReservationResourceNamesAsync()
        {
            // Snippet: GetBiReservationAsync(BiReservationName, CallSettings)
            // Additional: GetBiReservationAsync(BiReservationName, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BiReservationName name = BiReservationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            BiReservation response = await reservationServiceClient.GetBiReservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBiReservation</summary>
        public void UpdateBiReservationRequestObject()
        {
            // Snippet: UpdateBiReservation(UpdateBiReservationRequest, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            UpdateBiReservationRequest request = new UpdateBiReservationRequest
            {
                BiReservation = new BiReservation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BiReservation response = reservationServiceClient.UpdateBiReservation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBiReservationAsync</summary>
        public async Task UpdateBiReservationRequestObjectAsync()
        {
            // Snippet: UpdateBiReservationAsync(UpdateBiReservationRequest, CallSettings)
            // Additional: UpdateBiReservationAsync(UpdateBiReservationRequest, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBiReservationRequest request = new UpdateBiReservationRequest
            {
                BiReservation = new BiReservation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BiReservation response = await reservationServiceClient.UpdateBiReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBiReservation</summary>
        public void UpdateBiReservation()
        {
            // Snippet: UpdateBiReservation(BiReservation, FieldMask, CallSettings)
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            BiReservation biReservation = new BiReservation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BiReservation response = reservationServiceClient.UpdateBiReservation(biReservation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBiReservationAsync</summary>
        public async Task UpdateBiReservationAsync()
        {
            // Snippet: UpdateBiReservationAsync(BiReservation, FieldMask, CallSettings)
            // Additional: UpdateBiReservationAsync(BiReservation, FieldMask, CancellationToken)
            // Create client
            ReservationServiceClient reservationServiceClient = await ReservationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BiReservation biReservation = new BiReservation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BiReservation response = await reservationServiceClient.UpdateBiReservationAsync(biReservation, updateMask);
            // End snippet
        }
    }
}
