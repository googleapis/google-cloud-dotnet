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
    using Google.Cloud.PhishingProtection.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPhishingProtectionServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for ReportPhishing</summary>
        public void ReportPhishingRequestObject()
        {
            // Snippet: ReportPhishing(ReportPhishingRequest, CallSettings)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = PhishingProtectionServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Uri = "",
            };
            // Make the request
            ReportPhishingResponse response = phishingProtectionServiceV1Beta1Client.ReportPhishing(request);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishingAsync</summary>
        public async Task ReportPhishingRequestObjectAsync()
        {
            // Snippet: ReportPhishingAsync(ReportPhishingRequest, CallSettings)
            // Additional: ReportPhishingAsync(ReportPhishingRequest, CancellationToken)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Uri = "",
            };
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishing</summary>
        public void ReportPhishing()
        {
            // Snippet: ReportPhishing(string, string, CallSettings)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = PhishingProtectionServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string uri = "";
            // Make the request
            ReportPhishingResponse response = phishingProtectionServiceV1Beta1Client.ReportPhishing(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishingAsync</summary>
        public async Task ReportPhishingAsync()
        {
            // Snippet: ReportPhishingAsync(string, string, CallSettings)
            // Additional: ReportPhishingAsync(string, string, CancellationToken)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string uri = "";
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishing</summary>
        public void ReportPhishingResourceNames()
        {
            // Snippet: ReportPhishing(ProjectName, string, CallSettings)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = PhishingProtectionServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string uri = "";
            // Make the request
            ReportPhishingResponse response = phishingProtectionServiceV1Beta1Client.ReportPhishing(parent, uri);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishingAsync</summary>
        public async Task ReportPhishingResourceNamesAsync()
        {
            // Snippet: ReportPhishingAsync(ProjectName, string, CallSettings)
            // Additional: ReportPhishingAsync(ProjectName, string, CancellationToken)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string uri = "";
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(parent, uri);
            // End snippet
        }
    }
}
