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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Talent.V4Beta1;
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
    public class GeneratedResumeServiceClientSnippets
    {
        /// <summary>Snippet for ParseResumeAsync</summary>
        public async Task ParseResumeAsync()
        {
            // Snippet: ParseResumeAsync(string,ByteString,CallSettings)
            // Additional: ParseResumeAsync(string,ByteString,CancellationToken)
            // Create client
            ResumeServiceClient resumeServiceClient = await ResumeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            ByteString resume = ByteString.Empty;
            // Make the request
            ParseResumeResponse response = await resumeServiceClient.ParseResumeAsync(formattedParent, resume);
            // End snippet
        }

        /// <summary>Snippet for ParseResume</summary>
        public void ParseResume()
        {
            // Snippet: ParseResume(string,ByteString,CallSettings)
            // Create client
            ResumeServiceClient resumeServiceClient = ResumeServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            ByteString resume = ByteString.Empty;
            // Make the request
            ParseResumeResponse response = resumeServiceClient.ParseResume(formattedParent, resume);
            // End snippet
        }

        /// <summary>Snippet for ParseResumeAsync</summary>
        public async Task ParseResumeAsync_RequestObject()
        {
            // Snippet: ParseResumeAsync(ParseResumeRequest,CallSettings)
            // Additional: ParseResumeAsync(ParseResumeRequest,CancellationToken)
            // Create client
            ResumeServiceClient resumeServiceClient = await ResumeServiceClient.CreateAsync();
            // Initialize request argument(s)
            ParseResumeRequest request = new ParseResumeRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Resume = ByteString.Empty,
            };
            // Make the request
            ParseResumeResponse response = await resumeServiceClient.ParseResumeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ParseResume</summary>
        public void ParseResume_RequestObject()
        {
            // Snippet: ParseResume(ParseResumeRequest,CallSettings)
            // Create client
            ResumeServiceClient resumeServiceClient = ResumeServiceClient.Create();
            // Initialize request argument(s)
            ParseResumeRequest request = new ParseResumeRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Resume = ByteString.Empty,
            };
            // Make the request
            ParseResumeResponse response = resumeServiceClient.ParseResume(request);
            // End snippet
        }

    }
}
