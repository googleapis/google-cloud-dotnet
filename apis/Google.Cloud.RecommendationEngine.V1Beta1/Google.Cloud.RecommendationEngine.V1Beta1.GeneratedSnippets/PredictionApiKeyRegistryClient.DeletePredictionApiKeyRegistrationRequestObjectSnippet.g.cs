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

namespace Google.Cloud.RecommendationEngine.V1Beta1.Snippets
{
    // [START recommendationengine_v1beta1_generated_PredictionApiKeyRegistry_DeletePredictionApiKeyRegistration_sync]
    using Google.Cloud.RecommendationEngine.V1Beta1;

    public sealed partial class GeneratedPredictionApiKeyRegistryClientSnippets
    {
        /// <summary>Snippet for DeletePredictionApiKeyRegistration</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeletePredictionApiKeyRegistrationRequestObject()
        {
            // Create client
            PredictionApiKeyRegistryClient predictionApiKeyRegistryClient = PredictionApiKeyRegistryClient.Create();
            // Initialize request argument(s)
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            // Make the request
            predictionApiKeyRegistryClient.DeletePredictionApiKeyRegistration(request);
        }
    }
    // [END recommendationengine_v1beta1_generated_PredictionApiKeyRegistry_DeletePredictionApiKeyRegistration_sync]
}
