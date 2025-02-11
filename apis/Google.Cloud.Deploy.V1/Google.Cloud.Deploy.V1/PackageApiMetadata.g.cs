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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Deploy.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Deploy.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/deliveryPipelines/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/targets/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/customTargetTypes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/deployPolicies/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGVsaXZlcnlQaXBlbGluZXMvKn06Z2V0SWFtUG9saWN5Wj4SPC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi90YXJnZXRzLyp9OmdldElhbVBvbGljeVpIEkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY3VzdG9tVGFyZ2V0VHlwZXMvKn06Z2V0SWFtUG9saWN5WkUSQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kZXBsb3lQb2xpY2llcy8qfTpnZXRJYW1Qb2xpY3k=")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/deliveryPipelines/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/targets/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/customTargetTypes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/deployPolicies/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGVsaXZlcnlQaXBlbGluZXMvKn06c2V0SWFtUG9saWN5OgEqWkEiPC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi90YXJnZXRzLyp9OnNldElhbVBvbGljeToBKlpLIkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovY3VzdG9tVGFyZ2V0VHlwZXMvKn06c2V0SWFtUG9saWN5OgEqWkgiQy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kZXBsb3lQb2xpY2llcy8qfTpzZXRJYW1Qb2xpY3k6ASo=")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/deliveryPipelines/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/targets/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkwvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGVsaXZlcnlQaXBlbGluZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWkciQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi90YXJnZXRzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKg==")
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
            yield return AutomationPayloadReflection.Descriptor;
            yield return AutomationrunPayloadReflection.Descriptor;
            yield return CloudDeployReflection.Descriptor;
            yield return CustomtargettypeNotificationPayloadReflection.Descriptor;
            yield return DeliverypipelineNotificationPayloadReflection.Descriptor;
            yield return DeploypolicyEvaluationPayloadReflection.Descriptor;
            yield return DeploypolicyNotificationPayloadReflection.Descriptor;
            yield return JobrunNotificationPayloadReflection.Descriptor;
            yield return LogEnumsReflection.Descriptor;
            yield return ReleaseNotificationPayloadReflection.Descriptor;
            yield return ReleaseRenderPayloadReflection.Descriptor;
            yield return RolloutNotificationPayloadReflection.Descriptor;
            yield return RolloutUpdatePayloadReflection.Descriptor;
            yield return TargetNotificationPayloadReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
