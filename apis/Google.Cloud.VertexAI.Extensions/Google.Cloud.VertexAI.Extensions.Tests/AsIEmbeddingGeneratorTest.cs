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

using Google.Cloud.AIPlatform.V1;
using Grpc.Core;
using Microsoft.Extensions.AI;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Value = Google.Protobuf.WellKnownTypes.Value;

namespace Google.Cloud.VertexAI.Extensions.Tests;

public class AsIEmbeddingGeneratorTest
{
    [Fact]
    public void AsIEmbeddingGenerator_ValidArguments_CreatesIEmbeddingGeneratorSuccessfully()
    {
        PredictionServiceClient client = CreateClient();
        IEmbeddingGenerator generator = client.AsIEmbeddingGenerator();
        Assert.NotNull(generator);
        Assert.Same(client, generator.GetService<PredictionServiceClient>());
    }

    [Fact]
    public void BuildIEmbeddingGenerator_ValidArguments_CreatesIEmbeddingGeneratorSuccessfully()
    {
        IEmbeddingGenerator generator = new PredictionServiceClientBuilder() { ApiKey = "fake-api-key" }.BuildIEmbeddingGenerator();
        Assert.NotNull(generator.GetService<PredictionServiceClient>());
    }

    [Fact]
    public void AsIEmbeddingGenerator_InvalidArguments_Throws()
    {
        Assert.Throws<ArgumentNullException>("client", () => VertexAIExtensions.AsIEmbeddingGenerator(null!));
    }

