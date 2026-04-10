#pragma warning disable MEAI001 // Experimental AI API

// Copyright 2026 Google LLC
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
using Google.Cloud.VertexAI.Extensions.Live;
using Microsoft.Extensions.AI;
using System.Collections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.VertexAI.Extensions;

/// <summary>Provides an <see cref="IRealtimeClientSession"/> implementation for Vertex AI live sessions.</summary>
#if NET8_0_OR_GREATER
[System.Diagnostics.CodeAnalysis.Experimental("MEAI001")]
#endif
internal sealed class PredictionServiceRealtimeSession : IRealtimeClientSession
{
    private readonly AsyncSession _asyncSession;
    private readonly Client _client;
    private readonly ChatClientMetadata _metadata;
    private int _disposed;

    // Buffer for audio chunks between Append and Commit.
    private readonly List<byte[]> _audioBuffer = new();
    private readonly object _audioBufferLock = new();
    private int _audioBufferSize;

    private const int MaxAudioBufferBytes = 10 * 1024 * 1024;
    private const int MaxToolPayloadDepth = 64;

    // Tracks whether we are currently in a response cycle.
    private bool _responseInProgress;
    private int _activeStreamingEnumeration;

    // Serializes access to the underlying websocket sends.
    private readonly SemaphoreSlim _sendLock = new(1, 1);

    private bool _lastSendWasToolResponse;
    private bool _pendingMediaNeedsTrigger;
    private readonly ConcurrentDictionary<string, string> _callIdToFunctionName = new();
    private readonly List<FunctionResponse> _pendingToolResponses = new();
    private readonly string _inputAudioMimeType;

    /// <inheritdoc />
    public RealtimeSessionOptions? Options { get; private set; }

    /// <summary>Creates a session wrapper around an already-connected Vertex AI live session.</summary>
    public PredictionServiceRealtimeSession(
        AsyncSession asyncSession,
        Client client,
        string model,
        RealtimeSessionOptions? initialOptions)
    {
        _asyncSession = GaxPreconditions.CheckNotNull(asyncSession, nameof(asyncSession));
        _client = GaxPreconditions.CheckNotNull(client, nameof(client));
        _metadata = new(
            VertexAIExtensions.ProviderName,
            VertexAIExtensions.ProviderUrl,
            VertexAIExtensions.ExtractModelIdFromResourceName(model));
        Options = initialOptions;
        _inputAudioMimeType = initialOptions?.InputAudioFormat?.MediaType ?? "audio/pcm";
    }

