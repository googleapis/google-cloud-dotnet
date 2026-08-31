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
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class ServiceMetricsConfigurationTest
{
    private const string SpannerMetricPrefix = "spanner.googleapis.com/internal/client/";

    internal static readonly string[] s_sampleResourceValues =
        ["project", "instance", "us-central1", "regional-us-central1", "0000ff"];
    private static readonly ServiceMetricsConfiguration s_spanner = ServiceMetricsConfiguration.Spanner;
    private static readonly string[] s_expectedResourceLabels =
        ["project_id", "instance_id", "location", "instance_config", "client_hash"];
    private static readonly double[] s_expectedHistogramBoundaries =
    [
        0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 8.0, 10.0, 13.0, 16.0, 20.0, 25.0, 30.0, 40.0, 50.0, 65.0, 80.0, 100.0,
        130.0, 160.0, 200.0, 250.0, 300.0, 400.0, 500.0, 650.0, 800.0, 1000.0, 2000.0, 5000.0, 10000.0, 20000.0,
        50000.0, 100000.0, 200000.0, 400000.0, 800000.0, 1600000.0, 3200000.0
    ];

    [Theory]
    [InlineData("operation_count")]
    [InlineData("operation_latencies")]
    public void CreateMeterProvider_AddsMetricPrefix(string instrumentName)
    {
        var exported = ExportMetrics(instrumentName.EndsWith("_latencies", StringComparison.Ordinal)
            ? meter => meter.CreateHistogram<double>(instrumentName).Record(1)
            : meter => meter.CreateCounter<long>(instrumentName).Add(1));
        Assert.Equal(SpannerMetricPrefix + instrumentName, Assert.Single(exported).Name);
    }

    [Fact]
    public void CreateMeterProvider_HistogramUsesConfiguredBoundaries()
    {
        var metric = Assert.Single(ExportMetrics(meter => meter.CreateHistogram<double>("attempt_latencies").Record(1)));
        var bounds = new List<double>();
        foreach (ref readonly var point in metric.GetMetricPoints())
        {
            foreach (var bucket in point.GetHistogramBuckets())
            {
                bounds.Add(bucket.ExplicitBound);
            }
        }
        // The SDK adds a last bucket with no upper bound.
        Assert.Equal(s_expectedHistogramBoundaries.Concat([double.PositiveInfinity]), bounds);
    }

    [Fact]
    public void CreateMeterProvider_OtherMeter_IsFilteredOut()
    {
        using var otherMeter = new Meter(CreateMeterName());
        Assert.Empty(ExportMetrics(_ => otherMeter.CreateCounter<long>("operation_count").Add(1)));
    }

    [Fact]
    public void CreateMeterProvider_SetsResourceTypeProjectAndLabelsOnly()
    {
        var values = s_expectedResourceLabels.Select(name => $"{name}-value").ToList();
        using var exporter = new TestMetricExporter();
        using var provider = s_spanner.CreateMeterProvider(CreateMeterName(), values, _ => new BaseExportingMetricReader(exporter));

        var expected = s_expectedResourceLabels.ToDictionary(name => name, name => (object) $"{name}-value");
        expected["gcp.resource_type"] = "spanner_instance_client";
        expected["gcp.project_id"] = "project_id-value";
        Assert.Equal(expected, exporter.ParentProvider.GetResource().Attributes.ToDictionary(p => p.Key, p => p.Value));
    }

    [Fact]
    public void CreateMeterProvider_DisablesExemplarsDespiteEnvironmentVariable()
    {
        using var env = new TemporaryEnvironmentVariable("OTEL_METRICS_EXEMPLAR_FILTER", "always_on");
        using var activitySource = new ActivitySource(CreateMeterName());
        using var activityListener = new ActivityListener
        {
            ShouldListenTo = source => ReferenceEquals(source, activitySource),
            Sample = (ref ActivityCreationOptions<ActivityContext> _) => ActivitySamplingResult.AllDataAndRecorded
        };
        ActivitySource.AddActivityListener(activityListener);
        using var activity = activitySource.StartActivity("op");
        Assert.True(activity?.Recorded);

        var metric = Assert.Single(ExportMetrics(meter => meter.CreateCounter<long>("operation_count").Add(1)));
        int pointCount = 0;
        foreach (ref readonly var point in metric.GetMetricPoints())
        {
            pointCount++;
            Assert.False(point.TryGetExemplars(out _));
        }
        Assert.Equal(1, pointCount);
    }

    [Theory]
    [InlineData("operation_count", null, "1")]
    [InlineData("attempt_count", "s", "1")]
    [InlineData("gfe_connectivity_error_count", null, "1")]
    [InlineData("operation_latencies", null, "ms")]
    [InlineData("attempt_latencies", "s", "ms")]
    [InlineData("gfe_latencies", null, "ms")]
    [InlineData("unlisted_metric", "By", "By")]
    public void ResolveUnit_ReturnsConfiguredOrSourceUnit(string instrumentName, string sourceUnit, string expectedUnit)
    {
        using var meter = new Meter(CreateMeterName());
        Assert.Equal(expectedUnit, s_spanner.ResolveUnit(meter.CreateCounter<long>(instrumentName, sourceUnit)));
    }

    [Theory]
    [InlineData("project", "instance", true)]
    [InlineData("a|b", "c", false)]
    public void TrySplitLabels_ExtractsOrderedResourceValues(string projectId, string instanceId, bool reverse)
    {
        var labels = MetricForwarderTest.CreateLabels(instanceId, projectId);
        if (reverse)
        {
            labels = Enumerable.Reverse(labels).ToArray();
        }
        Assert.True(s_spanner.TrySplitLabels(labels, out var values, out _));
        Assert.Equal([projectId, instanceId, "us-central1", "regional-us-central1", "0000ff"], values);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public void TrySplitLabels_PreservesMetricTags(int tagCount)
    {
        var expectedTags = Enumerable.Range(0, tagCount)
            .Select(i => new KeyValuePair<string, object>($"tag_{i}", $"value_{i}")).ToArray();
        var labels = MetricForwarderTest.CreateLabels().Where(pair => pair.Key != "database").Concat(expectedTags).ToArray();

        Assert.True(s_spanner.TrySplitLabels(labels, out _, out var metricTags));
        Assert.Equal(expectedTags, metricTags);
    }

    [Fact]
    public void TrySplitLabels_NonStringResourceLabel_FormatsWithInvariantCulture()
    {
        var labels = MetricForwarderTest.CreateLabels()
            .Select(pair => pair.Key == "client_hash" ? new KeyValuePair<string, object>(pair.Key, 12.5) : pair).ToArray();
        var originalCulture = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
            Assert.True(s_spanner.TrySplitLabels(labels, out var values, out _));
            Assert.Equal("12.5", values[Array.IndexOf(s_expectedResourceLabels, "client_hash")]);
        }
        finally
        {
            CultureInfo.CurrentCulture = originalCulture;
        }
    }

    [Theory]
    [InlineData("instance_id", null, true)]
    [InlineData("instance_id", null, false)]
    [InlineData("instance_id", "", false)]
    [InlineData("project_id", "", false)]
    public void TrySplitLabels_MissingOrEmptyResourceLabel_ReturnsFalse(string label, string value, bool omit)
    {
        var labels = MetricForwarderTest.CreateLabels().Where(pair => pair.Key != label).ToList();
        if (!omit)
        {
            labels.Add(new(label, value));
        }
        Assert.False(s_spanner.TrySplitLabels(labels.ToArray(), out var values, out _));
        Assert.Null(values);
    }

    private static Metric[] ExportMetrics(Action<Meter> record)
    {
        string meterName = CreateMeterName();
        using var exporter = new TestMetricExporter();
        using var meterProvider = s_spanner.CreateMeterProvider(
            meterName, s_sampleResourceValues, _ => new BaseExportingMetricReader(exporter));
        using var meter = new Meter(meterName);
        record(meter);
        meterProvider.ForceFlush();
        return exporter.Metrics.ToArray();
    }

    private static string CreateMeterName() => $"Test.{Guid.NewGuid():N}";

    private sealed class TestMetricExporter : BaseExporter<Metric>
    {
        internal List<Metric> Metrics { get; } = new();

        public override ExportResult Export(in Batch<Metric> batch)
        {
            foreach (var metric in batch)
            {
                Metrics.Add(metric);
            }
            return ExportResult.Success;
        }
    }
}
