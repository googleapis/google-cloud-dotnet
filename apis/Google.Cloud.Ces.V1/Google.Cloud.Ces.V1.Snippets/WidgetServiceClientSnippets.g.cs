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
    using Google.Cloud.Ces.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWidgetServiceClientSnippets
    {
        /// <summary>Snippet for GenerateChatToken</summary>
        public void GenerateChatTokenRequestObject()
        {
            // Snippet: GenerateChatToken(GenerateChatTokenRequest, CallSettings)
            // Create client
            WidgetServiceClient widgetServiceClient = WidgetServiceClient.Create();
            // Initialize request argument(s)
            GenerateChatTokenRequest request = new GenerateChatTokenRequest
            {
                SessionName = SessionName.FromProjectLocationAppSession("[PROJECT]", "[LOCATION]", "[APP]", "[SESSION]"),
                DeploymentAsDeploymentName = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]"),
                RecaptchaToken = "",
            };
            // Make the request
            GenerateChatTokenResponse response = widgetServiceClient.GenerateChatToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateChatTokenAsync</summary>
        public async Task GenerateChatTokenRequestObjectAsync()
        {
            // Snippet: GenerateChatTokenAsync(GenerateChatTokenRequest, CallSettings)
            // Additional: GenerateChatTokenAsync(GenerateChatTokenRequest, CancellationToken)
            // Create client
            WidgetServiceClient widgetServiceClient = await WidgetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateChatTokenRequest request = new GenerateChatTokenRequest
            {
                SessionName = SessionName.FromProjectLocationAppSession("[PROJECT]", "[LOCATION]", "[APP]", "[SESSION]"),
                DeploymentAsDeploymentName = DeploymentName.FromProjectLocationAppDeployment("[PROJECT]", "[LOCATION]", "[APP]", "[DEPLOYMENT]"),
                RecaptchaToken = "",
            };
            // Make the request
            GenerateChatTokenResponse response = await widgetServiceClient.GenerateChatTokenAsync(request);
            // End snippet
        }
    }
}
