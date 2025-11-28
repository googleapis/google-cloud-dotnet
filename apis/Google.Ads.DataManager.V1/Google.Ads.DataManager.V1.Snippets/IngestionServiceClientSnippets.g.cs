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
    using Google.Ads.DataManager.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIngestionServiceClientSnippets
    {
        /// <summary>Snippet for IngestAudienceMembers</summary>
        public void IngestAudienceMembersRequestObject()
        {
            // Snippet: IngestAudienceMembers(IngestAudienceMembersRequest, CallSettings)
            // Create client
            IngestionServiceClient ingestionServiceClient = IngestionServiceClient.Create();
            // Initialize request argument(s)
            IngestAudienceMembersRequest request = new IngestAudienceMembersRequest
            {
                Destinations = { new Destination(), },
                AudienceMembers =
                {
                    new AudienceMember(),
                },
                Consent = new Consent(),
                ValidateOnly = false,
                Encoding = Encoding.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
                TermsOfService = new TermsOfService(),
            };
            // Make the request
            IngestAudienceMembersResponse response = ingestionServiceClient.IngestAudienceMembers(request);
            // End snippet
        }

        /// <summary>Snippet for IngestAudienceMembersAsync</summary>
        public async Task IngestAudienceMembersRequestObjectAsync()
        {
            // Snippet: IngestAudienceMembersAsync(IngestAudienceMembersRequest, CallSettings)
            // Additional: IngestAudienceMembersAsync(IngestAudienceMembersRequest, CancellationToken)
            // Create client
            IngestionServiceClient ingestionServiceClient = await IngestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IngestAudienceMembersRequest request = new IngestAudienceMembersRequest
            {
                Destinations = { new Destination(), },
                AudienceMembers =
                {
                    new AudienceMember(),
                },
                Consent = new Consent(),
                ValidateOnly = false,
                Encoding = Encoding.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
                TermsOfService = new TermsOfService(),
            };
            // Make the request
            IngestAudienceMembersResponse response = await ingestionServiceClient.IngestAudienceMembersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveAudienceMembers</summary>
        public void RemoveAudienceMembersRequestObject()
        {
            // Snippet: RemoveAudienceMembers(RemoveAudienceMembersRequest, CallSettings)
            // Create client
            IngestionServiceClient ingestionServiceClient = IngestionServiceClient.Create();
            // Initialize request argument(s)
            RemoveAudienceMembersRequest request = new RemoveAudienceMembersRequest
            {
                Destinations = { new Destination(), },
                AudienceMembers =
                {
                    new AudienceMember(),
                },
                ValidateOnly = false,
                Encoding = Encoding.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            // Make the request
            RemoveAudienceMembersResponse response = ingestionServiceClient.RemoveAudienceMembers(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveAudienceMembersAsync</summary>
        public async Task RemoveAudienceMembersRequestObjectAsync()
        {
            // Snippet: RemoveAudienceMembersAsync(RemoveAudienceMembersRequest, CallSettings)
            // Additional: RemoveAudienceMembersAsync(RemoveAudienceMembersRequest, CancellationToken)
            // Create client
            IngestionServiceClient ingestionServiceClient = await IngestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAudienceMembersRequest request = new RemoveAudienceMembersRequest
            {
                Destinations = { new Destination(), },
                AudienceMembers =
                {
                    new AudienceMember(),
                },
                ValidateOnly = false,
                Encoding = Encoding.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            // Make the request
            RemoveAudienceMembersResponse response = await ingestionServiceClient.RemoveAudienceMembersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for IngestEvents</summary>
        public void IngestEventsRequestObject()
        {
            // Snippet: IngestEvents(IngestEventsRequest, CallSettings)
            // Create client
            IngestionServiceClient ingestionServiceClient = IngestionServiceClient.Create();
            // Initialize request argument(s)
            IngestEventsRequest request = new IngestEventsRequest
            {
                Destinations = { new Destination(), },
                Events = { new Event(), },
                Consent = new Consent(),
                ValidateOnly = false,
                Encoding = Encoding.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            // Make the request
            IngestEventsResponse response = ingestionServiceClient.IngestEvents(request);
            // End snippet
        }

        /// <summary>Snippet for IngestEventsAsync</summary>
        public async Task IngestEventsRequestObjectAsync()
        {
            // Snippet: IngestEventsAsync(IngestEventsRequest, CallSettings)
            // Additional: IngestEventsAsync(IngestEventsRequest, CancellationToken)
            // Create client
            IngestionServiceClient ingestionServiceClient = await IngestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            IngestEventsRequest request = new IngestEventsRequest
            {
                Destinations = { new Destination(), },
                Events = { new Event(), },
                Consent = new Consent(),
                ValidateOnly = false,
                Encoding = Encoding.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            // Make the request
            IngestEventsResponse response = await ingestionServiceClient.IngestEventsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRequestStatus</summary>
        public void RetrieveRequestStatusRequestObject()
        {
            // Snippet: RetrieveRequestStatus(RetrieveRequestStatusRequest, CallSettings)
            // Create client
            IngestionServiceClient ingestionServiceClient = IngestionServiceClient.Create();
            // Initialize request argument(s)
            RetrieveRequestStatusRequest request = new RetrieveRequestStatusRequest { RequestId = "", };
            // Make the request
            RetrieveRequestStatusResponse response = ingestionServiceClient.RetrieveRequestStatus(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRequestStatusAsync</summary>
        public async Task RetrieveRequestStatusRequestObjectAsync()
        {
            // Snippet: RetrieveRequestStatusAsync(RetrieveRequestStatusRequest, CallSettings)
            // Additional: RetrieveRequestStatusAsync(RetrieveRequestStatusRequest, CancellationToken)
            // Create client
            IngestionServiceClient ingestionServiceClient = await IngestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveRequestStatusRequest request = new RetrieveRequestStatusRequest { RequestId = "", };
            // Make the request
            RetrieveRequestStatusResponse response = await ingestionServiceClient.RetrieveRequestStatusAsync(request);
            // End snippet
        }
    }
}
