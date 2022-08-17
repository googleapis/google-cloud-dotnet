// Copyright 2022 Google LLC
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

namespace Google.Cloud.Run.V2.Snippets
{
    // [START run_v2_generated_Revisions_GetRevision_sync]
    using Google.Cloud.Run.V2;

    public sealed partial class GeneratedRevisionsClientSnippets
    {
        /// <summary>Snippet for GetRevision</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetRevisionRequestObject()
        {
            // Create client
            RevisionsClient revisionsClient = RevisionsClient.Create();
            // Initialize request argument(s)
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            // Make the request
            Revision response = revisionsClient.GetRevision(request);
        }
    }
    // [END run_v2_generated_Revisions_GetRevision_sync]
}
