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
    using Google.Api.Gax.ResourceNames;

    /// <summary>Generated snippets</summary>
    public class GeneratedCompletionClientSnippets
    {
        /// <summary>Snippet for CompleteQueryAsync</summary>
        public async Task CompleteQueryAsync_RequestObject()
        {
            // Snippet: CompleteQueryAsync(CompleteQueryRequest,CallSettings)
            // Additional: CompleteQueryAsync(CompleteQueryRequest,CancellationToken)
            // Create client
            CompletionClient completionClient = await CompletionClient.CreateAsync();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Query = "",
                PageSize = 0,
            };
            // Make the request
            CompleteQueryResponse response = await completionClient.CompleteQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteQuery</summary>
        public void CompleteQuery_RequestObject()
        {
            // Snippet: CompleteQuery(CompleteQueryRequest,CallSettings)
            // Create client
            CompletionClient completionClient = CompletionClient.Create();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Query = "",
                PageSize = 0,
            };
            // Make the request
            CompleteQueryResponse response = completionClient.CompleteQuery(request);
            // End snippet
        }

    }
}
