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

using Google.Cloud.VertexAI.Extensions.Live;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Google.Cloud.VertexAI.Extensions;

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(LiveConnectConfig))]
[JsonSerializable(typeof(LiveClientMessage))]
[JsonSerializable(typeof(LiveClientSetup))]
[JsonSerializable(typeof(LiveClientContent))]
[JsonSerializable(typeof(LiveSendRealtimeInputParameters))]
[JsonSerializable(typeof(LiveSendToolResponseParameters))]
[JsonSerializable(typeof(LiveClientToolResponse))]
[JsonSerializable(typeof(LiveServerMessage))]
[JsonSerializable(typeof(LiveServerContent))]
[JsonSerializable(typeof(LiveServerToolCall))]
[JsonSerializable(typeof(LiveServerToolCallCancellation))]
[JsonSerializable(typeof(LiveServerGoAway))]
[JsonSerializable(typeof(UsageMetadata))]
[JsonSerializable(typeof(Content))]
[JsonSerializable(typeof(Part))]
[JsonSerializable(typeof(Blob))]
[JsonSerializable(typeof(GenerationConfig))]
[JsonSerializable(typeof(SpeechConfig))]
[JsonSerializable(typeof(VoiceConfig))]
[JsonSerializable(typeof(PrebuiltVoiceConfig))]
[JsonSerializable(typeof(AudioTranscriptionConfig))]
[JsonSerializable(typeof(RealtimeInputConfig))]
[JsonSerializable(typeof(AutomaticActivityDetection))]
[JsonSerializable(typeof(Tool))]
[JsonSerializable(typeof(FunctionDeclaration))]
[JsonSerializable(typeof(Schema))]
[JsonSerializable(typeof(FunctionResponse))]
[JsonSerializable(typeof(FunctionCall))]
[JsonSerializable(typeof(Transcription))]
[JsonSerializable(typeof(ActivityStart))]
[JsonSerializable(typeof(ActivityEnd))]
[JsonSerializable(typeof(List<Content>))]
[JsonSerializable(typeof(List<Part>))]
[JsonSerializable(typeof(List<Tool>))]
[JsonSerializable(typeof(List<FunctionResponse>))]
[JsonSerializable(typeof(List<FunctionCall>))]
[JsonSerializable(typeof(List<FunctionDeclaration>))]
[JsonSerializable(typeof(List<object>))]
[JsonSerializable(typeof(List<string>))]
[JsonSerializable(typeof(Dictionary<string, string>))]
[JsonSerializable(typeof(Dictionary<string, Schema>))]
[JsonSerializable(typeof(Dictionary<string, object>))]
[JsonSerializable(typeof(Dictionary<string, object?>))]
[JsonSerializable(typeof(JsonElement))]
[JsonSerializable(typeof(object))]
internal sealed partial class LiveJsonContext : JsonSerializerContext
{
}
