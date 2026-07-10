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
using gpr = Google.Protobuf.Reflection;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.BinaryAuthorization.V1Beta1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.BinaryAuthorization.V1Beta1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1beta1/{resource=projects/*/policy}:getIamPolicy", "additionalBindings": [ { "get": "/v1beta1/{resource=projects/*/attestors/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EjIvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9wb2xpY3l9OmdldElhbVBvbGljeVo5EjcvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9hdHRlc3RvcnMvKn06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1beta1/{resource=projects/*/policy}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1beta1/{resource=projects/*/attestors/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjIvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9wb2xpY3l9OnNldElhbVBvbGljeToBKlo8IjcvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9hdHRlc3RvcnMvKn06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1beta1/{resource=projects/*/policy}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1beta1/{resource=projects/*/attestors/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjgvdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9wb2xpY3l9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpCIj0vdjFiZXRhMS97cmVzb3VyY2U9cHJvamVjdHMvKi9hdHRlc3RvcnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEq")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return ContinuousValidationLoggingReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
        }
    }
}
