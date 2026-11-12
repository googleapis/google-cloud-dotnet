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

using Google.Api.Gax.Testing;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(PipelineCollection.Name)]
public class BuiltInMetricsTest
{
    public enum CredentialOption { Explicit, EmptyOptions, NullOptions }
    public enum FailureCase { NoDefaultCredential, CancelledBeforeDefaultCredential, CancelledAtGate, HandlerFactoryThrows }

    private static readonly BuiltInMetricsOptions s_defaultOptions = new() { GoogleCredential = GoogleCredential.FromAccessToken("default-token") };
    private static readonly BuiltInMetricsOptions s_otherOptions = new() { GoogleCredential = GoogleCredential.FromAccessToken("other-token") };
    private readonly FakeClock _clock = new();
    private readonly List<RecordingHandler> _handlers = new();

    [Theory]
    [InlineData(CredentialOption.Explicit, CredentialOption.Explicit)]
    [InlineData(CredentialOption.NullOptions, CredentialOption.Explicit)]
    [InlineData(CredentialOption.EmptyOptions, CredentialOption.Explicit)]
    [InlineData(CredentialOption.Explicit, CredentialOption.NullOptions)]
    public async Task EnableAsync_SameCredential_SharesPipeline(CredentialOption first, CredentialOption second)
    {
        static BuiltInMetricsOptions ToOptions(CredentialOption o) => o == CredentialOption.Explicit ? s_defaultOptions : o == CredentialOption.EmptyOptions ? new BuiltInMetricsOptions() : null;
        using var handle1 = await EnableAsync(ToOptions(first));
        using var handle2 = await EnableAsync(ToOptions(second));
        Assert.All(new[] { handle1, handle2 }, h => Assert.NotSame(BuiltInMetrics.NoOpHandle, h));
        Assert.Single(_handlers);
    }

    [Theory]
    [InlineData(true, 2)]
    [InlineData(false, 1)]
    public async Task EnableAsync_ConcurrentCalls_SerializesSetup(bool sameCredential, int expectedActiveHandles)
    {
        int callIndex = 0;
        using var ready = new CountdownEvent(2);
        var release = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        Task<IDisposable> StartCall() => Task.Run(() => EnableAsync(getDefault: async _ =>
        {
            ready.Signal();
            await release.Task;
            return (Interlocked.Increment(ref callIndex) == 1 || sameCredential ? s_defaultOptions : s_otherOptions).GoogleCredential;
        }));
        var handlesTask = Task.WhenAll(StartCall(), StartCall());
        Assert.True(ready.Wait(TimeSpan.FromSeconds(5)));
        release.SetResult(true);
        var handles = await handlesTask;
        try
        {
            Assert.Single(_handlers);
            Assert.Equal(expectedActiveHandles, handles.Count(h => !ReferenceEquals(h, BuiltInMetrics.NoOpHandle)));
        }
        finally
        {
            Array.ForEach(handles, h => h.Dispose());
        }
        Assert.True(Assert.Single(_handlers).Disposed);
    }

