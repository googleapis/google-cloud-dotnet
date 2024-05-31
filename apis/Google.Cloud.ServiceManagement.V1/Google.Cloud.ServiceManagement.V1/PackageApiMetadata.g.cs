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
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.ServiceManagement.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.ServiceManagement.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "post": "/v1/{resource=services/*}:getIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=services/*/consumers/*}:getIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IiYvdjEve3Jlc291cmNlPXNlcnZpY2VzLyp9OmdldElhbVBvbGljeToBKlo3IjIvdjEve3Jlc291cmNlPXNlcnZpY2VzLyovY29uc3VtZXJzLyp9OmdldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=services/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=services/*/consumers/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IiYvdjEve3Jlc291cmNlPXNlcnZpY2VzLyp9OnNldElhbVBvbGljeToBKlo3IjIvdjEve3Jlc291cmNlPXNlcnZpY2VzLyovY29uc3VtZXJzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=services/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=services/*/consumers/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IiwvdjEve3Jlc291cmNlPXNlcnZpY2VzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlo9IjgvdjEve3Jlc291cmNlPXNlcnZpY2VzLyovY29uc3VtZXJzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/operations" }
                    proto::ByteString.FromBase64("Eg4vdjEvb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return ServicemanagerReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
