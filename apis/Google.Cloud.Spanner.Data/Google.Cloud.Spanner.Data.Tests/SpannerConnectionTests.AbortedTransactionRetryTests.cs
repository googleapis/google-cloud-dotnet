// Copyright 2019 Google LLC
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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public partial class SpannerConnectionTests
    {
        public sealed class TransactionAbortedRetryTests
        {
            // Combining backoff and jittering for retries
            // when the RpcException doesn't specify a wait time.
            // InitialDelay = 250ms, BackoffMultiplier = 2, JitterMultiplier = 2
            // Those are all hard-coded, client code can't change them.
            private const int InitialDelayBackoffMs = 250;
            private const int BackoffMultiplier = 2;
            private const int JitterMultiplier = 2;

            private const int ExceptionRetryDelayMs = 300;
            // We respect the retry from the Exception
            private const int ExceptionBackoffMultiplier = 1;

            [Fact]
            public async Task FirstCallSucceeds()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteBatchDmlAsync()
                    .SetupCommitAsync();
                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler);

                await scheduler.RunAsync(async () =>
                {
                    var result = await connection.RunWithRetriableTransactionAsync(transaction => callee.DatabaseWorkAsync(connection, transaction));
                    Assert.Equal(1, result);
                });

                callee.AssertBackoffTimesInRange(time0);
                callee.AssertLastCallTime(scheduler.Clock.GetCurrentDateTimeUtc());
            }

            [Fact]
            public async Task CommitAbortsTwice()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteBatchDmlAsync()
                    .SetupCommitAsync_Fails(failures: 2, statusCode: StatusCode.Aborted)
                    .SetupRollbackAsync();

                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler);

                await scheduler.RunAsync(async () =>
                {
                    var result = await connection.RunWithRetriableTransactionAsync(transaction => callee.DatabaseWorkAsync(connection, transaction));
                    Assert.Equal(3, result);
                });

                callee.AssertBackoffTimesInRange(time0);
                callee.AssertLastCallTime(scheduler.Clock.GetCurrentDateTimeUtc());
            }

            // The transaction can be aborted on commit or on any of the operations.
            [Fact]
            public async Task BatchDmlAbortsTwice()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync()
                    .SetupBeginTransactionAsync()
                    // With transaction inlining we need batch DML to fail 4 times to get the retriable transaction
                    // to abort twice. That is because on each run of the retriable transaction the batch DML command
                    // is executed twice, once with inline transaction, and since that fails, with an explicit transaction.
                    // So the fifth time it will succeed with an inlined transaction, which matches the third retriable transaction
                    // attempt.
                    .SetupExecuteBatchDmlAsync_Fails(failures: 4, statusCode: StatusCode.Aborted)
                    .SetupCommitAsync()
                    .SetupRollbackAsync();

                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler);

                await scheduler.RunAsync(async () =>
                {
                    var result = await connection.RunWithRetriableTransactionAsync(transaction => callee.DatabaseWorkAsync(connection, transaction));
                    Assert.Equal(3, result);
                });

                callee.AssertBackoffTimesInRange(time0);
                callee.AssertLastCallTime(scheduler.Clock.GetCurrentDateTimeUtc());
            }

            [Fact]
            public async Task CommitAbortsTwice_RecommendedDelay()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteBatchDmlAsync()
                    .SetupCommitAsync_Fails(failures: 2, statusCode: StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(ExceptionRetryDelayMs))
                    .SetupRollbackAsync();

                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler, initialDelayMs: ExceptionRetryDelayMs, backoffMultiplier: ExceptionBackoffMultiplier);

                await scheduler.RunAsync(async () =>
                {
                    var result = await connection.RunWithRetriableTransactionAsync(transaction => callee.DatabaseWorkAsync(connection, transaction));
                    Assert.Equal(3, result);
                });

                callee.AssertBackoffTimesInRange(time0);
                callee.AssertLastCallTime(scheduler.Clock.GetCurrentDateTimeUtc());
            }

            [Fact]
            public async Task CommitAbortsAlways_RespectsOverallDeadline()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteBatchDmlAsync()
                    .SetupCommitAsync_FailsAlways(statusCode: StatusCode.Aborted)
                    .SetupRollbackAsync();

                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                // This test needs a little bit more of real time, else it's flaky.
                scheduler.RealTimeTimeout = TimeSpan.FromSeconds(60);
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler);

                await scheduler.RunAsync(async () =>
                {
                    var exception = await Assert.ThrowsAsync<SpannerException>(() => connection.RunWithRetriableTransactionAsync(transaction => callee.DatabaseWorkAsync(connection, transaction)));
                    Assert.True(exception.IsRetryable && !exception.SessionExpired);
                    Assert.Contains("Bang!", exception.InnerException.Message);
                });

                // The minimum calls that can be made (assuming maximum jitter always) in that time is 60 * 60 / 32 * 2 which is 56.25,
                // plus 1 because the first one has no delay.
                // The maximum number of calls that can be made in 1 hour:
                // - Given that 2^7 * 250 = 32000, the first 8 calls take, at a minimum 31_750ms, approx 32s.
                // - The rest will happen at most (60 * 60 - 32) / 32 which is 111.5
                callee.AssertCalledInRange(57, 120);
                // The overall deadline is of 1 hour. The maximum backoff delay is of 32s.
                // Because of jitter retries can stop at any time after 60mins - 64s, let's give it 2 minutes of range.
                Assert.InRange(scheduler.Clock.GetCurrentDateTimeUtc(), time0.AddMinutes(58), time0.AddMinutes(60));
            }

            [Fact]
            public async Task CommitFailsOtherThanAborted()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync()
                    .SetupExecuteBatchDmlAsync()
                    .SetupCommitAsync_Fails(failures: 1, StatusCode.Unknown)
                    .SetupRollbackAsync();

                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler);

                await scheduler.RunAsync(async () =>
                {
                    var exception = await Assert.ThrowsAsync<SpannerException>(
                        () => connection.RunWithRetriableTransactionAsync(
                            transaction => callee.DatabaseWorkAsync(connection, transaction)));
                    Assert.Contains("Bang!", exception.InnerException.Message);
                });

                callee.AssertBackoffTimesInRange(time0);
                callee.AssertLastCallTime(scheduler.Clock.GetCurrentDateTimeUtc());
            }

            [Fact]
            public async Task WorkFails()
            {
                SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger)
                    .SetupBatchCreateSessionsAsync();

                SpannerConnection connection = BuildSpannerConnection(spannerClientMock);

                var scheduler = (FakeScheduler)connection.Builder.SessionPoolManager.SpannerSettings.Scheduler;
                var time0 = scheduler.Clock.GetCurrentDateTimeUtc();
                var callee = new Callee(scheduler);

                await scheduler.RunAsync(async () =>
                {
                    var exception = await Assert.ThrowsAsync<InvalidOperationException>(() => connection.RunWithRetriableTransactionAsync(callee.Fails));
                    Assert.Contains("Bang!", exception.Message);
                });

                callee.AssertBackoffTimesInRange(time0);
                callee.AssertLastCallTime(scheduler.Clock.GetCurrentDateTimeUtc());
            }

            private SpannerConnection BuildSpannerConnection(SpannerClient spannerClient)
            {
                var sessionPoolOptions = new SessionPoolOptions
                {
                    MaintenanceLoopDelay = TimeSpan.Zero
                };

                var sessionPoolManager = new SessionPoolManager(sessionPoolOptions, spannerClient.Settings, spannerClient.Settings.Logger, (_o, _s) => Task.FromResult(spannerClient));
                sessionPoolManager.SpannerSettings.Scheduler = spannerClient.Settings.Scheduler;
                sessionPoolManager.SpannerSettings.Clock = spannerClient.Settings.Clock;

                SpannerConnectionStringBuilder builder = new SpannerConnectionStringBuilder
                {
                    DataSource = DatabaseName.Format(SpannerClientHelpers.ProjectId, SpannerClientHelpers.Instance, SpannerClientHelpers.Database),
                    SessionPoolManager = sessionPoolManager
                };

                return new SpannerConnection(builder);
            }

            private class Callee
            {
                private readonly FakeScheduler _scheduler;
                private readonly IList<DateTime> _callTimes = new List<DateTime>();
                // For checking call times.
                private readonly long _initialDelayTicks;
                private readonly int _backoffMultiplier;
                private readonly int _jitterMultiplier;

                public Callee(FakeScheduler scheduler, int initialDelayMs = InitialDelayBackoffMs, int backoffMultiplier = BackoffMultiplier, int jitterMultiplier = JitterMultiplier)
                {
                    _scheduler = scheduler;
                    _initialDelayTicks = initialDelayMs * TimeSpan.TicksPerMillisecond;
                    _backoffMultiplier = backoffMultiplier;
                    _jitterMultiplier = jitterMultiplier;
                }

                public async Task<int> DatabaseWorkAsync(SpannerConnection connection, SpannerTransaction transaction)
                {
                    _callTimes.Add(_scheduler.Clock.GetCurrentDateTimeUtc());

                    var insert = connection.CreateInsertCommand("table_1",
                        new SpannerParameterCollection
                        {
                        new SpannerParameter("column_1", SpannerDbType.Int64, 10)
                        });
                    insert.Transaction = transaction;

                    var dml = transaction.CreateBatchDmlCommand();
                    dml.Add("UPDATE table_1 SET column_1 = column1 + 5");

                    await insert.ExecuteNonQueryAsync();
                    await dml.ExecuteNonQueryAsync();

                    return _callTimes.Count;
                }

                public Task<int> Fails(SpannerTransaction transaction)
                {
                    _callTimes.Add(_scheduler.Clock.GetCurrentDateTimeUtc());
                    throw new InvalidOperationException("Bang!");
                }

                public void AssertBackoffTimesInRange(DateTime time0)
                {
                    Assert.Equal(time0, _callTimes[0]);
                    long lastCallTicks = time0.Ticks;
                    for (int i = 1; i < _callTimes.Count; i++)
                    {
                        var minDelayTicks = (long)Math.Pow(_backoffMultiplier, i - 1) * _initialDelayTicks;
                        var maxDelayTicks = minDelayTicks * _jitterMultiplier;

                        Assert.InRange(_callTimes[i].Ticks, lastCallTicks + minDelayTicks, lastCallTicks + maxDelayTicks);
                        lastCallTicks = _callTimes[i].Ticks;
                    }
                }

                public void AssertLastCallTime(DateTime time) => Assert.Equal(time, _callTimes.Last());

                public void AssertCalledInRange(int min, int max) => Assert.InRange(_callTimes.Count, min, max);
            }
        }
    }
}
