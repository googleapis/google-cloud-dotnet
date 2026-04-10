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

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Google.Cloud.VertexAI.Extensions.Live;

internal sealed class HttpOptions
{
    [JsonPropertyName("baseUrl")]
    public string? BaseUrl { get; set; }

    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    [JsonPropertyName("headers")]
    public Dictionary<string, string>? Headers { get; set; }
}

internal sealed class LiveConnectConfig
{
    [JsonPropertyName("generationConfig")]
    public GenerationConfig? GenerationConfig { get; set; }

    [JsonPropertyName("responseModalities")]
    public IList<string>? ResponseModalities { get; set; }

    [JsonPropertyName("systemInstruction")]
    public Content? SystemInstruction { get; set; }

    [JsonPropertyName("tools")]
    public IList<Tool>? Tools { get; set; }

    [JsonPropertyName("speechConfig")]
    public SpeechConfig? SpeechConfig { get; set; }

    [JsonPropertyName("inputAudioTranscription")]
    public AudioTranscriptionConfig? InputAudioTranscription { get; set; }

    [JsonPropertyName("outputAudioTranscription")]
    public AudioTranscriptionConfig? OutputAudioTranscription { get; set; }

    [JsonPropertyName("realtimeInputConfig")]
    public RealtimeInputConfig? RealtimeInputConfig { get; set; }
}

internal sealed class LiveClientMessage
{
    [JsonPropertyName("setup")]
    public LiveClientSetup? Setup { get; set; }

    [JsonPropertyName("realtimeInput")]
    public LiveSendRealtimeInputParameters? RealtimeInput { get; set; }

    [JsonPropertyName("clientContent")]
    public LiveClientContent? ClientContent { get; set; }

    [JsonPropertyName("toolResponse")]
    public LiveClientToolResponse? ToolResponse { get; set; }
}

internal sealed class LiveClientContent
{
    [JsonPropertyName("turns")]
    public IList<Content>? Turns { get; set; }

    [JsonPropertyName("turnComplete")]
    public bool? TurnComplete { get; set; }
}

internal sealed class LiveClientSetup
{
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("generationConfig")]
    public GenerationConfig? GenerationConfig { get; set; }

    [JsonPropertyName("systemInstruction")]
    public Content? SystemInstruction { get; set; }

    [JsonPropertyName("tools")]
    public IList<Tool>? Tools { get; set; }

    [JsonPropertyName("inputAudioTranscription")]
    public AudioTranscriptionConfig? InputAudioTranscription { get; set; }

    [JsonPropertyName("outputAudioTranscription")]
    public AudioTranscriptionConfig? OutputAudioTranscription { get; set; }

    [JsonPropertyName("realtimeInputConfig")]
    public RealtimeInputConfig? RealtimeInputConfig { get; set; }
}

internal sealed class LiveSendRealtimeInputParameters
{
    [JsonPropertyName("audio")]
    public Blob? Audio { get; set; }

    [JsonPropertyName("audioStreamEnd")]
    public bool? AudioStreamEnd { get; set; }

    [JsonPropertyName("video")]
    public Blob? Video { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("activityStart")]
    public ActivityStart? ActivityStart { get; set; }

    [JsonPropertyName("activityEnd")]
    public ActivityEnd? ActivityEnd { get; set; }
}

internal sealed class LiveSendToolResponseParameters
{
    [JsonPropertyName("functionResponses")]
    public IList<FunctionResponse>? FunctionResponses { get; set; }
}

internal sealed class LiveClientToolResponse
{
    [JsonPropertyName("functionResponses")]
    public IList<FunctionResponse>? FunctionResponses { get; set; }
}

internal sealed class Blob
{
    [JsonPropertyName("data")]
    public byte[]? Data { get; set; }

    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }
}

internal sealed class ActivityStart { }
internal sealed class ActivityEnd { }

internal sealed class Content
{
    [JsonPropertyName("parts")]
    public IList<Part>? Parts { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }
}

internal sealed class Part
{
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("inlineData")]
    public Blob? InlineData { get; set; }
}

internal sealed class GenerationConfig
{
    [JsonPropertyName("responseModalities")]
    public IList<string>? ResponseModalities { get; set; }

    [JsonPropertyName("speechConfig")]
    public SpeechConfig? SpeechConfig { get; set; }

    [JsonPropertyName("maxOutputTokens")]
    public int? MaxOutputTokens { get; set; }
}

