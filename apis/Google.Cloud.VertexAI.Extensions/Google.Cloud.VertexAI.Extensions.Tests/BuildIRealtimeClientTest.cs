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

using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.VertexAI.Extensions.Tests;

public class BuildIRealtimeClientTest
{
    [Fact]
    public void Build_ValidArguments_CreatesIRealtimeClientSuccessfully()
    {
        IRealtimeClient realtimeClient = CreateRealtimeClientBuilder().Build();
        Assert.NotNull(realtimeClient);
    }

    [Fact]
    public async Task BuildAsync_ValidArguments_CreatesIRealtimeClientSuccessfully()
    {
        IRealtimeClient realtimeClient = await CreateRealtimeClientBuilder().BuildAsync();
        Assert.NotNull(realtimeClient);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("projects/test-project/locations/us-central1/publishers/google/models/gemini-2.5-flash-live-preview")]
    public void IRealtimeClient_GetService_ReturnsExpectedInstance(string? defaultModelId)
    {
        var builder = CreateRealtimeClientBuilder();
        builder.DefaultModelId = defaultModelId;
        IRealtimeClient realtimeClient = builder.Build();
        Assert.NotNull(realtimeClient);

        Assert.Same(realtimeClient, realtimeClient.GetService(typeof(IRealtimeClient)));
        Assert.Same(realtimeClient, realtimeClient.GetService(typeof(IDisposable)));

        ChatClientMetadata? metadata = realtimeClient.GetService(typeof(ChatClientMetadata)) as ChatClientMetadata;
        Assert.NotNull(metadata);
        Assert.Equal("gcp.vertex_ai", metadata.ProviderName);
        Assert.Equal(new("https://aiplatform.googleapis.com:443"), metadata.ProviderUri);
        Assert.Equal(defaultModelId?.Substring(defaultModelId.LastIndexOf('/') + 1), metadata.DefaultModelId);
    }

    [Fact]
    public void IRealtimeClient_GetService_InvalidArguments_Throws()
    {
        IRealtimeClient realtimeClient = CreateRealtimeClientBuilder().Build();
        Assert.NotNull(realtimeClient);

        Assert.Throws<ArgumentNullException>("serviceType", () => realtimeClient.GetService(null!));
    }

    [Fact]
    public void IRealtimeClient_Dispose_Nop()
    {
        IRealtimeClient realtimeClient = CreateRealtimeClientBuilder().Build();
        Assert.NotNull(realtimeClient);

        realtimeClient.Dispose();

        // Client still functional after dispose (it's a no-op).
        Assert.NotNull(realtimeClient.GetService(typeof(ChatClientMetadata)));
    }

    [Fact]
    public async Task IRealtimeClient_CreateSessionAsync_NoModel_Throws()
    {
        IRealtimeClient realtimeClient = CreateRealtimeClientBuilder().Build();

        await Assert.ThrowsAsync<InvalidOperationException>(() => realtimeClient.CreateSessionAsync(new RealtimeSessionOptions()));
    }

    [Fact]
    public async Task BuildAsync_Cancelled_ReturnsCanceledTask()
    {
        using CancellationTokenSource cts = new();
        cts.Cancel();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(
            () => CreateRealtimeClientBuilder().BuildAsync(cts.Token));
    }

    [Fact]
    public void RealtimeSession_NormalizeToolPayload_ByteArray_EncodesAsBase64()
    {
        MethodInfo normalizeMethod = GetNormalizeToolPayloadMethod();
        byte[] payload = [1, 2, 3, 4];

        object? result = normalizeMethod.Invoke(null, [payload, 0]);

        Assert.Equal(Convert.ToBase64String(payload), result);
    }

    [Fact]
    public void RealtimeSession_NormalizeToolPayload_TooDeep_Throws()
    {
        MethodInfo normalizeMethod = GetNormalizeToolPayloadMethod();
        Dictionary<string, object?> payload = new();
        IDictionary<string, object?> current = payload;
        for (int i = 0; i < 80; i++)
        {
            Dictionary<string, object?> next = new();
            current[$"level{i}"] = next;
            current = next;
        }

        TargetInvocationException ex = Assert.Throws<TargetInvocationException>(() => normalizeMethod.Invoke(null, [payload, 0]));
        Assert.IsType<InvalidOperationException>(ex.InnerException);
    }

    [Fact]
    public void Validate_RejectsGrpcSpecificProperties()
    {
        var builder = CreateRealtimeClientBuilder();
        builder.ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure;
        Assert.Throws<InvalidOperationException>(() => builder.Build());
    }

    private static PredictionServiceRealtimeClientBuilder CreateRealtimeClientBuilder() =>
        new()
        {
            GoogleCredential = Google.Apis.Auth.OAuth2.GoogleCredential.FromAccessToken("fake-token"),
        };

    private static MethodInfo GetNormalizeToolPayloadMethod() =>
        typeof(VertexAIExtensions).Assembly
            .GetType("Google.Cloud.VertexAI.Extensions.PredictionServiceRealtimeSession", throwOnError: true)!
            .GetMethod("NormalizeToolPayload", BindingFlags.NonPublic | BindingFlags.Static)!;
}
