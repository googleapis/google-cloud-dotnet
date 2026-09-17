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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.BackupDR.V1Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.BackupDR.V1Beta", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1beta/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiUvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1beta/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("EiMvdjFiZXRhL3tuYW1lPXByb2plY3RzLyp9L2xvY2F0aW9ucw==")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1beta/{resource=projects/*/locations/*/managementServers/*}:getIamPolicy" }
                    proto::ByteString.FromBase64("EkovdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL21hbmFnZW1lbnRTZXJ2ZXJzLyp9OmdldElhbVBvbGljeQ==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1beta/{resource=projects/*/locations/*/managementServers/*}:setIamPolicy", "body": "*" }
                    proto::ByteString.FromBase64("IkovdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL21hbmFnZW1lbnRTZXJ2ZXJzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1beta/{resource=projects/*/locations/*/managementServers/*}:testIamPermissions", "body": "*" }
                    proto::ByteString.FromBase64("IlAvdjFiZXRhL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL21hbmFnZW1lbnRTZXJ2ZXJzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1beta/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjkvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASo=")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1beta/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("KjIvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("EjIvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EjAvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnM=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AppliedautoprotectionpolicyReflection.Descriptor;
            yield return AutoprotectionpolicyReflection.Descriptor;
            yield return AutoprotectionpolicybindingReflection.Descriptor;
            yield return BackupdrReflection.Descriptor;
            yield return BackupplanReflection.Descriptor;
            yield return BackupplanassociationReflection.Descriptor;
            yield return BackupvaultReflection.Descriptor;
            yield return BackupvaultAlloydbReflection.Descriptor;
            yield return BackupvaultBaReflection.Descriptor;
            yield return BackupvaultCloudsqlReflection.Descriptor;
            yield return BackupvaultDiskReflection.Descriptor;
            yield return BackupvaultGceReflection.Descriptor;
            yield return BindingmatchingresourceReflection.Descriptor;
            yield return DatasourcereferenceReflection.Descriptor;
            yield return ProtectionSummaryReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
