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

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Sql.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlConnectServiceClientSnippets
    {
        /// <summary>Snippet for GetConnectSettings</summary>
        public void GetConnectSettingsRequestObject()
        {
            // Snippet: GetConnectSettings(GetConnectSettingsRequest, CallSettings)
            // Create client
            SqlConnectServiceClient sqlConnectServiceClient = SqlConnectServiceClient.Create();
            // Initialize request argument(s)
            GetConnectSettingsRequest request = new GetConnectSettingsRequest
            {
                Instance = "",
                Project = "",
                ReadTime = new Timestamp(),
            };
            // Make the request
            ConnectSettings response = sqlConnectServiceClient.GetConnectSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectSettingsAsync</summary>
        public async Task GetConnectSettingsRequestObjectAsync()
        {
            // Snippet: GetConnectSettingsAsync(GetConnectSettingsRequest, CallSettings)
            // Additional: GetConnectSettingsAsync(GetConnectSettingsRequest, CancellationToken)
            // Create client
            SqlConnectServiceClient sqlConnectServiceClient = await SqlConnectServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectSettingsRequest request = new GetConnectSettingsRequest
            {
                Instance = "",
                Project = "",
                ReadTime = new Timestamp(),
            };
            // Make the request
            ConnectSettings response = await sqlConnectServiceClient.GetConnectSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResolveConnectSettings</summary>
        public void ResolveConnectSettingsRequestObject()
        {
            // Snippet: ResolveConnectSettings(ResolveConnectSettingsRequest, CallSettings)
            // Create client
            SqlConnectServiceClient sqlConnectServiceClient = SqlConnectServiceClient.Create();
            // Initialize request argument(s)
            ResolveConnectSettingsRequest request = new ResolveConnectSettingsRequest
            {
                DnsName = "",
                Location = "",
            };
            // Make the request
            ConnectSettings response = sqlConnectServiceClient.ResolveConnectSettings(request);
            // End snippet
        }

        /// <summary>Snippet for ResolveConnectSettingsAsync</summary>
        public async Task ResolveConnectSettingsRequestObjectAsync()
        {
            // Snippet: ResolveConnectSettingsAsync(ResolveConnectSettingsRequest, CallSettings)
            // Additional: ResolveConnectSettingsAsync(ResolveConnectSettingsRequest, CancellationToken)
            // Create client
            SqlConnectServiceClient sqlConnectServiceClient = await SqlConnectServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResolveConnectSettingsRequest request = new ResolveConnectSettingsRequest
            {
                DnsName = "",
                Location = "",
            };
            // Make the request
            ConnectSettings response = await sqlConnectServiceClient.ResolveConnectSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateEphemeralCert</summary>
        public void GenerateEphemeralCertRequestObject()
        {
            // Snippet: GenerateEphemeralCert(GenerateEphemeralCertRequest, CallSettings)
            // Create client
            SqlConnectServiceClient sqlConnectServiceClient = SqlConnectServiceClient.Create();
            // Initialize request argument(s)
            GenerateEphemeralCertRequest request = new GenerateEphemeralCertRequest
            {
                Instance = "",
                Project = "",
                PublicKey = "",
                AccessToken = "",
                ReadTime = new Timestamp(),
                ValidDuration = new Duration(),
            };
            // Make the request
            GenerateEphemeralCertResponse response = sqlConnectServiceClient.GenerateEphemeralCert(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateEphemeralCertAsync</summary>
        public async Task GenerateEphemeralCertRequestObjectAsync()
        {
            // Snippet: GenerateEphemeralCertAsync(GenerateEphemeralCertRequest, CallSettings)
            // Additional: GenerateEphemeralCertAsync(GenerateEphemeralCertRequest, CancellationToken)
            // Create client
            SqlConnectServiceClient sqlConnectServiceClient = await SqlConnectServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateEphemeralCertRequest request = new GenerateEphemeralCertRequest
            {
                Instance = "",
                Project = "",
                PublicKey = "",
                AccessToken = "",
                ReadTime = new Timestamp(),
                ValidDuration = new Duration(),
            };
            // Make the request
            GenerateEphemeralCertResponse response = await sqlConnectServiceClient.GenerateEphemeralCertAsync(request);
            // End snippet
        }
    }
}
