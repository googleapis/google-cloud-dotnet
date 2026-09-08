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

namespace Google.Cloud.BuiltInMetrics.Tests;

internal static class TestMeterProviderBuilderExtensions
{
    public static MeterProviderBuilder ConfigureSpannerMetrics(this MeterProviderBuilder builder)
    {
        SpannerMetricsConfiguration.Instance.Configure(builder);
        return builder;
    }

    public static MeterProviderBuilder AddTestExporter(this MeterProviderBuilder builder, List<Metric> exportedMetrics)
    {
        return builder.AddReader(new BaseExportingMetricReader(new TestMetricExporter(exportedMetrics)));
    }
}

internal class TestMetricExporter : BaseExporter<Metric>
{
    private readonly List<Metric> _metrics;

    public TestMetricExporter(List<Metric> metrics) => _metrics = metrics;

    public override ExportResult Export(in Batch<Metric> batch)
    {
        foreach (var metric in batch)
        {
            _metrics.Add(metric);
        }
        return ExportResult.Success;
    }
}
