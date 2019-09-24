// Copyright 2019 Google LLC
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

namespace Google.Cloud.AutoML.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.AutoML.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictAsync()
        {
            // Snippet: PredictAsync(ModelName,ExamplePayload,IDictionary<string, string>,CallSettings)
            // Additional: PredictAsync(ModelName,ExamplePayload,IDictionary<string, string>,CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string>();
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(name, payload, @params);
            // End snippet
        }

        /// <summary>Snippet for Predict</summary>
        public void Predict()
        {
            // Snippet: Predict(ModelName,ExamplePayload,IDictionary<string, string>,CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string>();
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(name, payload, @params);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictAsync_RequestObject()
        {
            // Snippet: PredictAsync(PredictRequest,CallSettings)
            // Additional: PredictAsync(PredictRequest,CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
            };
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Predict</summary>
        public void Predict_RequestObject()
        {
            // Snippet: Predict(PredictRequest,CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
            };
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(request);
            // End snippet
        }

    }
}
