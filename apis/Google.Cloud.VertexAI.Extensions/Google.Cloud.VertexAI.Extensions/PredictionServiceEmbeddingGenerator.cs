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

        GeneratedEmbeddings<Embedding<float>> result = [];

        // EmbedContentAsync only produces a single embedding a time, so we need to loop over the input values.
        foreach (string value in values)
        {
            // Create the EmbedContentRequest object. If the options contains a RawRepresentationFactory, try to use it to
            // create the request instance, allowing the caller to populate it with Vertex-specific options. Otherwise, create
            // a new instance directly.
            EmbedContentRequest request = options?.RawRepresentationFactory?.Invoke(this) as EmbedContentRequest ?? new();

            string? model = options?.ModelId ?? _defaultModelId;
            if (string.IsNullOrWhiteSpace(request.Model) && !string.IsNullOrWhiteSpace(model))
            {
                request.Model = model;
            }

            request.Content = new() { Role = "user" };
            request.Content.Parts.Add(new Part() { Text = value });

            // If a dimensionality is specified, add it to the parameters.
            if ((options?.Dimensions ?? _defaultModelDimensions) is { } outputDimensions)
            {
                request.OutputDimensionality = outputDimensions;
            }

            // Make the request.
            EmbedContentResponse response = await _client.EmbedContentAsync(request).ConfigureAwait(false);

            // Add any usage information to our result.
            if (response.UsageMetadata is { } usageMetadata && VertexAIExtensions.ExtractUsageDetails(usageMetadata) is { } usage)
            {
                (result.Usage ??= new()).Add(usage);
            }

            // Add the embedding to our result.
            if (response.Embedding is { Values: { } numberValues })
            {
                float[] embedding = new float[numberValues.Count];
                numberValues.CopyTo(embedding, 0);

                result.Add(new(embedding)
                {
                    CreatedAt = DateTimeOffset.UtcNow,
                    ModelId = request.Model,
                });
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
