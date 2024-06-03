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
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.PubSub.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "get": "/v1/{resource=projects/*/topics/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/subscriptions/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/snapshots/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/schemas/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("Ei8vdjEve3Jlc291cmNlPXByb2plY3RzLyovdG9waWNzLyp9OmdldElhbVBvbGljeVo4EjYvdjEve3Jlc291cmNlPXByb2plY3RzLyovc3Vic2NyaXB0aW9ucy8qfTpnZXRJYW1Qb2xpY3laNBIyL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3NuYXBzaG90cy8qfTpnZXRJYW1Qb2xpY3laMhIwL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3NjaGVtYXMvKn06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/topics/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/subscriptions/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/snapshots/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/schemas/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("Ii8vdjEve3Jlc291cmNlPXByb2plY3RzLyovdG9waWNzLyp9OnNldElhbVBvbGljeToBKlo7IjYvdjEve3Jlc291cmNlPXByb2plY3RzLyovc3Vic2NyaXB0aW9ucy8qfTpzZXRJYW1Qb2xpY3k6ASpaNyIyL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3NuYXBzaG90cy8qfTpzZXRJYW1Qb2xpY3k6ASpaNSIwL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3NjaGVtYXMvKn06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/subscriptions/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/topics/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/snapshots/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/schemas/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjwvdjEve3Jlc291cmNlPXByb2plY3RzLyovc3Vic2NyaXB0aW9ucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaOiI1L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3RvcGljcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaPSI4L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3NuYXBzaG90cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaOyI2L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3NjaGVtYXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEq")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return PubsubReflection.Descriptor;
            yield return SchemaReflection.Descriptor;
        }
    }
}
