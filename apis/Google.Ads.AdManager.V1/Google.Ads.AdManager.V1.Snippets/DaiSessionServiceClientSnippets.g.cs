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
    using Google.Ads.AdManager.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDaiSessionServiceClientSnippets
    {
        /// <summary>Snippet for GetDaiSession</summary>
        public void GetDaiSessionRequestObject()
        {
            // Snippet: GetDaiSession(GetDaiSessionRequest, CallSettings)
            // Create client
            DaiSessionServiceClient daiSessionServiceClient = DaiSessionServiceClient.Create();
            // Initialize request argument(s)
            GetDaiSessionRequest request = new GetDaiSessionRequest
            {
                DaiSessionName = DaiSessionName.FromNetworkCodeDaiSession("[NETWORK_CODE]", "[DAI_SESSION]"),
            };
            // Make the request
            DaiSession response = daiSessionServiceClient.GetDaiSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetDaiSessionAsync</summary>
        public async Task GetDaiSessionRequestObjectAsync()
        {
            // Snippet: GetDaiSessionAsync(GetDaiSessionRequest, CallSettings)
            // Additional: GetDaiSessionAsync(GetDaiSessionRequest, CancellationToken)
            // Create client
            DaiSessionServiceClient daiSessionServiceClient = await DaiSessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDaiSessionRequest request = new GetDaiSessionRequest
            {
                DaiSessionName = DaiSessionName.FromNetworkCodeDaiSession("[NETWORK_CODE]", "[DAI_SESSION]"),
            };
            // Make the request
            DaiSession response = await daiSessionServiceClient.GetDaiSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDaiSession</summary>
        public void GetDaiSession()
        {
            // Snippet: GetDaiSession(string, CallSettings)
            // Create client
            DaiSessionServiceClient daiSessionServiceClient = DaiSessionServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/daiSessions/[DAI_SESSION]";
            // Make the request
            DaiSession response = daiSessionServiceClient.GetDaiSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiSessionAsync</summary>
        public async Task GetDaiSessionAsync()
        {
            // Snippet: GetDaiSessionAsync(string, CallSettings)
            // Additional: GetDaiSessionAsync(string, CancellationToken)
            // Create client
            DaiSessionServiceClient daiSessionServiceClient = await DaiSessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/daiSessions/[DAI_SESSION]";
            // Make the request
            DaiSession response = await daiSessionServiceClient.GetDaiSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiSession</summary>
        public void GetDaiSessionResourceNames()
        {
            // Snippet: GetDaiSession(DaiSessionName, CallSettings)
            // Create client
            DaiSessionServiceClient daiSessionServiceClient = DaiSessionServiceClient.Create();
            // Initialize request argument(s)
            DaiSessionName name = DaiSessionName.FromNetworkCodeDaiSession("[NETWORK_CODE]", "[DAI_SESSION]");
            // Make the request
            DaiSession response = daiSessionServiceClient.GetDaiSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiSessionAsync</summary>
        public async Task GetDaiSessionResourceNamesAsync()
        {
            // Snippet: GetDaiSessionAsync(DaiSessionName, CallSettings)
            // Additional: GetDaiSessionAsync(DaiSessionName, CancellationToken)
            // Create client
            DaiSessionServiceClient daiSessionServiceClient = await DaiSessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DaiSessionName name = DaiSessionName.FromNetworkCodeDaiSession("[NETWORK_CODE]", "[DAI_SESSION]");
            // Make the request
            DaiSession response = await daiSessionServiceClient.GetDaiSessionAsync(name);
            // End snippet
        }
    }
}
