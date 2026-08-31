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
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

public class ServiceMetricsConfigurationTest
{
    private static readonly ServiceMetricsConfiguration s_spanner = ServiceMetricsConfiguration.Spanner;

    [Theory]
    [InlineData("operation_count")]
    [InlineData("attempt_count")]
    [InlineData("gfe_connectivity_error_count")]
    [InlineData("operation_latencies")]
    [InlineData("attempt_latencies")]
    [InlineData("gfe_latencies")]
    public void ConfigureViews_AddsMetricPrefix(string instrumentName)
    {
        string meterName = CreateMeterName();
        var exportedMetrics = new List<Metric>();
        using var meterProvider = CreateMeterProvider(exportedMetrics, meterName);
        using var meter = new Meter(meterName);

        if (instrumentName.EndsWith("_latencies", StringComparison.Ordinal))
        {
            meter.CreateHistogram<double>(instrumentName).Record(1);
        }
        else
        {
            meter.CreateCounter<long>(instrumentName).Add(1);
        }
        meterProvider.ForceFlush();

        var metric = Assert.Single(exportedMetrics);
        Assert.Equal(s_spanner.MetricPrefix + instrumentName, metric.Name);
    }

    [Fact]
    public void ConfigureViews_HistogramUsesConfiguredBoundaries()
    {
        string meterName = CreateMeterName();
        var exportedMetrics = new List<Metric>();
        using var meterProvider = CreateMeterProvider(exportedMetrics, meterName);
        using var meter = new Meter(meterName);

        meter.CreateHistogram<double>("attempt_latencies").Record(1);
        meterProvider.ForceFlush();

        var metric = Assert.Single(exportedMetrics);
        var bounds = new List<double>();
        foreach (ref readonly var point in metric.GetMetricPoints())
        {
            foreach (var bucket in point.GetHistogramBuckets())
            {
                bounds.Add(bucket.ExplicitBound);
            }
        }
        // The SDK adds a last bucket with no upper bound.
        Assert.Equal(s_spanner.HistogramBoundaries.Concat([double.PositiveInfinity]), bounds);
    }

    [Fact]
    public void ConfigureViews_OtherMeter_KeepsInstrumentName()
    {
        string meterName = CreateMeterName();
        string otherMeterName = CreateMeterName();
        var exportedMetrics = new List<Metric>();
        using var meterProvider = CreateMeterProvider(exportedMetrics, meterName, otherMeterName);
        using var otherMeter = new Meter(otherMeterName);

        otherMeter.CreateCounter<long>("operation_count").Add(1);
        meterProvider.ForceFlush();

        var metric = Assert.Single(exportedMetrics);
        Assert.Equal("operation_count", metric.Name);
    }

    [Fact]
    public void CreateResourceAttributes_AddsResourceTypeProjectAndLabels()
    {
        var values = s_spanner.ResourceLabelNames.Select(name => $"{name}-value").ToList();

        var attributes = s_spanner.CreateResourceAttributes(values).ToDictionary(pair => pair.Key, pair => pair.Value);

        var expected = s_spanner.ResourceLabelNames.ToDictionary(name => name, name => (object) $"{name}-value");
        expected["gcp.resource_type"] = "spanner_instance_client";
        expected["gcp.project_id"] = "project_id-value";
        Assert.Equal(expected, attributes);
    }

    [Fact]
    public void Spanner_HasResourceLabelNames()
    {
        string[] expected = ["client_hash", "instance_config", "instance_id", "location", "project_id"];
        Assert.Equal(expected, s_spanner.ResourceLabelNames.OrderBy(name => name, StringComparer.Ordinal));
    }

    [Fact]
    public void Spanner_HasUnitsForAllInstruments()
    {
        var expected = new Dictionary<string, string>
        {
            ["operation_count"] = "1",
            ["operation_latencies"] = "ms",
            ["attempt_count"] = "1",
            ["attempt_latencies"] = "ms",
            ["gfe_latencies"] = "ms",
            ["gfe_connectivity_error_count"] = "1"
        };

        Assert.Equal(
            expected.OrderBy(pair => pair.Key, StringComparer.Ordinal),
            s_spanner.Units.OrderBy(pair => pair.Key, StringComparer.Ordinal));
    }

    private static string CreateMeterName() => $"Test.{Guid.NewGuid():N}";

    // Collects the given meters and applies the Spanner views to the first one.
    private static MeterProvider CreateMeterProvider(List<Metric> exportedMetrics, string meterName, params string[] otherMeterNames)
    {
        var builder = Sdk.CreateMeterProviderBuilder()
            .AddMeter(meterName)
            .AddMeter(otherMeterNames)
            .AddReader(new BaseExportingMetricReader(new TestMetricExporter(exportedMetrics)));
        s_spanner.ConfigureViews(builder, meterName);
        return builder.Build();
    }

    private sealed class TestMetricExporter(List<Metric> metrics) : BaseExporter<Metric>
    {
        public override ExportResult Export(in Batch<Metric> batch)
        {
            foreach (var metric in batch)
            {
                metrics.Add(metric);
            }
            return ExportResult.Success;
        }
    }
}
