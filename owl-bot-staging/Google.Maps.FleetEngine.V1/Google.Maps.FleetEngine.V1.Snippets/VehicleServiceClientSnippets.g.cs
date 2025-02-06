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
    using Google.Geo.Type;
    using Google.Maps.FleetEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVehicleServiceClientSnippets
    {
        /// <summary>Snippet for CreateVehicle</summary>
        public void CreateVehicleRequestObject()
        {
            // Snippet: CreateVehicle(CreateVehicleRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            CreateVehicleRequest request = new CreateVehicleRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                VehicleId = "",
                Vehicle = new Vehicle(),
            };
            // Make the request
            Vehicle response = vehicleServiceClient.CreateVehicle(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVehicleAsync</summary>
        public async Task CreateVehicleRequestObjectAsync()
        {
            // Snippet: CreateVehicleAsync(CreateVehicleRequest, CallSettings)
            // Additional: CreateVehicleAsync(CreateVehicleRequest, CancellationToken)
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateVehicleRequest request = new CreateVehicleRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                VehicleId = "",
                Vehicle = new Vehicle(),
            };
            // Make the request
            Vehicle response = await vehicleServiceClient.CreateVehicleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVehicle</summary>
        public void GetVehicleRequestObject()
        {
            // Snippet: GetVehicle(GetVehicleRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            GetVehicleRequest request = new GetVehicleRequest
            {
                Header = new RequestHeader(),
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                WaypointsVersion = new Timestamp(),
            };
            // Make the request
            Vehicle response = vehicleServiceClient.GetVehicle(request);
            // End snippet
        }

        /// <summary>Snippet for GetVehicleAsync</summary>
        public async Task GetVehicleRequestObjectAsync()
        {
            // Snippet: GetVehicleAsync(GetVehicleRequest, CallSettings)
            // Additional: GetVehicleAsync(GetVehicleRequest, CancellationToken)
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVehicleRequest request = new GetVehicleRequest
            {
                Header = new RequestHeader(),
                VehicleName = VehicleName.FromProviderVehicle("[PROVIDER]", "[VEHICLE]"),
                CurrentRouteSegmentVersion = new Timestamp(),
                WaypointsVersion = new Timestamp(),
            };
            // Make the request
            Vehicle response = await vehicleServiceClient.GetVehicleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVehicle</summary>
        public void UpdateVehicleRequestObject()
        {
            // Snippet: UpdateVehicle(UpdateVehicleRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            UpdateVehicleRequest request = new UpdateVehicleRequest
            {
                Header = new RequestHeader(),
                Name = "",
                Vehicle = new Vehicle(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Vehicle response = vehicleServiceClient.UpdateVehicle(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVehicleAsync</summary>
        public async Task UpdateVehicleRequestObjectAsync()
        {
            // Snippet: UpdateVehicleAsync(UpdateVehicleRequest, CallSettings)
            // Additional: UpdateVehicleAsync(UpdateVehicleRequest, CancellationToken)
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVehicleRequest request = new UpdateVehicleRequest
            {
                Header = new RequestHeader(),
                Name = "",
                Vehicle = new Vehicle(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Vehicle response = await vehicleServiceClient.UpdateVehicleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVehicleAttributes</summary>
        public void UpdateVehicleAttributesRequestObject()
        {
            // Snippet: UpdateVehicleAttributes(UpdateVehicleAttributesRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            UpdateVehicleAttributesRequest request = new UpdateVehicleAttributesRequest
            {
                Header = new RequestHeader(),
                Name = "",
                Attributes =
                {
                    new VehicleAttribute(),
                },
            };
            // Make the request
            UpdateVehicleAttributesResponse response = vehicleServiceClient.UpdateVehicleAttributes(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVehicleAttributesAsync</summary>
        public async Task UpdateVehicleAttributesRequestObjectAsync()
        {
            // Snippet: UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest, CallSettings)
            // Additional: UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest, CancellationToken)
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVehicleAttributesRequest request = new UpdateVehicleAttributesRequest
            {
                Header = new RequestHeader(),
                Name = "",
                Attributes =
                {
                    new VehicleAttribute(),
                },
            };
            // Make the request
            UpdateVehicleAttributesResponse response = await vehicleServiceClient.UpdateVehicleAttributesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListVehicles</summary>
        public void ListVehiclesRequestObject()
        {
            // Snippet: ListVehicles(ListVehiclesRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            ListVehiclesRequest request = new ListVehiclesRequest
            {
                Parent = "",
                MinimumCapacity = 0,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new Duration(),
                VehicleTypeCategories =
                {
                    Vehicle.Types.VehicleType.Types.Category.Unknown,
                },
                RequiredAttributes = { "", },
                VehicleState = VehicleState.UnknownVehicleState,
                Header = new RequestHeader(),
                RequiredOneOfAttributes = { "", },
                OnTripOnly = false,
                RequiredOneOfAttributeSets = { "", },
                Filter = "",
                Viewport = new Viewport(),
            };
            // Make the request
            PagedEnumerable<ListVehiclesResponse, Vehicle> response = vehicleServiceClient.ListVehicles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Vehicle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVehiclesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Vehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Vehicle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Vehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVehiclesAsync</summary>
        public async Task ListVehiclesRequestObjectAsync()
        {
            // Snippet: ListVehiclesAsync(ListVehiclesRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVehiclesRequest request = new ListVehiclesRequest
            {
                Parent = "",
                MinimumCapacity = 0,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new Duration(),
                VehicleTypeCategories =
                {
                    Vehicle.Types.VehicleType.Types.Category.Unknown,
                },
                RequiredAttributes = { "", },
                VehicleState = VehicleState.UnknownVehicleState,
                Header = new RequestHeader(),
                RequiredOneOfAttributes = { "", },
                OnTripOnly = false,
                RequiredOneOfAttributeSets = { "", },
                Filter = "",
                Viewport = new Viewport(),
            };
            // Make the request
            PagedAsyncEnumerable<ListVehiclesResponse, Vehicle> response = vehicleServiceClient.ListVehiclesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Vehicle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVehiclesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Vehicle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Vehicle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Vehicle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchVehicles</summary>
        public void SearchVehiclesRequestObject()
        {
            // Snippet: SearchVehicles(SearchVehiclesRequest, CallSettings)
            // Create client
            VehicleServiceClient vehicleServiceClient = VehicleServiceClient.Create();
            // Initialize request argument(s)
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 0,
                Count = 0,
                MinimumCapacity = 0,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = false,
                TripId = "",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
                CurrentTripsPresent = SearchVehiclesRequest.Types.CurrentTripsPresent.Unspecified,
                Filter = "",
            };
            // Make the request
            SearchVehiclesResponse response = vehicleServiceClient.SearchVehicles(request);
            // End snippet
        }

        /// <summary>Snippet for SearchVehiclesAsync</summary>
        public async Task SearchVehiclesRequestObjectAsync()
        {
            // Snippet: SearchVehiclesAsync(SearchVehiclesRequest, CallSettings)
            // Additional: SearchVehiclesAsync(SearchVehiclesRequest, CancellationToken)
            // Create client
            VehicleServiceClient vehicleServiceClient = await VehicleServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchVehiclesRequest request = new SearchVehiclesRequest
            {
                Header = new RequestHeader(),
                Parent = "",
                PickupPoint = new TerminalLocation(),
                DropoffPoint = new TerminalLocation(),
                PickupRadiusMeters = 0,
                Count = 0,
                MinimumCapacity = 0,
                TripTypes =
                {
                    TripType.UnknownTripType,
                },
                MaximumStaleness = new Duration(),
                RequiredAttributes =
                {
                    new VehicleAttribute(),
                },
                OrderBy = SearchVehiclesRequest.Types.VehicleMatchOrder.UnknownVehicleMatchOrder,
                VehicleTypes =
                {
                    new Vehicle.Types.VehicleType(),
                },
                RequiredOneOfAttributes =
                {
                    new VehicleAttributeList(),
                },
                IncludeBackToBack = false,
                TripId = "",
                RequiredOneOfAttributeSets =
                {
                    new VehicleAttributeList(),
                },
                CurrentTripsPresent = SearchVehiclesRequest.Types.CurrentTripsPresent.Unspecified,
                Filter = "",
            };
            // Make the request
            SearchVehiclesResponse response = await vehicleServiceClient.SearchVehiclesAsync(request);
            // End snippet
        }
    }
}
