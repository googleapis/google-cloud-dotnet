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
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Threading;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Owns the OpenTelemetry meter and export pipeline for one monitored resource, creating instruments on first use.
/// </summary>
internal sealed class ResourceMeter : IDisposable
{
    internal static readonly TimeSpan ExportInterval = TimeSpan.FromSeconds(60);
    private const string PooledMeterPrefix = "BuiltInMetrics.Pool#";
    // Process-wide counter so two live providers never subscribe to the same meter name.
    private static long s_lastMeterId;

    private readonly ServiceMetricsConfiguration _configuration;
    private readonly Meter _meter;
    private readonly MeterProvider _meterProvider;
    private readonly MetricReader _reader;
    private readonly AuthorizingOtlpMetricExporter _exporter;
    private readonly HttpClient _httpClient;
    private readonly ConcurrentDictionary<string, Instrument> _instruments = new(StringComparer.Ordinal);

    private ResourceMeter(
        ServiceMetricsConfiguration configuration,
        Meter meter,
        MeterProvider meterProvider,
        MetricReader reader,
        AuthorizingOtlpMetricExporter exporter,
        HttpClient httpClient)
    {
        _configuration = configuration;
        _meter = meter;
        _meterProvider = meterProvider;
        _reader = reader;
        _exporter = exporter;
        _httpClient = httpClient;
    }

    internal static ResourceMeter Create(ResourceKey key, HttpMessageHandler handler, ITokenAccessWithHeaders credential)
    {
        var configuration = key.Configuration;
        string meterName = PooledMeterPrefix + Interlocked.Increment(ref s_lastMeterId);
        var httpClient = new HttpClient(handler, disposeHandler: false) { Timeout = AuthorizingOtlpMetricExporter.ExportTimeout };
        AuthorizingOtlpMetricExporter exporter = null;
        PeriodicExportingMetricReader reader = null;
        MeterProvider meterProvider = null;
        try
        {
            exporter = new AuthorizingOtlpMetricExporter(httpClient, credential);
            reader = new PeriodicExportingMetricReader(
                exporter,
                exportIntervalMilliseconds: (int) ExportInterval.TotalMilliseconds,
                exportTimeoutMilliseconds: (int) AuthorizingOtlpMetricExporter.ExportTimeout.TotalMilliseconds);
            var builder = Sdk.CreateMeterProviderBuilder()
                // Pin AlwaysOff so OTEL_METRICS_EXEMPLAR_FILTER does not enable exemplars.
                .SetExemplarFilter(ExemplarFilterType.AlwaysOff)
                .SetResourceBuilder(ResourceBuilder.CreateEmpty().AddAttributes(configuration.CreateResourceAttributes(key.Values)))
                .AddMeter(meterName)
                .AddReader(reader);
            configuration.ConfigureViews(builder, meterName);
            meterProvider = builder.Build();
            if (exporter.ParentProvider is null)
            {
                // OTEL_SDK_DISABLED=true returned a no-op provider, so stop the unowned reader thread immediately.
                exporter.SkipExport = true;
                reader.Shutdown(0);
            }
            // Create the meter last so a failed build leaves no orphaned meter.
            return new ResourceMeter(configuration, new Meter(meterName), meterProvider, reader, exporter, httpClient);
        }
        catch
        {
            if (exporter is not null)
            {
                exporter.SkipExport = true;
            }
            reader?.Shutdown(0);
            meterProvider?.Dispose();
            reader?.Dispose();
            exporter?.Dispose();
            httpClient.Dispose();
            throw;
        }
    }

    internal void Record<T>(Instrument source, T value, in TagList tags) where T : struct
    {
        switch (GetOrCreateInstrument<T>(source))
        {
            case Counter<T> counter when source is Counter<T>:
                counter.Add(value, in tags);
                break;
            case Histogram<T> histogram when source is Histogram<T>:
                histogram.Record(value, in tags);
                break;
        }
    }

    internal void DisableExport() => _exporter.SkipExport = true;

    private Instrument GetOrCreateInstrument<T>(Instrument source) where T : struct
    {
        if (_instruments.TryGetValue(source.Name, out var instrument))
        {
            return instrument;
        }
        // Serialize instrument creation so the meter never registers the same instrument twice.
        lock (_instruments)
        {
            if (!_instruments.TryGetValue(source.Name, out instrument))
            {
                string unit = _configuration.Units.TryGetValue(source.Name, out var configuredUnit) ? configuredUnit : source.Unit;
                instrument = source switch
                {
                    Counter<T> => _meter.CreateCounter<T>(source.Name, unit),
                    Histogram<T> => _meter.CreateHistogram<T>(source.Name, unit),
                    _ => null
                };
                if (instrument is not null)
                {
                    _instruments[source.Name] = instrument;
                }
            }
            return instrument;
        }
    }

    /// <summary>
    /// Exports remaining metrics within the export timeout and disposes owned resources.
    /// </summary>
    public void Dispose()
    {
        // MeterProvider.Dispose caps reader shutdown at 5 seconds, so shut down with ExportTimeout first.
        _reader.Shutdown((int) AuthorizingOtlpMetricExporter.ExportTimeout.TotalMilliseconds);
        _exporter.SkipExport = true;
        _meter.Dispose();
        _meterProvider.Dispose();
        // MeterProvider.Dispose disposes the reader unless OTEL_SDK_DISABLED returned a no-op provider.
        _reader.Dispose();
        _httpClient.Dispose();
    }
}
