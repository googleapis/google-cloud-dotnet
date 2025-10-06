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
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.AI;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides an <see cref="IImageGenerator"/> implementation based on <see cref="PredictionServiceClient"/>.</summary>
[Experimental("MEAI001")]
internal sealed class PredictionServiceImageGenerator(
    PredictionServiceClient client,
    string projectId, string location, string? publisher,
    string? defaultModelId) : IImageGenerator
{
    /// <summary>The wrapped <see cref="PredictionServiceClient"/> instance.</summary>
    private readonly PredictionServiceClient _client = client;

    /// <summary>The project ID for the resource.</summary>
    private readonly string _projectId = projectId;

    /// <summary>The location for the resource.</summary>
    private readonly string _location = location;

    /// <summary>The publisher for the model.</summary>
    private readonly string? _publisher = publisher;

    /// <summary>The default model that should be used when no override is specified.</summary>
    private readonly string? _defaultModelId = defaultModelId;

    /// <summary>Lazily-initialized metadata describing the implementation.</summary>
    private ImageGeneratorMetadata? _metadata;

    /// <inheritdoc />
    public async Task<ImageGenerationResponse> GenerateAsync(ImageGenerationRequest request, ImageGenerationOptions? options = null, CancellationToken cancellationToken = default)
    {
        VertexAIExtensions.ThrowIfNull(request);

        // Create the PredictRequest object. If the options contains a RawRepresentationFactory, try to use it to
        // create the request instance, allowing the caller to populate it with Vertex-specific options. Otherwise, create
        // a new instance directly.
        PredictRequest predicRequest = options?.RawRepresentationFactory?.Invoke(this) as PredictRequest ?? new();

        string? model = options?.ModelId ?? _defaultModelId;
        if (string.IsNullOrWhiteSpace(predicRequest.Endpoint) && !string.IsNullOrWhiteSpace(model))
        {
            predicRequest.Endpoint = VertexAIExtensions.GetModelEndpoint(_projectId, _location, _publisher, model);
        }

        // Add the inputs.
        Struct instances = new();
        if (request.Prompt is { } prompt)
        {
            instances.Fields.Add("prompt", Protobuf.WellKnownTypes.Value.ForString(prompt));
        }

        // Add any options.
        Struct parameters = new();
        int sampleCount = 1;
        if (options is not null)
        {
            if (options.Count is { } count)
            {
                sampleCount = count;
            }

            if (options.MediaType is { } mediaType)
            {
                parameters.Fields.Add("outputOptions", new Protobuf.WellKnownTypes.Value
                {
                    StructValue = new Struct { Fields = { { "mimeType", Protobuf.WellKnownTypes.Value.ForString(mediaType) } } },
                });
            }

            if (options.ImageSize is { } imageSize && imageSize.Width > 0 && imageSize.Height > 0)
            {
                int gcd = GCD(imageSize.Width, imageSize.Height);

                parameters.Fields.Add("aspectRatio", Protobuf.WellKnownTypes.Value.ForString($"{imageSize.Width / gcd}:{imageSize.Height / gcd}"));

                static int GCD(int x, int y)
                {
                    while (y != 0)
                    {
                        int temp = y;
                        y = x % y;
                        x = temp;
                    }

                    return x;
                }
            }
        }
        parameters.Fields.Add("sampleCount", Protobuf.WellKnownTypes.Value.ForNumber(sampleCount));

        // Make the request.
        predicRequest.Instances.Add(new Protobuf.WellKnownTypes.Value { StructValue = instances });
        predicRequest.Parameters = new Protobuf.WellKnownTypes.Value { StructValue = parameters };
        PredictResponse response = await _client.PredictAsync(predicRequest).ConfigureAwait(false);

        // Parse the response into a ImageGenerationResponse instance.
        ImageGenerationResponse result = new()
        {
            RawRepresentation = response,
        };

        if (response.Predictions is not null)
        {
            // Process each prediction.
            foreach (Protobuf.WellKnownTypes.Value pred in response.Predictions)
            {
                if (pred.KindCase == Protobuf.WellKnownTypes.Value.KindOneofCase.StructValue &&
                    pred.StructValue.Fields.TryGetValue("bytesBase64Encoded", out Protobuf.WellKnownTypes.Value base64Value) &&
                    base64Value.KindCase == Protobuf.WellKnownTypes.Value.KindOneofCase.StringValue)
                {
                    string mediaType = "image/png";
                    if (pred.StructValue.Fields.TryGetValue("mimeType", out Protobuf.WellKnownTypes.Value mimeTypeValue) &&
                        mimeTypeValue.KindCase == Protobuf.WellKnownTypes.Value.KindOneofCase.StringValue)
                    {
                        mediaType = mimeTypeValue.StringValue;
                    }

                    DataContent dc = new(Convert.FromBase64String(base64Value.StringValue), mediaType);
                    result.Contents.Add(dc);
                }
            }
        }

        return result;
    }

    /// <inheritdoc />
    public object? GetService(System.Type serviceType, object? serviceKey = null)
    {
        VertexAIExtensions.ThrowIfNull(serviceType);

        if (serviceKey is null)
        {
            // If there's a request for metadata, lazily-initialize it and return it. We don't need to worry about race conditions,
            // as there's no requirement that the same instance be returned each time, and creation is idempotent.
            if (serviceType == typeof(EmbeddingGenerationOptions))
            {
                return _metadata ??= new("gcp.vertex_ai", defaultModelId: _defaultModelId);
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
