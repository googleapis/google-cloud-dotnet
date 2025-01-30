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
    using Google.Maps.AddressValidation.V1;
    using Google.Type;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAddressValidationClientSnippets
    {
        /// <summary>Snippet for ValidateAddress</summary>
        public void ValidateAddressRequestObject()
        {
            // Snippet: ValidateAddress(ValidateAddressRequest, CallSettings)
            // Create client
            AddressValidationClient addressValidationClient = AddressValidationClient.Create();
            // Initialize request argument(s)
            ValidateAddressRequest request = new ValidateAddressRequest
            {
                Address = new PostalAddress(),
                PreviousResponseId = "",
                EnableUspsCass = false,
                SessionToken = "",
            };
            // Make the request
            ValidateAddressResponse response = addressValidationClient.ValidateAddress(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateAddressAsync</summary>
        public async Task ValidateAddressRequestObjectAsync()
        {
            // Snippet: ValidateAddressAsync(ValidateAddressRequest, CallSettings)
            // Additional: ValidateAddressAsync(ValidateAddressRequest, CancellationToken)
            // Create client
            AddressValidationClient addressValidationClient = await AddressValidationClient.CreateAsync();
            // Initialize request argument(s)
            ValidateAddressRequest request = new ValidateAddressRequest
            {
                Address = new PostalAddress(),
                PreviousResponseId = "",
                EnableUspsCass = false,
                SessionToken = "",
            };
            // Make the request
            ValidateAddressResponse response = await addressValidationClient.ValidateAddressAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProvideValidationFeedback</summary>
        public void ProvideValidationFeedbackRequestObject()
        {
            // Snippet: ProvideValidationFeedback(ProvideValidationFeedbackRequest, CallSettings)
            // Create client
            AddressValidationClient addressValidationClient = AddressValidationClient.Create();
            // Initialize request argument(s)
            ProvideValidationFeedbackRequest request = new ProvideValidationFeedbackRequest
            {
                Conclusion = ProvideValidationFeedbackRequest.Types.ValidationConclusion.Unspecified,
                ResponseId = "",
            };
            // Make the request
            ProvideValidationFeedbackResponse response = addressValidationClient.ProvideValidationFeedback(request);
            // End snippet
        }

        /// <summary>Snippet for ProvideValidationFeedbackAsync</summary>
        public async Task ProvideValidationFeedbackRequestObjectAsync()
        {
            // Snippet: ProvideValidationFeedbackAsync(ProvideValidationFeedbackRequest, CallSettings)
            // Additional: ProvideValidationFeedbackAsync(ProvideValidationFeedbackRequest, CancellationToken)
            // Create client
            AddressValidationClient addressValidationClient = await AddressValidationClient.CreateAsync();
            // Initialize request argument(s)
            ProvideValidationFeedbackRequest request = new ProvideValidationFeedbackRequest
            {
                Conclusion = ProvideValidationFeedbackRequest.Types.ValidationConclusion.Unspecified,
                ResponseId = "",
            };
            // Make the request
            ProvideValidationFeedbackResponse response = await addressValidationClient.ProvideValidationFeedbackAsync(request);
            // End snippet
        }
    }
}
