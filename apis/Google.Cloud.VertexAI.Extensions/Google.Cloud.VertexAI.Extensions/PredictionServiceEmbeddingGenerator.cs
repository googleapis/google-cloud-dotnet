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

using Google.Api.Gax;
using Google.Cloud.AIPlatform.V1;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Value = Google.Protobuf.WellKnownTypes.Value;
using Struct = Google.Protobuf.WellKnownTypes.Struct;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides an <see cref="IEmbeddingGenerator{String, Embedding}"/> implementation based on <see cref="PredictionServiceClient"/>.</summary>
internal sealed class PredictionServiceEmbeddingGenerator(PredictionServiceClient client, string? defaultModelId, int? defaultModelDimensions) : IEmbeddingGenerator<string, Embedding<float>>
{
    /// <summary>The wrapped <see cref="PredictionServiceClient"/> instance.</summary>
    private readonly PredictionServiceClient _client = client;

    /// <summary>The default model that should be used when no override is specified.</summary>
    private readonly string? _defaultModelId = defaultModelId;

    /// <summary>The default output dimensions for the embeddings.</summary>
    private readonly int? _defaultModelDimensions = defaultModelDimensions;

    /// <summary>Lazily-initialized metadata describing the implementation.</summary>
    private EmbeddingGeneratorMetadata? _metadata;

    /// <inheritdoc />
    public async Task<GeneratedEmbeddings<Embedding<float>>> GenerateAsync(IEnumerable<string> values, EmbeddingGenerationOptions? options = null, CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(values, nameof(values));

        // Create the PredictRequest object. If the options contains a RawRepresentationFactory, try to use it to
        // create the request instance, allowing the caller to populate it with Vertex-specific options. Otherwise, create
        // a new instance directly.
        PredictRequest request = options?.RawRepresentationFactory?.Invoke(this) as PredictRequest ?? new();

        string? model = options?.ModelId ?? _defaultModelId;
        if (string.IsNullOrWhiteSpace(request.Endpoint) && !string.IsNullOrWhiteSpace(model))
        {
            request.Endpoint = model;
        }

        // Add all of the inputs.
        foreach (string value in values)
        {
            request.Instances.Add(new Value
            {
                StructValue = new Struct
                {
                    Fields = { { "content", Value.ForString(value) } },
                }
            });
        }

        // If a dimensionality is specified, add it to the parameters.
        if ((options?.Dimensions ?? _defaultModelDimensions) is { } outputDimensions)
        {
            (request.Parameters ??= new()).StructValue ??= new Struct
            {
                Fields = { { "outputDimensionality", Value.ForNumber(outputDimensions) } },
            };
        }

        // Make the request.
        PredictResponse response = await _client.PredictAsync(request).ConfigureAwait(false);

        // Parse the response into a GeneratedEmbeddings instance.
        GeneratedEmbeddings<Embedding<float>> result = [];

        if (response.Predictions is not null)
        {
            // Process each prediction.
            foreach (Value pred in response.Predictions)
            {
                if (pred.KindCase == Value.KindOneofCase.StructValue &&
                    pred.StructValue.Fields.TryGetValue("embeddings", out Value embeddingsValue) &&
                    embeddingsValue.KindCase == Value.KindOneofCase.StructValue)
                {
                    // Convert the embedding values into an Embedding<float>.
                    if (embeddingsValue.StructValue.Fields.TryGetValue("values", out Value listValue) &&
                        listValue.KindCase == Value.KindOneofCase.ListValue)
                    {
                        Protobuf.Collections.RepeatedField<Value> numberValues = listValue.ListValue.Values;

                        float[] embedding = new float[numberValues.Count];
                        for (int j = 0; j < numberValues.Count; j++)
                        {
                            embedding[j] = (float) numberValues[j].NumberValue;
                        }

                        result.Add(new Embedding<float>(embedding)
                        {
                            CreatedAt = DateTimeOffset.UtcNow,
                            ModelId = !string.IsNullOrWhiteSpace(response.ModelVersionId) ? response.ModelVersionId : request.Endpoint,
                        });
                    }

                    // Sum up any token counts to include as UsageDetails.
                    if (embeddingsValue.StructValue.Fields.TryGetValue("statistics", out Value statsValue) &&
                        statsValue.KindCase == Value.KindOneofCase.StructValue &&
                        statsValue.StructValue.Fields.TryGetValue("token_count", out Value tokenCountValue) &&
                        tokenCountValue.KindCase == Value.KindOneofCase.NumberValue)
                    {
                        int tokenCount = (int) tokenCountValue.NumberValue;

                        result.Usage ??= new();
                        result.Usage.InputTokenCount += tokenCount;
                        result.Usage.TotalTokenCount += tokenCount;
                    }
                }
            }
        }

        return result;
    }

    /// <inheritdoc />
    public object? GetService(System.Type serviceType, object? serviceKey = null)
    {
        GaxPreconditions.CheckNotNull(serviceType, nameof(serviceType));

        if (serviceKey is null)
        {
            // If there's a request for metadata, lazily-initialize it and return it. We don't need to worry about race conditions,
            // as there's no requirement that the same instance be returned each time, and creation is idempotent.
            if (serviceType == typeof(EmbeddingGeneratorMetadata))
            {
                return _metadata ??= new(
                    VertexAIExtensions.ProviderName,
                    VertexAIExtensions.ProviderUrl,
                    VertexAIExtensions.ExtractModelIdFromResourceName(_defaultModelId),
                    _defaultModelDimensions);
            }

            // Allow a consumer to "break glass" and access the underlying client if they need it.
            if (serviceType.IsInstanceOfType(_client))
            {
                return _client;
            }

            if (serviceType.IsInstanceOfType(this))
            {
                return this;
            }
        }

        return null;
    }

    /// <inheritdoc />
    void IDisposable.Dispose() { /* nop */ }
}
