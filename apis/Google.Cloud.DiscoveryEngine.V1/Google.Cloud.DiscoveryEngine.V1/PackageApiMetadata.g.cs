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
using gcl = Google.Cloud.Location;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DiscoveryEngine.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1/{name=projects/*/operations/*}:cancel", "body": "*", "additionalBindings": [ { "post": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*/operations/*}:cancel", "body": "*" }, { "post": "/v1/{name=projects/*/locations/*/collections/*/engines/*/operations/*}:cancel", "body": "*" }, { "post": "/v1/{name=projects/*/locations/*/dataStores/*/branches/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("IikvdjEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKlpgIlsvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9icmFuY2hlcy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEqWlIiTS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZW5naW5lcy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEqWlIiTS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9icmFuY2hlcy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/collections/*/dataConnector/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/engines/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/identityMappingStores/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/operations/*}" }, { "get": "/v1/{name=projects/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiIvdjEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9WkwSSi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YUNvbm5lY3Rvci9vcGVyYXRpb25zLyp9WlYSVC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL2JyYW5jaGVzLyovb3BlcmF0aW9ucy8qfVpUElIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKi9vcGVyYXRpb25zLyp9WksSSS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL29wZXJhdGlvbnMvKn1aVRJTL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2NoZW1hcy8qL29wZXJhdGlvbnMvKn1aXBJaL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZS9vcGVyYXRpb25zLyp9WmgSZi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL3NpdGVTZWFyY2hFbmdpbmUvdGFyZ2V0U2l0ZXMvb3BlcmF0aW9ucy8qfVpIEkYvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2VuZ2luZXMvKi9vcGVyYXRpb25zLyp9Wj4SPC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovb3BlcmF0aW9ucy8qfVpIEkYvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKi9vcGVyYXRpb25zLyp9WkYSRC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKi9vcGVyYXRpb25zLyp9Wj0SOy92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9vcGVyYXRpb25zLyp9WkgSRi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2lkZW50aXR5TWFwcGluZ1N0b3Jlcy8qL29wZXJhdGlvbnMvKn1aMBIuL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovb3BlcmF0aW9ucy8qfVokEiIvdjEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*}/operations", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/collections/*/dataConnector}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/models/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/engines/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/branches/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/models/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/identityMappingStores/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*}/operations" }, { "get": "/v1/{name=projects/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiAvdjEve25hbWU9cHJvamVjdHMvKn0vb3BlcmF0aW9uc1pKEkgvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFDb25uZWN0b3J9L29wZXJhdGlvbnNaVBJSL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKn0vb3BlcmF0aW9uc1pSElAvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKn0vb3BlcmF0aW9uc1pTElEvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zY2hlbWFzLyp9L29wZXJhdGlvbnNaZhJkL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZS90YXJnZXRTaXRlc30vb3BlcmF0aW9uc1paElgvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zaXRlU2VhcmNoRW5naW5lfS9vcGVyYXRpb25zWkkSRy92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qfS9vcGVyYXRpb25zWkYSRC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZW5naW5lcy8qfS9vcGVyYXRpb25zWjwSOi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyp9L29wZXJhdGlvbnNaRhJEL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qL2JyYW5jaGVzLyp9L29wZXJhdGlvbnNaRBJCL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qL21vZGVscy8qfS9vcGVyYXRpb25zWjsSOS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKn0vb3BlcmF0aW9uc1pGEkQvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9pZGVudGl0eU1hcHBpbmdTdG9yZXMvKn0vb3BlcmF0aW9uc1ouEiwvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKn0vb3BlcmF0aW9uc1oiEiAvdjEve25hbWU9cHJvamVjdHMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AnswerReflection.Descriptor;
            yield return AssistAnswerReflection.Descriptor;
            yield return AssistantReflection.Descriptor;
            yield return AssistantServiceReflection.Descriptor;
            yield return ChunkReflection.Descriptor;
            yield return CmekConfigServiceReflection.Descriptor;
            yield return CommonReflection.Descriptor;
            yield return CompletionReflection.Descriptor;
            yield return CompletionServiceReflection.Descriptor;
            yield return ControlReflection.Descriptor;
            yield return ControlServiceReflection.Descriptor;
            yield return ConversationReflection.Descriptor;
            yield return ConversationalSearchServiceReflection.Descriptor;
            yield return CustomTuningModelReflection.Descriptor;
            yield return DataStoreReflection.Descriptor;
            yield return DataStoreServiceReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return DocumentProcessingConfigReflection.Descriptor;
            yield return DocumentServiceReflection.Descriptor;
            yield return EngineReflection.Descriptor;
            yield return EngineServiceReflection.Descriptor;
            yield return GroundedGenerationServiceReflection.Descriptor;
            yield return GroundingReflection.Descriptor;
            yield return IdentityMappingStoreReflection.Descriptor;
            yield return IdentityMappingStoreServiceReflection.Descriptor;
            yield return ImportConfigReflection.Descriptor;
            yield return ProjectReflection.Descriptor;
            yield return ProjectServiceReflection.Descriptor;
            yield return PurgeConfigReflection.Descriptor;
            yield return RankServiceReflection.Descriptor;
            yield return RecommendationServiceReflection.Descriptor;
            yield return SafetyReflection.Descriptor;
            yield return SchemaReflection.Descriptor;
            yield return SchemaServiceReflection.Descriptor;
            yield return SearchServiceReflection.Descriptor;
            yield return SearchTuningServiceReflection.Descriptor;
            yield return ServingConfigReflection.Descriptor;
            yield return ServingConfigServiceReflection.Descriptor;
            yield return SessionReflection.Descriptor;
            yield return SiteSearchEngineReflection.Descriptor;
            yield return SiteSearchEngineServiceReflection.Descriptor;
            yield return UserEventReflection.Descriptor;
            yield return UserEventServiceReflection.Descriptor;
            yield return UserLicenseReflection.Descriptor;
            yield return UserLicenseServiceReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