    [Fact]
    public async Task EnableAsync_ScopeRequiringCredential_AppliesScopeAndMatchesUnscopedCredential()
    {
        Uri tokenUri = null;
        var factory = new FakeHttpClientFactory(request =>
        {
            tokenUri = request.RequestUri;
            return new HttpResponseMessage { Content = new StringContent("{\"access_token\":\"scoped-token\",\"expires_in\":3600,\"token_type\":\"Bearer\"}") };
        });
        var credential = GoogleCredential.FromComputeCredential(
            new ComputeCredential(new ComputeCredential.Initializer("http://metadata.example/token") { HttpClientFactory = factory }));
        Assert.True(credential.IsCreateScopedRequired);
        var options = new BuiltInMetricsOptions { GoogleCredential = credential };
        using var handle1 = await EnableAsync(options);
        using var handle2 = await EnableAsync(options);
        using var meter = new Meter(ServiceMetricsConfiguration.Spanner.SourceMeterName);
        Assert.All(new[] { handle1, handle2 }, h => Assert.NotSame(BuiltInMetrics.NoOpHandle, h));
        Assert.Single(_handlers);
        meter.CreateCounter<long>("attempt_count").Add(1, MetricForwarderTest.CreateLabels());
        Array.ForEach(new[] { handle1, handle2 }, h => h.Dispose());
        Assert.Equal("?scopes=https://www.googleapis.com/auth/monitoring.write", tokenUri?.Query);
        Assert.Equal("Bearer scoped-token", Assert.Single(_handlers).GetLastHeader("Authorization"));
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    public async Task Dispose_StopsPipelineOnlyAfterLastHandle(int disposedCount, bool expectedDisposed)
    {
        using var handle1 = await EnableAsync(s_defaultOptions);
        using var handle2 = await EnableAsync(s_defaultOptions);
        Array.ForEach(new[] { handle1, handle2 }.Take(disposedCount).ToArray(), h => h.Dispose());
        Assert.Equal(expectedDisposed, Assert.Single(_handlers).Disposed);
    }

    [Fact]
    public async Task Dispose_Twice_CountsOnce()
    {
        using var handle1 = await EnableAsync(s_defaultOptions);
        using var handle2 = await EnableAsync(s_defaultOptions);
        handle2.Dispose();
        handle2.Dispose();
        Assert.False(Assert.Single(_handlers).Disposed);
    }

    [Fact]
    public async Task EnableAsync_DifferentCredential_ReturnsNoOpHandle()
    {
        using var handle1 = await EnableAsync(s_defaultOptions);
        using var handle2 = await EnableAsync(s_otherOptions);
        Assert.Same(BuiltInMetrics.NoOpHandle, handle2);
    }

    [Fact]
    public async Task Dispose_NoOpHandle_KeepsPipeline()
    {
        using var handle1 = await EnableAsync(s_defaultOptions);
        (await EnableAsync(s_otherOptions)).Dispose();
        Assert.False(Assert.Single(_handlers).Disposed);
    }

    [Fact]
    public async Task EnableAsync_AfterLastDispose_AcceptsDifferentCredential()
    {
        (await EnableAsync(s_defaultOptions)).Dispose();
        using var handle = await EnableAsync(s_otherOptions);
        Assert.NotSame(BuiltInMetrics.NoOpHandle, handle);
    }

    [Theory]
    [InlineData(FailureCase.NoDefaultCredential)]
    [InlineData(FailureCase.CancelledBeforeDefaultCredential)]
    [InlineData(FailureCase.CancelledAtGate)]
    [InlineData(FailureCase.HandlerFactoryThrows)]
    public async Task EnableAsync_SetupFails_ReturnsNoOpHandle(FailureCase failure)
    {
        using var handle = await (failure switch
        {
            FailureCase.NoDefaultCredential => EnableAsync(getDefault: _ => Task.FromException<GoogleCredential>(new InvalidOperationException("No ADC"))),
            FailureCase.CancelledBeforeDefaultCredential => EnableAsync(token: new CancellationToken(true)),
            FailureCase.CancelledAtGate => EnableAsync(s_defaultOptions, new CancellationToken(true)),
            _ => BuiltInMetrics.EnableAsync(s_defaultOptions, GetDefaultCredentialAsync, () => throw new InvalidOperationException("Setup failed"), _clock, default)
        });
        Assert.Same(BuiltInMetrics.NoOpHandle, handle);
    }

    [Theory]
    [InlineData("OTEL_SDK_DISABLED", "true", true)]
    [InlineData("OTEL_SDK_DISABLED", "TRUE", true)]
    [InlineData("OTEL_SDK_DISABLED", "false", false)]
    [InlineData("OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY", "bogus", true)]
    public async Task EnableAsync_EnvironmentVariables(string name, string value, bool expectNoOp)
    {
        using var env = new TemporaryEnvironmentVariable(name, value);
        using var handle = await EnableAsync(s_defaultOptions);
        Assert.Equal(expectNoOp, ReferenceEquals(BuiltInMetrics.NoOpHandle, handle));
        handle.Dispose();
        Assert.All(_handlers, handler => Assert.True(handler.Disposed));
    }

    private Task<IDisposable> EnableAsync(BuiltInMetricsOptions options = null, CancellationToken token = default,
        Func<CancellationToken, Task<GoogleCredential>> getDefault = null) =>
        BuiltInMetrics.EnableAsync(options, getDefault ?? GetDefaultCredentialAsync, CreateHandler, _clock, token);

    private static Task<GoogleCredential> GetDefaultCredentialAsync(CancellationToken token) =>
        token.IsCancellationRequested ? Task.FromCanceled<GoogleCredential>(token) : Task.FromResult(s_defaultOptions.GoogleCredential);

    private HttpMessageHandler CreateHandler()
    {
        var handler = new RecordingHandler();
        _handlers.Add(handler);
        return handler;
    }
}
