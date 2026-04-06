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
using Google.Api.Gax.Grpc;
using Google.Cloud.AIPlatform.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.Extensions.AI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Struct = Google.Protobuf.WellKnownTypes.Struct;
using Value = Google.Protobuf.WellKnownTypes.Value;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides an <see cref="IChatClient"/> implementation based on <see cref="PredictionServiceClient"/>.</summary>
internal sealed class PredictionServiceChatClient(PredictionServiceClient client, string? defaultModelId) : IChatClient
{
    /// <summary>A thought signature that can be used to skip thought validation when sending foreign function calls.</summary>
    /// <remarks>
    /// See https://ai.google.dev/gemini-api/docs/thought-signatures#faqs.
    /// This is more common in agentic scenarios, where a chat history is built up across multiple providers/models.
    /// </remarks>
    private static readonly ByteString s_skipThoughtValidation = ByteString.CopyFromUtf8("skip_thought_signature_validator");
    private const int MaxToolPayloadDepth = 64;

    /// <summary>The wrapped <see cref="PredictionServiceClient"/> instance.</summary>
    private readonly PredictionServiceClient _client = client;

    /// <summary>The default model that should be used when no override is specified.</summary>
    private readonly string? _defaultModelId = defaultModelId;

    /// <summary>Lazily-initialized metadata describing the implementation.</summary>
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    public async Task<ChatResponse> GetResponseAsync(IEnumerable<ChatMessage> messages, ChatOptions? options = null, CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(messages, nameof(messages));

        // Create the request.
        GenerateContentRequest request = CreateRequest(messages, options);

        // Send it.
        GenerateContentResponse generateResult = await _client.GenerateContentAsync(request, cancellationToken).ConfigureAwait(false);

        // Create the response.
        ChatResponse chatResponse = new(new ChatMessage(ChatRole.Assistant, (IList<AIContent>)[]))
        {
            CreatedAt = generateResult.CreateTime?.ToDateTimeOffset(),
            ModelId = !string.IsNullOrEmpty(generateResult.ModelVersion) ? generateResult.ModelVersion : request.Model,
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
        GaxPreconditions.CheckNotNull(messages, nameof(messages));

        // Create the request.
        GenerateContentRequest request = CreateRequest(messages, options);

        // Send it.
        AsyncResponseStream<GenerateContentResponse> responseStream = _client.StreamGenerateContent(request).GetResponseStream();

        // Send it, and process the res
        await foreach (GenerateContentResponse generateResult in responseStream.WithCancellation(cancellationToken).ConfigureAwait(false))
        {
            // Create a response update for each result in the stream.
            ChatResponseUpdate responseUpdate = new(ChatRole.Assistant, (IList<AIContent>)[])
            {
                CreatedAt = generateResult.CreateTime.ToDateTimeOffset(),
                ModelId = !string.IsNullOrEmpty(generateResult.ModelVersion) ? generateResult.ModelVersion : request.Model,
                RawRepresentation = generateResult,
                ResponseId = generateResult.ResponseId,
                MessageId = generateResult.ResponseId,
            };

            // Populate the response update contents.
            responseUpdate.FinishReason = PopulateResponseContents(generateResult, responseUpdate.Contents);

            // Populate usage information if there is any.
            if (generateResult.UsageMetadata is { } usageMetadata && ExtractUsageDetails(usageMetadata) is { } usage)
            {
                responseUpdate.Contents.Add(new UsageContent(usage));
            }

            // Yield the update.
            yield return responseUpdate;
        }
    }

    /// <inheritdoc />
    public object? GetService(System.Type serviceType, object? serviceKey = null)
    {
        GaxPreconditions.CheckNotNull(serviceType, nameof(serviceType));

        if (serviceKey is null)
        {
            // If there's a request for metadata, lazily-initialize it and return it. We don't need to worry about race conditions,
            // as there's no requirement that the same instance be returned each time, and creation is idempotent.
            if (serviceType == typeof(ChatClientMetadata))
            {
                return _metadata ??= new(
                    VertexAIExtensions.ProviderName,
                    VertexAIExtensions.ProviderUrl,
                    VertexAIExtensions.ExtractModelIdFromResourceName(_defaultModelId));
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

        if (string.IsNullOrEmpty(request.Model) && !string.IsNullOrEmpty(_defaultModelId))
        {
            request.Model = _defaultModelId;
        }

        List<ChatMessage>? systemMessages = null;
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

            if (!string.IsNullOrEmpty(options.ModelId))
            {
                request.Model = options.ModelId;
            }

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

            if (options.Reasoning is { } reasoning)
            {
                if (reasoning.Effort is { } effort)
                {
                    request.GenerationConfig.ThinkingConfig ??= new();
                    switch (effort)
                    {
                        case ReasoningEffort.None:
                            request.GenerationConfig.ThinkingConfig.ThinkingBudget = 0;
                            break;

                        case ReasoningEffort.Low:
                            request.GenerationConfig.ThinkingConfig.ThinkingLevel = GenerationConfig.Types.ThinkingConfig.Types.ThinkingLevel.Low;
                            break;

                        case ReasoningEffort.Medium:
                            request.GenerationConfig.ThinkingConfig.ThinkingLevel = GenerationConfig.Types.ThinkingConfig.Types.ThinkingLevel.Medium;
                            break;

                        default:
                            request.GenerationConfig.ThinkingConfig.ThinkingLevel = GenerationConfig.Types.ThinkingConfig.Types.ThinkingLevel.High;
                            break;
                    }
                }

                if (reasoning.Output is { } output)
                {
                    request.GenerationConfig.ThinkingConfig ??= new();
                    request.GenerationConfig.ThinkingConfig.IncludeThoughts = output is not ReasoningOutput.None;
                }
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
                        case ToolAITool raw:
                            request.Tools.Add(raw.Tool);
                            break;

                        case AIFunctionDeclaration af:
                            functionDeclarations ??= [];
                            functionDeclarations.Add(new FunctionDeclaration
                            {
                                Name = af.Name,
                                Description = af.Description ?? "",
                                ParametersJsonSchema = Value.Parser.ParseJson(af.JsonSchema.ToString()),
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
                    request.GenerationConfig.ResponseJsonSchema = Value.Parser.ParseJson(schema.ToString());
                }
            }
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
                AddPartsForAIContents([.. systemMessage.Contents.OfType<TextContent>()], systemInstructions.Parts);
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
    private static void AddPartsForAIContents(IList<AIContent> contents, RepeatedField<Part> parts)
    {
        for (int i = 0; i < contents.Count; i++)
        {
            var content = contents[i];

            // When AddAIContentsForParts added thought signatures, they were added as a separate part
            // immediately after the main part. So if we see a TextReasoningContent with no text but with
            // protected data, we treat that as the thought signature for the previous part.
            byte[]? thoughtSignature = null;
            if (content is not TextReasoningContent { ProtectedData: not null } &&
                i + 1 < contents.Count &&
                contents[i + 1] is TextReasoningContent nextReasoning &&
                string.IsNullOrEmpty(nextReasoning.Text) &&
                nextReasoning.ProtectedData is { } protectedData)
            {
                i++;
                try
                {
                    thoughtSignature = Convert.FromBase64String(protectedData);
                }
                catch (FormatException)
                {
                    // Ignore base64 parsing failures
                }
            }

            // Translate the AIContent into a Part.
            Part? part = null;
            switch (content)
            {
                case AIContent when content.RawRepresentation is Part rawPart:
                    // Roundtrip the raw representation directly if it's a Part. This case comes before
                    // the others so that it's prioritized.
                    part = rawPart;
                    break;

                case TextContent textContent:
                    part = new Part() { Text = textContent.Text };
                    break;

                case DataContent dataContent:
                    part = new Part()
                    {
                        InlineData = new Blob
                        {
                            MimeType = dataContent.MediaType,
                            Data = ByteString.CopyFrom(dataContent.Data.Span)
                        }
                    };
                    break;

                case UriContent uriContent:
                    part = new Part()
                    {
                        FileData = new FileData
                        {
                            FileUri = uriContent.Uri.AbsoluteUri,
                            MimeType = uriContent.MediaType
                        }
                    };
                    break;

                case FunctionCallContent functionCallContent:
                    part = new Part()
                    {
                        FunctionCall = new FunctionCall
                        {
                            Name = functionCallContent.Name,
                            Args = functionCallContent.Arguments is not null ?
                                ConvertObjectToStruct(functionCallContent.Arguments) :
                                new(),
                        },
                        ThoughtSignature = thoughtSignature is not null ? ByteString.CopyFrom(thoughtSignature) : s_skipThoughtValidation,
                    };
                    break;

                case FunctionResultContent functionResultContent:
                    FunctionResponse funcResponse = new()
                    {
                        Name = functionResultContent.CallId,
                    };

                    switch (functionResultContent.Result)
                    {
                        case null:
                            funcResponse.Response = new();
                            break;

                        case AIContent aic when ToFunctionResponsePart(aic) is { } singleContentBlob:
                            funcResponse.Response = new();
                            funcResponse.Parts.Add(singleContentBlob);
                            break;

                        case IEnumerable<AIContent> aiContents:
                            List<AIContent>? nonBlobContent = null;
                            foreach (var aiContent in aiContents)
                            {
                                if (ToFunctionResponsePart(aiContent) is { } contentBlob)
                                {
                                    funcResponse.Parts.Add(contentBlob);
                                }
                                else
                                {
                                    (nonBlobContent ??= []).Add(aiContent);
                                }
                            }

                            funcResponse.Response = nonBlobContent is { Count: > 0 } ?
                                CreateFunctionResponseStruct(nonBlobContent) :
                                new();
                            break;

                        case TextContent textContent:
                            funcResponse.Response = CreateFunctionResponseStruct(textContent.Text);
                            break;

                        case TextReasoningContent textContent:
                            funcResponse.Response = CreateFunctionResponseStruct(textContent.Text);
                            break;

                        default:
                            funcResponse.Response = CreateFunctionResponseStruct(functionResultContent.Result);
                            break;
                    }

                    part = new Part()
                    {
                        FunctionResponse = funcResponse
                    };
                    break;

                case TextReasoningContent reasoningContent when !string.IsNullOrEmpty(reasoningContent.Text) || reasoningContent.ProtectedData is not null:
                    part = new Part() { Thought = true };

                    if (!string.IsNullOrEmpty(reasoningContent.Text))
                    {
                        part.Text = reasoningContent.Text;
                    }

                    if (reasoningContent.ProtectedData is not null)
                    {
                        try
                        {
                            part.ThoughtSignature = ByteString.FromBase64(reasoningContent.ProtectedData);
                        }
                        catch
                        {
                            // Ignore reasoning data if we can't parse it.
                        }
                    }
                    break;
            }

            if (part is not null)
            {
                part.ThoughtSignature ??= ByteString.CopyFrom(thoughtSignature);
                parts.Add(part);
            }

            thoughtSignature = null;
        }
    }

    private static FunctionResponsePart? ToFunctionResponsePart(AIContent content)
    {
        switch (content)
        {
            case AIContent when content.RawRepresentation is FunctionResponsePart functionResponsePart:
                return functionResponsePart;

            case DataContent dc when IsSupportedMediaType(dc.MediaType):
                FunctionResponseBlob dataBlob = new()
                {
                    MimeType = dc.MediaType,
                    Data = ByteString.CopyFrom(dc.Data.Span),
                };

                if (!string.IsNullOrEmpty(dc.Name))
                {
                    dataBlob.DisplayName = dc.Name;
                }

                return new() { InlineData = dataBlob };

            case UriContent uc when IsSupportedMediaType(uc.MediaType):
                return new()
                {
                    FileData = new()
                    {
                        MimeType = uc.MediaType,
                        FileUri = uc.Uri.AbsoluteUri,
                    }
                };

            default:
                return null;
        }

        // https://docs.cloud.google.com/vertex-ai/generative-ai/docs/multimodal/function-calling#mm-fr
        static bool IsSupportedMediaType(string mediaType) =>
            // images
            mediaType.Equals("image/png", StringComparison.OrdinalIgnoreCase) ||
            mediaType.Equals("image/jpeg", StringComparison.OrdinalIgnoreCase) ||
            mediaType.Equals("image/webp", StringComparison.OrdinalIgnoreCase) ||
            // documents
            mediaType.Equals("application/pdf", StringComparison.OrdinalIgnoreCase) ||
            mediaType.Equals("text/plain", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>Creates <see cref="AIContent"/>s for <paramref name="parts"/> and adds them to <paramref name="contents"/>.</summary>
    private static void AddAIContentsForParts(RepeatedField<Part> parts, IList<AIContent> contents)
    {
        string? lastCodeInterpreterCallId = null;
        foreach (var part in parts)
        {
            AIContent content = part.DataCase switch
            {
                Part.DataOneofCase.Text when !part.Thought => new TextContent(part.Text),

                Part.DataOneofCase.InlineData => new DataContent(part.InlineData!.Data.ToByteArray(), part.InlineData.MimeType),

                Part.DataOneofCase.FileData => new UriContent(new Uri(part.FileData!.FileUri), part.FileData.MimeType),

                Part.DataOneofCase.FunctionCall =>
                    part.FunctionCall.Args is not null ?
                        FunctionCallContent.CreateFromParsedArguments(
                            part.FunctionCall.Args, part.FunctionCall!.Name, part.FunctionCall.Name,
                            static args => args is Struct structArgs ? ConvertStructToDictionary(structArgs) : null) :
                        new FunctionCallContent(part.FunctionCall!.Name, part.FunctionCall.Name, null),

                Part.DataOneofCase.FunctionResponse => new FunctionResultContent(part.FunctionResponse!.Name,
                    part.FunctionResponse.Response?.Fields.TryGetValue("output", out Value output) is true ? ConvertValueToObject(output) :
                    part.FunctionResponse.Response?.Fields.TryGetValue("error", out Value error) is true ? ConvertValueToObject(error) :
                    part.FunctionResponse.Response?.Fields.TryGetValue("result", out Value result) is true ? ConvertValueToObject(result) :
                    part.FunctionResponse.Response is not null ? ConvertStructToDictionary(part.FunctionResponse.Response) :
                    null),

                Part.DataOneofCase.ExecutableCode when part.ExecutableCode is { } execCode =>
                    new CodeInterpreterToolCallContent(lastCodeInterpreterCallId = Guid.NewGuid().ToString())
                    {
                        Inputs = [new DataContent(Encoding.UTF8.GetBytes(execCode.Code), LanguageToMimeType(execCode.Language))],
                    },

                Part.DataOneofCase.CodeExecutionResult when part.CodeExecutionResult is { Output: { } codeResultOutput } codeResult =>
                    new CodeInterpreterToolResultContent(lastCodeInterpreterCallId ?? Guid.NewGuid().ToString())
                    {
                        Outputs = [codeResult.Outcome is CodeExecutionResult.Types.Outcome.Ok ?
                            new TextContent(codeResultOutput) :
                            new ErrorContent(codeResultOutput) { ErrorCode = codeResult.Outcome.ToString() }],
                    },

                _ when part.Thought => new TextReasoningContent(part.Text),

                _ => new AIContent(),
            };

            content.RawRepresentation = part;
            contents.Add(content);

            if (part.ThoughtSignature is { } thoughtSignature && !thoughtSignature.IsEmpty)
            {
                contents.Add(new TextReasoningContent(null)
                {
                    ProtectedData = Convert.ToBase64String(thoughtSignature.Span.ToArray()),
                });
            }
        }

        static string LanguageToMimeType(ExecutableCode.Types.Language language) => language switch
        {
            ExecutableCode.Types.Language.Python => "text/python",
            _ => "text/x-source-code",
        };
    }

    private static Struct CreateFunctionResponseStruct(object? result)
    {
        Struct response = new();
        if (result is not null)
        {
            response.Fields["result"] = ConvertObjectToValue(result, 0);
        }
        return response;
    }

    private static Struct ConvertObjectToStruct(object value, int depth = 0)
    {
        GaxPreconditions.CheckNotNull(value, nameof(value));
        ValidateToolPayloadDepth(depth);

        if (value is Struct structValue)
        {
            return structValue.Clone();
        }

        if (value is JsonElement element)
        {
            return ConvertJsonElementToStruct(element, depth + 1);
        }

        if (value is JsonDocument document)
        {
            return ConvertJsonElementToStruct(document.RootElement, depth + 1);
        }

        if (value is IEnumerable<KeyValuePair<string, object?>> nullablePairs)
        {
            Struct response = new();
            foreach (KeyValuePair<string, object?> pair in nullablePairs)
            {
                response.Fields[pair.Key] = ConvertObjectToValue(pair.Value, depth + 1);
            }
            return response;
        }

        if (value is IEnumerable<KeyValuePair<string, object>> pairs)
        {
            Struct response = new();
            foreach (KeyValuePair<string, object> pair in pairs)
            {
                response.Fields[pair.Key] = ConvertObjectToValue(pair.Value, depth + 1);
            }
            return response;
        }

        if (value is IDictionary dictionary)
        {
            Struct response = new();
            foreach (DictionaryEntry entry in dictionary)
            {
                if (entry.Key is string key)
                {
                    response.Fields[key] = ConvertObjectToValue(entry.Value, depth + 1);
                }
            }
            return response;
        }

        // Defer to the shared AI JSON options only for consumer-supplied POCOs after handling the
        // common JSON-shaped cases directly, which avoids extra reflection-heavy round-tripping in the provider.
        JsonElement serialized = JsonSerializer.SerializeToElement(value, AIJsonUtilities.DefaultOptions);
        return ConvertJsonElementToStruct(serialized, depth + 1);
    }

    private static Dictionary<string, object?> ConvertStructToDictionary(Struct structValue, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);
        return structValue.Fields.ToDictionary(pair => pair.Key, pair => ConvertValueToObject(pair.Value, depth + 1));
    }

    private static Value ConvertObjectToValue(object? value, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);

        switch (value)
        {
            case null:
                return new Value { NullValue = Google.Protobuf.WellKnownTypes.NullValue.NullValue };

            case Value protobufValue:
                return protobufValue.Clone();

            case Struct protobufStruct:
                return new Value { StructValue = protobufStruct.Clone() };

            case JsonElement element:
                return ConvertJsonElementToValue(element, depth + 1);

            case JsonDocument document:
                return ConvertJsonElementToValue(document.RootElement, depth + 1);

            case string stringValue:
                return Value.ForString(stringValue);

            case bool boolValue:
                return Value.ForBool(boolValue);

            case byte[] byteArray:
                return Value.ForString(Convert.ToBase64String(byteArray));

            case ReadOnlyMemory<byte> readOnlyMemory:
                return Value.ForString(Convert.ToBase64String(readOnlyMemory.ToArray()));

            case Memory<byte> memory:
                return Value.ForString(Convert.ToBase64String(memory.ToArray()));

            case Enum enumValue:
                return Value.ForString(enumValue.ToString());

            case IEnumerable<KeyValuePair<string, object?>> or IEnumerable<KeyValuePair<string, object>> or IDictionary:
                return new Value { StructValue = ConvertObjectToStruct(value, depth + 1) };

            case IEnumerable enumerable when value is not string:
                var listValue = new Google.Protobuf.WellKnownTypes.ListValue();
                foreach (object? item in enumerable)
                {
                    listValue.Values.Add(ConvertObjectToValue(item, depth + 1));
                }
                return new Value { ListValue = listValue };
        }

        if (TryConvertToDouble(value, out double numberValue))
        {
            return Value.ForNumber(numberValue);
        }

        JsonElement serialized = JsonSerializer.SerializeToElement(value, AIJsonUtilities.DefaultOptions);
        return ConvertJsonElementToValue(serialized, depth + 1);
    }

    private static object? ConvertValueToObject(Value value, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);
        return value.KindCase switch
        {
            Value.KindOneofCase.NullValue => null,
            Value.KindOneofCase.NumberValue => value.NumberValue,
            Value.KindOneofCase.StringValue => value.StringValue,
            Value.KindOneofCase.BoolValue => value.BoolValue,
            Value.KindOneofCase.StructValue => ConvertStructToDictionary(value.StructValue, depth + 1),
            Value.KindOneofCase.ListValue => value.ListValue.Values.Select(item => ConvertValueToObject(item, depth + 1)).ToList(),
            _ => null,
        };
    }

    private static Struct ConvertJsonElementToStruct(JsonElement element, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);

        if (element.ValueKind == JsonValueKind.Null || element.ValueKind == JsonValueKind.Undefined)
        {
            return new Struct();
        }

        if (element.ValueKind != JsonValueKind.Object)
        {
            throw new InvalidOperationException("Function call arguments and structured function results must serialize to a JSON object.");
        }

        Struct response = new();
        foreach (JsonProperty property in element.EnumerateObject())
        {
            response.Fields[property.Name] = ConvertJsonElementToValue(property.Value, depth + 1);
        }
        return response;
    }

    private static Value ConvertJsonElementToValue(JsonElement element, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);

        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                return new Value { StructValue = ConvertJsonElementToStruct(element, depth + 1) };

            case JsonValueKind.Array:
                var listValue = new Google.Protobuf.WellKnownTypes.ListValue();
                foreach (JsonElement item in element.EnumerateArray())
                {
                    listValue.Values.Add(ConvertJsonElementToValue(item, depth + 1));
                }
                return new Value { ListValue = listValue };

            case JsonValueKind.String:
                return Value.ForString(element.GetString() ?? "");

            case JsonValueKind.Number:
                return Value.ForNumber(element.GetDouble());

            case JsonValueKind.True:
                return Value.ForBool(true);

            case JsonValueKind.False:
                return Value.ForBool(false);

            case JsonValueKind.Null:
            case JsonValueKind.Undefined:
            default:
                return new Value { NullValue = Google.Protobuf.WellKnownTypes.NullValue.NullValue };
        }
    }

    private static bool TryConvertToDouble(object value, out double numberValue)
    {
        switch (value)
        {
            case byte or sbyte or short or ushort or int or uint or long or ulong or float or double or decimal:
                numberValue = Convert.ToDouble(value, CultureInfo.InvariantCulture);
                return true;

            default:
                numberValue = default;
                return false;
        }
    }

    private static void ValidateToolPayloadDepth(int depth)
    {
        if (depth > MaxToolPayloadDepth)
        {
            throw new InvalidOperationException(
                $"Function arguments or results exceed the maximum supported nesting depth of {MaxToolPayloadDepth}.");
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
            Candidate.Types.FinishReason.Blocklist => ChatFinishReason.ContentFilter,
            Candidate.Types.FinishReason.Recitation => ChatFinishReason.ContentFilter,
            Candidate.Types.FinishReason.MalformedFunctionCall => ChatFinishReason.ToolCalls,
            Candidate.Types.FinishReason.MaxTokens => ChatFinishReason.Length,
            Candidate.Types.FinishReason.ModelArmor => ChatFinishReason.ContentFilter,
            Candidate.Types.FinishReason.Other => ChatFinishReason.Stop,
            Candidate.Types.FinishReason.ProhibitedContent => ChatFinishReason.ContentFilter,
            Candidate.Types.FinishReason.Safety => ChatFinishReason.ContentFilter,
            Candidate.Types.FinishReason.Spii => ChatFinishReason.ContentFilter,
            Candidate.Types.FinishReason.Stop => ChatFinishReason.Stop,
            Candidate.Types.FinishReason.Unspecified => ChatFinishReason.Stop,
            _ => ChatFinishReason.Stop
        };

    /// <summary>Creates a <see cref="UsageDetails"/> populated from the supplied <paramref name="usageMetadata"/>.</summary>
    private static UsageDetails? ExtractUsageDetails(GenerateContentResponse.Types.UsageMetadata usageMetadata)
    {
        if (usageMetadata.TotalTokenCount == 0 &&
            usageMetadata.PromptTokenCount == 0 &&
            usageMetadata.CandidatesTokenCount == 0 &&
            usageMetadata.CachedContentTokenCount == 0 &&
            usageMetadata.ThoughtsTokenCount == 0)
        {
            return null;
        }

        UsageDetails usage = new()
        {
            InputTokenCount = usageMetadata.PromptTokenCount != 0 ? usageMetadata.PromptTokenCount : null,
            CachedInputTokenCount = usageMetadata.CachedContentTokenCount != 0 ? usageMetadata.CachedContentTokenCount : null,
            OutputTokenCount = usageMetadata.CandidatesTokenCount != 0 ? usageMetadata.CandidatesTokenCount : null,
            ReasoningTokenCount = usageMetadata.ThoughtsTokenCount != 0 ? usageMetadata.ThoughtsTokenCount : null,
            TotalTokenCount = usageMetadata.TotalTokenCount != 0 ? usageMetadata.TotalTokenCount : null,
        };

        return usage;
    }

    /// <summary>Provides an <see cref="AITool"/> wrapper for a <see cref="Tool"/>.</summary>
    internal sealed class ToolAITool(Tool tool) : AITool
    {
        public Tool Tool => tool;

        public override string Name => Tool.GetType().Name;
 
        /// <inheritdoc />
        public override object? GetService(System.Type serviceType, object? serviceKey = null) =>
            serviceKey is null && serviceType?.IsInstanceOfType(Tool) is true ? Tool :
            base.GetService(serviceType!, serviceKey);
    }
}