    /// <inheritdoc />
    public async Task SendAsync(
        RealtimeClientMessage message,
        CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(message, nameof(message));

        if (Volatile.Read(ref _disposed) != 0)
        {
            throw new ObjectDisposedException(nameof(PredictionServiceRealtimeSession));
        }

        cancellationToken.ThrowIfCancellationRequested();

        if (message is InputAudioBufferAppendRealtimeClientMessage audioAppend)
        {
            HandleAudioAppend(audioAppend);
            return;
        }

        try
        {
            await _sendLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (ObjectDisposedException)
        {
            throw new ObjectDisposedException(nameof(PredictionServiceRealtimeSession));
        }

        try
        {
            // Recheck after acquiring lock to avoid race with DisposeAsync
            if (Volatile.Read(ref _disposed) != 0)
            {
                throw new ObjectDisposedException(nameof(PredictionServiceRealtimeSession));
            }

            switch (message)
            {
                case InputAudioBufferCommitRealtimeClientMessage:
                    await HandleAudioCommitAsync(cancellationToken).ConfigureAwait(false);
                    break;

                case CreateConversationItemRealtimeClientMessage itemCreate:
                    await HandleConversationItemCreateAsync(itemCreate, cancellationToken).ConfigureAwait(false);
                    break;

                case SessionUpdateRealtimeClientMessage:
                    // Gemini's Live API does not support mid-session reconfiguration.
                    break;

                case CreateResponseRealtimeClientMessage:
                    if (_pendingToolResponses.Count > 0)
                    {
                        await _asyncSession.SendToolResponseAsync(
                            new LiveSendToolResponseParameters
                            {
                                FunctionResponses = new List<FunctionResponse>(_pendingToolResponses)
                            },
                            cancellationToken).ConfigureAwait(false);
                        _pendingToolResponses.Clear();
                        _lastSendWasToolResponse = true;
                    }

                    if (_lastSendWasToolResponse)
                    {
                        _lastSendWasToolResponse = false;
                    }
                    else if (_pendingMediaNeedsTrigger)
                    {
                        // Complete the turn to trigger the model to respond about
                        // the media content sent via clientContent.
                        _pendingMediaNeedsTrigger = false;
                        await _asyncSession.SendClientContentAsync(
                            new LiveClientContent
                            {
                                Turns = new List<Content>
                                {
                                    new()
                                    {
                                        Role = "user",
                                        Parts = new List<Part> { new() { Text = " " } }
                                    }
                                },
                                TurnComplete = true,
                            },
                            cancellationToken).ConfigureAwait(false);
                    }
                    break;
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            throw;
        }
        catch (ObjectDisposedException)
        {
            throw new ObjectDisposedException(nameof(PredictionServiceRealtimeSession));
        }
        catch (WebSocketException) when (Volatile.Read(ref _disposed) != 0)
        {
            // Ignore websocket teardown once the session has started disposing.
        }
        finally
        {
            try
            {
                _sendLock.Release();
            }
            catch (ObjectDisposedException)
            {
            }
        }
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<RealtimeServerMessage> GetStreamingResponseAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (Volatile.Read(ref _disposed) != 0)
        {
            throw new ObjectDisposedException(nameof(PredictionServiceRealtimeSession));
        }

        if (Interlocked.CompareExchange(ref _activeStreamingEnumeration, 1, 0) != 0)
        {
            throw new InvalidOperationException(
                "Only one active streaming enumeration is allowed at a time. " +
                "Await or cancel the existing enumeration before starting a new one.");
        }

        try
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                LiveServerMessage? serverMessage;
                try
                {
                    serverMessage = await _asyncSession.ReceiveAsync(cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                {
                    throw;
                }
                catch (Exception ex) when (ex is OperationCanceledException or ObjectDisposedException or WebSocketException)
                {
                    yield break;
                }

                if (serverMessage is null)
                {
                    yield break;
                }

                foreach (RealtimeServerMessage mapped in MapServerMessage(serverMessage))
                {
                    yield return mapped;
                }
            }
        }
        finally
        {
            Volatile.Write(ref _activeStreamingEnumeration, 0);
        }
    }

    /// <inheritdoc />
    public object? GetService(System.Type serviceType, object? serviceKey = null)
    {
        GaxPreconditions.CheckNotNull(serviceType, nameof(serviceType));

        if (serviceKey is not null)
        {
            return null;
        }

        if (serviceType == typeof(ChatClientMetadata))
        {
            return _metadata;
        }

        if (serviceType.IsInstanceOfType(this))
        {
            return this;
        }

        if (serviceType.IsInstanceOfType(_client))
        {
            return _client;
        }

        return null;
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (Interlocked.Exchange(ref _disposed, 1) != 0)
        {
            return;
        }

        _responseInProgress = false;
        Exception? firstException = null;
        try
        {
            await _asyncSession.DisposeAsync().ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            firstException = ex;
        }

        try
        {
            _sendLock.Dispose();
        }
        catch (Exception ex) when (firstException is null)
        {
            firstException = ex;
        }

        try
        {
            await _client.DisposeAsync().ConfigureAwait(false);
        }
        catch (Exception ex) when (firstException is null)
        {
            firstException = ex;
        }

        if (firstException is not null)
        {
            ExceptionDispatchInfo.Capture(firstException).Throw();
        }
    }

    private void HandleAudioAppend(InputAudioBufferAppendRealtimeClientMessage audioAppend)
    {
        if (audioAppend.Content is null || !audioAppend.Content.HasTopLevelMediaType("audio"))
        {
            return;
        }

        byte[] audioBytes = ExtractDataBytes(audioAppend.Content);

        lock (_audioBufferLock)
        {
            if (_audioBufferSize + audioBytes.Length > MaxAudioBufferBytes)
            {
                throw new InvalidOperationException(
                    $"Audio buffer would exceed {MaxAudioBufferBytes} bytes. Call AudioBufferCommit before appending more audio.");
            }

            _audioBuffer.Add(audioBytes);
            _audioBufferSize += audioBytes.Length;
        }
    }

    private async Task HandleAudioCommitAsync(CancellationToken cancellationToken)
    {
        List<byte[]> bufferedChunks;
        lock (_audioBufferLock)
        {
            if (_audioBuffer.Count == 0)
            {
                return;
            }

            bufferedChunks = new List<byte[]>(_audioBuffer);
            _audioBuffer.Clear();
            _audioBufferSize = 0;
        }

        _lastSendWasToolResponse = false;
        _pendingMediaNeedsTrigger = false;

        // Vertex AI does not support audioStreamEnd and automatic activity detection
        // is always disabled, so we always use explicit ActivityStart/ActivityEnd
        // framing to mark speech boundaries and trigger the model to respond.
        await _asyncSession.SendRealtimeInputAsync(
            new LiveSendRealtimeInputParameters
            {
                ActivityStart = new ActivityStart()
            },
            cancellationToken).ConfigureAwait(false);

        const int maxFrameBytes = 32_000;
        foreach (byte[] buffered in bufferedChunks)
        {
            if (buffered.Length <= maxFrameBytes)
            {
                await SendAudioFrameAsync(buffered, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                for (int i = 0; i < buffered.Length; i += maxFrameBytes)
                {
                    int len = Math.Min(maxFrameBytes, buffered.Length - i);
                    byte[] frame = new byte[len];
                    Buffer.BlockCopy(buffered, i, frame, 0, len);
                    await SendAudioFrameAsync(frame, cancellationToken).ConfigureAwait(false);
                }
            }
        }

        await _asyncSession.SendRealtimeInputAsync(
            new LiveSendRealtimeInputParameters
            {
                ActivityEnd = new ActivityEnd()
            },
            cancellationToken).ConfigureAwait(false);
    }

    private Task SendAudioFrameAsync(byte[] data, CancellationToken cancellationToken) =>
        _asyncSession.SendRealtimeInputAsync(
            new LiveSendRealtimeInputParameters
            {
                Audio = new Blob
                {
                    Data = data,
                    MimeType = _inputAudioMimeType,
                }
            },
            cancellationToken);

    private async Task HandleConversationItemCreateAsync(
        CreateConversationItemRealtimeClientMessage itemCreate,
        CancellationToken cancellationToken)
    {
        if (itemCreate.Item?.Contents is null or { Count: 0 })
        {
            return;
        }

        var functionResults = new List<FunctionResponse>();
        foreach (AIContent content in itemCreate.Item.Contents)
        {
            if (content is FunctionResultContent functionResult)
            {
                _callIdToFunctionName.TryRemove(functionResult.CallId, out string? functionName);
                functionResults.Add(new FunctionResponse
                {
                    Id = functionResult.CallId,
                    Name = functionName ?? "",
                    Response = new Dictionary<string, object>
                    {
                        ["result"] = NormalizeToolPayload(functionResult.Result) ?? ""
                    }
                });
            }
        }

        if (functionResults.Count > 0)
        {
            _pendingToolResponses.AddRange(functionResults);
            _lastSendWasToolResponse = true;
            return;
        }

        bool hasText = false;
        bool hasMedia = false;
        foreach (AIContent content in itemCreate.Item.Contents)
        {
            if (content is TextContent textContent && !string.IsNullOrEmpty(textContent.Text))
            {
                hasText = true;
                _lastSendWasToolResponse = false;
                await _asyncSession.SendRealtimeInputAsync(
                    new LiveSendRealtimeInputParameters
                    {
                        Text = textContent.Text,
                    },
                    cancellationToken).ConfigureAwait(false);
            }
            else if (content is DataContent dataContent)
            {
                if (dataContent.HasTopLevelMediaType("image"))
                {
                    // Send images via clientContent with inlineData rather than
                    // realtimeInput.video. The video field is designed for streaming
                    // video frames; clientContent properly adds the image to the
                    // conversation context so the model can reason about it.
                    hasMedia = true;
                    _lastSendWasToolResponse = false;
                    await _asyncSession.SendClientContentAsync(
                        new LiveClientContent
                        {
                            Turns = new List<Content>
                            {
                                new()
                                {
                                    Role = "user",
                                    Parts = new List<Part>
                                    {
                                        new()
                                        {
                                            InlineData = new Blob
                                            {
                                                Data = ExtractDataBytes(dataContent),
                                                MimeType = dataContent.MediaType ?? "image/jpeg",
                                            }
                                        }
                                    }
                                }
                            },
                            TurnComplete = false,
                        },
                        cancellationToken).ConfigureAwait(false);
                }
                else if (dataContent.HasTopLevelMediaType("audio"))
                {
                    hasMedia = true;
                    _lastSendWasToolResponse = false;
                    await _asyncSession.SendRealtimeInputAsync(
                        new LiveSendRealtimeInputParameters
                        {
                            Audio = new Blob
                            {
                                Data = ExtractDataBytes(dataContent),
                                MimeType = dataContent.MediaType ?? _inputAudioMimeType,
                            }
                        },
                        cancellationToken).ConfigureAwait(false);
                }
            }
        }

        if (hasMedia && !hasText)
        {
            _pendingMediaNeedsTrigger = true;
        }
    }

    internal static byte[] ExtractDataBytes(DataContent content)
    {
        string? dataUri = content.Uri?.ToString();
        if (dataUri is not null)
        {
            int commaIndex = dataUri.LastIndexOf(',');
            if (commaIndex >= 0 && commaIndex < dataUri.Length - 1)
            {
                string base64 = dataUri.Substring(commaIndex + 1);
                try
                {
                    return Convert.FromBase64String(base64);
                }
                catch (FormatException)
                {
                }
            }
        }

        return content.Data.ToArray();
    }

    private static Dictionary<string, object?> NormalizeToolArguments(IReadOnlyDictionary<string, object?> arguments, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);

        var normalized = new Dictionary<string, object?>(arguments.Count);
        foreach (KeyValuePair<string, object?> pair in arguments)
        {
            normalized[pair.Key] = NormalizeToolPayload(pair.Value, depth + 1);
        }
        return normalized;
    }

    private static object? NormalizeToolPayload(object? value, int depth = 0)
    {
        ValidateToolPayloadDepth(depth);

        switch (value)
        {
            case null:
                return null;

            case JsonElement element:
                return ConvertJsonElementToToolPayload(element, depth + 1);

            case JsonDocument document:
                return ConvertJsonElementToToolPayload(document.RootElement, depth + 1);

            case TextContent textContent:
                return textContent.Text ?? "";

            case TextReasoningContent reasoningContent:
                return reasoningContent.Text ?? "";

            case DataContent dataContent:
                return new Dictionary<string, object?>
                {
                    ["data"] = Convert.ToBase64String(ExtractDataBytes(dataContent)),
                    ["mimeType"] = dataContent.MediaType,
                    ["name"] = dataContent.Name,
                };

            case UriContent uriContent:
                return new Dictionary<string, object?>
                {
                    ["uri"] = uriContent.Uri.AbsoluteUri,
                    ["mimeType"] = uriContent.MediaType,
                };

            case IEnumerable<KeyValuePair<string, object?>> pairs:
                return NormalizeToolArguments(pairs.ToDictionary(pair => pair.Key, pair => pair.Value), depth + 1);

            case IDictionary dictionary:
                var mapped = new Dictionary<string, object?>();
                foreach (DictionaryEntry entry in dictionary)
                {
                    if (entry.Key is string key)
                    {
                        mapped[key] = NormalizeToolPayload(entry.Value, depth + 1);
                    }
                }
                return mapped;

            case IEnumerable<AIContent> aiContents:
                return aiContents.Select(content => NormalizeToolPayload(content, depth + 1)).ToList();

            case string or bool or byte or sbyte or short or ushort or int or uint or long or ulong or
                float or double or decimal:
                return value;

            case byte[] bytes:
                return Convert.ToBase64String(bytes);

            case ReadOnlyMemory<byte> readOnlyMemory:
                return Convert.ToBase64String(readOnlyMemory.ToArray());

            case Memory<byte> memory:
                return Convert.ToBase64String(memory.ToArray());

            case Enum enumValue:
                return enumValue.ToString();

            case IEnumerable enumerable when value is not string:
                var list = new List<object?>();
                foreach (object? item in enumerable)
                {
                    list.Add(NormalizeToolPayload(item, depth + 1));
                }
                return list;

            default:
                JsonElement serialized = JsonSerializer.SerializeToElement(value, AIJsonUtilities.DefaultOptions);
                return ConvertJsonElementToToolPayload(serialized, depth + 1);
        }
    }

    private static object? ConvertJsonElementToToolPayload(JsonElement element, int depth)
    {
        ValidateToolPayloadDepth(depth);

        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                var dictionary = new Dictionary<string, object?>();
                foreach (JsonProperty property in element.EnumerateObject())
                {
                    dictionary[property.Name] = ConvertJsonElementToToolPayload(property.Value, depth + 1);
                }
                return dictionary;

            case JsonValueKind.Array:
                var list = new List<object?>();
                foreach (JsonElement item in element.EnumerateArray())
                {
                    list.Add(ConvertJsonElementToToolPayload(item, depth + 1));
                }
                return list;

            case JsonValueKind.String:
                return element.GetString();

            case JsonValueKind.Number:
                return element.TryGetInt64(out long intValue) ? intValue : element.GetDouble();

            case JsonValueKind.True:
                return true;

            case JsonValueKind.False:
                return false;

            case JsonValueKind.Null:
            case JsonValueKind.Undefined:
            default:
                return null;
        }
    }

    private static void ValidateToolPayloadDepth(int depth)
    {
        if (depth > MaxToolPayloadDepth)
        {
            throw new InvalidOperationException(
                $"Realtime tool payloads exceed the maximum supported nesting depth of {MaxToolPayloadDepth}.");
        }
    }

    private IEnumerable<RealtimeServerMessage> MapServerMessage(LiveServerMessage serverMessage)
    {
        if (serverMessage.SetupComplete is not null)
        {
            yield break;
        }

        if (serverMessage.ServerContent is { } serverContent)
        {
            foreach (RealtimeServerMessage msg in MapServerContent(serverContent, serverMessage))
            {
                yield return msg;
            }
        }

        if (serverMessage.ToolCall is { FunctionCalls: { Count: > 0 } functionCalls })
        {
            if (!_responseInProgress)
            {
                _responseInProgress = true;
                yield return new ResponseCreatedRealtimeServerMessage(RealtimeServerMessageType.ResponseCreated)
                {
                    RawRepresentation = serverMessage,
                };
            }

            foreach (FunctionCall fc in functionCalls)
            {
                string callId = fc.Id ?? Guid.NewGuid().ToString();
                string functionName = fc.Name ?? "";

                _callIdToFunctionName[callId] = functionName;

                var contents = new List<AIContent>
                {
                    fc.Args is not null ?
                        FunctionCallContent.CreateFromParsedArguments(
                            fc.Args,
                            callId,
                            functionName,
                            static args => args is IReadOnlyDictionary<string, object?> dictionary ?
                                NormalizeToolArguments(dictionary) :
                                null) :
                        new FunctionCallContent(callId, functionName, null)
                };

                var item = new RealtimeConversationItem(contents, id: callId, role: ChatRole.Assistant);
                yield return new ResponseOutputItemRealtimeServerMessage(RealtimeServerMessageType.ResponseOutputItemAdded)
                {
                    Item = item,
                    RawRepresentation = serverMessage,
                };

                yield return new ResponseOutputItemRealtimeServerMessage(RealtimeServerMessageType.ResponseOutputItemDone)
                {
                    Item = item,
                    RawRepresentation = serverMessage,
                };
            }
        }

        if (serverMessage.ToolCallCancellation is { Ids: { Count: > 0 } })
        {
            yield return new RealtimeServerMessage
            {
                Type = RealtimeServerMessageType.RawContentOnly,
                RawRepresentation = serverMessage,
            };
        }

        // UsageMetadata is emitted as a standalone ResponseDone only when the
        // response wasn't already closed by TurnComplete/GenerationComplete in
        // MapServerContent. When they arrive in the same message, the usage is
        // included in the ResponseDone yielded by MapServerContent.
        if (serverMessage.UsageMetadata is { } usage && _responseInProgress)
        {
            _responseInProgress = false;
            yield return new ResponseCreatedRealtimeServerMessage(RealtimeServerMessageType.ResponseDone)
            {
                Usage = new UsageDetails
                {
                    InputTokenCount = usage.PromptTokenCount ?? 0,
                    OutputTokenCount = usage.ResponseTokenCount ?? 0,
                    TotalTokenCount = usage.TotalTokenCount ?? 0,
                },
                RawRepresentation = serverMessage,
            };
        }

        if (serverMessage.GoAway is not null)
        {
            yield return new ErrorRealtimeServerMessage
            {
                Error = new ErrorContent("Server is disconnecting (GoAway)"),
                RawRepresentation = serverMessage,
            };
        }
    }

    private IEnumerable<RealtimeServerMessage> MapServerContent(
        LiveServerContent serverContent,
        LiveServerMessage rawMessage)
    {
        if (serverContent.ModelTurn?.Parts is { Count: > 0 } parts)
        {
            if (!_responseInProgress)
            {
                _responseInProgress = true;
                yield return new ResponseCreatedRealtimeServerMessage(RealtimeServerMessageType.ResponseCreated)
                {
                    RawRepresentation = rawMessage,
                };
            }

            foreach (Part part in parts)
            {
                if (part.InlineData is { Data: not null } blob &&
                    blob.MimeType?.StartsWith("audio/", StringComparison.OrdinalIgnoreCase) == true)
                {
                    yield return new OutputTextAudioRealtimeServerMessage(RealtimeServerMessageType.OutputAudioDelta)
                    {
                        Audio = Convert.ToBase64String(blob.Data),
                        RawRepresentation = rawMessage,
                    };
                }

                if (!string.IsNullOrEmpty(part.Text))
                {
                    yield return new OutputTextAudioRealtimeServerMessage(RealtimeServerMessageType.OutputTextDelta)
                    {
                        Text = part.Text,
                        RawRepresentation = rawMessage,
                    };
                }
            }
        }

        if (serverContent.InputTranscription is { Text: not null } inputTranscription)
        {
            yield return new InputAudioTranscriptionRealtimeServerMessage(RealtimeServerMessageType.InputAudioTranscriptionCompleted)
            {
                Transcription = inputTranscription.Text,
                RawRepresentation = rawMessage,
            };
        }

        if (serverContent.OutputTranscription is { Text: not null } outputTranscription)
        {
            yield return new OutputTextAudioRealtimeServerMessage(RealtimeServerMessageType.OutputAudioTranscriptionDelta)
            {
                Text = outputTranscription.Text,
                RawRepresentation = rawMessage,
            };
        }

        if (serverContent.TurnComplete == true || serverContent.GenerationComplete == true)
        {
            _responseInProgress = false;
            var responseDone = new ResponseCreatedRealtimeServerMessage(RealtimeServerMessageType.ResponseDone)
            {
                RawRepresentation = rawMessage,
            };

            // Include usage metadata when it arrives in the same message as TurnComplete,
            // preventing it from being lost due to _responseInProgress already being false.
            if (rawMessage.UsageMetadata is { } usage)
            {
                responseDone.Usage = new UsageDetails
                {
                    InputTokenCount = usage.PromptTokenCount ?? 0,
                    OutputTokenCount = usage.ResponseTokenCount ?? 0,
                    TotalTokenCount = usage.TotalTokenCount ?? 0,
                };
            }

            yield return responseDone;
        }
    }

    internal static FunctionDeclaration ToGoogleFunctionDeclaration(AIFunction aiFunction)
    {
        var declaration = new FunctionDeclaration
        {
            Name = aiFunction.Name,
            Description = aiFunction.Description,
        };

        if (aiFunction.JsonSchema is JsonElement schemaElement &&
            schemaElement.ValueKind == JsonValueKind.Object)
        {
            declaration.Parameters = ConvertJsonSchemaToGoogleSchema(schemaElement);
        }

        return declaration;
    }

    internal static Schema ConvertJsonSchemaToGoogleSchema(JsonElement element, int depth = 0)
    {
        const int MaxDepth = 32;
        if (depth > MaxDepth)
        {
            throw new InvalidOperationException($"JSON schema nesting exceeds maximum depth of {MaxDepth}.");
        }

        var schema = new Schema();

        if (element.TryGetProperty("type", out JsonElement typeValue))
        {
            schema.Type = typeValue.GetString()?.ToLowerInvariant() switch
            {
                "object" => SchemaType.Object,
                "string" => SchemaType.String,
                "integer" => SchemaType.Integer,
                "number" => SchemaType.Number,
                "boolean" => SchemaType.Boolean,
                "array" => SchemaType.Array,
                _ => null
            };
        }

        if (element.TryGetProperty("description", out JsonElement description) &&
            description.ValueKind == JsonValueKind.String)
        {
            schema.Description = description.GetString();
        }

        if (element.TryGetProperty("properties", out JsonElement properties) &&
            properties.ValueKind == JsonValueKind.Object)
        {
            schema.Properties = new Dictionary<string, Schema>();
            foreach (JsonProperty property in properties.EnumerateObject())
            {
                schema.Properties[property.Name] = ConvertJsonSchemaToGoogleSchema(property.Value, depth + 1);
            }
        }

        if (element.TryGetProperty("required", out JsonElement required) &&
            required.ValueKind == JsonValueKind.Array)
        {
            schema.Required = new List<string>();
            foreach (JsonElement item in required.EnumerateArray())
            {
                if (item.ValueKind == JsonValueKind.String)
                {
                    schema.Required.Add(item.GetString()!);
                }
            }
        }

        if (element.TryGetProperty("items", out JsonElement items) &&
            items.ValueKind == JsonValueKind.Object)
        {
            schema.Items = ConvertJsonSchemaToGoogleSchema(items, depth + 1);
        }

        return schema;
    }
}
