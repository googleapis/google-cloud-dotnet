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
    using Google.Cloud.BinaryAuthorization.V1;
    using Grafeas.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedValidationHelperV1ClientSnippets
    {
        /// <summary>Snippet for ValidateAttestationOccurrence</summary>
        public void ValidateAttestationOccurrenceRequestObject()
        {
            // Snippet: ValidateAttestationOccurrence(ValidateAttestationOccurrenceRequest, CallSettings)
            // Create client
            ValidationHelperV1Client validationHelperV1Client = ValidationHelperV1Client.Create();
            // Initialize request argument(s)
            ValidateAttestationOccurrenceRequest request = new ValidateAttestationOccurrenceRequest
            {
                Attestor = "",
                Attestation = new AttestationOccurrence(),
                OccurrenceNote = "",
                OccurrenceResourceUri = "",
            };
            // Make the request
            ValidateAttestationOccurrenceResponse response = validationHelperV1Client.ValidateAttestationOccurrence(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateAttestationOccurrenceAsync</summary>
        public async Task ValidateAttestationOccurrenceRequestObjectAsync()
        {
            // Snippet: ValidateAttestationOccurrenceAsync(ValidateAttestationOccurrenceRequest, CallSettings)
            // Additional: ValidateAttestationOccurrenceAsync(ValidateAttestationOccurrenceRequest, CancellationToken)
            // Create client
            ValidationHelperV1Client validationHelperV1Client = await ValidationHelperV1Client.CreateAsync();
            // Initialize request argument(s)
            ValidateAttestationOccurrenceRequest request = new ValidateAttestationOccurrenceRequest
            {
                Attestor = "",
                Attestation = new AttestationOccurrence(),
                OccurrenceNote = "",
                OccurrenceResourceUri = "",
            };
            // Make the request
            ValidateAttestationOccurrenceResponse response = await validationHelperV1Client.ValidateAttestationOccurrenceAsync(request);
            // End snippet
        }
    }
}
