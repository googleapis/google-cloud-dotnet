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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dataproc.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.iam.v1.IAMPolicy.GetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/regions/*/clusters/*}:getIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/regions/*/jobs/*}:getIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/operations/*}:getIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/workflowTemplates/*}:getIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/workflowTemplates/*}:getIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/autoscalingPolicies/*}:getIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/autoscalingPolicies/*}:getIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjsvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2NsdXN0ZXJzLyp9OmdldElhbVBvbGljeToBKlo8IjcvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2pvYnMvKn06Z2V0SWFtUG9saWN5OgEqWkIiPS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfTpnZXRJYW1Qb2xpY3k6ASpaSSJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3JlZ2lvbnMvKi93b3JrZmxvd1RlbXBsYXRlcy8qfTpnZXRJYW1Qb2xpY3k6ASpaSyJGL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dvcmtmbG93VGVtcGxhdGVzLyp9OmdldElhbVBvbGljeToBKlpLIkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2F1dG9zY2FsaW5nUG9saWNpZXMvKn06Z2V0SWFtUG9saWN5OgEqWk0iSC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRvc2NhbGluZ1BvbGljaWVzLyp9OmdldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/regions/*/clusters/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/regions/*/jobs/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/operations/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/workflowTemplates/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/workflowTemplates/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/autoscalingPolicies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/autoscalingPolicies/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjsvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2NsdXN0ZXJzLyp9OnNldElhbVBvbGljeToBKlo8IjcvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2pvYnMvKn06c2V0SWFtUG9saWN5OgEqWkIiPS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfTpzZXRJYW1Qb2xpY3k6ASpaSSJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3JlZ2lvbnMvKi93b3JrZmxvd1RlbXBsYXRlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSyJGL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dvcmtmbG93VGVtcGxhdGVzLyp9OnNldElhbVBvbGljeToBKlpLIkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2F1dG9zY2FsaW5nUG9saWNpZXMvKn06c2V0SWFtUG9saWN5OgEqWk0iSC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRvc2NhbGluZ1BvbGljaWVzLyp9OnNldElhbVBvbGljeToBKg==")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/regions/*/clusters/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/regions/*/jobs/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/operations/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/workflowTemplates/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/workflowTemplates/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/regions/*/autoscalingPolicies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/autoscalingPolicies/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkEvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2NsdXN0ZXJzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpCIj0vdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2pvYnMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWkgiQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTyJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL3JlZ2lvbnMvKi93b3JrZmxvd1RlbXBsYXRlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUSJML3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3dvcmtmbG93VGVtcGxhdGVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpRIkwvdjEve3Jlc291cmNlPXByb2plY3RzLyovcmVnaW9ucy8qL2F1dG9zY2FsaW5nUG9saWNpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlMiTi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9hdXRvc2NhbGluZ1BvbGljaWVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/regions/*/operations/*}:cancel", "additionalBindings": [ { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel" } ] }
                    proto::ByteString.FromBase64("IjMvdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWxaNyI1L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw=")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/regions/*/operations/*}", "additionalBindings": [ { "delete": "/v1/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("KiwvdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfVowKi4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/regions/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9ucy8qfVowEi4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/regions/*/operations}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/operations}" } ] }
                    proto::ByteString.FromBase64("EiovdjEve25hbWU9cHJvamVjdHMvKi9yZWdpb25zLyovb3BlcmF0aW9uc31aLhIsL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9uc30=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AutoscalingPoliciesReflection.Descriptor;
            yield return BatchesReflection.Descriptor;
            yield return ClustersReflection.Descriptor;
            yield return JobsReflection.Descriptor;
            yield return NodeGroupsReflection.Descriptor;
            yield return OperationsReflection.Descriptor;
            yield return SessionTemplatesReflection.Descriptor;
            yield return SessionsReflection.Descriptor;
            yield return SharedReflection.Descriptor;
            yield return WorkflowTemplatesReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
