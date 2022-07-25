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

namespace Google.Cloud.Dataflow.V1Beta3.Snippets
{
    // [START dataflow_v1beta3_generated_TemplatesService_GetTemplate_sync]
    using Google.Cloud.Dataflow.V1Beta3;

    public sealed partial class GeneratedTemplatesServiceClientSnippets
    {
        /// <summary>Snippet for GetTemplate</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetTemplateRequestObject()
        {
            // Create client
            TemplatesServiceClient templatesServiceClient = TemplatesServiceClient.Create();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                ProjectId = "",
                GcsPath = "",
                View = GetTemplateRequest.Types.TemplateView.MetadataOnly,
                Location = "",
            };
            // Make the request
            GetTemplateResponse response = templatesServiceClient.GetTemplate(request);
        }
    }
    // [END dataflow_v1beta3_generated_TemplatesService_GetTemplate_sync]
}
