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
using Microsoft.Extensions.AI;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides extension methods for creating Microsoft.Extensions.AI clients for Vertex AI.</summary>
public static class VertexAIExtensions
{
    /// <summary>
    /// Creates an <see cref="IChatClient"/> wrapper around the specified <see cref="PredictionServiceClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PredictionServiceClient"/> to wrap.</param>
    /// <param name="projectId">The ID of the Google Cloud project that accesses the resource, e.g. "my-vertex-project".</param>
    /// <param name="location">The region where the resource is hosted, e.g. "us-central1".</param>
    /// <param name="publisher">The model publisher. Defaults to "google" if not specified.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="ChatOptions.ModelId"/>.
    /// If this is not specified, the model ID must be provided in each <see cref="ChatOptions"/> instance.
    /// The model ID may be just the model name, in which case <paramref name="publisher"/> (defaulting to "google") is used
    /// in conjunction with <paramref name="projectId"/> and <paramref name="location"/> to form the full resource name.
    /// It may be "publisher/model", in which case <paramref name="publisher"/> is ignored. Or it may be the full resource name of the model,
    /// in which case <paramref name="publisher"/>, <paramref name="projectId"/>, and <paramref name="location"/> will all be ignored.
    /// </param>
    /// <returns>An <see cref="IChatClient"/> that wraps the specified client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
    public static IChatClient AsIChatClient(
        this PredictionServiceClient client, string projectId, string location, string? publisher = null, string? defaultModelId = null)
    {
        ThrowIfNull(client);
        ThrowIfNull(projectId);
        ThrowIfNull(location);

        return new PredictionServiceChatClient(client, projectId, location, publisher, defaultModelId);
    }

    /// <summary>
    /// Creates an <see cref="IEmbeddingGenerator{String, Embedding}"/> wrapper around the specified <see cref="PredictionServiceClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PredictionServiceClient"/> to wrap.</param>
    /// <param name="projectId">The ID of the Google Cloud project that accesses the resource, e.g. "my-vertex-project".</param>
    /// <param name="location">The region where the resource is hosted, e.g. "us-central1".</param>
    /// <param name="publisher">The model publisher. Defaults to "google" if not specified.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for embedding generation requests if not specified in <see cref="EmbeddingGenerationOptions.ModelId"/>.
    /// If this is not specified, the model ID must be provided in each <see cref="EmbeddingGenerationOptions"/> instance.
    /// The model ID must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}"
    /// </param>
    /// <param name="defaultModelDimensions">The optional default output dimensions for the embeddings.</param>
    /// <returns>An <see cref="IEmbeddingGenerator{String, Embedding}"/> that wraps the specified client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
    public static IEmbeddingGenerator<string, Embedding<float>> AsIEmbeddingGenerator(
        this PredictionServiceClient client, string projectId, string location, string? publisher = null, string? defaultModelId = null, int? defaultModelDimensions = null)
    {
        ThrowIfNull(client);
        ThrowIfNull(projectId);
        ThrowIfNull(location);

        return new PredictionServiceEmbeddingGenerator(client, projectId, location, publisher, defaultModelId, defaultModelDimensions);
    }

    /// <summary>
    /// Creates an <see cref="IImageGenerator"/> wrapper around the specified <see cref="PredictionServiceClient"/>.
    /// </summary>
    /// <param name="client">The <see cref="PredictionServiceClient"/> to wrap.</param>
    /// <param name="projectId">The ID of the Google Cloud project that accesses the resource, e.g. "my-vertex-project".</param>
    /// <param name="location">The region where the resource is hosted, e.g. "us-central1".</param>
    /// <param name="publisher">The model publisher. Defaults to "google" if not specified.</param>
    /// <param name="defaultModelId">
    /// The default model ID to use for chat requests if not specified in <see cref="ImageGenerationOptions.ModelId"/>.
    /// If this is not specified, the model ID must be provided in each <see cref="ImageGenerationOptions"/> instance.
    /// The model ID must be the full resource name of the model, e.g. "projects/{projectId}/locations/{location}/publishers/{publisher}/models/{model}"
    /// </param>
    /// <returns>An <see cref="IImageGenerator"/> that wraps the specified client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="client"/> is <see langword="null"/>.</exception>
    [Experimental("MEAI001")]
    public static IImageGenerator AsIImageGenerator(
        this PredictionServiceClient client, string projectId, string location, string? publisher = null, string? defaultModelId = null)
    {
        ThrowIfNull(client);
        ThrowIfNull(projectId);
        ThrowIfNull(location);

        return new PredictionServiceImageGenerator(client, projectId, location, publisher, defaultModelId);
    }

    /// <summary>
    /// Gets the full model endpoint resource name from the specified parameters.
    /// Handles three model ID formats:
    /// - Simple model name (e.g., "gemini-pro") -> constructs full resource name using provided project/location/publisher
    /// - Publisher/model format (e.g., "anthropic/claude-3-sonnet") -> constructs full resource name using extracted publisher
    /// - Full resource name (e.g., "projects/.../models/...") -> returns as-is
    /// </summary>
    internal static string GetModelEndpoint(string projectId, string location, string? publisher, string? modelId)
    {
        if (modelId is null)
        {
            throw new InvalidOperationException("A model ID must be specified either when creating the client or in each request's options.");
        }

        int slashPos = modelId.IndexOf('/');
        if (slashPos < 0)
        {
            // There are 0 slashes in the model ID, so treat it just as the model name and compose the full resource name.
            return EndpointName.FromProjectLocationPublisherModel(projectId, location, publisher ?? "google", modelId).ToString();
        }

        int secondSlashPos = modelId.IndexOf('/', slashPos + 1);
        if (secondSlashPos < 0)
        {
            // There's 1 slash in the model ID, so treat it as publisher/model, using the publisher to override the default.
            return EndpointName.FromProjectLocationPublisherModel(projectId, location, modelId.Substring(0, slashPos), modelId.Substring(slashPos + 1)).ToString();
        }

        // There are 2 or more slashes in the model ID, so treat it as a full resource name, overriding everything else.
        return modelId;
    }

    /// <summary>Parses the last segment of an endpoint to use as an informative model ID.</summary>
    internal static string? GetModelIdFromEndpoint(string? endpoint) =>
        endpoint is null ? null :
        endpoint.LastIndexOf('/') is int slashPos && slashPos >= 0 ? endpoint.Substring(slashPos + 1) :
        endpoint;

    /// <summary>Throws <see cref="ArgumentNullException"/> if <paramref name="obj"/> is <see langword="null"/>.</summary>
    internal static void ThrowIfNull(object? obj, [CallerArgumentExpression(nameof(obj))] string? paramName = null)
    {
        if (obj is null)
        {
            ThrowArgumentNullException(paramName);
        }

        static void ThrowArgumentNullException(string? paramName) => throw new ArgumentNullException(paramName);
    }
}
