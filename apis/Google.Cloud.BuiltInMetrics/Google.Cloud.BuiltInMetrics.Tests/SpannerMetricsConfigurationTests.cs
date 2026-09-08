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

using OpenTelemetry;
using OpenTelemetry.Metrics;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

public class SpannerMetricsConfigurationTests
{
    public enum MetricInstrumentType
    {
        Counter,
        Histogram
    }

    [Theory]
    [InlineData("operation_count", MetricInstrumentType.Counter)]
    [InlineData("attempt_count", MetricInstrumentType.Counter)]
    [InlineData("gfe_connectivity_error_count", MetricInstrumentType.Counter)]
    [InlineData("afe_connectivity_error_count", MetricInstrumentType.Counter)]
    [InlineData("operation_latencies", MetricInstrumentType.Histogram)]
    [InlineData("attempt_latencies", MetricInstrumentType.Histogram)]
    [InlineData("gfe_latencies", MetricInstrumentType.Histogram)]
    [InlineData("afe_latencies", MetricInstrumentType.Histogram)]
    public void Configure_MapsInstrumentsToInternalPrefix(
        string instrumentName,
        MetricInstrumentType instrumentType)
    {
        var exportedMetrics = new List<Metric>();
        using var meterProvider = Sdk.CreateMeterProviderBuilder()
            .AddTestExporter(exportedMetrics)
            .ConfigureSpannerMetrics()
            .Build();

        var meter = new Meter(SpannerMetricsConfiguration.MeterName);
        if (instrumentType == MetricInstrumentType.Counter)
        {
            meter.CreateCounter<long>(instrumentName).Add(1);
        }
        else
        {
            meter.CreateHistogram<double>(instrumentName).Record(1);
        }

        meterProvider.ForceFlush();

        var metric = Assert.Single(exportedMetrics);
        // The metrics should have spanner.googleapis.com/internal/client/ as a prefix
        Assert.Equal(SpannerMetricsConfiguration.InternalMetricPrefix + instrumentName, metric.Name);
    }

    [Fact]
    public void Configure_UnregisteredMeter_IsIgnored()
    {
        var exportedMetrics = new List<Metric>();
        using var meterProvider = Sdk.CreateMeterProviderBuilder()
            .AddTestExporter(exportedMetrics)
            .ConfigureSpannerMetrics()
            .Build();

        var unregisteredMeter = new Meter("Some.Other.Unregistered.Meter");
        unregisteredMeter.CreateCounter<long>("operation_count").Add(10);

        meterProvider.ForceFlush();

        Assert.Empty(exportedMetrics);
    }

    [Fact]
    public void Configure_AnotherMeter_IsNotTransformedBySpannerViews()
    {
        var exportedMetrics = new List<Metric>();
        using var meterProvider = Sdk.CreateMeterProviderBuilder()
            .AddMeter("CustomApp.Meter")
            .AddTestExporter(exportedMetrics)
            .ConfigureSpannerMetrics()
            .Build();

        var customMeter = new Meter("CustomApp.Meter");
        customMeter.CreateCounter<long>("operation_count").Add(10);

        meterProvider.ForceFlush();

        var metric = Assert.Single(exportedMetrics);
        Assert.Equal("operation_count", metric.Name);
    }
}
