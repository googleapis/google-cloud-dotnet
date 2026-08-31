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

using Google.Api.Gax;
using OpenTelemetry.Metrics;
using System.Linq;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Configuration for Google Cloud Spanner built-in metrics telemetry.
/// </summary>
internal sealed class SpannerMetricsConfiguration : IServiceMetricsConfiguration
{
    /// <summary>
    /// The singleton instance of <see cref="SpannerMetricsConfiguration"/>.
    /// </summary>
    internal static SpannerMetricsConfiguration Instance { get; } = new SpannerMetricsConfiguration();

    /// <summary>
    /// The meter name used for Spanner client telemetry.
    /// </summary>
    internal const string MeterName = "Google.Cloud.Spanner.BuiltInMetrics";

    /// <summary>
    /// The internal metric prefix required for GCP Monitoring OTLP ingestion.
    /// </summary>
    internal const string InternalMetricPrefix = "spanner.googleapis.com/internal/client/";

    /// <summary>
    /// Default explicit histogram bucket boundaries (in milliseconds) for Spanner latency metrics.
    /// </summary>
    private static readonly double[] DefaultHistogramBoundaries = [10.0, 50.0, 100.0, 250.0, 500.0, 1000.0];

    private static readonly string[] s_counterInstruments =
    [
        "operation_count",
        "attempt_count",
        "gfe_connectivity_error_count",
        "afe_connectivity_error_count"
    ];

    private static readonly string[] s_latencyInstruments =
    [
        "operation_latencies",
        "attempt_latencies",
        "gfe_latencies",
        "afe_latencies"
    ];

    /// <inheritdoc/>
    public void Configure(MeterProviderBuilder builder)
    {
        GaxPreconditions.CheckNotNull(builder, nameof(builder));

        builder.AddMeter(MeterName);

        builder.AddView(instrument =>
        {
            if (instrument.Meter.Name != MeterName)
            {
                return null;
            }

            if (s_counterInstruments.Contains(instrument.Name))
            {
                return new MetricStreamConfiguration
                {
                    Name = InternalMetricPrefix + instrument.Name
                };
            }

            if (s_latencyInstruments.Contains(instrument.Name))
            {
                return new ExplicitBucketHistogramConfiguration
                {
                    Name = InternalMetricPrefix + instrument.Name,
                    Boundaries = DefaultHistogramBoundaries
                };
            }

            return null;
        });
    }
}
