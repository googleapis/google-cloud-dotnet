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

namespace Google.Ads.DataManager.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Ads.DataManager.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AudienceReflection.Descriptor;
            yield return CartDataReflection.Descriptor;
            yield return ConsentReflection.Descriptor;
            yield return DestinationReflection.Descriptor;
            yield return DeviceInfoReflection.Descriptor;
            yield return EncryptionInfoReflection.Descriptor;
            yield return ErrorReflection.Descriptor;
            yield return EventReflection.Descriptor;
            yield return ExperimentalFieldReflection.Descriptor;
            yield return IngestionServiceReflection.Descriptor;
            yield return ItemParameterReflection.Descriptor;
            yield return MatchRateReflection.Descriptor;
            yield return ProcessingErrorsReflection.Descriptor;
            yield return RequestStatusPerDestinationReflection.Descriptor;
            yield return TermsOfServiceReflection.Descriptor;
            yield return UserDataReflection.Descriptor;
            yield return UserPropertiesReflection.Descriptor;
        }
    }
}
