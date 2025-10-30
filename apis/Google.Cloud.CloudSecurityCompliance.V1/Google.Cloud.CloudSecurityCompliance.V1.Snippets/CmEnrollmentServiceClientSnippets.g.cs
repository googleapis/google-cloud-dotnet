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
    using Google.Cloud.CloudSecurityCompliance.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCmEnrollmentServiceClientSnippets
    {
        /// <summary>Snippet for UpdateCmEnrollment</summary>
        public void UpdateCmEnrollmentRequestObject()
        {
            // Snippet: UpdateCmEnrollment(UpdateCmEnrollmentRequest, CallSettings)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = CmEnrollmentServiceClient.Create();
            // Initialize request argument(s)
            UpdateCmEnrollmentRequest request = new UpdateCmEnrollmentRequest
            {
                CmEnrollment = new CmEnrollment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CmEnrollment response = cmEnrollmentServiceClient.UpdateCmEnrollment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmEnrollmentAsync</summary>
        public async Task UpdateCmEnrollmentRequestObjectAsync()
        {
            // Snippet: UpdateCmEnrollmentAsync(UpdateCmEnrollmentRequest, CallSettings)
            // Additional: UpdateCmEnrollmentAsync(UpdateCmEnrollmentRequest, CancellationToken)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = await CmEnrollmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCmEnrollmentRequest request = new UpdateCmEnrollmentRequest
            {
                CmEnrollment = new CmEnrollment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CmEnrollment response = await cmEnrollmentServiceClient.UpdateCmEnrollmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmEnrollment</summary>
        public void UpdateCmEnrollment()
        {
            // Snippet: UpdateCmEnrollment(CmEnrollment, FieldMask, CallSettings)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = CmEnrollmentServiceClient.Create();
            // Initialize request argument(s)
            CmEnrollment cmEnrollment = new CmEnrollment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CmEnrollment response = cmEnrollmentServiceClient.UpdateCmEnrollment(cmEnrollment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmEnrollmentAsync</summary>
        public async Task UpdateCmEnrollmentAsync()
        {
            // Snippet: UpdateCmEnrollmentAsync(CmEnrollment, FieldMask, CallSettings)
            // Additional: UpdateCmEnrollmentAsync(CmEnrollment, FieldMask, CancellationToken)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = await CmEnrollmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmEnrollment cmEnrollment = new CmEnrollment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CmEnrollment response = await cmEnrollmentServiceClient.UpdateCmEnrollmentAsync(cmEnrollment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveCmEnrollment</summary>
        public void CalculateEffectiveCmEnrollmentRequestObject()
        {
            // Snippet: CalculateEffectiveCmEnrollment(CalculateEffectiveCmEnrollmentRequest, CallSettings)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = CmEnrollmentServiceClient.Create();
            // Initialize request argument(s)
            CalculateEffectiveCmEnrollmentRequest request = new CalculateEffectiveCmEnrollmentRequest
            {
                CmEnrollmentName = CmEnrollmentName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            CalculateEffectiveCmEnrollmentResponse response = cmEnrollmentServiceClient.CalculateEffectiveCmEnrollment(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveCmEnrollmentAsync</summary>
        public async Task CalculateEffectiveCmEnrollmentRequestObjectAsync()
        {
            // Snippet: CalculateEffectiveCmEnrollmentAsync(CalculateEffectiveCmEnrollmentRequest, CallSettings)
            // Additional: CalculateEffectiveCmEnrollmentAsync(CalculateEffectiveCmEnrollmentRequest, CancellationToken)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = await CmEnrollmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculateEffectiveCmEnrollmentRequest request = new CalculateEffectiveCmEnrollmentRequest
            {
                CmEnrollmentName = CmEnrollmentName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            CalculateEffectiveCmEnrollmentResponse response = await cmEnrollmentServiceClient.CalculateEffectiveCmEnrollmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveCmEnrollment</summary>
        public void CalculateEffectiveCmEnrollment()
        {
            // Snippet: CalculateEffectiveCmEnrollment(string, CallSettings)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = CmEnrollmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cmEnrollment";
            // Make the request
            CalculateEffectiveCmEnrollmentResponse response = cmEnrollmentServiceClient.CalculateEffectiveCmEnrollment(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveCmEnrollmentAsync</summary>
        public async Task CalculateEffectiveCmEnrollmentAsync()
        {
            // Snippet: CalculateEffectiveCmEnrollmentAsync(string, CallSettings)
            // Additional: CalculateEffectiveCmEnrollmentAsync(string, CancellationToken)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = await CmEnrollmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/cmEnrollment";
            // Make the request
            CalculateEffectiveCmEnrollmentResponse response = await cmEnrollmentServiceClient.CalculateEffectiveCmEnrollmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveCmEnrollment</summary>
        public void CalculateEffectiveCmEnrollmentResourceNames()
        {
            // Snippet: CalculateEffectiveCmEnrollment(CmEnrollmentName, CallSettings)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = CmEnrollmentServiceClient.Create();
            // Initialize request argument(s)
            CmEnrollmentName name = CmEnrollmentName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            CalculateEffectiveCmEnrollmentResponse response = cmEnrollmentServiceClient.CalculateEffectiveCmEnrollment(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateEffectiveCmEnrollmentAsync</summary>
        public async Task CalculateEffectiveCmEnrollmentResourceNamesAsync()
        {
            // Snippet: CalculateEffectiveCmEnrollmentAsync(CmEnrollmentName, CallSettings)
            // Additional: CalculateEffectiveCmEnrollmentAsync(CmEnrollmentName, CancellationToken)
            // Create client
            CmEnrollmentServiceClient cmEnrollmentServiceClient = await CmEnrollmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CmEnrollmentName name = CmEnrollmentName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            CalculateEffectiveCmEnrollmentResponse response = await cmEnrollmentServiceClient.CalculateEffectiveCmEnrollmentAsync(name);
            // End snippet
        }
    }
}
