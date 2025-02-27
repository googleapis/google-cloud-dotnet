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
    using Google.Maps.FleetEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTripServiceClientSnippets
    {
        /// <summary>Snippet for CreateTrip</summary>
        public void CreateTripRequestObject()
        {
            // Snippet: CreateTrip(CreateTripRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            CreateTripRequest request = new CreateTripRequest
            {
                Header = new RequestHeader(),
                ParentAsTripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                Trip = new Trip(),
                TripId = "",
            };
            // Make the request
            Trip response = tripServiceClient.CreateTrip(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTripAsync</summary>
        public async Task CreateTripRequestObjectAsync()
        {
            // Snippet: CreateTripAsync(CreateTripRequest, CallSettings)
            // Additional: CreateTripAsync(CreateTripRequest, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTripRequest request = new CreateTripRequest
            {
                Header = new RequestHeader(),
                ParentAsTripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                Trip = new Trip(),
                TripId = "",
            };
            // Make the request
            Trip response = await tripServiceClient.CreateTripAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrip</summary>
        public void GetTripRequestObject()
        {
            // Snippet: GetTrip(GetTripRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            GetTripRequest request = new GetTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                RemainingWaypointsVersion = new Timestamp(),
                RouteFormatType = PolylineFormatType.UnknownFormatType,
                CurrentRouteSegmentTrafficVersion = new Timestamp(),
                RemainingWaypointsRouteVersion = new Timestamp(),
                View = TripView.Unspecified,
            };
            // Make the request
            Trip response = tripServiceClient.GetTrip(request);
            // End snippet
        }

        /// <summary>Snippet for GetTripAsync</summary>
        public async Task GetTripRequestObjectAsync()
        {
            // Snippet: GetTripAsync(GetTripRequest, CallSettings)
            // Additional: GetTripAsync(GetTripRequest, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTripRequest request = new GetTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                RemainingWaypointsVersion = new Timestamp(),
                RouteFormatType = PolylineFormatType.UnknownFormatType,
                CurrentRouteSegmentTrafficVersion = new Timestamp(),
                RemainingWaypointsRouteVersion = new Timestamp(),
                View = TripView.Unspecified,
            };
            // Make the request
            Trip response = await tripServiceClient.GetTripAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrip</summary>
        public void DeleteTripRequestObject()
        {
            // Snippet: DeleteTrip(DeleteTripRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            DeleteTripRequest request = new DeleteTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
            };
            // Make the request
            tripServiceClient.DeleteTrip(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTripAsync</summary>
        public async Task DeleteTripRequestObjectAsync()
        {
            // Snippet: DeleteTripAsync(DeleteTripRequest, CallSettings)
            // Additional: DeleteTripAsync(DeleteTripRequest, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTripRequest request = new DeleteTripRequest
            {
                Header = new RequestHeader(),
                TripName = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]"),
            };
            // Make the request
            await tripServiceClient.DeleteTripAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrip</summary>
        public void DeleteTrip()
        {
            // Snippet: DeleteTrip(string, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/trips/[TRIP]";
            // Make the request
            tripServiceClient.DeleteTrip(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTripAsync</summary>
        public async Task DeleteTripAsync()
        {
            // Snippet: DeleteTripAsync(string, CallSettings)
            // Additional: DeleteTripAsync(string, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "providers/[PROVIDER]/trips/[TRIP]";
            // Make the request
            await tripServiceClient.DeleteTripAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTrip</summary>
        public void DeleteTripResourceNames()
        {
            // Snippet: DeleteTrip(TripName, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            TripName name = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]");
            // Make the request
            tripServiceClient.DeleteTrip(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTripAsync</summary>
        public async Task DeleteTripResourceNamesAsync()
        {
            // Snippet: DeleteTripAsync(TripName, CallSettings)
            // Additional: DeleteTripAsync(TripName, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            TripName name = TripName.FromProviderTrip("[PROVIDER]", "[TRIP]");
            // Make the request
            await tripServiceClient.DeleteTripAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ReportBillableTrip</summary>
        public void ReportBillableTripRequestObject()
        {
            // Snippet: ReportBillableTrip(ReportBillableTripRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            ReportBillableTripRequest request = new ReportBillableTripRequest
            {
                Name = "",
                CountryCode = "",
                Platform = BillingPlatformIdentifier.Unspecified,
                RelatedIds = { "", },
                SolutionType = ReportBillableTripRequest.Types.SolutionType.Unspecified,
            };
            // Make the request
            tripServiceClient.ReportBillableTrip(request);
            // End snippet
        }

        /// <summary>Snippet for ReportBillableTripAsync</summary>
        public async Task ReportBillableTripRequestObjectAsync()
        {
            // Snippet: ReportBillableTripAsync(ReportBillableTripRequest, CallSettings)
            // Additional: ReportBillableTripAsync(ReportBillableTripRequest, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportBillableTripRequest request = new ReportBillableTripRequest
            {
                Name = "",
                CountryCode = "",
                Platform = BillingPlatformIdentifier.Unspecified,
                RelatedIds = { "", },
                SolutionType = ReportBillableTripRequest.Types.SolutionType.Unspecified,
            };
            // Make the request
            await tripServiceClient.ReportBillableTripAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchTrips</summary>
        public void SearchTripsRequestObject()
        {
            // Snippet: SearchTrips(SearchTripsRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            SearchTripsRequest request = new SearchTripsRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                VehicleId = "",
                ActiveTripsOnly = false,
                MinimumStaleness = new Duration(),
            };
            // Make the request
            PagedEnumerable<SearchTripsResponse, Trip> response = tripServiceClient.SearchTrips(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trip item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchTripsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trip item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trip> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trip item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchTripsAsync</summary>
        public async Task SearchTripsRequestObjectAsync()
        {
            // Snippet: SearchTripsAsync(SearchTripsRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchTripsRequest request = new SearchTripsRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                VehicleId = "",
                ActiveTripsOnly = false,
                MinimumStaleness = new Duration(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchTripsResponse, Trip> response = tripServiceClient.SearchTripsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trip item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchTripsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trip item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trip> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trip item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateTrip</summary>
        public void UpdateTripRequestObject()
        {
            // Snippet: UpdateTrip(UpdateTripRequest, CallSettings)
            // Create client
            TripServiceClient tripServiceClient = TripServiceClient.Create();
            // Initialize request argument(s)
            UpdateTripRequest request = new UpdateTripRequest
            {
                Header = new RequestHeader(),
                Name = "",
                Trip = new Trip(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Trip response = tripServiceClient.UpdateTrip(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTripAsync</summary>
        public async Task UpdateTripRequestObjectAsync()
        {
            // Snippet: UpdateTripAsync(UpdateTripRequest, CallSettings)
            // Additional: UpdateTripAsync(UpdateTripRequest, CancellationToken)
            // Create client
            TripServiceClient tripServiceClient = await TripServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTripRequest request = new UpdateTripRequest
            {
                Header = new RequestHeader(),
                Name = "",
                Trip = new Trip(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Trip response = await tripServiceClient.UpdateTripAsync(request);
            // End snippet
        }
    }
}
