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

using Google.Api.Gax.Grpc;
using Google.Cloud.AIPlatform.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides an <see cref="IChatClient"/> implementation based on <see cref="PredictionServiceClient"/>.</summary>
internal sealed class PredictionServiceChatClient(
    PredictionServiceClient client,
    string projectId, string location, string? publisher,
    string? defaultModelId)
    : IChatClient
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
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    public async Task<ChatResponse> GetResponseAsync(IEnumerable<ChatMessage> messages, ChatOptions? options = null, CancellationToken cancellationToken = default)
    {
        VertexAIExtensions.ThrowIfNull(messages);

        // Create the request.
        GenerateContentRequest request = CreateRequest(messages, options);

        // Send it.
        GenerateContentResponse generateResult = await _client.GenerateContentAsync(request, cancellationToken).ConfigureAwait(false);

        // Create the response.
        ChatResponse chatResponse = new(new ChatMessage(ChatRole.Assistant, []))
        {
            CreatedAt = generateResult.CreateTime?.ToDateTimeOffset(),
            ModelId = !string.IsNullOrWhiteSpace(generateResult.ModelVersion) ? generateResult.ModelVersion : VertexAIExtensions.GetModelIdFromEndpoint(request.Model),
            RawRepresentation = generateResult,
            ResponseId = generateResult.ResponseId,
        };

        // Populate the response messages.
        chatResponse.FinishReason = PopulateResponseContents(generateResult, chatResponse.Messages[0].Contents);

        // Populate usage information if there is any.
        if (generateResult.UsageMetadata is { } usageMetadata)
        {
            chatResponse.Usage = ExtractUsageDetails(usageMetadata);
        }

        // Return the response.
        return chatResponse;
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<ChatResponseUpdate> GetStreamingResponseAsync(IEnumerable<ChatMessage> messages, ChatOptions? options = null, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        VertexAIExtensions.ThrowIfNull(messages);

        // Create the request.
        GenerateContentRequest request = CreateRequest(messages, options);
        string? requestModelId = VertexAIExtensions.GetModelIdFromEndpoint(request.Model);

        // Send it.
        AsyncResponseStream<GenerateContentResponse> responseStream = _client.StreamGenerateContent(request).GetResponseStream();

        // Send it, and process the res
        await foreach (GenerateContentResponse generateResult in responseStream.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            // Create a response update for each result in the stream.
            ChatResponseUpdate responseUpdate = new(ChatRole.Assistant, [])
            {
                CreatedAt = generateResult.CreateTime.ToDateTimeOffset(),
                ModelId = !string.IsNullOrWhiteSpace(generateResult.ModelVersion) ? generateResult.ModelVersion : requestModelId,
                RawRepresentation = generateResult,
                ResponseId = generateResult.ResponseId,
            };

            // Populate the response update contents.
            responseUpdate.FinishReason = PopulateResponseContents(generateResult, responseUpdate.Contents);

            // Populate usage information if there is any.
            if (generateResult.UsageMetadata is { } usageMetadata)
            {
                responseUpdate.Contents.Add(new UsageContent(ExtractUsageDetails(usageMetadata)));
            }

            // Yield the update.
            yield return responseUpdate;
        }
    }

    /// <inheritdoc />
    public object? GetService(System.Type serviceType, object? serviceKey = null)
    {
        VertexAIExtensions.ThrowIfNull(serviceType);

        if (serviceKey is null)
        {
            // If there's a request for metadata, lazily-initialize it and return it. We don't need to worry about race conditions,
            // as there's no requirement that the same instance be returned each time, and creation is idempotent.
            if (serviceType == typeof(ChatClientMetadata))
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

    /// <summary>Creates a Google <see cref="GenerateContentRequest"/> from <paramref name="messages"/> and <paramref name="options"/>.</summary>
    private GenerateContentRequest CreateRequest(IEnumerable<ChatMessage> messages, ChatOptions? options)
    {
        // Create the GenerateContentRequest object. If the options contains a RawRepresentationFactory, try to use it to
        // create the request instance, allowing the caller to populate it with Vertex-specific options. Otherwise, create
        // a new instance directly.
        GenerateContentRequest request = options?.RawRepresentationFactory?.Invoke(this) as GenerateContentRequest ?? new();

        List<ChatMessage>? systemMessages = null;
        string? model = null;
        if (options is not null)
        {
            // Transfer over all options to the request.
            request.GenerationConfig ??= new();

            if (options.FrequencyPenalty is { } frequencyPenalty)
            {
                request.GenerationConfig.FrequencyPenalty = frequencyPenalty;
            }

            if (options.Instructions is { } instructions)
            {
                (systemMessages ??= []).Add(new ChatMessage(ChatRole.System, instructions));
            }

            if (options.MaxOutputTokens is { } maxOutputTokens)
            {
                request.GenerationConfig.MaxOutputTokens = maxOutputTokens;
            }

            model = options.ModelId;

            if (options.PresencePenalty is { } presencePenalty)
            {
                request.GenerationConfig.PresencePenalty = presencePenalty;
            }

            if (options.Seed is { } seed)
            {
                request.GenerationConfig.Seed = (int)seed;
            }

            if (options.StopSequences is { } stopSequences)
            {
                request.GenerationConfig.StopSequences.AddRange(stopSequences);
            }

            if (options.Temperature is { } temperature)
            {
                request.GenerationConfig.Temperature = temperature;
            }

            if (options.TopP is { } topP)
            {
                request.GenerationConfig.TopP = topP;
            }

            if (options.TopK is { } topK)
            {
                request.GenerationConfig.TopK = topK;
            }

            // Populate tools. Each kind of tool is added on its own, except for function declarations,
            // which are grouped into a single FunctionDeclaration.
            List<FunctionDeclaration>? functionDeclarations = null;
            if (options.Tools is { } tools)
            {
                foreach (var tool in tools)
                {
                    switch (tool)
                    {
                        case AIFunctionDeclaration af:
                            functionDeclarations ??= [];
                            functionDeclarations.Add(new FunctionDeclaration
                            {
                                Name = af.Name,
                                Description = af.Description ?? "",
                                ParametersJsonSchema = Protobuf.WellKnownTypes.Value.Parser.ParseJson(af.JsonSchema.ToString()),
                            });
                            break;

                        case HostedCodeInterpreterTool:
                            request.Tools.Add(new Tool() { CodeExecution = new() });
                            break;

                        case HostedFileSearchTool:
                            request.Tools.Add(new Tool() { Retrieval = new() });
                            break;

                        case HostedWebSearchTool:
                            request.Tools.Add(new Tool() { GoogleSearch = new() });
                            break;
                    }
                }
            }

            if (functionDeclarations is { Count: > 0 })
            {
                Tool functionTools = new();
                functionTools.FunctionDeclarations.AddRange(functionDeclarations);
                request.Tools.Add(functionTools);
            }

            // Transfer over the tool mode if there are any tools.
            if (options.ToolMode is { } toolMode && request.Tools.Count > 0)
            {
                switch (toolMode)
                {
                    case NoneChatToolMode:
                        request.ToolConfig = new() { FunctionCallingConfig = new() { Mode = FunctionCallingConfig.Types.Mode.None } };
                        break;

                    case AutoChatToolMode:
                        request.ToolConfig = new() { FunctionCallingConfig = new() { Mode = FunctionCallingConfig.Types.Mode.Auto } };
                        break;

                    case RequiredChatToolMode required:
                        request.ToolConfig = new() { FunctionCallingConfig = new() { Mode = FunctionCallingConfig.Types.Mode.Any } };
                        if (required.RequiredFunctionName is not null)
                        {
                            request.ToolConfig.FunctionCallingConfig.AllowedFunctionNames.Add(required.RequiredFunctionName);
                        }
                        break;
                }
            }

            // Set the response format if specified.
            if (options.ResponseFormat is ChatResponseFormatJson responseFormat)
            {
                request.GenerationConfig.ResponseMimeType = "application/json";
                if (responseFormat.Schema is { } schema)
                {
                    request.GenerationConfig.ResponseJsonSchema = Protobuf.WellKnownTypes.Value.Parser.ParseJson(schema.ToString());
                }
            }
        }

        // Set the model, preferring what was in GenerateContentRequest if one was provided via RawRepresentationFactory,
        // then what was in ChatOptions.Model, and finally any default set at the IChatClient level.
        model ??= _defaultModelId;
        if (string.IsNullOrWhiteSpace(request.Model) && !string.IsNullOrWhiteSpace(model))
        {
            request.Model = VertexAIExtensions.GetModelEndpoint(_projectId, _location, _publisher, model);
        }

        // Transfer messages to request, handling system messages specially
        foreach (var message in messages)
        {
            if (message.Role == ChatRole.System)
            {
                (systemMessages ??= []).Add(message);
                continue;
            }

            Content content = new() { Role = message.Role == ChatRole.Assistant ? "model" : "user" };
            AddPartsForAIContents(message.Contents, content.Parts);

            request.Contents.Add(content);
        }

        // Set system instruction if we found a system message
        if (systemMessages is not null && systemMessages.Count > 0)
        {
            Content systemInstructions = new() { Role = "system" };

            foreach (var systemMessage in systemMessages)
            {
                AddPartsForAIContents(systemMessage.Contents.OfType<TextContent>(), systemInstructions.Parts);
            }

            if (systemInstructions.Parts?.Count > 0)
            {
                request.SystemInstruction = systemInstructions;
            }
        }

        // Make sure the request contains at least one content part (the request would always fail if empty).
        if (!request.Contents.SelectMany(c => c.Parts).Any())
        {
            request.Contents.Add(new Content() { Role = "user", Parts = { new Part() { Text = "" } } });
        }

        return request;
    }

    /// <summary>Creates <see cref="Part"/>s for <paramref name="contents"/> and adds them to <paramref name="parts"/>.</summary>
    private static void AddPartsForAIContents(IEnumerable<AIContent> contents, RepeatedField<Part> parts)
    {
        foreach (AIContent content in contents)
        {
            switch (content)
            {
                case AIContent when content.RawRepresentation is Part part:
                    parts.Add(part);
                    break;

                case TextContent textContent:
                    parts.Add(new Part() { Text = textContent.Text });
                    break;

                case DataContent dataContent:
                    parts.Add(new Part()
                    {
                        InlineData = new Blob
                        {
                            MimeType = dataContent.MediaType,
                            Data = ByteString.CopyFrom(dataContent.Data.Span)
                        }
                    });
                    break;

                case UriContent uriContent:
                    parts.Add(new Part()
                    {
                        FileData = new FileData
                        {
                            FileUri = uriContent.Uri.AbsoluteUri,
                            MimeType = uriContent.MediaType
                        }
                    });
                    break;

                case FunctionCallContent functionCallContent:
                    parts.Add(new Part()
                    {
                        FunctionCall = new FunctionCall
                        {
                            Name = functionCallContent.Name,
                            Args = functionCallContent.Arguments is not null ?
                                Protobuf.WellKnownTypes.Struct.Parser.ParseJson(JsonSerializer.Serialize(functionCallContent.Arguments)) :
                                new Protobuf.WellKnownTypes.Struct()
                        }
                    });
                    break;

                case FunctionResultContent functionResultContent:
                    parts.Add(new Part()
                    {
                        FunctionResponse = new FunctionResponse
                        {
                            Name = functionResultContent.CallId,
                            Response = functionResultContent.Result is not null ?
                            Protobuf.WellKnownTypes.Struct.Parser.ParseJson(JsonSerializer.Serialize(new { result = functionResultContent.Result })) :
                            new Protobuf.WellKnownTypes.Struct()
                        }
                    });
                    break;

                case TextReasoningContent reasoningContent when reasoningContent.ProtectedData is { } reasoningData:
                    try
                    {
                        parts.Add(new Part()
                        {
                            Thought = true,
                            ThoughtSignature = ByteString.FromBase64(reasoningData),
                        });
                    }
                    catch
                    {
                        // Ignore reasoning data if we can't parse it.
                    }
                    break;
            }
        }
    }

    /// <summary>Creates <see cref="AIContent"/>s for <paramref name="parts"/> and adds them to <paramref name="contents"/>.</summary>
    private static void AddAIContentsForParts(RepeatedField<Part> parts, IList<AIContent> contents)
    {
        foreach (var part in parts)
        {
            AIContent? content = null;

            if (!string.IsNullOrEmpty(part.Text))
            {
                content = new TextContent(part.Text);
            }
            else if (part.InlineData is not null)
            {
                content = new DataContent(part.InlineData.Data.ToByteArray(), part.InlineData.MimeType);
            }
            else if (part.FileData is not null)
            {
                if (Uri.TryCreate(part.FileData.FileUri, UriKind.Absolute, out Uri? uri))
                {
                    content = new UriContent(uri, part.FileData.MimeType);
                }
            }
            else if (part.FunctionCall is not null)
            {
                content = new FunctionCallContent(part.FunctionCall.Name, part.FunctionCall.Name, part.FunctionCall.Args is not null ?
                    JsonSerializer.Deserialize<Dictionary<string, object?>>(part.FunctionCall.Args.ToString()) :
                    null);
            }
            else if (part.FunctionResponse is not null)
            {
                content = new FunctionResultContent(part.FunctionResponse.Name, part.FunctionResponse.Response is not null ?
                    JsonSerializer.Deserialize<object>(part.FunctionResponse.Response.ToString()) :
                    null);
            }
            else if (part.Thought)
            {
                content = new TextReasoningContent(null) { ProtectedData = part.ThoughtSignature.ToBase64() };
            }

            if (content is not null)
            {
                contents.Add(content);
            }
        }
    }

    private static ChatFinishReason? PopulateResponseContents(GenerateContentResponse generateResult, IList<AIContent> responseContents)
    {
        ChatFinishReason? finishReason = null;

        // Populate the response messages. There should only be at most one candidate, but if there are more, ignore all but the first.
        if (generateResult.Candidates is { Count: > 0 } &&
            generateResult.Candidates[0] is { Content: { } candidateContent } candidate)
        {
            // Grab the finish reason if one exists.
            finishReason = ConvertFinishReason(candidate.FinishReason);

            // Add all of the response content parts as AIContents.
            AddAIContentsForParts(candidateContent.Parts, responseContents);

            // Add any citation metadata.
            if (candidate.CitationMetadata is { Citations: { Count: > 0 } citations } &&
                responseContents.OfType<TextContent>().FirstOrDefault() is TextContent textContent)
            {
                foreach (var citation in citations)
                {
                    textContent.Annotations =
                    [
                        new CitationAnnotation()
                        {
                            Title = citation.Title,
                            Url = Uri.TryCreate(citation.Uri, UriKind.Absolute, out Uri uri) ? uri : null,
                            AnnotatedRegions =
                            [
                                new TextSpanAnnotatedRegion()
                                {
                                    StartIndex = citation.StartIndex,
                                    EndIndex = citation.EndIndex,
                                }
                            ],
                        }
                    ];
                }
            }
        }

        // Populate error information if there is any.
        if (generateResult.PromptFeedback is { } promptFeedback)
        {
            responseContents.Add(new ErrorContent(promptFeedback.BlockReasonMessage));
        }

        return finishReason;
    }

    /// <summary>Creates an M.E.AI <see cref="ChatFinishReason"/> from a Google <see cref="ConvertFinishReason(Candidate.Types.FinishReason)"/>.</summary>
    private static ChatFinishReason ConvertFinishReason(Candidate.Types.FinishReason finishReason) =>
        finishReason switch
        {
            Candidate.Types.FinishReason.MaxTokens => ChatFinishReason.Length,
            Candidate.Types.FinishReason.MalformedFunctionCall => ChatFinishReason.ToolCalls,
            Candidate.Types.FinishReason.Safety or
                Candidate.Types.FinishReason.Recitation or
                Candidate.Types.FinishReason.Blocklist or
                Candidate.Types.FinishReason.ProhibitedContent or
                Candidate.Types.FinishReason.Spii => ChatFinishReason.ContentFilter,
            _ => ChatFinishReason.Stop
        };

    /// <summary>Creates a <see cref="UsageDetails"/> populated from the supplied <paramref name="usageMetadata"/>.</summary>
    private static UsageDetails ExtractUsageDetails(GenerateContentResponse.Types.UsageMetadata usageMetadata) =>
        new()
        {
            InputTokenCount = usageMetadata.PromptTokenCount,
            OutputTokenCount = usageMetadata.CandidatesTokenCount,
            TotalTokenCount = usageMetadata.TotalTokenCount,
            AdditionalCounts = new()
            {
                [nameof(usageMetadata.CachedContentTokenCount)] = usageMetadata.CachedContentTokenCount,
                [nameof(usageMetadata.ThoughtsTokenCount)] = usageMetadata.ThoughtsTokenCount,
            },
        };
}
