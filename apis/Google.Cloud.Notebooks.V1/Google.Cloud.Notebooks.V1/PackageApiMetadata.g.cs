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

namespace Google.Cloud.Notebooks.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Notebooks.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/instances/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/runtimes/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("Ej4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VzLyp9OmdldElhbVBvbGljeVo/Ej0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcnVudGltZXMvKn06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/instances/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/runtimes/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ij4vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VzLyp9OnNldElhbVBvbGljeToBKlpCIj0vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcnVudGltZXMvKn06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/instances/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/runtimes/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkQvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovaW5zdGFuY2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpIIkMvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovcnVudGltZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEq")
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
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return DiagnosticConfigReflection.Descriptor;
            yield return EnvironmentReflection.Descriptor;
            yield return EventReflection.Descriptor;
            yield return ExecutionReflection.Descriptor;
            yield return InstanceReflection.Descriptor;
            yield return InstanceConfigReflection.Descriptor;
            yield return ManagedServiceReflection.Descriptor;
            yield return RuntimeReflection.Descriptor;
            yield return ScheduleReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
