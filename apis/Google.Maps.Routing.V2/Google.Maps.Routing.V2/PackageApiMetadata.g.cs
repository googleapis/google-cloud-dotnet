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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Maps.Routing.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Maps.Routing.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return FallbackInfoReflection.Descriptor;
            yield return GeocodingResultsReflection.Descriptor;
            yield return LocalizedTimeReflection.Descriptor;
            yield return LocationReflection.Descriptor;
            yield return ManeuverReflection.Descriptor;
            yield return NavigationInstructionReflection.Descriptor;
            yield return PolylineReflection.Descriptor;
            yield return PolylineDetailsReflection.Descriptor;
            yield return RouteReflection.Descriptor;
            yield return RouteLabelReflection.Descriptor;
            yield return RouteModifiersReflection.Descriptor;
            yield return RouteTravelModeReflection.Descriptor;
            yield return RoutesServiceReflection.Descriptor;
            yield return RoutingPreferenceReflection.Descriptor;
            yield return SpeedReadingIntervalReflection.Descriptor;
            yield return TollInfoReflection.Descriptor;
            yield return TollPassesReflection.Descriptor;
            yield return TrafficModelReflection.Descriptor;
            yield return TransitReflection.Descriptor;
            yield return TransitPreferencesReflection.Descriptor;
            yield return UnitsReflection.Descriptor;
            yield return VehicleEmissionTypeReflection.Descriptor;
            yield return VehicleInfoReflection.Descriptor;
            yield return WaypointReflection.Descriptor;
        }
    }
}
