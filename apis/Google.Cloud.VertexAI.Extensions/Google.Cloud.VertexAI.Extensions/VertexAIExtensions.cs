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

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides extension methods for creating Microsoft.Extensions.AI clients for Vertex AI.</summary>
public static class VertexAIExtensions
{
    /// <summary>
    /// Creates an <see cref="IChatClient"/> wrapper around the specified <see cref="PredictionServiceClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PredictionServiceClient"/> to wrap.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="ChatOptions.ModelId"/>.
    /// This must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </param>
    /// <returns>An <see cref="IChatClient"/> that wraps the specified client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
    public static IChatClient AsIChatClient(
        this PredictionServiceClient client, string? defaultModelId = null)
    {
        GaxPreconditions.CheckNotNull(client, nameof(client));

        return new PredictionServiceChatClient(client, defaultModelId);
    }

    /// <summary>
    /// Builds a <see cref="PredictionServiceClient"/> and creates an <see cref="IChatClient"/> wrapper around it.
    /// </summary>
    /// <param name="builder">The <see cref="PredictionServiceClientBuilder"/> with which to build the <see cref="PredictionServiceClient"/>.</param>
    /// <param name="provider">An optional <see cref="IServiceProvider"/> from which services are requested when building the client.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="ChatOptions.ModelId"/>.
    /// This must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </param>
    /// <returns>An <see cref="IChatClient"/> that wraps the built client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <see langword="null"/>.</exception>
    public static IChatClient BuildIChatClient(
        this PredictionServiceClientBuilder builder, IServiceProvider? provider = null, string? defaultModelId = null)
    {
        GaxPreconditions.CheckNotNull(builder, nameof(builder));

        PredictionServiceClient client = provider is not null ?
            builder.Build(provider) :
            builder.Build();

        return client.AsIChatClient(defaultModelId);
    }

    /// <summary>
    /// Creates an <see cref="IEmbeddingGenerator{String, Embedding}"/> wrapper around the specified <see cref="PredictionServiceClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PredictionServiceClient"/> to wrap.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="EmbeddingGenerationOptions.ModelId"/>.
    /// This must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </param>
    /// <param name="defaultModelDimensions">The optional default output dimensions for the embeddings.</param>
    /// <returns>An <see cref="IEmbeddingGenerator{String, Embedding}"/> that wraps the specified client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
    public static IEmbeddingGenerator<string, Embedding<float>> AsIEmbeddingGenerator(
        this PredictionServiceClient client, string? defaultModelId = null, int? defaultModelDimensions = null)
    {
        GaxPreconditions.CheckNotNull(client, nameof(client));

        return new PredictionServiceEmbeddingGenerator(client, defaultModelId, defaultModelDimensions);
    }

    /// <summary>
    /// Builds a <see cref="PredictionServiceClient"/> and creates an <see cref="IEmbeddingGenerator{String, Embedding}"/> wrapper around it.
    /// </summary>
    /// <param name="builder">The <see cref="PredictionServiceClientBuilder"/> with which to build the <see cref="PredictionServiceClient"/>.</param>
    /// <param name="provider">An optional <see cref="IServiceProvider"/> from which services are requested when building the client.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="EmbeddingGenerationOptions.ModelId"/>.
    /// This must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </param>
    /// <returns>An <see cref="IEmbeddingGenerator{String, Embedding}"/> that wraps the built client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <see langword="null"/>.</exception>
    public static IEmbeddingGenerator<string, Embedding<float>> BuildIEmbeddingGenerator(
        this PredictionServiceClientBuilder builder, IServiceProvider? provider = null, string? defaultModelId = null)
    {
        GaxPreconditions.CheckNotNull(builder, nameof(builder));

        PredictionServiceClient client = provider is not null ?
            builder.Build(provider) :
            builder.Build();

        return client.AsIEmbeddingGenerator(defaultModelId);
    }

    /// <summary>
    /// Creates an <see cref="IImageGenerator"/> wrapper around the specified <see cref="PredictionServiceClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PredictionServiceClient"/> to wrap.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="ImageGenerationOptions.ModelId"/>.
    /// This must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </param>
    /// <returns>An <see cref="IImageGenerator"/> that wraps the specified client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
    public static IImageGenerator AsIImageGenerator(
        this PredictionServiceClient client, string? defaultModelId = null)
    {
        GaxPreconditions.CheckNotNull(client, nameof(client));

        return new PredictionServiceImageGenerator(client, defaultModelId);
    }

    /// <summary>
    /// Builds a <see cref="PredictionServiceClient"/> and creates an <see cref="IImageGenerator"/> wrapper around it.
    /// </summary>
    /// <param name="builder">The <see cref="PredictionServiceClientBuilder"/> with which to build the <see cref="PredictionServiceClient"/>.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="ImageGenerationOptions.ModelId"/>.
    /// This must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}".
    /// </param>
    /// <param name="provider">An optional <see cref="IServiceProvider"/> from which services are requested when building the client.</param>
    /// <returns>An <see cref="IImageGenerator"/> that wraps the built client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <see langword="null"/>.</exception>
    public static IImageGenerator BuildIImageGenerator(
        this PredictionServiceClientBuilder builder, IServiceProvider? provider = null, string? defaultModelId = null)
    {
        GaxPreconditions.CheckNotNull(builder, nameof(builder));

        PredictionServiceClient client = provider is not null ?
            builder.Build(provider) :
            builder.Build();

        return client.AsIImageGenerator(defaultModelId);
    }

    /// <summary>Gets the name of the provider for use as the metadata provider name.</summary>
    internal static string ProviderName { get; } = "gcp.vertex_ai";

    /// <summary>Gets a <see cref="Uri"/> to use as the metadata provider url.</summary>
    internal static Uri ProviderUrl { get; } = new($"{Uri.UriSchemeHttps}{Uri.SchemeDelimiter}{PredictionServiceClient.DefaultEndpoint}");

    /// <summary>Extracts just the model ID from <paramref name="resourceName"/>, if possible.</summary>
    internal static string? ExtractModelIdFromResourceName(string? resourceName) =>
        resourceName is null ? null :
        EndpointName.TryParse(resourceName, out EndpointName? endpointName) && !string.IsNullOrWhiteSpace(endpointName.ModelId) ? endpointName.ModelId :
        resourceName;
}
