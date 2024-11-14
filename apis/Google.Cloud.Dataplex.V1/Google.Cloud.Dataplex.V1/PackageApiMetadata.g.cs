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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Dataplex.V1", GetFileDescriptors)
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
                    // { "get": "/v1/{resource=projects/*/locations/*/lakes/*}:getIamPolicy", "additionalBindings": [ { "get": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*/assets/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/lakes/*/tasks/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/lakes/*/environments/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/dataScans/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/dataTaxonomies/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/dataTaxonomies/*/attributes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/dataAttributeBindings/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/entryTypes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/entryLinkTypes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/aspectTypes/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/entryGroups/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/governanceRules/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/glossaries/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/glossaries/*/categories/*}:getIamPolicy" }, { "get": "/v1/{resource=projects/*/locations/*/glossaries/*/terms/*}:getIamPolicy" }, { "get": "/v1/{resource=organizations/*/locations/*/encryptionConfigs/*}:getIamPolicy" } ] }
                    proto::ByteString.FromBase64("EjovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKn06Z2V0SWFtUG9saWN5WkQSQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL3pvbmVzLyp9OmdldElhbVBvbGljeVpNEksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKi96b25lcy8qL2Fzc2V0cy8qfTpnZXRJYW1Qb2xpY3laRBJCL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2xha2VzLyovdGFza3MvKn06Z2V0SWFtUG9saWN5WksSSS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL2Vudmlyb25tZW50cy8qfTpnZXRJYW1Qb2xpY3laQBI+L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTY2Fucy8qfTpnZXRJYW1Qb2xpY3laRRJDL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFUYXhvbm9taWVzLyp9OmdldElhbVBvbGljeVpSElAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVRheG9ub21pZXMvKi9hdHRyaWJ1dGVzLyp9OmdldElhbVBvbGljeVpMEkovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YUF0dHJpYnV0ZUJpbmRpbmdzLyp9OmdldElhbVBvbGljeVpBEj8vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZW50cnlUeXBlcy8qfTpnZXRJYW1Qb2xpY3laRRJDL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VudHJ5TGlua1R5cGVzLyp9OmdldElhbVBvbGljeVpCEkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXNwZWN0VHlwZXMvKn06Z2V0SWFtUG9saWN5WkISQC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lbnRyeUdyb3Vwcy8qfTpnZXRJYW1Qb2xpY3laRhJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dvdmVybmFuY2VSdWxlcy8qfTpnZXRJYW1Qb2xpY3laQRI/L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dsb3NzYXJpZXMvKn06Z2V0SWFtUG9saWN5Wk4STC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nbG9zc2FyaWVzLyovY2F0ZWdvcmllcy8qfTpnZXRJYW1Qb2xpY3laSRJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dsb3NzYXJpZXMvKi90ZXJtcy8qfTpnZXRJYW1Qb2xpY3laTRJLL3YxL3tyZXNvdXJjZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovZW5jcnlwdGlvbkNvbmZpZ3MvKn06Z2V0SWFtUG9saWN5")
                },
                {
                    "google.iam.v1.IAMPolicy.SetIamPolicy",
                    // { "post": "/v1/{resource=projects/*/locations/*/lakes/*}:setIamPolicy", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*/assets/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/tasks/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/environments/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataScans/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataTaxonomies/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataTaxonomies/*/attributes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataAttributeBindings/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/entryTypes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/entryLinkTypes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/aspectTypes/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/entryGroups/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/governanceRules/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/glossaries/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/glossaries/*/categories/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/glossaries/*/terms/*}:setIamPolicy", "body": "*" }, { "post": "/v1/{resource=organizations/*/locations/*/encryptionConfigs/*}:setIamPolicy", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKn06c2V0SWFtUG9saWN5OgEqWkciQi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL3pvbmVzLyp9OnNldElhbVBvbGljeToBKlpQIksvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKi96b25lcy8qL2Fzc2V0cy8qfTpzZXRJYW1Qb2xpY3k6ASpaRyJCL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2xha2VzLyovdGFza3MvKn06c2V0SWFtUG9saWN5OgEqWk4iSS92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL2Vudmlyb25tZW50cy8qfTpzZXRJYW1Qb2xpY3k6ASpaQyI+L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTY2Fucy8qfTpzZXRJYW1Qb2xpY3k6ASpaSCJDL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFUYXhvbm9taWVzLyp9OnNldElhbVBvbGljeToBKlpVIlAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVRheG9ub21pZXMvKi9hdHRyaWJ1dGVzLyp9OnNldElhbVBvbGljeToBKlpPIkovdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YUF0dHJpYnV0ZUJpbmRpbmdzLyp9OnNldElhbVBvbGljeToBKlpEIj8vdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZW50cnlUeXBlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSCJDL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VudHJ5TGlua1R5cGVzLyp9OnNldElhbVBvbGljeToBKlpFIkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXNwZWN0VHlwZXMvKn06c2V0SWFtUG9saWN5OgEqWkUiQC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lbnRyeUdyb3Vwcy8qfTpzZXRJYW1Qb2xpY3k6ASpaSSJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dvdmVybmFuY2VSdWxlcy8qfTpzZXRJYW1Qb2xpY3k6ASpaRCI/L3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dsb3NzYXJpZXMvKn06c2V0SWFtUG9saWN5OgEqWlEiTC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nbG9zc2FyaWVzLyovY2F0ZWdvcmllcy8qfTpzZXRJYW1Qb2xpY3k6ASpaTCJHL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dsb3NzYXJpZXMvKi90ZXJtcy8qfTpzZXRJYW1Qb2xpY3k6ASpaUCJLL3YxL3tyZXNvdXJjZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovZW5jcnlwdGlvbkNvbmZpZ3MvKn06c2V0SWFtUG9saWN5OgEq")
                },
                {
                    "google.iam.v1.IAMPolicy.TestIamPermissions",
                    // { "post": "/v1/{resource=projects/*/locations/*/lakes/*}:testIamPermissions", "body": "*", "additionalBindings": [ { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/zones/*/assets/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/tasks/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/lakes/*/environments/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataScans/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataTaxonomies/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataTaxonomies/*/attributes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/dataAttributeBindings/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/entryTypes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/entryLinkTypes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/aspectTypes/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/entryGroups/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/governanceRules/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/glossaries/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/glossaries/*/categories/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=projects/*/locations/*/glossaries/*/terms/*}:testIamPermissions", "body": "*" }, { "post": "/v1/{resource=organizations/*/locations/*/encryptionConfigs/*}:testIamPermissions", "body": "*" } ] }
                    proto::ByteString.FromBase64("IkAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWk0iSC92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL3pvbmVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpWIlEvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovbGFrZXMvKi96b25lcy8qL2Fzc2V0cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTSJIL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2xha2VzLyovdGFza3MvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlQiTy92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9sYWtlcy8qL2Vudmlyb25tZW50cy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaSSJEL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTY2Fucy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTiJJL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFUYXhvbm9taWVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpbIlYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVRheG9ub21pZXMvKi9hdHRyaWJ1dGVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpVIlAvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YUF0dHJpYnV0ZUJpbmRpbmdzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpKIkUvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovZW50cnlUeXBlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTiJJL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2VudHJ5TGlua1R5cGVzLyp9OnRlc3RJYW1QZXJtaXNzaW9uczoBKlpLIkYvdjEve3Jlc291cmNlPXByb2plY3RzLyovbG9jYXRpb25zLyovYXNwZWN0VHlwZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWksiRi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9lbnRyeUdyb3Vwcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaTyJKL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dvdmVybmFuY2VSdWxlcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaSiJFL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dsb3NzYXJpZXMvKn06dGVzdElhbVBlcm1pc3Npb25zOgEqWlciUi92MS97cmVzb3VyY2U9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9nbG9zc2FyaWVzLyovY2F0ZWdvcmllcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaUiJNL3YxL3tyZXNvdXJjZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2dsb3NzYXJpZXMvKi90ZXJtcy8qfTp0ZXN0SWFtUGVybWlzc2lvbnM6ASpaViJRL3YxL3tyZXNvdXJjZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovZW5jcnlwdGlvbkNvbmZpZ3MvKn06dGVzdElhbVBlcm1pc3Npb25zOgEq")
                },
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/locations/*/operations/*}:cancel", "body": "*", "additionalBindings": [ { "post": "/v1/{name=organizations/*/locations/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("IjUvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKlo/IjovdjEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "delete": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ki4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjUqMy92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/locations/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ei4vdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjUSMy92MS97bmFtZT1vcmdhbml6YXRpb25zLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*/locations/*}/operations", "additionalBindings": [ { "get": "/v1/{name=organizations/*/locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9uc1o1EjMvdjEve25hbWU9b3JnYW5pemF0aW9ucy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AnalyzeReflection.Descriptor;
            yield return CatalogReflection.Descriptor;
            yield return ContentReflection.Descriptor;
            yield return DataDiscoveryReflection.Descriptor;
            yield return DataProfileReflection.Descriptor;
            yield return DataQualityReflection.Descriptor;
            yield return DataTaxonomyReflection.Descriptor;
            yield return DatascansReflection.Descriptor;
            yield return LogsReflection.Descriptor;
            yield return MetadataReflection.Descriptor;
            yield return ProcessingReflection.Descriptor;
            yield return ResourcesReflection.Descriptor;
            yield return SecurityReflection.Descriptor;
            yield return ServiceReflection.Descriptor;
            yield return TasksReflection.Descriptor;
            yield return gciv::IamPolicyReflection.Descriptor;
            yield return gciv::OptionsReflection.Descriptor;
            yield return gciv::PolicyReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
