// Copyright 2019 Google LLC
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

namespace Google.Cloud.PhishingProtection.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.PhishingProtection.V1Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedPhishingProtectionServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for ReportPhishingAsync</summary>
        public async Task ReportPhishingAsync()
        {
            // Snippet: ReportPhishingAsync(string,string,CallSettings)
            // Additional: ReportPhishingAsync(string,string,CancellationToken)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            string uri = "";
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(formattedParent, uri);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishing</summary>
        public void ReportPhishing()
        {
            // Snippet: ReportPhishing(string,string,CallSettings)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = PhishingProtectionServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            string uri = "";
            // Make the request
            ReportPhishingResponse response = phishingProtectionServiceV1Beta1Client.ReportPhishing(formattedParent, uri);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishingAsync</summary>
        public async Task ReportPhishingAsync_RequestObject()
        {
            // Snippet: ReportPhishingAsync(ReportPhishingRequest,CallSettings)
            // Additional: ReportPhishingAsync(ReportPhishingRequest,CancellationToken)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = await PhishingProtectionServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Uri = "",
            };
            // Make the request
            ReportPhishingResponse response = await phishingProtectionServiceV1Beta1Client.ReportPhishingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportPhishing</summary>
        public void ReportPhishing_RequestObject()
        {
            // Snippet: ReportPhishing(ReportPhishingRequest,CallSettings)
            // Create client
            PhishingProtectionServiceV1Beta1Client phishingProtectionServiceV1Beta1Client = PhishingProtectionServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Uri = "",
            };
            // Make the request
            ReportPhishingResponse response = phishingProtectionServiceV1Beta1Client.ReportPhishing(request);
            // End snippet
        }

    }
}
