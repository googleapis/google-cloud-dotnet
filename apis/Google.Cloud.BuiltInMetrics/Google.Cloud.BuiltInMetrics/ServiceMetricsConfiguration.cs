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
using OpenTelemetry.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Describes the built-in metrics schema for one Google Cloud service.
/// </summary>
internal sealed class ServiceMetricsConfiguration(
    string sourceMeterName, string metricPrefix, string resourceType,
    string[] resourceLabelNames, double[] histogramBoundaries, IReadOnlyDictionary<string, string> units)
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
        units: new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["operation_count"] = "1",
            ["operation_latencies"] = "ms",
            ["attempt_count"] = "1",
            ["attempt_latencies"] = "ms",
            ["gfe_latencies"] = "ms",
            ["gfe_connectivity_error_count"] = "1",
        });

    internal static IReadOnlyList<ServiceMetricsConfiguration> All { get; } = [Spanner];

    internal string SourceMeterName { get; } = sourceMeterName;

    internal bool TrySplitLabels(
        ReadOnlySpan<KeyValuePair<string, object>> labels, out string[] resourceValues, out TagList metricTags)
    {
        var values = new string[resourceLabelNames.Length];
        metricTags = default;
        foreach (var label in labels)
        {
            int index = Array.IndexOf(resourceLabelNames, label.Key);
            if (index >= 0)
            {
                values[index] = FormatLabelValue(label.Value);
            }
            else
            {
                metricTags.Add(label);
            }
        }
        // Without every resource label, Cloud Monitoring cannot map the point to a monitored resource.
        if (Array.Exists(values, string.IsNullOrEmpty))
        {
            resourceValues = null;
            return false;
        }
        resourceValues = values;
        return true;
    }

    internal string ResolveUnit(Instrument sourceInstrument) =>
        units.TryGetValue(sourceInstrument.Name, out string configuredUnit) ? configuredUnit : sourceInstrument.Unit;

    internal MeterProvider CreateMeterProvider(
        string meterName, IReadOnlyList<string> resourceValues, Func<IServiceProvider, MetricReader> createReader)
    {
        var builder = Sdk.CreateMeterProviderBuilder()
            // Pin AlwaysOff so OTEL_METRICS_EXEMPLAR_FILTER does not enable exemplars.
            .SetExemplarFilter(ExemplarFilterType.AlwaysOff)
            // Use CreateEmpty so default SDK and service.* attributes are not sent as unknown resource labels.
            .SetResourceBuilder(ResourceBuilder.CreateEmpty().AddAttributes(CreateResourceAttributes(resourceValues)))
            .AddMeter(meterName)
            .AddReader(createReader);
        ConfigureViews(builder);
        return builder.Build();
    }

    private IEnumerable<KeyValuePair<string, object>> CreateResourceAttributes(IReadOnlyList<string> resourceValues)
    {
        // telemetry.googleapis.com maps gcp.resource_type and gcp.project_id to the resource type and project, and remaining attributes to resource labels.
        yield return new(ResourceTypeAttribute, resourceType);
        for (int i = 0; i < resourceLabelNames.Length; i++)
        {
            string labelName = resourceLabelNames[i];
            string labelValue = resourceValues[i];
            if (labelName == ProjectIdLabel)
            {
                yield return new(ProjectIdAttribute, labelValue);
            }
            yield return new(labelName, labelValue);
        }
    }

    private void ConfigureViews(MeterProviderBuilder builder) =>
        builder.AddView(instrument => instrument is Histogram<double>
            ? new ExplicitBucketHistogramConfiguration { Name = metricPrefix + instrument.Name, Boundaries = histogramBoundaries }
            : new MetricStreamConfiguration { Name = metricPrefix + instrument.Name });

    private static string FormatLabelValue(object value) =>
        value is string text ? text : Convert.ToString(value, CultureInfo.InvariantCulture);
}
