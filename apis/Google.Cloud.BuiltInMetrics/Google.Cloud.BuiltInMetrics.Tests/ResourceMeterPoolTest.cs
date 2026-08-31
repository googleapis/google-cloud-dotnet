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
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class ResourceMeterPoolTest : IDisposable
{
    private static readonly ServiceMetricsConfiguration s_otherService = new(
        "Other.Meter", "other.googleapis.com/client/", "other_resource",
        ["project_id", "instance_id", "location", "instance_config", "client_hash"],
        [0.0, 1.0], new Dictionary<string, string>());

    private readonly FakeClock _clock = new();
    private readonly RecordingHandler _handler = new();
    private readonly Meter _sourceMeter = new(ServiceMetricsConfiguration.Spanner.SourceMeterName);
    private readonly Counter<long> _counter;

    public ResourceMeterPoolTest() => _counter = _sourceMeter.CreateCounter<long>("attempt_count");

    public void Dispose()
    {
        _sourceMeter.Dispose();
        _handler.Dispose();
    }

    [Theory]
    [InlineData("project", "instance", "project", "instance", false, false, 1)]
    [InlineData("project", "instance", "project", "instance", true, false, 1)]
    [InlineData("project", "instance", "project", "other-instance", false, false, 2)]
    [InlineData("a|b", "c", "a", "b|c", false, false, 2)]
    [InlineData("project", "instance", "project", "instance", false, true, 2)]
    public void Record_UsesOneMeterPerDistinctResource(
        string firstProject, string firstInstance, string secondProject, string secondInstance,
        bool reverseSecond, bool differentService, int expectedCount)
    {
        using var pool = CreatePool();
        var secondLabels = MetricForwarderTest.CreateLabels(secondInstance, secondProject);
        if (reverseSecond)
        {
            secondLabels = Enumerable.Reverse(secondLabels).ToArray();
        }
        pool.Record(ServiceMetricsConfiguration.Spanner, _counter, 1L, MetricForwarderTest.CreateLabels(firstInstance, firstProject));
        pool.Record(differentService ? s_otherService : ServiceMetricsConfiguration.Spanner, _counter, 1L, secondLabels);
        Assert.Equal(expectedCount, pool.Count);
    }

    [Theory]
    [InlineData(-1L, 1)]
    [InlineData(0L, 0)]
    public void EvictIdleEntries_RespectsExactTickBoundary(long ticksAfterIdleTimeout, int expectedCount)
    {
        using var pool = CreatePool();
        RecordPoint(pool);
        _clock.Advance(ResourceMeterPool.IdleTimeout + TimeSpan.FromTicks(ticksAfterIdleTimeout));
        pool.EvictIdleEntries();
        Assert.Equal(expectedCount, pool.Count);
    }

    [Fact]
    public void EvictIdleEntries_EvictsOnlyIdleEntries()
    {
        using var listener = new PooledMeterListener();
        using var pool = CreatePool();
        RecordPoint(pool, "idle-instance");
        RecordPoint(pool, "active-instance");
        string activeMeterName = listener.Measurements.Last().MeterName;

        _clock.Advance(ResourceMeterPool.IdleTimeout - TimeSpan.FromTicks(1));
        RecordPoint(pool, "active-instance");

        _clock.Advance(TimeSpan.FromTicks(1));
        pool.EvictIdleEntries();

        Assert.Equal(1, pool.Count);
        RecordPoint(pool, "active-instance");
        Assert.Equal(activeMeterName, listener.Measurements.Last().MeterName);
    }

    [Fact]
    public void EvictIdleEntries_SkipsFinalExport()
    {
        using var pool = CreatePool();
        RecordPoint(pool);
        _clock.Advance(ResourceMeterPool.IdleTimeout);
        pool.EvictIdleEntries();
        Assert.Equal(0, _handler.RequestCount);
    }

    [Fact]
    public void EvictIdleEntries_DisposesInlineOnCallerThread()
    {
        using var listener = new PooledMeterListener();
        using var pool = CreatePool();
        RecordPoint(pool);
        _clock.Advance(ResourceMeterPool.IdleTimeout);
        pool.EvictIdleEntries();
        Assert.Equal(Environment.CurrentManagedThreadId, Assert.Single(listener.DisposeThreads).ThreadId);
    }

    [Fact]
    public void Record_AfterEviction_CreatesNewPooledMeter()
    {
        using var listener = new PooledMeterListener();
        using var pool = CreatePool();
        RecordPoint(pool);
        _clock.Advance(ResourceMeterPool.IdleTimeout);
        pool.EvictIdleEntries();
        RecordPoint(pool);
        Assert.Equal(2, listener.Measurements.Select(m => m.MeterName).Distinct().Count());
    }

    [Fact]
    public async Task Record_DuringEviction_IsNotLost()
    {
        const int recordIterations = 200;
        const int evictIterations = 50;
        using var listener = new PooledMeterListener();
        using var pool = CreatePool();
        using var startBarrier = new CountdownEvent(2);
        var labels = MetricForwarderTest.CreateLabels();

        var evictTask = Task.Run(() =>
        {
            startBarrier.Signal();
            Assert.True(startBarrier.Wait(TimeSpan.FromSeconds(5)));
            for (int i = 0; i < evictIterations; i++)
            {
                _clock.Advance(ResourceMeterPool.IdleTimeout);
                pool.EvictIdleEntries();
            }
        });

        startBarrier.Signal();
        Assert.True(startBarrier.Wait(TimeSpan.FromSeconds(5)));
        for (int i = 0; i < recordIterations; i++)
        {
            pool.Record(ServiceMetricsConfiguration.Spanner, _counter, 1L, labels);
        }

        await evictTask;
        Assert.Equal(recordIterations, listener.Measurements.Count);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Dispose_ExportsRecordedDataOnce(int disposeCalls)
    {
        var pool = CreatePool();
        RecordPoint(pool);
        for (int i = 0; i < disposeCalls; i++)
        {
            Assert.Null(Record.Exception(pool.Dispose));
        }
        Assert.Equal(1, _handler.RequestCount);
        Assert.False(_handler.Disposed);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(25)]
    public void Dispose_FlushesEntriesOffThreadPool(int resourceCount)
    {
        using var listener = new PooledMeterListener();
        var pool = CreatePool();
        int callerThreadId = Environment.CurrentManagedThreadId;
        for (int i = 0; i < resourceCount; i++)
        {
            RecordPoint(pool, $"instance-{i}");
        }

        pool.Dispose();

        Assert.Equal(resourceCount, _handler.RequestCount);
        Assert.Equal(resourceCount, listener.DisposeThreads.Count);
        Assert.All(listener.DisposeThreads, d =>
        {
            Assert.NotEqual(callerThreadId, d.ThreadId);
            Assert.False(d.IsThreadPoolThread);
        });
        Assert.InRange(listener.DisposeThreads.Select(d => d.ThreadId).Distinct().Count(), 1, 16);
    }

    [Fact]
    public void Record_AfterDispose_IsIgnored()
    {
        using var listener = new PooledMeterListener();
        var pool = CreatePool();
        pool.Dispose();
        RecordPoint(pool);
        Assert.Empty(listener.Measurements);
        Assert.Equal(0, pool.Count);
    }

    private ResourceMeterPool CreatePool() =>
        new(_clock, (s, v) => ResourceMeterTest.CreateMeter(s, v, _handler));

    private void RecordPoint(ResourceMeterPool pool, string instanceId = "instance") =>
        pool.Record(ServiceMetricsConfiguration.Spanner, _counter, 1L, MetricForwarderTest.CreateLabels(instanceId));
}
