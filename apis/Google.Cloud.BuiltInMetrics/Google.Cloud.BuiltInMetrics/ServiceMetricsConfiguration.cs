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

using OpenTelemetry.Metrics;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Describes the built-in metrics of one Google Cloud service, including its source meter and export rules.
/// </summary>
internal sealed class ServiceMetricsConfiguration
{
    private const string ResourceTypeAttribute = "gcp.resource_type";
    private const string ProjectIdAttribute = "gcp.project_id";
    private const string ProjectIdLabel = "project_id";

    // The latency buckets that the Java and Go client libraries use, in milliseconds.
    private static readonly double[] s_histogramBoundaries =
    [
        0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 8.0, 10.0, 13.0, 16.0, 20.0, 25.0, 30.0, 40.0, 50.0, 65.0, 80.0, 100.0,
        130.0, 160.0, 200.0, 250.0, 300.0, 400.0, 500.0, 650.0, 800.0, 1000.0, 2000.0, 5000.0, 10000.0, 20000.0,
        50000.0, 100000.0, 200000.0, 400000.0, 800000.0, 1600000.0, 3200000.0
    ];

    internal static ServiceMetricsConfiguration Spanner { get; } = new(
        sourceMeterName: "Google.Cloud.Spanner.BuiltInMetrics",
        metricPrefix: "spanner.googleapis.com/internal/client/",
        resourceType: "spanner_instance_client",
        resourceLabelNames: ["project_id", "instance_id", "location", "instance_config", "client_hash"],
        histogramBoundaries: s_histogramBoundaries,
        units: new Dictionary<string, string>
        {
            ["operation_count"] = "1",
            ["operation_latencies"] = "ms",
            ["attempt_count"] = "1",
            ["attempt_latencies"] = "ms",
            ["gfe_latencies"] = "ms",
            ["gfe_connectivity_error_count"] = "1",
        });

    internal static IReadOnlyList<ServiceMetricsConfiguration> All { get; } = [Spanner];

    internal string SourceMeterName { get; }
    internal string MetricPrefix { get; }
    internal string ResourceType { get; }
    internal string[] ResourceLabelNames { get; }
    internal double[] HistogramBoundaries { get; }
    internal IReadOnlyDictionary<string, string> Units { get; }

    private ServiceMetricsConfiguration(
        string sourceMeterName,
        string metricPrefix,
        string resourceType,
        string[] resourceLabelNames,
        double[] histogramBoundaries,
        IReadOnlyDictionary<string, string> units)
    {
        SourceMeterName = sourceMeterName;
        MetricPrefix = metricPrefix;
        ResourceType = resourceType;
        ResourceLabelNames = resourceLabelNames;
        HistogramBoundaries = histogramBoundaries;
        Units = units;
    }

    /// <summary>
    /// Adds views that assign metric names and histogram buckets to instruments on <paramref name="meterName"/>.
    /// </summary>
    internal void ConfigureViews(MeterProviderBuilder builder, string meterName) =>
        builder.AddView(instrument =>
            instrument.Meter.Name != meterName ? null
            : instrument is Histogram<double>
                ? new ExplicitBucketHistogramConfiguration { Name = MetricPrefix + instrument.Name, Boundaries = HistogramBoundaries }
                : new MetricStreamConfiguration { Name = MetricPrefix + instrument.Name });

    /// <summary>
    /// Creates the resource attributes for one monitored resource in the order of <see cref="ResourceLabelNames"/>.
    /// </summary>
    internal IEnumerable<KeyValuePair<string, object>> CreateResourceAttributes(IReadOnlyList<string> resourceLabelValues)
    {
        // telemetry.googleapis.com reads these two attributes to select the monitored resource type and project.
        // All remaining attributes become monitored resource labels.
        yield return new(ResourceTypeAttribute, ResourceType);
        for (int i = 0; i < ResourceLabelNames.Length; i++)
        {
            if (ResourceLabelNames[i] == ProjectIdLabel)
            {
                yield return new(ProjectIdAttribute, resourceLabelValues[i]);
            }
            yield return new(ResourceLabelNames[i], resourceLabelValues[i]);
        }
    }
}
