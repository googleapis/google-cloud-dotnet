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

namespace Google.Cloud.ServiceDirectory.V1Beta1.Snippets
{
    // [START servicedirectory_v1beta1_generated_RegistrationService_UpdateNamespace_sync]
    using Google.Cloud.ServiceDirectory.V1Beta1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedRegistrationServiceClientSnippets
    {
        /// <summary>Snippet for UpdateNamespace</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateNamespaceRequestObject()
        {
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Namespace response = registrationServiceClient.UpdateNamespace(request);
        }
    }
    // [END servicedirectory_v1beta1_generated_RegistrationService_UpdateNamespace_sync]
}