internal sealed class SpeechConfig
{
    [JsonPropertyName("voiceConfig")]
    public VoiceConfig? VoiceConfig { get; set; }
}

internal sealed class VoiceConfig
{
    [JsonPropertyName("prebuiltVoiceConfig")]
    public PrebuiltVoiceConfig? PrebuiltVoiceConfig { get; set; }
}

internal sealed class PrebuiltVoiceConfig
{
    [JsonPropertyName("voiceName")]
    public string? VoiceName { get; set; }
}

internal sealed class AudioTranscriptionConfig
{
    [JsonPropertyName("languageCodes")]
    public List<string>? LanguageCodes { get; set; }
}

internal sealed class RealtimeInputConfig
{
    [JsonPropertyName("automaticActivityDetection")]
    public AutomaticActivityDetection? AutomaticActivityDetection { get; set; }

    [JsonPropertyName("activityHandling")]
    public string? ActivityHandling { get; set; }
}

internal sealed class AutomaticActivityDetection
{
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

internal static class Modality
{
    public const string Audio = "AUDIO";
    public const string Text = "TEXT";
}

internal static class ActivityHandling
{
    public const string StartOfActivityInterrupts = "START_OF_ACTIVITY_INTERRUPTS";
    public const string NoInterruption = "NO_INTERRUPTION";
}

internal sealed class Tool
{
    [JsonPropertyName("functionDeclarations")]
    public IList<FunctionDeclaration>? FunctionDeclarations { get; set; }
}

internal sealed class FunctionDeclaration
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("parameters")]
    public Schema? Parameters { get; set; }
}

internal sealed class Schema
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("properties")]
    public Dictionary<string, Schema>? Properties { get; set; }

    [JsonPropertyName("required")]
    public IList<string>? Required { get; set; }

    [JsonPropertyName("items")]
    public Schema? Items { get; set; }
}

internal static class SchemaType
{
    public const string Object = "OBJECT";
    public const string String = "STRING";
    public const string Integer = "INTEGER";
    public const string Number = "NUMBER";
    public const string Boolean = "BOOLEAN";
    public const string Array = "ARRAY";
}

internal sealed class FunctionResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("response")]
    public Dictionary<string, object>? Response { get; set; }
}

internal sealed class LiveServerMessage
{
    [JsonPropertyName("setupComplete")]
    public object? SetupComplete { get; set; }

    [JsonPropertyName("serverContent")]
    public LiveServerContent? ServerContent { get; set; }

    [JsonPropertyName("toolCall")]
    public LiveServerToolCall? ToolCall { get; set; }

    [JsonPropertyName("toolCallCancellation")]
    public LiveServerToolCallCancellation? ToolCallCancellation { get; set; }

    [JsonPropertyName("usageMetadata")]
    public UsageMetadata? UsageMetadata { get; set; }

    [JsonPropertyName("goAway")]
    public LiveServerGoAway? GoAway { get; set; }
}

internal sealed class LiveServerContent
{
    [JsonPropertyName("modelTurn")]
    public Content? ModelTurn { get; set; }

    [JsonPropertyName("turnComplete")]
    public bool? TurnComplete { get; set; }

    [JsonPropertyName("generationComplete")]
    public bool? GenerationComplete { get; set; }

    [JsonPropertyName("inputTranscription")]
    public Transcription? InputTranscription { get; set; }

    [JsonPropertyName("outputTranscription")]
    public Transcription? OutputTranscription { get; set; }
}

internal sealed class Transcription
{
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

internal sealed class LiveServerToolCall
{
    [JsonPropertyName("functionCalls")]
    public IList<FunctionCall>? FunctionCalls { get; set; }
}

internal sealed class FunctionCall
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("args")]
    public Dictionary<string, object?>? Args { get; set; }
}

internal sealed class LiveServerToolCallCancellation
{
    [JsonPropertyName("ids")]
    public IList<string>? Ids { get; set; }
}

internal sealed class UsageMetadata
{
    [JsonPropertyName("promptTokenCount")]
    public long? PromptTokenCount { get; set; }

    [JsonPropertyName("responseTokenCount")]
    public long? ResponseTokenCount { get; set; }

    [JsonPropertyName("totalTokenCount")]
    public long? TotalTokenCount { get; set; }
}

internal sealed class LiveServerGoAway { }
