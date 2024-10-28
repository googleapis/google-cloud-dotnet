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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Eventarc.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}" }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations" }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25z")
                },
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1/{resource=projects/*/locations/*/triggers/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/channels/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/channelConnections/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/messageBuses/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/enrollments/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/pipelines/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/googleApiSources/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("Ej0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovdHJpZ2dlcnMvKn06Z2V0SWFtUG9saWN5Wj8SPS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jaGFubmVscy8qfTpnZXRJYW1Qb2xpY3laSRJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NoYW5uZWxDb25uZWN0aW9ucy8qfTpnZXRJYW1Qb2xpY3laQxJBL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL21lc3NhZ2VCdXNlcy8qfTpnZXRJYW1Qb2xpY3laQhJAL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2Vucm9sbG1lbnRzLyp9OmdldElhbVBvbGljeVpAEj4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcGlwZWxpbmVzLyp9OmdldElhbVBvbGljeVpHEkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZ29vZ2xlQXBpU291cmNlcy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/triggers/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/channels/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/channelConnections/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/messageBuses/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/enrollments/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/pipelines/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/googleApiSources/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ij0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovdHJpZ2dlcnMvKn06c2V0SWFtUG9saWN5OgEqWkIiPS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jaGFubmVscy8qfTpzZXRJYW1Qb2xpY3k6ASpaTCJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NoYW5uZWxDb25uZWN0aW9ucy8qfTpzZXRJYW1Qb2xpY3k6ASpaRiJBL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL21lc3NhZ2VCdXNlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaRSJAL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2Vucm9sbG1lbnRzLyp9OnNldElhbVBvbGljeToBKlpDIj4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcGlwZWxpbmVzLyp9OnNldElhbVBvbGljeToBKlpKIkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZ29vZ2xlQXBpU291cmNlcy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/triggers/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/channels/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/channelConnections/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/messageBuses/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/enrollments/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/pipelines/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/googleApiSources/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkMvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovdHJpZ2dlcnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWkgiQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jaGFubmVscy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUiJNL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NoYW5uZWxDb25uZWN0aW9ucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTCJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL21lc3NhZ2VCdXNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaSyJGL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2Vucm9sbG1lbnRzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpJIkQvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcGlwZWxpbmVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpQIksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZ29vZ2xlQXBpU291cmNlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASo=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKg==")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ki4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}" }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*}/operations" }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ChannelReflection.Descriptor;
            yield return ChannelConnectionReflection.Descriptor;
            yield return DiscoveryReflection.Descriptor;
            yield return EnrollmentReflection.Descriptor;
            yield return EventarcReflection.Descriptor;
            yield return GoogleApiSourceReflection.Descriptor;
            yield return GoogleChannelConfigReflection.Descriptor;
            yield return LoggingConfigReflection.Descriptor;
            yield return MessageBusReflection.Descriptor;
            yield return NetworkConfigReflection.Descriptor;
            yield return PipelineReflection.Descriptor;
            yield return TriggerReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
