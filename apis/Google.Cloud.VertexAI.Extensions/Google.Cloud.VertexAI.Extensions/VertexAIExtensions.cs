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
using System.Threading;
using System.Threading.Tasks;

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
        this PredictionServiceClientBuilder builder,
        IServiceProvider? provider = null, string? defaultModelId = null)
    {
        builder = builder.WithAssemblyVersionHeader();

        PredictionServiceClient client = provider is not null ?
            builder.Build(provider) :
            builder.Build();

        return client.AsIChatClient(defaultModelId);
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
    /// <param name="cancellationToken">A token to cancel the async operation.</param>
    /// <returns>An <see cref="IChatClient"/> that wraps the built client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <see langword="null"/>.</exception>
    public static async Task<IChatClient> BuildIChatClientAsync(
        this PredictionServiceClientBuilder builder,
        IServiceProvider? provider = null, string? defaultModelId = null,
        CancellationToken cancellationToken = default)
    {
        builder = builder.WithAssemblyVersionHeader();

        PredictionServiceClient client = await (provider is not null ?
            builder.BuildAsync(provider, cancellationToken) :
            builder.BuildAsync(cancellationToken)).ConfigureAwait(false);

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
        this PredictionServiceClientBuilder builder,
        IServiceProvider? provider = null, string? defaultModelId = null)
    {
        builder = builder.WithAssemblyVersionHeader();

        PredictionServiceClient client = provider is not null ?
            builder.Build(provider) :
            builder.Build();

        return client.AsIEmbeddingGenerator(defaultModelId);
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
    /// <param name="cancellationToken">A token to cancel the async operation.</param>
    /// <returns>An <see cref="IEmbeddingGenerator{String, Embedding}"/> that wraps the built client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <see langword="null"/>.</exception>
    public static async Task<IEmbeddingGenerator<string, Embedding<float>>> BuildIEmbeddingGeneratorAsync(
        this PredictionServiceClientBuilder builder,
        IServiceProvider? provider = null, string? defaultModelId = null,
        CancellationToken cancellationToken = default)
    {
        builder = builder.WithAssemblyVersionHeader();

        PredictionServiceClient client = await (provider is not null ?
            builder.BuildAsync(provider, cancellationToken) :
            builder.BuildAsync(cancellationToken)).ConfigureAwait(false);

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
        this PredictionServiceClientBuilder builder,
        IServiceProvider? provider = null, string? defaultModelId = null)
    {
        builder = builder.WithAssemblyVersionHeader();

        PredictionServiceClient client = provider is not null ?
            builder.Build(provider) :
            builder.Build();

        return client.AsIImageGenerator(defaultModelId);
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
    /// <param name="cancellationToken">A token to cancel the async operation.</param>
    /// <returns>An <see cref="IImageGenerator"/> that wraps the built client.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="builder"/> is <see langword="null"/>.</exception>
    public static async Task<IImageGenerator> BuildIImageGeneratorAsync(
        this PredictionServiceClientBuilder builder,
        IServiceProvider? provider = null, string? defaultModelId = null,
        CancellationToken cancellationToken = default)
    {
        builder = builder.WithAssemblyVersionHeader();

        PredictionServiceClient client = await (provider is not null ?
            builder.BuildAsync(provider, cancellationToken) :
            builder.BuildAsync(cancellationToken)).ConfigureAwait(false);

        return client.AsIImageGenerator(defaultModelId);
    }

    /// <summary>Creates an <see cref="AITool"/> to represent a raw <see cref="Tool"/>.</summary>
    /// <param name="tool">The tool to wrap as an <see cref="AITool"/>.</param>
    /// <returns>The <paramref name="tool"/> wrapped as an <see cref="AITool"/>.</returns>
    /// <remarks>
    /// <para>
    /// The returned tool is only suitable for use with the <see cref="IChatClient"/> returned by
    /// <see cref="AsIChatClient"/> or <see cref="BuildIChatClient"/> (or <see cref="IChatClient"/>s that delegate
    /// to such an instance). It is likely to be ignored by any other <see cref="IChatClient"/> implementation.
    /// </para>
    /// <para>
    /// When a tool has a corresponding <see cref="AITool"/>-derived type already defined in Microsoft.Extensions.AI,
    /// such as <see cref="AIFunction"/> or <see cref="HostedWebSearchTool"/>, those types should be preferred instead
    /// of this method, as they are more portable, capable of being respected by any <see cref="IChatClient"/> implementation.
    /// This method does not attempt to map the supplied <see cref="Tool"/> to any of those types, it simply wraps it as-is:
    /// the <see cref="IChatClient"/> returned by <see cref="AsIChatClient"/>/<see cref="BuildIChatClient"/> will
    /// be able to unwrap the <see cref="Tool"/> when it processes the list of tools.
    /// </para>
    /// </remarks>
    public static AITool AsAITool(this Tool tool)
    {
        GaxPreconditions.CheckNotNull(tool, nameof(tool));

        return new PredictionServiceChatClient.ToolAITool(tool);
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

    /// <summary>Creates a <see cref="UsageDetails"/> populated from the supplied <paramref name="usageMetadata"/>.</summary>
    internal static UsageDetails? ExtractUsageDetails(UsageMetadata usageMetadata)
    {
        if (usageMetadata.TotalTokenCount == 0 &&
            usageMetadata.PromptTokenCount == 0 &&
            usageMetadata.CandidatesTokenCount == 0 &&
            usageMetadata.CachedContentTokenCount == 0 &&
            usageMetadata.ThoughtsTokenCount == 0 &&
            usageMetadata.ToolUsePromptTokenCount == 0)
        {
            return null;
        }

        UsageDetails usage = new()
        {
            InputTokenCount = usageMetadata.PromptTokenCount,
            OutputTokenCount = usageMetadata.CandidatesTokenCount,
            TotalTokenCount = usageMetadata.TotalTokenCount,
        };

        if (usageMetadata.CachedContentTokenCount != 0)
        {
            (usage.AdditionalCounts ??= [])[nameof(usageMetadata.CachedContentTokenCount)] = usageMetadata.CachedContentTokenCount;
        }

        if (usageMetadata.ThoughtsTokenCount != 0)
        {
            (usage.AdditionalCounts ??= [])[nameof(usageMetadata.ThoughtsTokenCount)] = usageMetadata.ThoughtsTokenCount;
        }

        if (usageMetadata.ToolUsePromptTokenCount != 0)
        {
            (usage.AdditionalCounts ??= [])[nameof(usageMetadata.ToolUsePromptTokenCount)] = usageMetadata.ToolUsePromptTokenCount;
        }

        return usage;
    }

    private static PredictionServiceClientBuilder WithAssemblyVersionHeader(this PredictionServiceClientBuilder builder)
    {
        GaxPreconditions.CheckNotNull(builder, nameof(builder));
        var newBuilder = MemberwiseCloneBuilder();
        newBuilder.Settings = newBuilder.Settings?.Clone() ?? new PredictionServiceSettings();
        newBuilder.Settings.VersionHeaderBuilder.AppendAssemblyVersion("gccl", typeof(VertexAIExtensions));
        return newBuilder;

        // This is a shallow copy.
        PredictionServiceClientBuilder MemberwiseCloneBuilder() => new PredictionServiceClientBuilder
        {
            ApiKey = builder.ApiKey,
            CallInvoker = builder.CallInvoker,
            ChannelCredentials = builder.ChannelCredentials,
            Credential = builder.Credential,
#pragma warning disable CS0618 // Type or member is obsolete
            CredentialsPath = builder.CredentialsPath,
#pragma warning restore CS0618 // Type or member is obsolete
            Endpoint = builder.Endpoint,
            GoogleCredential = builder.GoogleCredential,
            GrpcAdapter = builder.GrpcAdapter,
            GrpcChannelOptions = builder.GrpcChannelOptions,
#pragma warning disable CS0618 // Type or member is obsolete
            JsonCredentials = builder.JsonCredentials,
#pragma warning restore CS0618 // Type or member is obsolete
            Logger = builder.Logger,
            QuotaProject = builder.QuotaProject,
            Scopes = builder.Scopes,
            Settings = builder.Settings,
#pragma warning disable CS0618 // Type or member is obsolete
            TokenAccessMethod = builder.TokenAccessMethod,
#pragma warning restore CS0618 // Type or member is obsolete
            UniverseDomain = builder.UniverseDomain,
            UseJwtAccessWithScopes = builder.UseJwtAccessWithScopes,
            UserAgent = builder.UserAgent,
        };
    }
}
