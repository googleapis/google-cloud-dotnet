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
using OpenTelemetry.Metrics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Threading;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Owns the OpenTelemetry meter and export pipeline for one monitored resource.
/// </summary>
internal sealed class ResourceMeter(
    ServiceMetricsConfiguration service,
    Meter meter,
    MeterProvider meterProvider,
    AuthorizingOtlpMetricExporter exporter) : IDisposable
{
    internal const string MeterNamePrefix = "BuiltInMetrics.Pool#";
    private static readonly TimeSpan s_exportInterval = TimeSpan.FromSeconds(60);
    // Process-wide counter so two live providers never subscribe to the same meter name.
    private static long s_lastMeterId;

    private readonly Dictionary<string, Instrument> _instruments = new(StringComparer.Ordinal);

    internal static ResourceMeter Create(
        ServiceMetricsConfiguration service,
        IReadOnlyList<string> resourceValues,
        HttpMessageHandler httpHandler,
        Func<AccessTokenWithHeaders> getToken)
    {
        string meterName = MeterNamePrefix + Interlocked.Increment(ref s_lastMeterId);
        AuthorizingOtlpMetricExporter exporter = null;
        PeriodicExportingMetricReader reader = null;
        MeterProvider meterProvider = null;
        try
        {
            exporter = AuthorizingOtlpMetricExporter.Create(httpHandler, getToken);
            meterProvider = service.CreateMeterProvider(
                meterName,
                resourceValues,
                _ => reader = CreatePeriodicReader(exporter));
            // Create the meter last so a failed build leaves no orphaned meter.
            return new ResourceMeter(service, new Meter(meterName), meterProvider, exporter);
        }
        catch
        {
            exporter?.DisableExport();
            meterProvider?.Dispose();
            reader?.Shutdown(0);
            reader?.Dispose();
            exporter?.Dispose();
            throw;
        }
    }

    public void Dispose()
    {
        // MeterProvider.Dispose caps reader shutdown at 5 seconds, so shut down with ExportTimeout first.
        meterProvider.Shutdown((int) AuthorizingOtlpMetricExporter.ExportTimeout.TotalMilliseconds);
        exporter.DisableExport();
        meter.Dispose();
        meterProvider.Dispose();
        exporter.Dispose();
    }

    internal void Record<T>(Instrument sourceInstrument, T value, in TagList metricTags) where T : struct
    {
        switch (GetOrCreateInstrument<T>(sourceInstrument))
        {
            case Counter<T> counter:
                counter.Add(value, in metricTags);
                break;
            case Histogram<T> histogram:
                histogram.Record(value, in metricTags);
                break;
        }
    }

    internal void SkipFinalExport() => exporter.DisableExport();

    private Instrument GetOrCreateInstrument<T>(Instrument sourceInstrument) where T : struct
    {
        if (!_instruments.TryGetValue(sourceInstrument.Name, out var instrument))
        {
            string unit = service.ResolveUnit(sourceInstrument);
            instrument = sourceInstrument switch
            {
                Counter<T> => meter.CreateCounter<T>(sourceInstrument.Name, unit),
                Histogram<T> => meter.CreateHistogram<T>(sourceInstrument.Name, unit),
                _ => null
            };
            if (instrument is not null)
            {
                _instruments[sourceInstrument.Name] = instrument;
            }
        }
        return instrument;
    }

    private static PeriodicExportingMetricReader CreatePeriodicReader(AuthorizingOtlpMetricExporter exporter) =>
        new(
            exporter,
            exportIntervalMilliseconds: (int) s_exportInterval.TotalMilliseconds,
            exportTimeoutMilliseconds: (int) AuthorizingOtlpMetricExporter.ExportTimeout.TotalMilliseconds)
        {
            TemporalityPreference = MetricReaderTemporalityPreference.Cumulative
        };
}
