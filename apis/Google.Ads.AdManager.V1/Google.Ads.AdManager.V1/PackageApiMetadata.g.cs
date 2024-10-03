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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Ads.AdManager.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=networks/*/operations/reports/runs/*}", "additionalBindings": [ { "get": "/v1/{name=networks/*/operations/reports/exports/*}" } ] }
                    proto::ByteString.FromBase64("Ei8vdjEve25hbWU9bmV0d29ya3MvKi9vcGVyYXRpb25zL3JlcG9ydHMvcnVucy8qfVo0EjIvdjEve25hbWU9bmV0d29ya3MvKi9vcGVyYXRpb25zL3JlcG9ydHMvZXhwb3J0cy8qfQ==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AdUnitEnumsReflection.Descriptor;
            yield return AdUnitMessagesReflection.Descriptor;
            yield return AdUnitServiceReflection.Descriptor;
            yield return AdmanagerErrorReflection.Descriptor;
            yield return AppliedLabelReflection.Descriptor;
            yield return CompanyCreditStatusEnumReflection.Descriptor;
            yield return CompanyMessagesReflection.Descriptor;
            yield return CompanyServiceReflection.Descriptor;
            yield return CompanyTypeEnumReflection.Descriptor;
            yield return ContactMessagesReflection.Descriptor;
            yield return CustomFieldEnumsReflection.Descriptor;
            yield return CustomFieldMessagesReflection.Descriptor;
            yield return CustomFieldServiceReflection.Descriptor;
            yield return CustomFieldValueReflection.Descriptor;
            yield return CustomTargetingKeyEnumsReflection.Descriptor;
            yield return CustomTargetingKeyMessagesReflection.Descriptor;
            yield return CustomTargetingKeyServiceReflection.Descriptor;
            yield return CustomTargetingValueEnumsReflection.Descriptor;
            yield return CustomTargetingValueMessagesReflection.Descriptor;
            yield return CustomTargetingValueServiceReflection.Descriptor;
            yield return EntitySignalsMappingMessagesReflection.Descriptor;
            yield return EntitySignalsMappingServiceReflection.Descriptor;
            yield return EnvironmentTypeEnumReflection.Descriptor;
            yield return FrequencyCapReflection.Descriptor;
            yield return LabelMessagesReflection.Descriptor;
            yield return NetworkMessagesReflection.Descriptor;
            yield return NetworkServiceReflection.Descriptor;
            yield return OrderEnumsReflection.Descriptor;
            yield return OrderMessagesReflection.Descriptor;
            yield return OrderServiceReflection.Descriptor;
            yield return PlacementEnumsReflection.Descriptor;
            yield return PlacementMessagesReflection.Descriptor;
            yield return PlacementServiceReflection.Descriptor;
            yield return ReportServiceReflection.Descriptor;
            yield return RoleEnumsReflection.Descriptor;
            yield return RoleMessagesReflection.Descriptor;
            yield return RoleServiceReflection.Descriptor;
            yield return SizeReflection.Descriptor;
            yield return SizeTypeEnumReflection.Descriptor;
            yield return TaxonomyCategoryMessagesReflection.Descriptor;
            yield return TaxonomyCategoryServiceReflection.Descriptor;
            yield return TaxonomyTypeEnumReflection.Descriptor;
            yield return TeamMessagesReflection.Descriptor;
            yield return TimeUnitEnumReflection.Descriptor;
            yield return UserMessagesReflection.Descriptor;
            yield return UserServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
