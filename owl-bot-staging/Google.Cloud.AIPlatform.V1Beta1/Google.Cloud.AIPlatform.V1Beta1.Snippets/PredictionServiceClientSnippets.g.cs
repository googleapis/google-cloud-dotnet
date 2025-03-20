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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.Protobuf;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

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
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
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
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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

        /// <summary>Snippet for StreamRawPredict</summary>
        public async Task StreamRawPredictRequestObject()
        {
            // Snippet: StreamRawPredict(StreamRawPredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            StreamRawPredictRequest request = new StreamRawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new HttpBody(),
            };
            // Make the request, returning a streaming response
            using PredictionServiceClient.StreamRawPredictStream response = predictionServiceClient.StreamRawPredict(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamRawPredict</summary>
        public async Task StreamRawPredict()
        {
            // Snippet: StreamRawPredict(string, HttpBody, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            HttpBody httpBody = new HttpBody();
            // Make the request, returning a streaming response
            using PredictionServiceClient.StreamRawPredictStream response = predictionServiceClient.StreamRawPredict(endpoint, httpBody);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamRawPredict</summary>
        public async Task StreamRawPredictResourceNames()
        {
            // Snippet: StreamRawPredict(EndpointName, HttpBody, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            HttpBody httpBody = new HttpBody();
            // Make the request, returning a streaming response
            using PredictionServiceClient.StreamRawPredictStream response = predictionServiceClient.StreamRawPredict(endpoint, httpBody);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for DirectPredict</summary>
        public void DirectPredictRequestObject()
        {
            // Snippet: DirectPredict(DirectPredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            DirectPredictRequest request = new DirectPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Inputs = { new Tensor(), },
                Parameters = new Tensor(),
            };
            // Make the request
            DirectPredictResponse response = predictionServiceClient.DirectPredict(request);
            // End snippet
        }

        /// <summary>Snippet for DirectPredictAsync</summary>
        public async Task DirectPredictRequestObjectAsync()
        {
            // Snippet: DirectPredictAsync(DirectPredictRequest, CallSettings)
            // Additional: DirectPredictAsync(DirectPredictRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DirectPredictRequest request = new DirectPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Inputs = { new Tensor(), },
                Parameters = new Tensor(),
            };
            // Make the request
            DirectPredictResponse response = await predictionServiceClient.DirectPredictAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DirectRawPredict</summary>
        public void DirectRawPredictRequestObject()
        {
            // Snippet: DirectRawPredict(DirectRawPredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            DirectRawPredictRequest request = new DirectRawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                MethodName = "",
                Input = ByteString.Empty,
            };
            // Make the request
            DirectRawPredictResponse response = predictionServiceClient.DirectRawPredict(request);
            // End snippet
        }

        /// <summary>Snippet for DirectRawPredictAsync</summary>
        public async Task DirectRawPredictRequestObjectAsync()
        {
            // Snippet: DirectRawPredictAsync(DirectRawPredictRequest, CallSettings)
            // Additional: DirectRawPredictAsync(DirectRawPredictRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DirectRawPredictRequest request = new DirectRawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                MethodName = "",
                Input = ByteString.Empty,
            };
            // Make the request
            DirectRawPredictResponse response = await predictionServiceClient.DirectRawPredictAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StreamDirectPredict</summary>
        public async Task StreamDirectPredict()
        {
            // Snippet: StreamDirectPredict(CallSettings, BidirectionalStreamingSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using PredictionServiceClient.StreamDirectPredictStream response = predictionServiceClient.StreamDirectPredict();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamDirectPredictResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamDirectPredictResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamDirectPredictRequest request = new StreamDirectPredictRequest
                {
                    EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                    Inputs = { new Tensor(), },
                    Parameters = new Tensor(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for StreamDirectRawPredict</summary>
        public async Task StreamDirectRawPredict()
        {
            // Snippet: StreamDirectRawPredict(CallSettings, BidirectionalStreamingSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using PredictionServiceClient.StreamDirectRawPredictStream response = predictionServiceClient.StreamDirectRawPredict();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamDirectRawPredictResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamDirectRawPredictResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamDirectRawPredictRequest request = new StreamDirectRawPredictRequest
                {
                    EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                    MethodName = "",
                    Input = ByteString.Empty,
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for StreamingPredict</summary>
        public async Task StreamingPredict()
        {
            // Snippet: StreamingPredict(CallSettings, BidirectionalStreamingSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using PredictionServiceClient.StreamingPredictStream response = predictionServiceClient.StreamingPredict();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingPredictResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingPredictResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingPredictRequest request = new StreamingPredictRequest
                {
                    EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                    Inputs = { new Tensor(), },
                    Parameters = new Tensor(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for ServerStreamingPredict</summary>
        public async Task ServerStreamingPredictRequestObject()
        {
            // Snippet: ServerStreamingPredict(StreamingPredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            StreamingPredictRequest request = new StreamingPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Inputs = { new Tensor(), },
                Parameters = new Tensor(),
            };
            // Make the request, returning a streaming response
            using PredictionServiceClient.ServerStreamingPredictStream response = predictionServiceClient.ServerStreamingPredict(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamingPredictResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamingPredictResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamingRawPredict</summary>
        public async Task StreamingRawPredict()
        {
            // Snippet: StreamingRawPredict(CallSettings, BidirectionalStreamingSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using PredictionServiceClient.StreamingRawPredictStream response = predictionServiceClient.StreamingRawPredict();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingRawPredictResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingRawPredictResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingRawPredictRequest request = new StreamingRawPredictRequest
                {
                    EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                    MethodName = "",
                    Input = ByteString.Empty,
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
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
                Instances = { new wkt::Value(), },
                DeployedModelId = "",
                Parameters = new wkt::Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
                ConcurrentExplanationSpecOverride =
                {
                    {
                        "",
                        new ExplanationSpecOverride()
                    },
                },
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
                Instances = { new wkt::Value(), },
                DeployedModelId = "",
                Parameters = new wkt::Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
                ConcurrentExplanationSpecOverride =
                {
                    {
                        "",
                        new ExplanationSpecOverride()
                    },
                },
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
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
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            wkt::Value parameters = new wkt::Value();
            string deployedModelId = "";
            // Make the request
            ExplainResponse response = await predictionServiceClient.ExplainAsync(endpoint, instances, parameters, deployedModelId);
            // End snippet
        }

        /// <summary>Snippet for CountTokens</summary>
        public void CountTokensRequestObject()
        {
            // Snippet: CountTokens(CountTokensRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            CountTokensRequest request = new CountTokensRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Model = "",
                Contents = { new Content(), },
                SystemInstruction = new Content(),
                Tools = { new Tool(), },
                GenerationConfig = new GenerationConfig(),
            };
            // Make the request
            CountTokensResponse response = predictionServiceClient.CountTokens(request);
            // End snippet
        }

        /// <summary>Snippet for CountTokensAsync</summary>
        public async Task CountTokensRequestObjectAsync()
        {
            // Snippet: CountTokensAsync(CountTokensRequest, CallSettings)
            // Additional: CountTokensAsync(CountTokensRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CountTokensRequest request = new CountTokensRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Model = "",
                Contents = { new Content(), },
                SystemInstruction = new Content(),
                Tools = { new Tool(), },
                GenerationConfig = new GenerationConfig(),
            };
            // Make the request
            CountTokensResponse response = await predictionServiceClient.CountTokensAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CountTokens</summary>
        public void CountTokens()
        {
            // Snippet: CountTokens(string, IEnumerable<Value>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = predictionServiceClient.CountTokens(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for CountTokensAsync</summary>
        public async Task CountTokensAsync()
        {
            // Snippet: CountTokensAsync(string, IEnumerable<Value>, CallSettings)
            // Additional: CountTokensAsync(string, IEnumerable<Value>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = await predictionServiceClient.CountTokensAsync(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for CountTokens</summary>
        public void CountTokensResourceNames()
        {
            // Snippet: CountTokens(EndpointName, IEnumerable<Value>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = predictionServiceClient.CountTokens(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for CountTokensAsync</summary>
        public async Task CountTokensResourceNamesAsync()
        {
            // Snippet: CountTokensAsync(EndpointName, IEnumerable<Value>, CallSettings)
            // Additional: CountTokensAsync(EndpointName, IEnumerable<Value>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            IEnumerable<wkt::Value> instances = new wkt::Value[] { new wkt::Value(), };
            // Make the request
            CountTokensResponse response = await predictionServiceClient.CountTokensAsync(endpoint, instances);
            // End snippet
        }

        /// <summary>Snippet for GenerateContent</summary>
        public void GenerateContentRequestObject()
        {
            // Snippet: GenerateContent(GenerateContentRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            GenerateContentRequest request = new GenerateContentRequest
            {
                Contents = { new Content(), },
                SafetySettings =
                {
                    new SafetySetting(),
                },
                GenerationConfig = new GenerationConfig(),
                Model = "",
                Tools = { new Tool(), },
                ToolConfig = new ToolConfig(),
                SystemInstruction = new Content(),
                CachedContentAsCachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
                Labels = { { "", "" }, },
            };
            // Make the request
            GenerateContentResponse response = predictionServiceClient.GenerateContent(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateContentAsync</summary>
        public async Task GenerateContentRequestObjectAsync()
        {
            // Snippet: GenerateContentAsync(GenerateContentRequest, CallSettings)
            // Additional: GenerateContentAsync(GenerateContentRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateContentRequest request = new GenerateContentRequest
            {
                Contents = { new Content(), },
                SafetySettings =
                {
                    new SafetySetting(),
                },
                GenerationConfig = new GenerationConfig(),
                Model = "",
                Tools = { new Tool(), },
                ToolConfig = new ToolConfig(),
                SystemInstruction = new Content(),
                CachedContentAsCachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
                Labels = { { "", "" }, },
            };
            // Make the request
            GenerateContentResponse response = await predictionServiceClient.GenerateContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateContent</summary>
        public void GenerateContent()
        {
            // Snippet: GenerateContent(string, IEnumerable<Content>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string model = "";
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request
            GenerateContentResponse response = predictionServiceClient.GenerateContent(model, contents);
            // End snippet
        }

        /// <summary>Snippet for GenerateContentAsync</summary>
        public async Task GenerateContentAsync()
        {
            // Snippet: GenerateContentAsync(string, IEnumerable<Content>, CallSettings)
            // Additional: GenerateContentAsync(string, IEnumerable<Content>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string model = "";
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request
            GenerateContentResponse response = await predictionServiceClient.GenerateContentAsync(model, contents);
            // End snippet
        }

        /// <summary>Snippet for StreamGenerateContent</summary>
        public async Task StreamGenerateContentRequestObject()
        {
            // Snippet: StreamGenerateContent(GenerateContentRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            GenerateContentRequest request = new GenerateContentRequest
            {
                Contents = { new Content(), },
                SafetySettings =
                {
                    new SafetySetting(),
                },
                GenerationConfig = new GenerationConfig(),
                Model = "",
                Tools = { new Tool(), },
                ToolConfig = new ToolConfig(),
                SystemInstruction = new Content(),
                CachedContentAsCachedContentName = CachedContentName.FromProjectLocationCachedContent("[PROJECT]", "[LOCATION]", "[CACHED_CONTENT]"),
                Labels = { { "", "" }, },
            };
            // Make the request, returning a streaming response
            using PredictionServiceClient.StreamGenerateContentStream response = predictionServiceClient.StreamGenerateContent(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<GenerateContentResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                GenerateContentResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamGenerateContent</summary>
        public async Task StreamGenerateContent()
        {
            // Snippet: StreamGenerateContent(string, IEnumerable<Content>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string model = "";
            IEnumerable<Content> contents = new Content[] { new Content(), };
            // Make the request, returning a streaming response
            using PredictionServiceClient.StreamGenerateContentStream response = predictionServiceClient.StreamGenerateContent(model, contents);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<GenerateContentResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                GenerateContentResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ChatCompletions</summary>
        public async Task ChatCompletionsRequestObject()
        {
            // Snippet: ChatCompletions(ChatCompletionsRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            ChatCompletionsRequest request = new ChatCompletionsRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new HttpBody(),
            };
            // Make the request, returning a streaming response
            using PredictionServiceClient.ChatCompletionsStream response = predictionServiceClient.ChatCompletions(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ChatCompletions</summary>
        public async Task ChatCompletions()
        {
            // Snippet: ChatCompletions(string, HttpBody, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string endpoint = "projects/[PROJECT]/locations/[LOCATION]/endpoints/[ENDPOINT]";
            HttpBody httpBody = new HttpBody();
            // Make the request, returning a streaming response
            using PredictionServiceClient.ChatCompletionsStream response = predictionServiceClient.ChatCompletions(endpoint, httpBody);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ChatCompletions</summary>
        public async Task ChatCompletionsResourceNames()
        {
            // Snippet: ChatCompletions(EndpointName, HttpBody, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            HttpBody httpBody = new HttpBody();
            // Make the request, returning a streaming response
            using PredictionServiceClient.ChatCompletionsStream response = predictionServiceClient.ChatCompletions(endpoint, httpBody);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<HttpBody> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                HttpBody responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
