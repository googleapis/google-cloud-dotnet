// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Google.Api.Gax.Testing;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using NSubstitute;
using NSubstitute.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

public class ManagedSessionTests
{
    private static readonly DatabaseName SampleDatabaseName = new DatabaseName("project", "instance", "database");
    private static readonly TimeSpan SoftExpiry = TimeSpan.FromDays(7);
    private static readonly TimeSpan HardExpiry = TimeSpan.FromDays(27) + TimeSpan.FromHours(12);

    [Fact]
    public async Task GetFreshSession_InitialCreation()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        client.Configure()
            .CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1));

        await managedSession.EnsureFreshAsync(CancellationToken.None);

        await client.Received(1).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task GetFreshSession_NoExpiry()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);
        
        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        client.Configure()
            .CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1));

        await managedSession.EnsureFreshAsync(CancellationToken.None);
        
        // Advance clock a bit, but not enough for soft expiry
        clock.Advance(TimeSpan.FromDays(1));
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Still only 1 call to CreateSessionAsync
        await client.Received(1).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task GetFreshSession_SoftExpiry_BackgroundRefresh()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        var session2 = new Session { Name = "session2" }; // CreateTime will be set when it's created

        var createSessionCalledTsc = new TaskCompletionSource<bool>();
        var freshSessionTsc = new TaskCompletionSource<Session>();
        client.Configure()
            .CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1), freshSessionTsc.Task);
        client.Configure()
            .When(client => client.CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>()))
            .Do(Callback.First(_ => { }).Then(_ => createSessionCalledTsc.SetResult(true)));

        // This calls CreateSessionAsync for the first time and does not return until the session is acquired.
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Advance past soft expiry
        clock.Advance(SoftExpiry + TimeSpan.FromMinutes(1));
        session2.CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp();

        // This should trigger background refresh but return immediately because session1 is only soft expired.
        // The triggered background refresh will eventually call CreateSessionAsync for a second time.
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Allow CreateSessionAsync to return.
        freshSessionTsc.SetResult(session2);

        // And now we can wait for CreateSessionAsync to be done.
        await createSessionCalledTsc.Task;
        await client.Received(2).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task GetFreshSession_ConcurrentCalls_OnlyOneRefresh()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        var session2 = new Session { Name = "session2" };

        var freshSessionTsc = new TaskCompletionSource<Session>();
        client.Configure().CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1), freshSessionTsc.Task);

        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Advance past hard expiry
        clock.Advance(HardExpiry + TimeSpan.FromMinutes(1));

        // Start multiple concurrent calls
        var task1 = managedSession.EnsureFreshAsync(CancellationToken.None);
        var task2 = managedSession.EnsureFreshAsync(CancellationToken.None);
        var task3 = managedSession.EnsureFreshAsync(CancellationToken.None);

        Assert.False(task1.IsCompleted);
        Assert.False(task2.IsCompleted);
        Assert.False(task3.IsCompleted);

        freshSessionTsc.SetResult(session2);
        await Task.WhenAll(task1, task2, task3);

        // Only 2 calls total (1 initial, 1 refresh)
        await client.Received(2).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task GetFreshSession_SoftExpiry_RefreshFailure_Swallowed()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        var session2 = new Session { Name = "session2" };

        var throwingCreateSessionCalledTcs = new TaskCompletionSource<bool>();
        var throwingFreshSessionTcs = new TaskCompletionSource<Session>();
        var createSessionCalledTcs = new TaskCompletionSource<bool>();
        var freshSessionTcs = new TaskCompletionSource<Session>();
        client.Configure()
            .CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1), throwingFreshSessionTcs.Task, freshSessionTcs.Task);
        client.Configure()
            .When(client => client.CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>()))
            .Do(Callback.First(_ => { }).Then(_ => throwingCreateSessionCalledTcs.SetResult(true)).Then(_ => createSessionCalledTcs.SetResult(true)));

        // This calls CreateSessionAsync for the first time and does not return until the session is acquired.
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Advance past soft expiry
        clock.Advance(SoftExpiry + TimeSpan.FromMinutes(1));
        session2.CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp();

        // This should trigger background refresh but return immediately because session1 is only soft expired.
        // The triggered background refresh will eventually call CreateSessionAsync for a second time, which fails.
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Allow CreateSessionAsync to fail.
        throwingFreshSessionTcs.SetException(new Exception("Soft failure"));

        // And now we can wait for CreateSessionAsync to be called.
        // It has failed but that failure is not bubbled up because the session was only soft expired.
        await throwingCreateSessionCalledTcs.Task;
        await client.Received(2).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());

        // Wait a little in real time to allow the failed background refresh to complete.
        // There's a little bit of work that's done in the backgroun refresh after CreateSessionAsync has returned,
        // but we don't have a way to wait on that.
        // Note: Adust this number up if this is flaky.
        await Task.Delay(500);

        // This should still return immediately and without throwing because session1 is only soft expired.
        // Because the previous background refresh failed, this call will trigger a new background refresh.
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Allow CreateSessionAsync to return
        freshSessionTcs.SetResult(session2);

        // And now we can wait for CreateSessionAsync to be called for the third time.
        await createSessionCalledTcs.Task;
        await client.Received(3).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task GetFreshSession_HardExpiry_BlockingRefresh()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        var session2 = new Session { Name = "session2" };

        var freshSessionTsc = new TaskCompletionSource<Session>();
        client.Configure().CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1), freshSessionTsc.Task);

        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Advance past hard expiry
        clock.Advance(HardExpiry + TimeSpan.FromMinutes(1));
        session2.CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp();

        // This should block
        var refreshTask = managedSession.EnsureFreshAsync(CancellationToken.None);
        Assert.False(refreshTask.IsCompleted);

        freshSessionTsc.SetResult(session2);
        await refreshTask;

        await client.Received(2).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());
    }

    [Fact]
    public async Task GetFreshSession_HardExpiry_RefreshFailure_Propagated()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };

        client.Configure().CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1), Task.FromException<Session>(new Exception("Hard failure")));

        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Advance past hard expiry
        clock.Advance(HardExpiry + TimeSpan.FromMinutes(1));

        // Should throw
        var ex = await Assert.ThrowsAsync<Exception>(() => managedSession.EnsureFreshAsync(CancellationToken.None));
        Assert.Equal("Hard failure", ex.Message);
    }

    [Fact]
    public async Task BeginTransactionAsync_ConcurrentCalls()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        var session2 = new Session { Name = "session2" };

        var tcs = new TaskCompletionSource<Session>();
        client.Configure().CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1), tcs.Task);

        // Initial creation
        await managedSession.EnsureFreshAsync(CancellationToken.None);

        // Advance past hard expiry
        clock.Advance(HardExpiry + TimeSpan.FromMinutes(1));

        // Start multiple concurrent calls to BeginTransactionAsync
        var task1 = managedSession.BeginTransactionAsync(new TransactionOptions(), false, false, CancellationToken.None);
        var task2 = managedSession.BeginTransactionAsync(new TransactionOptions(), false, false, CancellationToken.None);
        var task3 = managedSession.BeginTransactionAsync(new TransactionOptions(), false, false, CancellationToken.None);

        Assert.False(task1.IsCompleted);
        Assert.False(task2.IsCompleted);
        Assert.False(task3.IsCompleted);

        tcs.SetResult(session2);
        var transactions = await Task.WhenAll(task1, task2, task3);

        // Only 2 calls total (1 initial, 1 refresh)
        await client.Received(2).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());

        // Verify all transactions use the new session
        foreach (var transaction in transactions)
        {
            Assert.Equal(session2.SessionName, transaction.SessionName);
        }
    }

    [Fact]
    public async Task BatchWriteAsync_EnsureFreshnessAndSetsSession()
    {
        var clock = new FakeClock(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc));
        var client = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger, clock);

        var options = ManagedSessionOptions.Create(SampleDatabaseName, client);
        var managedSession = new ManagedSession(options);

        var session1 = new Session { Name = "session1", CreateTime = clock.GetCurrentDateTimeUtc().ToTimestamp() };
        client.Configure().CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>())
            .Returns(Task.FromResult(session1));

        // Mock BatchWrite
        var batchWriteStream = Substitute.For<SpannerClient.BatchWriteStream>();
        client.BatchWrite(Arg.Any<BatchWriteRequest>(), Arg.Any<CallSettings>())
            .Returns(batchWriteStream);

        // Execute BatchWriteAsync
        var request = new BatchWriteRequest();
        await managedSession.BatchWriteAsync(request, null);

        // Verify session was created
        await client.Received(1).CreateSessionAsync(Arg.Any<CreateSessionRequest>(), Arg.Any<CallSettings>());

        // Verify BatchWrite was called with the correct session
        client.Received(1).BatchWrite(Arg.Is<BatchWriteRequest>(r => r.Session == session1.Name), Arg.Any<CallSettings>());
    }
}
