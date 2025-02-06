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
    using Google.Cloud.Retail.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for Predict</summary>
        public void PredictRequestObject()
        {
            // Snippet: Predict(PredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                Placement = "",
                UserEvent = new UserEvent(),
                PageSize = 0,
                Filter = "",
                ValidateOnly = false,
                Params = { { "", new Value() }, },
                Labels = { { "", "" }, },
            };
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(request);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictRequestObjectAsync()
        {
            // Snippet: PredictAsync(PredictRequest, CallSettings)
            // Additional: PredictAsync(PredictRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                Placement = "",
                UserEvent = new UserEvent(),
                PageSize = 0,
                Filter = "",
                ValidateOnly = false,
                Params = { { "", new Value() }, },
                Labels = { { "", "" }, },
            };
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(request);
            // End snippet
        }
    }
}
