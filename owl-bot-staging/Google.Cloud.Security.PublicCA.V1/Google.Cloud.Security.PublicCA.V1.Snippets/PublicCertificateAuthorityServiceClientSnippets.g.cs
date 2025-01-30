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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Security.PublicCA.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPublicCertificateAuthorityServiceClientSnippets
    {
        /// <summary>Snippet for CreateExternalAccountKey</summary>
        public void CreateExternalAccountKeyRequestObject()
        {
            // Snippet: CreateExternalAccountKey(CreateExternalAccountKeyRequest, CallSettings)
            // Create client
            PublicCertificateAuthorityServiceClient publicCertificateAuthorityServiceClient = PublicCertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            // Make the request
            ExternalAccountKey response = publicCertificateAuthorityServiceClient.CreateExternalAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccountKeyAsync</summary>
        public async Task CreateExternalAccountKeyRequestObjectAsync()
        {
            // Snippet: CreateExternalAccountKeyAsync(CreateExternalAccountKeyRequest, CallSettings)
            // Additional: CreateExternalAccountKeyAsync(CreateExternalAccountKeyRequest, CancellationToken)
            // Create client
            PublicCertificateAuthorityServiceClient publicCertificateAuthorityServiceClient = await PublicCertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            // Make the request
            ExternalAccountKey response = await publicCertificateAuthorityServiceClient.CreateExternalAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccountKey</summary>
        public void CreateExternalAccountKey()
        {
            // Snippet: CreateExternalAccountKey(string, ExternalAccountKey, CallSettings)
            // Create client
            PublicCertificateAuthorityServiceClient publicCertificateAuthorityServiceClient = PublicCertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExternalAccountKey externalAccountKey = new ExternalAccountKey();
            // Make the request
            ExternalAccountKey response = publicCertificateAuthorityServiceClient.CreateExternalAccountKey(parent, externalAccountKey);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccountKeyAsync</summary>
        public async Task CreateExternalAccountKeyAsync()
        {
            // Snippet: CreateExternalAccountKeyAsync(string, ExternalAccountKey, CallSettings)
            // Additional: CreateExternalAccountKeyAsync(string, ExternalAccountKey, CancellationToken)
            // Create client
            PublicCertificateAuthorityServiceClient publicCertificateAuthorityServiceClient = await PublicCertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExternalAccountKey externalAccountKey = new ExternalAccountKey();
            // Make the request
            ExternalAccountKey response = await publicCertificateAuthorityServiceClient.CreateExternalAccountKeyAsync(parent, externalAccountKey);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccountKey</summary>
        public void CreateExternalAccountKeyResourceNames()
        {
            // Snippet: CreateExternalAccountKey(LocationName, ExternalAccountKey, CallSettings)
            // Create client
            PublicCertificateAuthorityServiceClient publicCertificateAuthorityServiceClient = PublicCertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExternalAccountKey externalAccountKey = new ExternalAccountKey();
            // Make the request
            ExternalAccountKey response = publicCertificateAuthorityServiceClient.CreateExternalAccountKey(parent, externalAccountKey);
            // End snippet
        }

        /// <summary>Snippet for CreateExternalAccountKeyAsync</summary>
        public async Task CreateExternalAccountKeyResourceNamesAsync()
        {
            // Snippet: CreateExternalAccountKeyAsync(LocationName, ExternalAccountKey, CallSettings)
            // Additional: CreateExternalAccountKeyAsync(LocationName, ExternalAccountKey, CancellationToken)
            // Create client
            PublicCertificateAuthorityServiceClient publicCertificateAuthorityServiceClient = await PublicCertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExternalAccountKey externalAccountKey = new ExternalAccountKey();
            // Make the request
            ExternalAccountKey response = await publicCertificateAuthorityServiceClient.CreateExternalAccountKeyAsync(parent, externalAccountKey);
            // End snippet
        }
    }
}
