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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class ResourceMeterTest : IDisposable
{
    private readonly RecordingHandler _handler = new();
    private readonly Meter _sourceMeter = new(ServiceMetricsConfiguration.Spanner.SourceMeterName);

    public void Dispose()
    {
        _sourceMeter.Dispose();
        _handler.Dispose();
    }

    [Theory]
    [InlineData(InstrumentKind.Counter, "attempt_count", null, "1")]
    [InlineData(InstrumentKind.Counter, "attempt_count", "s", "1")]
    [InlineData(InstrumentKind.Counter, "unlisted_count", "By", "By")]
    [InlineData(InstrumentKind.Histogram, "attempt_latencies", null, "ms")]
    [InlineData(InstrumentKind.Histogram, "attempt_latencies", "s", "ms")]
    [InlineData(InstrumentKind.Histogram, "unlisted_latencies", "s", "s")]
    public void Record_PooledInstrumentGetsUnit(
        InstrumentKind kind, string instrumentName, string sourceUnit, string expectedUnit)
    {
        using var listener = new PooledMeterListener();
        using var meter = CreateResourceMeter();
        TagList tags = default;

        if (kind == InstrumentKind.Counter)
        {
            meter.Record(_sourceMeter.CreateCounter<long>(instrumentName, sourceUnit), 1L, in tags);
        }
        else
        {
            meter.Record(_sourceMeter.CreateHistogram<double>(instrumentName, sourceUnit), 1.5, in tags);
        }

        var measurement = Assert.Single(listener.Measurements);
        Assert.Equal(instrumentName, measurement.InstrumentName);
        Assert.Equal(expectedUnit, measurement.Unit);
    }

    [Theory]
    [InlineData(InstrumentKind.Counter)]
    [InlineData(InstrumentKind.Histogram)]
    public void Record_ForwardsMetricTagsAndReusesCachedInstrument(InstrumentKind kind)
    {
        int publishedInstruments = 0;
        using var publishListener = new MeterListener
        {
            InstrumentPublished = (instrument, _) =>
            {
                if (instrument.Meter.Name.StartsWith(ResourceMeter.MeterNamePrefix, StringComparison.Ordinal))
                {
                    Interlocked.Increment(ref publishedInstruments);
                }
            }
        };
        publishListener.Start();
        using var listener = new PooledMeterListener();
        using var meter = CreateResourceMeter();
        TagList tags = new() { { "database", "db-1" }, { "method", "ExecuteSql" } };

        if (kind == InstrumentKind.Counter)
        {
            var counter = _sourceMeter.CreateCounter<long>("attempt_count");
            meter.Record(counter, 1L, in tags);
            meter.Record(counter, 2L, in tags);
        }
        else
        {
            var histogram = _sourceMeter.CreateHistogram<double>("attempt_latencies");
            meter.Record(histogram, 10.0, in tags);
            meter.Record(histogram, 20.0, in tags);
        }

        Assert.Equal(1, Volatile.Read(ref publishedInstruments));
        Assert.Equal(2, listener.Measurements.Count);
        Assert.All(listener.Measurements, m =>
        {
            Assert.Equal("db-1", m.Labels["database"]);
            Assert.Equal("ExecuteSql", m.Labels["method"]);
        });
    }

    [Fact]
    public void Create_AssignsUniquePoolMeterNames()
    {
        using var listener = new PooledMeterListener();
        var counter = _sourceMeter.CreateCounter<long>("attempt_count");
        TagList tags = default;
        using var first = CreateResourceMeter();
        using var second = CreateResourceMeter();

        first.Record(counter, 1L, in tags);
        second.Record(counter, 1L, in tags);

        var meterNames = listener.Measurements.Select(m => m.MeterName).ToList();
        Assert.Equal(2, meterNames.Count);
        Assert.All(meterNames, name => Assert.Matches(@"^BuiltInMetrics\.Pool#\d+$", name));
        Assert.NotEqual(meterNames[0], meterNames[1]);
    }

    [Fact]
    public void Create_InvalidExporterEnvironmentVariable_Throws()
    {
        using var env = new TemporaryEnvironmentVariable("OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY", "bogus");
        Assert.ThrowsAny<Exception>(CreateResourceMeter);
    }

    [Fact]
    public void Create_MeterProviderBuildFails_LeavesHttpHandlerOpen()
    {
        Assert.ThrowsAny<Exception>(
            () => CreateMeter(ServiceMetricsConfiguration.Spanner, Array.Empty<string>(), _handler));
        Assert.False(_handler.Disposed);
    }

    [Theory]
    [InlineData(false, 1)]
    [InlineData(true, 0)]
    public void Dispose_ExportsRecordedDataUnlessSkipped(bool skipFinalExport, int expectedRequests)
    {
        var meter = CreateResourceMeter();
        TagList tags = default;
        meter.Record(_sourceMeter.CreateCounter<long>("attempt_count"), 1L, in tags);
        if (skipFinalExport)
        {
            meter.SkipFinalExport();
        }

        meter.Dispose();

        Assert.Equal(expectedRequests, _handler.RequestCount);
        Assert.False(_handler.Disposed);
    }

    internal static ResourceMeter CreateMeter(
        ServiceMetricsConfiguration service, IReadOnlyList<string> resourceValues, HttpMessageHandler handler) =>
        ResourceMeter.Create(
            service,
            resourceValues,
            handler,
            static () => new AccessTokenWithHeaders("token", null));

    private ResourceMeter CreateResourceMeter() =>
        CreateMeter(ServiceMetricsConfiguration.Spanner, ServiceMetricsConfigurationTest.s_sampleResourceValues, _handler);
}
