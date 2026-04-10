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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;

namespace Google.Cloud.VertexAI.Extensions.Live.Tests;

public class AotJsonContextTest
{
    private static readonly Assembly s_assembly = typeof(VertexAIExtensions).Assembly;

    [Fact]
    public void LiveJsonContext_CoversAllDirectlySerializedTypes()
    {
        JsonSerializerContext context = GetContext();
        System.Type[] requiredTypes =
        [
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveConnectConfig"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveClientMessage"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveClientSetup"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveSendRealtimeInputParameters"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveSendToolResponseParameters"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveServerMessage"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveServerContent"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveServerToolCall"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveServerToolCallCancellation"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Content"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Part"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Blob"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Tool"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.FunctionDeclaration"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.FunctionResponse"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.FunctionCall"),
            GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Schema"),
        ];

        List<string> missingTypes = requiredTypes
            .Where(type => context.GetTypeInfo(type) is null)
            .Select(type => type.FullName ?? type.Name)
            .ToList();

        Assert.True(
            missingTypes.Count == 0,
            "The following types are missing from LiveJsonContext and may fail under Native AOT: " +
            string.Join(", ", missingTypes));
    }

    [Fact]
    public void LiveJsonContext_RoundTripsLiveServerMessage()
    {
        JsonSerializerContext context = GetContext();
        System.Type liveServerMessageType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveServerMessage");
        System.Type liveServerContentType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveServerContent");
        System.Type contentType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Content");
        System.Type partType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.Part");

        object message = Activator.CreateInstance(liveServerMessageType)!;
        object serverContent = Activator.CreateInstance(liveServerContentType)!;
        object content = Activator.CreateInstance(contentType)!;
        object part = Activator.CreateInstance(partType)!;

        partType.GetProperty("Text")!.SetValue(part, "Hello from the model");

        IList parts = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(partType))!;
        parts.Add(part);

        contentType.GetProperty("Role")!.SetValue(content, "model");
        contentType.GetProperty("Parts")!.SetValue(content, parts);
        liveServerContentType.GetProperty("ModelTurn")!.SetValue(serverContent, content);
        liveServerMessageType.GetProperty("ServerContent")!.SetValue(message, serverContent);

        string json = JsonSerializer.Serialize(message, liveServerMessageType, context);
        object? roundTripped = JsonSerializer.Deserialize(json, liveServerMessageType, context);

        Assert.NotNull(roundTripped);

        object? roundTrippedServerContent = liveServerMessageType.GetProperty("ServerContent")!.GetValue(roundTripped);
        Assert.NotNull(roundTrippedServerContent);

        object? roundTrippedContent = liveServerContentType.GetProperty("ModelTurn")!.GetValue(roundTrippedServerContent);
        Assert.NotNull(roundTrippedContent);
        Assert.Equal("model", contentType.GetProperty("Role")!.GetValue(roundTrippedContent) as string);

        IList? roundTrippedParts = contentType.GetProperty("Parts")!.GetValue(roundTrippedContent) as IList;
        Assert.NotNull(roundTrippedParts);
        Assert.Single(roundTrippedParts!);
        Assert.Equal("Hello from the model", partType.GetProperty("Text")!.GetValue(roundTrippedParts[0]) as string);
    }

    [Fact]
    public void LiveJsonContext_RoundTripsToolResponseMessage()
    {
        JsonSerializerContext context = GetContext();
        System.Type liveClientMessageType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveClientMessage");
        System.Type liveClientToolResponseType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.LiveClientToolResponse");
        System.Type functionResponseType = GetRequiredType("Google.Cloud.VertexAI.Extensions.Live.FunctionResponse");

        object message = Activator.CreateInstance(liveClientMessageType)!;
        object toolResponse = Activator.CreateInstance(liveClientToolResponseType)!;
        object functionResponse = Activator.CreateInstance(functionResponseType)!;

        functionResponseType.GetProperty("Id")!.SetValue(functionResponse, "call-1");
        functionResponseType.GetProperty("Name")!.SetValue(functionResponse, "lookupWeather");
        functionResponseType.GetProperty("Response")!.SetValue(
            functionResponse,
            new Dictionary<string, object>
            {
                ["result"] = new List<object>
                {
                    "sunny",
                    72,
                    new Dictionary<string, object> { ["unit"] = "F" }
                }
            });

        IList responses = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(functionResponseType))!;
        responses.Add(functionResponse);

        liveClientToolResponseType.GetProperty("FunctionResponses")!.SetValue(toolResponse, responses);
        liveClientMessageType.GetProperty("ToolResponse")!.SetValue(message, toolResponse);

        string json = JsonSerializer.Serialize(message, liveClientMessageType, context);
        object? roundTripped = JsonSerializer.Deserialize(json, liveClientMessageType, context);

        Assert.NotNull(roundTripped);
        Assert.Contains("\"result\":[\"sunny\",72", json);
        Assert.Contains("\"unit\":\"F\"", json);
    }

    private static JsonSerializerContext GetContext() =>
        (JsonSerializerContext)GetRequiredType("Google.Cloud.VertexAI.Extensions.LiveJsonContext")
            .GetProperty("Default", BindingFlags.Public | BindingFlags.Static)!
            .GetValue(null)!;

    private static System.Type GetRequiredType(string fullName) => s_assembly.GetType(fullName, throwOnError: true)!;
}
