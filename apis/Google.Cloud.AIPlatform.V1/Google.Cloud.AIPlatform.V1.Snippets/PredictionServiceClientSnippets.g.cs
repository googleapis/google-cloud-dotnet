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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    using Google.Api;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPredictionServiceClientSnippets
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
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new Value(), },
                Parameters = new Value(),
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
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new Value(), },
                Parameters = new Value(),
            };
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Predict</summary>
        public void Predict()
        {
            // Snippet: Predict(string, IEnumerable<Value>, Value, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(endpoint, instances, parameters);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictAsync()
        {
            // Snippet: PredictAsync(string, IEnumerable<Value>, Value, CallSettings)
            // Additional: PredictAsync(string, IEnumerable<Value>, Value, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(endpoint, instances, parameters);
            // End snippet
        }

        /// <summary>Snippet for Predict</summary>
        public void PredictResourceNames()
        {
            // Snippet: Predict(EndpointName, IEnumerable<Value>, Value, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(endpoint, instances, parameters);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictResourceNamesAsync()
        {
            // Snippet: PredictAsync(EndpointName, IEnumerable<Value>, Value, CallSettings)
            // Additional: PredictAsync(EndpointName, IEnumerable<Value>, Value, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(endpoint, instances, parameters);
            // End snippet
        }

        /// <summary>Snippet for RawPredict</summary>
        public void RawPredictRequestObject()
        {
            // Snippet: RawPredict(RawPredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new HttpBody(),
            };
            // Make the request
            HttpBody response = predictionServiceClient.RawPredict(request);
            // End snippet
        }

        /// <summary>Snippet for RawPredictAsync</summary>
        public async Task RawPredictRequestObjectAsync()
        {
            // Snippet: RawPredictAsync(RawPredictRequest, CallSettings)
            // Additional: RawPredictAsync(RawPredictRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new HttpBody(),
            };
            // Make the request
            HttpBody response = await predictionServiceClient.RawPredictAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RawPredict</summary>
        public void RawPredict()
        {
            // Snippet: RawPredict(string, HttpBody, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            HttpBody httpBody = new HttpBody();
            // Make the request
            HttpBody response = predictionServiceClient.RawPredict(endpoint, httpBody);
            // End snippet
        }

        /// <summary>Snippet for RawPredictAsync</summary>
        public async Task RawPredictAsync()
        {
            // Snippet: RawPredictAsync(string, HttpBody, CallSettings)
            // Additional: RawPredictAsync(string, HttpBody, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            HttpBody httpBody = new HttpBody();
            // Make the request
            HttpBody response = await predictionServiceClient.RawPredictAsync(endpoint, httpBody);
            // End snippet
        }

        /// <summary>Snippet for RawPredict</summary>
        public void RawPredictResourceNames()
        {
            // Snippet: RawPredict(EndpointName, HttpBody, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            HttpBody httpBody = new HttpBody();
            // Make the request
            HttpBody response = predictionServiceClient.RawPredict(endpoint, httpBody);
            // End snippet
        }

        /// <summary>Snippet for RawPredictAsync</summary>
        public async Task RawPredictResourceNamesAsync()
        {
            // Snippet: RawPredictAsync(EndpointName, HttpBody, CallSettings)
            // Additional: RawPredictAsync(EndpointName, HttpBody, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            HttpBody httpBody = new HttpBody();
            // Make the request
            HttpBody response = await predictionServiceClient.RawPredictAsync(endpoint, httpBody);
            // End snippet
        }

        /// <summary>Snippet for Explain</summary>
        public void ExplainRequestObject()
        {
            // Snippet: Explain(ExplainRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new Value(), },
                DeployedModelId = "",
                Parameters = new Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
            };
            // Make the request
            ExplainResponse response = predictionServiceClient.Explain(request);
            // End snippet
        }

        /// <summary>Snippet for ExplainAsync</summary>
        public async Task ExplainRequestObjectAsync()
        {
            // Snippet: ExplainAsync(ExplainRequest, CallSettings)
            // Additional: ExplainAsync(ExplainRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new Value(), },
                DeployedModelId = "",
                Parameters = new Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
            };
            // Make the request
            ExplainResponse response = await predictionServiceClient.ExplainAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Explain</summary>
        public void Explain()
        {
            // Snippet: Explain(string, IEnumerable<Value>, Value, string, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            string deployedModelId = "";
            // Make the request
            ExplainResponse response = predictionServiceClient.Explain(endpoint, instances, parameters, deployedModelId);
            // End snippet
        }

        /// <summary>Snippet for ExplainAsync</summary>
        public async Task ExplainAsync()
        {
            // Snippet: ExplainAsync(string, IEnumerable<Value>, Value, string, CallSettings)
            // Additional: ExplainAsync(string, IEnumerable<Value>, Value, string, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            string deployedModelId = "";
            // Make the request
            ExplainResponse response = await predictionServiceClient.ExplainAsync(endpoint, instances, parameters, deployedModelId);
            // End snippet
        }

        /// <summary>Snippet for Explain</summary>
        public void ExplainResourceNames()
        {
            // Snippet: Explain(EndpointName, IEnumerable<Value>, Value, string, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            string deployedModelId = "";
            // Make the request
            ExplainResponse response = predictionServiceClient.Explain(endpoint, instances, parameters, deployedModelId);
            // End snippet
        }

        /// <summary>Snippet for ExplainAsync</summary>
        public async Task ExplainResourceNamesAsync()
        {
            // Snippet: ExplainAsync(EndpointName, IEnumerable<Value>, Value, string, CallSettings)
            // Additional: ExplainAsync(EndpointName, IEnumerable<Value>, Value, string, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<Value> instances = new Value[] { new Value(), };
            Value parameters = new Value();
            string deployedModelId = "";
            // Make the request
            ExplainResponse response = await predictionServiceClient.ExplainAsync(endpoint, instances, parameters, deployedModelId);
            // End snippet
        }
    }
}
