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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Maps.Places.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Maps.Places.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AttributionReflection.Descriptor;
            yield return ContentBlockReflection.Descriptor;
            yield return ContextualContentReflection.Descriptor;
            yield return EvChargingReflection.Descriptor;
            yield return FuelOptionsReflection.Descriptor;
            yield return GeometryReflection.Descriptor;
            yield return PhotoReflection.Descriptor;
            yield return PlaceReflection.Descriptor;
            yield return PlacesServiceReflection.Descriptor;
            yield return PolylineReflection.Descriptor;
            yield return PriceRangeReflection.Descriptor;
            yield return ReferenceReflection.Descriptor;
            yield return ReviewReflection.Descriptor;
            yield return RouteModifiersReflection.Descriptor;
            yield return RoutingPreferenceReflection.Descriptor;
            yield return RoutingSummaryReflection.Descriptor;
            yield return TravelModeReflection.Descriptor;
        }
    }
}
