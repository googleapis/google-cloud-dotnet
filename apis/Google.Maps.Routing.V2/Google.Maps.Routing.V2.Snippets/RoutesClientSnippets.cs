// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Type;
using System;
using Xunit;

namespace Google.Maps.Routing.V2.Snippets;

[SnippetOutputCollector]
public class RoutesClientSnippets
{
    [Fact]
    public void GettingStarted()
    {
        // Sample: GettingStarted
        RoutesClient client = RoutesClient.Create();
        CallSettings callSettings = CallSettings.FromHeader("X-Goog-FieldMask", "*");
        ComputeRoutesRequest request = new ComputeRoutesRequest
        {
            Origin = new Waypoint
            {
                Location = new Location { LatLng = new LatLng { Latitude = 37.419734, Longitude = -122.0827784 } }
            },
            Destination = new Waypoint
            {
                Location = new Location { LatLng = new LatLng { Latitude = 37.417670, Longitude = -122.079595 } }
            },
            TravelMode = RouteTravelMode.Drive,
            RoutingPreference = RoutingPreference.TrafficAware
        };
        ComputeRoutesResponse response = client.ComputeRoutes(request, callSettings);
        Console.WriteLine(response);
        // End sample
    }
}
