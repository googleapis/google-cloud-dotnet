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
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Listens to client library source meters and routes each measurement to <see cref="ResourceMeterPool"/>.
/// </summary>
internal sealed class MetricForwarder : IDisposable
{
    private readonly Dictionary<string, ServiceMetricsConfiguration> _configurationsBySourceMeter;
    private readonly ResourceMeterPool _pool;
    private readonly MeterListener _listener;

    internal MetricForwarder(
        IReadOnlyList<ServiceMetricsConfiguration> configurations,
        HttpMessageHandler handler,
        ITokenAccessWithHeaders credential,
        IClock clock)
    {
        _configurationsBySourceMeter = GaxPreconditions.CheckNotNull(configurations, nameof(configurations))
            .ToDictionary(configuration => configuration.SourceMeterName, StringComparer.Ordinal);
        _pool = new ResourceMeterPool(handler, credential, clock);
        _listener = new MeterListener
        {
            InstrumentPublished = (instrument, listener) =>
            {
                if (instrument is Counter<long> or Histogram<double> &&
                    _configurationsBySourceMeter.TryGetValue(instrument.Meter.Name, out var configuration))
                {
                    listener.EnableMeasurementEvents(instrument, configuration);
                }
            }
        };
        _listener.SetMeasurementEventCallback<long>(OnMeasurement);
        _listener.SetMeasurementEventCallback<double>(OnMeasurement);
        _listener.Start();
    }

    private void OnMeasurement<T>(Instrument instrument, T value, ReadOnlySpan<KeyValuePair<string, object>> labels, object state)
        where T : struct
    {
        try
        {
            if (ResourceKey.TrySplitLabels((ServiceMetricsConfiguration) state, labels, out var key, out var tags))
            {
                _pool.Record(key, instrument, value, in tags);
            }
        }
        catch
        {
            // Drop the measurement. Built-in metrics must never break the client library or later listeners.
        }
    }

    /// <summary>
    /// Stops listening to source meters and disposes the resource meter pool.
    /// </summary>
    public void Dispose()
    {
        _listener.Dispose();
        _pool.Dispose();
    }
}
