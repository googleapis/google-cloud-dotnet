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
using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(PipelineCollection.Name)]
public class ResourceMeterPoolTest : IDisposable
{
    private readonly FakeClock _clock = new();
    private readonly RecordingHandler _handler = new();
    private readonly Meter _sourceMeter = new(ServiceMetricsConfiguration.Spanner.SourceMeterName);

    public void Dispose()
    {
        _sourceMeter.Dispose();
        _handler.Dispose();
    }

    [Theory]
    [InlineData("instance", 1)]
    [InlineData("other-instance", 2)]
    public void Record_UsesOneEntryForEachResource(string secondInstanceId, int expectedCount)
    {
        using var pool = CreatePool();
        RecordPoint(pool, "instance");
        RecordPoint(pool, secondInstanceId);

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
        _clock.Advance(ResourceMeterPool.IdleTimeout - TimeSpan.FromTicks(1));
        RecordPoint(pool, "active-instance");
        string activeMeterName = listener.Measurements.Last().MeterName;

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
        using var listener = new PooledMeterListener();
        using var pool = CreatePool();
        var counter = _sourceMeter.CreateCounter<long>("attempt_count");
        Assert.True(ResourceKey.TrySplitLabels(
            ServiceMetricsConfiguration.Spanner, MetricForwarderTest.CreateLabels(), out var key, out var tags));

        // Each pass sees the entry as idle, so records race with the closing flag and the retry.
        var evictTask = Task.Run(() =>
        {
            for (int i = 0; i < 50; i++)
            {
                _clock.Advance(ResourceMeterPool.IdleTimeout);
                pool.EvictIdleEntries();
            }
        });
        int recorded = 0;
        while (!evictTask.IsCompleted)
        {
            pool.Record(key, counter, 1L, in tags);
            recorded++;
        }
        await evictTask;

        Assert.Equal(recorded, listener.Measurements.Count);
    }

    [Fact]
    public void Dispose_ExportsRecordedData()
    {
        var pool = CreatePool();
        RecordPoint(pool);
        pool.Dispose();

        Assert.Equal(1, _handler.RequestCount);
    }

    [Fact]
    public void Dispose_DisposesHandler()
    {
        CreatePool().Dispose();
        Assert.True(_handler.Disposed);
    }

    [Fact]
    public void Dispose_Twice_ExportsOnce()
    {
        var pool = CreatePool();
        RecordPoint(pool);
        pool.Dispose();

        Assert.Null(Record.Exception(pool.Dispose));
        Assert.Equal(1, _handler.RequestCount);
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
        new(_handler, GoogleCredential.FromAccessToken("token"), _clock);

    private void RecordPoint(ResourceMeterPool pool, string instanceId = "instance")
    {
        Assert.True(ResourceKey.TrySplitLabels(
            ServiceMetricsConfiguration.Spanner, MetricForwarderTest.CreateLabels(instanceId), out var key, out var tags));
        pool.Record(key, _sourceMeter.CreateCounter<long>("attempt_count"), 1L, in tags);
    }
}
