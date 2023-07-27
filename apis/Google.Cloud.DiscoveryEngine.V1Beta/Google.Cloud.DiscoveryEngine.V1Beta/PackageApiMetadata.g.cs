// Copyright 2023 Google LLC
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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
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
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*/operations/*}", "additionalBindings": [ { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/engines/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/locations/*/operations/*}" }, { "get": "/v1beta/{name=projects/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("ElgvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKi9vcGVyYXRpb25zLyp9WlgSVi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKi9vcGVyYXRpb25zLyp9Wk8STS92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9vcGVyYXRpb25zLyp9WlkSVy92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zY2hlbWFzLyovb3BlcmF0aW9ucy8qfVpgEl4vdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZS9vcGVyYXRpb25zLyp9WmwSai92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zaXRlU2VhcmNoRW5naW5lL3RhcmdldFNpdGVzL29wZXJhdGlvbnMvKn1aTBJKL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZW5naW5lcy8qL29wZXJhdGlvbnMvKn1aQhJAL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovb3BlcmF0aW9ucy8qfVpMEkovdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qL2JyYW5jaGVzLyovb3BlcmF0aW9ucy8qfVpKEkgvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qL21vZGVscy8qL29wZXJhdGlvbnMvKn1aQRI/L3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9vcGVyYXRpb25zLyp9WjQSMi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9vcGVyYXRpb25zLyp9WigSJi92MWJldGEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*}/operations", "additionalBindings": [ { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/models/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/dataStores/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*/engines/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/collections/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/branches/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*/models/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*/dataStores/*}/operations" }, { "get": "/v1beta/{name=projects/*/locations/*}/operations" }, { "get": "/v1beta/{name=projects/*}/operations" } ] }
                    proto::ByteString.FromBase64("ElYvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKn0vb3BlcmF0aW9uc1pWElQvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovbW9kZWxzLyp9L29wZXJhdGlvbnNaVxJVL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL3NjaGVtYXMvKn0vb3BlcmF0aW9uc1pqEmgvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZS90YXJnZXRTaXRlc30vb3BlcmF0aW9uc1peElwvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZX0vb3BlcmF0aW9uc1pNEksvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyp9L29wZXJhdGlvbnNaShJIL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZW5naW5lcy8qfS9vcGVyYXRpb25zWkASPi92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qfS9vcGVyYXRpb25zWkoSSC92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKn0vb3BlcmF0aW9uc1pIEkYvdjFiZXRhL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qL21vZGVscy8qfS9vcGVyYXRpb25zWj8SPS92MWJldGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyp9L29wZXJhdGlvbnNaMhIwL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25zWiYSJC92MWJldGEve25hbWU9cHJvamVjdHMvKn0vb3BlcmF0aW9ucw==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return CommonReflection.Descriptor;
            yield return CompletionServiceReflection.Descriptor;
            yield return ConversationReflection.Descriptor;
            yield return ConversationalSearchServiceReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return DocumentServiceReflection.Descriptor;
            yield return ImportConfigReflection.Descriptor;
            yield return PurgeConfigReflection.Descriptor;
            yield return RecommendationServiceReflection.Descriptor;
            yield return SchemaReflection.Descriptor;
            yield return SchemaServiceReflection.Descriptor;
            yield return SearchServiceReflection.Descriptor;
            yield return UserEventReflection.Descriptor;
            yield return UserEventServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
