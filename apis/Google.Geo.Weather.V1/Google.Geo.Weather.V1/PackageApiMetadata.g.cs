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

namespace Google.Geo.Weather.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Geo.Weather.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AirPressureReflection.Descriptor;
            yield return CelestialEventsReflection.Descriptor;
            yield return ForecastDayReflection.Descriptor;
            yield return ForecastHourReflection.Descriptor;
            yield return HistoryHourReflection.Descriptor;
            yield return IceReflection.Descriptor;
            yield return PrecipitationReflection.Descriptor;
            yield return PublicAlertsReflection.Descriptor;
            yield return PublicAlertsEnumsReflection.Descriptor;
            yield return TemperatureReflection.Descriptor;
            yield return UnitsSystemReflection.Descriptor;
            yield return VisibilityReflection.Descriptor;
            yield return WeatherConditionReflection.Descriptor;
            yield return WeatherServiceReflection.Descriptor;
            yield return WindReflection.Descriptor;
        }
    }
}
