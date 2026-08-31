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
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class BuiltInMetricsTest
{
    public enum CredentialOption
    {
        Explicit,
        EmptyOptions,
        NullOptions
    }

    public enum FailureCase
    {
        NoDefaultCredential,
        NullDefaultCredential,
        CancelledBeforeDefaultCredential,
        CancelledAtGate,
        ReporterStartThrows
    }

    private static readonly BuiltInMetricsOptions s_defaultOptions =
        new() { GoogleCredential = GoogleCredential.FromAccessToken("default-token") };
    private static readonly BuiltInMetricsOptions s_otherOptions =
        new() { GoogleCredential = GoogleCredential.FromAccessToken("other-token") };
    private readonly List<RecordingHandler> _handlers = new();

    [Fact]
    public async Task EnableAsync_PublicOverload_ReturnsActiveHandle()
    {
        var handle = await BuiltInMetrics.EnableAsync(s_defaultOptions);
        Assert.NotSame(BuiltInMetrics.NoOpHandle, handle);
        Assert.Null(Record.Exception(handle.Dispose));
    }

    [Theory]
    [InlineData(CredentialOption.Explicit, CredentialOption.Explicit)]
    [InlineData(CredentialOption.NullOptions, CredentialOption.Explicit)]
    [InlineData(CredentialOption.EmptyOptions, CredentialOption.Explicit)]
    [InlineData(CredentialOption.Explicit, CredentialOption.NullOptions)]
    public async Task EnableAsync_SameCredential_SharesReporter(CredentialOption first, CredentialOption second)
    {
        static BuiltInMetricsOptions ToOptions(CredentialOption option) => option switch
        {
            CredentialOption.Explicit => s_defaultOptions,
            CredentialOption.EmptyOptions => new BuiltInMetricsOptions(),
            _ => null
        };

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
        int startCalls = 0;
        var inStartReporter = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        var releaseStartReporter = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);

        async Task<IDisposable> StartBlockingReporterAsync(GoogleCredential credential, CancellationToken token)
        {
            Interlocked.Increment(ref startCalls);
            inStartReporter.TrySetResult(true);
            await releaseStartReporter.Task;
            return await MetricReporter.StartAsync(
                credential, () => RecordingHandler.Create(_handlers), SystemClock.Instance, token);
        }

        var firstTask = BuiltInMetrics.EnableAsync(
            s_defaultOptions, GetDefaultCredentialAsync, StartBlockingReporterAsync, default);
        await TokenRefresherTest.AwaitWithTimeoutAsync(inStartReporter.Task);

        var secondOptions = sameCredential ? s_defaultOptions : s_otherOptions;
        var secondTask = BuiltInMetrics.EnableAsync(
            secondOptions, GetDefaultCredentialAsync, StartBlockingReporterAsync, default);
        Assert.False(secondTask.IsCompleted);

        releaseStartReporter.SetResult(true);
        var handles = await Task.WhenAll(firstTask, secondTask);
        try
        {
            Assert.Equal(1, Volatile.Read(ref startCalls));
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
    public async Task EnableAsync_ScopeRequiringCredential_SharesReporter()
    {
        var credential = MetricReporterTest.CreateComputeCredential(_ => MetricReporterTest.CreateTokenResponse());
        Assert.True(credential.IsCreateScopedRequired);
        var options = new BuiltInMetricsOptions { GoogleCredential = credential };

        using var handle1 = await EnableAsync(options);
        using var handle2 = await EnableAsync(options);

        Assert.All(new[] { handle1, handle2 }, h => Assert.NotSame(BuiltInMetrics.NoOpHandle, h));
        Assert.Single(_handlers);
    }

    [Theory]
    [InlineData(1, 0, false)]
    [InlineData(2, 0, false)]
    [InlineData(1, 1, true)]
    [InlineData(2, 2, true)]
    public async Task Dispose_ReferenceCountsActiveHandles(
        int firstDisposeCalls, int secondDisposeCalls, bool expectedDisposed)
    {
        using var handle1 = await EnableAsync(s_defaultOptions);
        using var handle2 = await EnableAsync(s_defaultOptions);

        for (int i = 0; i < firstDisposeCalls; i++)
        {
            handle1.Dispose();
        }
        for (int i = 0; i < secondDisposeCalls; i++)
        {
            handle2.Dispose();
        }

        Assert.Equal(expectedDisposed, Assert.Single(_handlers).Disposed);
    }

    [Fact]
    public async Task Dispose_ReporterDisposeThrows_DoesNotThrow()
    {
        var handle = await BuiltInMetrics.EnableAsync(
            s_defaultOptions,
            GetDefaultCredentialAsync,
            (_, _) => Task.FromResult<IDisposable>(new ThrowingDisposable()),
            default);

        Assert.Null(Record.Exception(handle.Dispose));
        using var nextHandle = await EnableAsync(s_otherOptions);
        Assert.NotSame(BuiltInMetrics.NoOpHandle, nextHandle);
    }

    [Fact]
    public async Task EnableAsync_DifferentCredential_ReturnsNoOpHandle()
    {
        using var handle1 = await EnableAsync(s_defaultOptions);
        using var handle2 = await EnableAsync(s_otherOptions);
        Assert.Same(BuiltInMetrics.NoOpHandle, handle2);
    }

    [Fact]
    public async Task Dispose_NoOpHandle_KeepsReporter()
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
    [InlineData(FailureCase.NullDefaultCredential)]
    [InlineData(FailureCase.CancelledBeforeDefaultCredential)]
    [InlineData(FailureCase.CancelledAtGate)]
    [InlineData(FailureCase.ReporterStartThrows)]
    public async Task EnableAsync_SetupFails_ReturnsNoOpHandle(FailureCase failure)
    {
        using var handle = await (failure switch
        {
            FailureCase.NoDefaultCredential =>
                EnableAsync(getDefault: _ => Task.FromException<GoogleCredential>(new InvalidOperationException("No ADC"))),
            FailureCase.NullDefaultCredential =>
                EnableAsync(getDefault: _ => Task.FromResult<GoogleCredential>(null)),
            FailureCase.CancelledBeforeDefaultCredential =>
                EnableAsync(token: new CancellationToken(true)),
            FailureCase.CancelledAtGate =>
                EnableAsync(s_defaultOptions, new CancellationToken(true)),
            _ => BuiltInMetrics.EnableAsync(
                s_defaultOptions,
                GetDefaultCredentialAsync,
                (_, _) => Task.FromException<IDisposable>(new InvalidOperationException("Setup failed")),
                default)
        });

        Assert.Same(BuiltInMetrics.NoOpHandle, handle);
        using var nextHandle = await EnableAsync(s_otherOptions);
        Assert.NotSame(BuiltInMetrics.NoOpHandle, nextHandle);
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

    private Task<IDisposable> EnableAsync(
        BuiltInMetricsOptions options = null,
        CancellationToken token = default,
        Func<CancellationToken, Task<GoogleCredential>> getDefault = null) =>
        BuiltInMetrics.EnableAsync(
            options,
            getDefault ?? GetDefaultCredentialAsync,
            (cred, ct) => MetricReporter.StartAsync(cred, () => RecordingHandler.Create(_handlers), SystemClock.Instance, ct),
            token);

    private static Task<GoogleCredential> GetDefaultCredentialAsync(CancellationToken token) =>
        token.IsCancellationRequested
            ? Task.FromCanceled<GoogleCredential>(token)
            : Task.FromResult(s_defaultOptions.GoogleCredential);

    private sealed class ThrowingDisposable : IDisposable
    {
        public void Dispose() => throw new InvalidOperationException("Dispose failed");
    }
}
