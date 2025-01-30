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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Logging.V2", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v2/{name=*/*/locations/*/operations/*}:cancel", "body": "*", "additionalBindings": [ { "post": "/v2/{name=projects/*/locations/*/operations/*}:cancel", "body": "*" }, { "post": "/v2/{name=organizations/*/locations/*/operations/*}:cancel", "body": "*" }, { "post": "/v2/{name=folders/*/locations/*/operations/*}:cancel", "body": "*" }, { "post": "/v2/{name=billingAccounts/*/locations/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ii4vdjIve25hbWU9Ki8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEqWjoiNS92Mi97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEqWj8iOi92Mi97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASpaOSI0L3YyL3tuYW1lPWZvbGRlcnMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKlpBIjwvdjIve25hbWU9YmlsbGluZ0FjY291bnRzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASo=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v2/{name=*/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v2/{name=projects/*/locations/*/operations/*}" }, { "get": "/v2/{name=organizations/*/locations/*/operations/*}" }, { "get": "/v2/{name=folders/*/locations/*/operations/*}" }, { "get": "/v2/{name=billingAccounts/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EicvdjIve25hbWU9Ki8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn1aMBIuL3YyL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfVo1EjMvdjIve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn1aLxItL3YyL3tuYW1lPWZvbGRlcnMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjcSNS92Mi97bmFtZT1iaWxsaW5nQWNjb3VudHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v2/{name=*/*/locations/*}/operations", "additionalBindings": [ { "get": "/v2/{name=projects/*/locations/*}/operations" }, { "get": "/v2/{name=organizations/*/locations/*}/operations" }, { "get": "/v2/{name=folders/*/locations/*}/operations" }, { "get": "/v2/{name=billingAccounts/*/locations/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiUvdjIve25hbWU9Ki8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25zWi4SLC92Mi97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25zWjMSMS92Mi97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnNaLRIrL3YyL3tuYW1lPWZvbGRlcnMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9uc1o1EjMvdjIve25hbWU9YmlsbGluZ0FjY291bnRzLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnM=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return LogEntryReflection.Descriptor;
            yield return LoggingReflection.Descriptor;
            yield return LoggingConfigReflection.Descriptor;
            yield return LoggingMetricsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
