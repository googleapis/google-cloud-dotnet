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

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DiscoveryEngine.V1Beta", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*/operations/*}:cancel", "body": "*", "additionalBindings": [ { "post": "/v1beta/{name=projects/*/locations/*/dataStores/*/branches/*/operations/*}:cancel", "body": "*" } ] }
                    proto::ByteString.FromBase64("Il8vdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKi9vcGVyYXRpb25zLyp9OmNhbmNlbDoBKlpWIlEvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qL2JyYW5jaGVzLyovb3BlcmF0aW9ucy8qfTpjYW5jZWw6ASo=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataConnector/operations/*}", "additionalBindings": [ { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/engines/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/evaluations/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/sampleQuerySets/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("Ek4vdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhQ29ubmVjdG9yL29wZXJhdGlvbnMvKn1aWhJYL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL2JyYW5jaGVzLyovb3BlcmF0aW9ucy8qfVpYElYvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovbW9kZWxzLyovb3BlcmF0aW9ucy8qfVpPEk0vdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovb3BlcmF0aW9ucy8qfVpZElcvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2NoZW1hcy8qL29wZXJhdGlvbnMvKn1aYBJeL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL3NpdGVTZWFyY2hFbmdpbmUvb3BlcmF0aW9ucy8qfVpsEmovdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZS90YXJnZXRTaXRlcy9vcGVyYXRpb25zLyp9WkwSSi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2VuZ2luZXMvKi9vcGVyYXRpb25zLyp9WkISQC92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL29wZXJhdGlvbnMvKn1aTBJKL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9icmFuY2hlcy8qL29wZXJhdGlvbnMvKn1aShJIL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKi9vcGVyYXRpb25zLyp9WkESPy92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovb3BlcmF0aW9ucy8qfVpCEkAvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZXZhbHVhdGlvbnMvKi9vcGVyYXRpb25zLyp9WjQSMi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WkYSRC92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9zYW1wbGVRdWVyeVNldHMvKi9vcGVyYXRpb25zLyp9WigSJi92MWJldGEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataConnector}/operations", "additionalBindings": [ { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/models/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/engines/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/branches/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/models/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*}/operations" }, { "get": "/v1beta/{name=projects/*}/operations" } ] }
                    proto::ByteString.FromBase64("EkwvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhQ29ubmVjdG9yfS9vcGVyYXRpb25zWlgSVi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9icmFuY2hlcy8qfS9vcGVyYXRpb25zWlYSVC92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKn0vb3BlcmF0aW9uc1pXElUvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2NoZW1hcy8qfS9vcGVyYXRpb25zWmoSaC92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zaXRlU2VhcmNoRW5naW5lL3RhcmdldFNpdGVzfS9vcGVyYXRpb25zWl4SXC92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zaXRlU2VhcmNoRW5naW5lfS9vcGVyYXRpb25zWk0SSy92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKn0vb3BlcmF0aW9uc1pKEkgvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9lbmdpbmVzLyp9L29wZXJhdGlvbnNaQBI+L3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyp9L29wZXJhdGlvbnNaShJIL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9icmFuY2hlcy8qfS9vcGVyYXRpb25zWkgSRi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovbW9kZWxzLyp9L29wZXJhdGlvbnNaPxI9L3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKn0vb3BlcmF0aW9uc1oyEjAvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyp9L29wZXJhdGlvbnNaJhIkL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AnswerReflection.Descriptor;
            yield return ChunkReflection.Descriptor;
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
            yield return EvaluationReflection.Descriptor;
            yield return EvaluationServiceReflection.Descriptor;
            yield return GroundedGenerationServiceReflection.Descriptor;
            yield return GroundingReflection.Descriptor;
            yield return ImportConfigReflection.Descriptor;
            yield return ProjectReflection.Descriptor;
            yield return ProjectServiceReflection.Descriptor;
            yield return PurgeConfigReflection.Descriptor;
            yield return RankServiceReflection.Descriptor;
            yield return RecommendationServiceReflection.Descriptor;
            yield return SampleQueryReflection.Descriptor;
            yield return SampleQueryServiceReflection.Descriptor;
            yield return SampleQuerySetReflection.Descriptor;
            yield return SampleQuerySetServiceReflection.Descriptor;
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
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
