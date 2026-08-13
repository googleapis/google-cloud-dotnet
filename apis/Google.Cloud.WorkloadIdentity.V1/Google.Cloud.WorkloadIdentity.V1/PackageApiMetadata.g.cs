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
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.WorkloadIdentity.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.WorkloadIdentity.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.cloud.location.Locations.GetLocation",
                    // { "get": "/v1/{name=projects/*/locations/*}", "additionalBindings": [ { "get": "/v1/{name=folders/*/locations/*}" }, { "get": "/v1/{name=organizations/*/locations/*}" } ] }
                    proto::ByteString.FromBase64("EiEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn1aIhIgL3YxL3tuYW1lPWZvbGRlcnMvKi9sb2NhdGlvbnMvKn1aKBImL3YxL3tuYW1lPW9yZ2FuaXphdGlvbnMvKi9sb2NhdGlvbnMvKn0=")
                },
                {
                    "google.cloud.location.Locations.ListLocations",
                    // { "get": "/v1/{name=projects/*}/locations", "additionalBindings": [ { "get": "/v1/{name=folders/*}/locations" }, { "get": "/v1/{name=organizations/*}/locations" } ] }
                    proto::ByteString.FromBase64("Eh8vdjEve25hbWU9cHJvamVjdHMvKn0vbG9jYXRpb25zWiASHi92MS97bmFtZT1mb2xkZXJzLyp9L2xvY2F0aW9uc1omEiQvdjEve25hbWU9b3JnYW5pemF0aW9ucy8qfS9sb2NhdGlvbnM=")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*", "additionalBindings": [ { "post": "/v1/{name=folders/*/locations/*/operations/*}:cancel", "body": "*" }, { "post": "/v1/{name=organizations/*/locations/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKlo5IjQvdjEve25hbWU9Zm9sZGVycy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEqWj8iOi92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASo=")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "delete": "/v1/{name=folders/*/locations/*/operations/*}" }, { "delete": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ki4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9Wi8qLS92MS97bmFtZT1mb2xkZXJzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfVo1KjMvdjEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=folders/*/locations/*/operations/*}" }, { "get": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9Wi8SLS92MS97bmFtZT1mb2xkZXJzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfVo1EjMvdjEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*}/operations", "additionalBindings": [ { "get": "/v1/{name=folders/*/locations/*}/operations" }, { "get": "/v1/{name=organizations/*/locations/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9uc1otEisvdjEve25hbWU9Zm9sZGVycy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25zWjMSMS92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnM=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gcl::LocationsReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