    [Fact]
    public void IEmbeddingGenerator_GetService_InvalidArguments_Throws()
    {
        PredictionServiceClient client = CreateClient();

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = client.AsIEmbeddingGenerator();
        Assert.NotNull(embeddingGenerator);

        Assert.Throws<ArgumentNullException>("serviceType", () => embeddingGenerator.GetService(null!));
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData(null, 512)]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/fakemodel", null)]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/fakemodel", 1024)]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/text-embedding-004", null)]
    public void IEmbeddingGenerator_GetService_ReturnsExpectedInstance(string? defaultModelId, int? defaultDimensions)
    {
        PredictionServiceClient client = CreateClient();

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = client.AsIEmbeddingGenerator(defaultModelId, defaultDimensions);
        Assert.NotNull(embeddingGenerator);

        Assert.Same(client, embeddingGenerator.GetService<PredictionServiceClient>());

        Assert.Same(embeddingGenerator, embeddingGenerator.GetService<IEmbeddingGenerator<string, Embedding<float>>>());
        Assert.Same(embeddingGenerator, embeddingGenerator.GetService<IDisposable>());

        EmbeddingGeneratorMetadata? metadata = embeddingGenerator.GetService<EmbeddingGeneratorMetadata>();
        Assert.NotNull(metadata);
        Assert.Equal("gcp.vertex_ai", metadata.ProviderName);
        Assert.Equal(new("https://aiplatform.googleapis.com:443"), metadata.ProviderUri);
        Assert.Equal(defaultModelId?.Substring(defaultModelId.LastIndexOf('/') + 1), metadata.DefaultModelId);
        Assert.Equal(defaultDimensions, metadata.DefaultModelDimensions);
    }

    [Fact]
    public void IEmbeddingGenerator_Dispose_Nop()
    {
        PredictionServiceClient client = CreateClient();

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = client.AsIEmbeddingGenerator();
        Assert.NotNull(embeddingGenerator);

        embeddingGenerator.Dispose();

        Assert.Same(client, embeddingGenerator.GetService<PredictionServiceClient>());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_BasicRequest()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Hello"]);
        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_MultipleInputs()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify multiple inputs were sent
                Assert.Equal(3, request.Instances.Count);
                Assert.Equal("Hello", request.Instances[0].StructValue.Fields["content"].StringValue);
                Assert.Equal("World", request.Instances[1].StructValue.Fields["content"].StringValue);
                Assert.Equal("Test", request.Instances[2].StructValue.Fields["content"].StringValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                response.Predictions.Add(CreateEmbeddingPrediction([0.4f, 0.5f, 0.6f]));
                response.Predictions.Add(CreateEmbeddingPrediction([0.7f, 0.8f, 0.9f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Hello", "World", "Test"]);
        Assert.NotNull(result);
        Assert.Equal(3, result.Count);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
        Assert.Equal([0.4f, 0.5f, 0.6f], result[1].Vector.ToArray());
        Assert.Equal([0.7f, 0.8f, 0.9f], result[2].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_WithOptions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify the model ID was set from options
                Assert.Equal("projects/test/locations/us-central1/publishers/google/models/text-embedding-004", request.Endpoint);

                // Verify dimensions parameter was set
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("outputDimensionality"));
                Assert.Equal(512, request.Parameters.StructValue.Fields["outputDimensionality"].NumberValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f, 0.4f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/default-model");

        EmbeddingGenerationOptions options = new()
        {
            ModelId = "projects/test/locations/us-central1/publishers/google/models/text-embedding-004",
            Dimensions = 512
        };

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test embedding"], options);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f, 0.4f], result[0].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_WithDefaultDimensions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify default dimensions were used
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("outputDimensionality"));
                Assert.Equal(768, request.Parameters.StructValue.Fields["outputDimensionality"].NumberValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel", 768);

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test"]);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_OptionsOverrideDefaultDimensions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify options dimensions override default
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("outputDimensionality"));
                Assert.Equal(1024, request.Parameters.StructValue.Fields["outputDimensionality"].NumberValue);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel", 768);

        EmbeddingGenerationOptions options = new()
        {
            Dimensions = 1024
        };

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test"], options);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
    }

    [Fact] 
    public async Task IEmbeddingGenerator_GenerateAsync_WithUsageMetadata()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPredictionWithTokens([0.1f, 0.2f, 0.3f], 5));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test with tokens"]);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_WithMultipleUsageMetadata()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                
                // First embedding with 3 tokens
                response.Predictions.Add(CreateEmbeddingPredictionWithTokens([0.1f, 0.2f, 0.3f], 3));
                
                // Second embedding with 7 tokens
                response.Predictions.Add(CreateEmbeddingPredictionWithTokens([0.4f, 0.5f, 0.6f], 7));

                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["First text", "Second longer text"]);

        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
        Assert.Equal([0.4f, 0.5f, 0.6f], result[1].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_WithRawRepresentationFactory()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify custom parameter was set via RawRepresentationFactory
                Assert.NotNull(request.Parameters);
                Assert.NotNull(request.Parameters.StructValue);
                Assert.True(request.Parameters.StructValue.Fields.ContainsKey("customParameter"));
                Assert.Equal("customValue", request.Parameters.StructValue.Fields["customParameter"].StringValue);
                
                // Verify endpoint was set via RawRepresentationFactory
                Assert.Equal("custom-endpoint", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        EmbeddingGenerationOptions options = new()
        {
            RawRepresentationFactory = (generator) =>
            {
                PredictRequest request = new()
                {
                    Endpoint = "custom-endpoint",
                    Parameters = new Value
                    {
                        StructValue = new()
                        {
                            Fields = { { "customParameter", Value.ForString("customValue") } }
                        }
                    }
                };
                return request;
            }
        };

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test"], options);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_EmptyPredictions()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                // No predictions in response
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test"]);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_MalformedPrediction()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                PredictResponse response = new();
                
                // Add a malformed prediction (missing embeddings field)
                response.Predictions.Add(new Value
                {
                    StructValue = new()
                    {
                        Fields = { { "invalid", Value.ForString("data") } }
                    }
                });

                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test"]);

        Assert.NotNull(result);
        Assert.Empty(result); // Should handle gracefully and return empty results
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_NullValues_ThrowsArgumentNullException()
    {
        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient().AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        await Assert.ThrowsAsync<ArgumentNullException>("values", () => embeddingGenerator.GenerateAsync(null!));
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_EmptyValues()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify no instances were added for empty input
                Assert.Empty(request.Instances);

                PredictResponse response = new();
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/mymodel");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync([]);

        Assert.NotNull(result);
        Assert.Empty(result);
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_WithFullResourceModelId()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify the full resource model ID was used
                Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/text-embedding-004", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator();

        EmbeddingGenerationOptions options = new()
        {
            ModelId = "projects/test-project/locations/us-central1/publishers/google/models/text-embedding-004"
        };

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test with full resource model ID"], options);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.1f, 0.2f, 0.3f], result[0].Vector.ToArray());
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_DefaultModelUsedWhenNoOverride()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify default model was used
                Assert.Equal("projects/test-project/locations/us-central1/publishers/google/models/default-model-id", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.1f, 0.2f, 0.3f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator("projects/test-project/locations/us-central1/publishers/google/models/default-model-id");

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test"]);

        Assert.NotNull(result);
        Assert.Single(result);
    }

    [Fact]
    public async Task IEmbeddingGenerator_GenerateAsync_WithComplexModelPath()
    {
        DelegateCallInvoker invoker = new()
        {
            OnPredictRequest = request =>
            {
                // Verify complex path with multiple segments was used as-is
                Assert.Equal("projects/prod-project/locations/asia-southeast1/endpoints/custom-endpoint-123", request.Endpoint);

                PredictResponse response = new();
                response.Predictions.Add(CreateEmbeddingPrediction([0.4f, 0.5f, 0.6f]));
                return response;
            }
        };

        IEmbeddingGenerator<string, Embedding<float>> embeddingGenerator = CreateClient(invoker).AsIEmbeddingGenerator();

        EmbeddingGenerationOptions options = new()
        {
            ModelId = "projects/prod-project/locations/asia-southeast1/endpoints/custom-endpoint-123"
        };

        GeneratedEmbeddings<Embedding<float>> result = await embeddingGenerator.GenerateAsync(["Test with complex path"], options);

        Assert.NotNull(result);
        Assert.Single(result);
        Assert.Equal([0.4f, 0.5f, 0.6f], result[0].Vector.ToArray());
    }

    private static Value CreateEmbeddingPrediction(float[] embedding) =>
        new()
        {
            StructValue = new()
            {
                Fields =
                {
                    {
                        "embeddings", new Value
                        {
                            StructValue = new()
                            {
                                Fields =
                                {
                                    {
                                        "values", new()
                                        {
                                            ListValue = new()
                                            {
                                                Values = { embedding.Select(f => Value.ForNumber(f)) }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };

    private static Value CreateEmbeddingPredictionWithTokens(float[] embedding, int tokenCount)
    {
        return new Value
        {
            StructValue = new()
            {
                Fields =
                {
                    {
                        "embeddings", new()
                        {
                            StructValue = new()
                            {
                                Fields =
                                {
                                    {
                                        "values", new()
                                        {
                                            ListValue = new()
                                            {
                                                Values = { embedding.Select(f => Value.ForNumber(f)) }
                                            }
                                        }
                                    },
                                    {
                                        "statistics", new()
                                        {
                                            StructValue = new()
                                            {
                                                Fields = { { "token_count", Value.ForNumber(tokenCount) } }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
    }

    private static PredictionServiceClient CreateClient(CallInvoker? callInvoker = null) =>
        new PredictionServiceClientBuilder()
        {
            ApiKey = "fake-api-key",
            CallInvoker = callInvoker,
        }.Build();

    private sealed class DelegateCallInvoker : CallInvoker
    {
        public Func<PredictRequest, PredictResponse>? OnPredictRequest { get; set; }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request)
        {
            if (OnPredictRequest is null)
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked but no {nameof(OnPredictRequest)} was provided.");
            }

            if (typeof(TRequest) != typeof(PredictRequest))
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked with unexpected request type {typeof(TRequest).FullName}. Expected {typeof(PredictRequest).FullName}.");
            }

            if (typeof(TResponse) != typeof(PredictResponse))
            {
                throw new NotSupportedException($"{nameof(AsyncUnaryCall)} was invoked with unexpected response type {typeof(TResponse).FullName}. Expected {typeof(PredictResponse).FullName}.");
            }

            TResponse response = (TResponse)(object)OnPredictRequest((PredictRequest)(object)request);
            return new(Task.FromResult(response), Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => [], () => { });
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request) =>
            throw new NotSupportedException();

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options) =>
            throw new NotSupportedException();

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options) =>
            throw new NotSupportedException();

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string? host, CallOptions options, TRequest request) =>
            throw new NotSupportedException();
    }
}

