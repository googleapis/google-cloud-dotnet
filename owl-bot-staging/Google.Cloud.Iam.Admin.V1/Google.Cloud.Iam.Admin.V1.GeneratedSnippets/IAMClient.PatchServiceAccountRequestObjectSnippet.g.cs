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

namespace Google.Cloud.Iam.Admin.V1.Snippets
{
    // [START iam_v1_generated_IAM_PatchServiceAccount_sync]
    using Google.Cloud.Iam.Admin.V1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedIAMClientSnippets
    {
        /// <summary>Snippet for PatchServiceAccount</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PatchServiceAccountRequestObject()
        {
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            PatchServiceAccountRequest request = new PatchServiceAccountRequest
            {
                ServiceAccount = new ServiceAccount(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServiceAccount response = iAMClient.PatchServiceAccount(request);
        }
    }
    // [END iam_v1_generated_IAM_PatchServiceAccount_sync]
}
