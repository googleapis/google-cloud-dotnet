// Copyright 2021 Google LLC
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

namespace Google.Cloud.Dialogflow.Cx.V3.Snippets
{
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedFlowsClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateFlow</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateFlowRequestObject()
        {
            // Create client
            FlowsClient flowsClient = FlowsClient.Create();
            // Initialize request argument(s)
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new FieldMask(),
                LanguageCode = "",
            };
            // Make the request
            Flow response = flowsClient.UpdateFlow(request);
        }
    }
}
