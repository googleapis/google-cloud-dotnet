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

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Listens to client library source meters and forwards measurements to <see cref="ResourceMeterPool"/>.
/// </summary>
internal sealed class MetricForwarder : IDisposable
{
    private readonly Dictionary<string, ServiceMetricsConfiguration> _servicesByMeterName;
    private readonly ResourceMeterPool _pool;
    private readonly MeterListener _listener;

    internal MetricForwarder(IReadOnlyList<ServiceMetricsConfiguration> services, ResourceMeterPool pool)
    {
        _servicesByMeterName = services.ToDictionary(service => service.SourceMeterName, StringComparer.Ordinal);
        _pool = pool;
        _listener = StartMeterListener();
    }

    public void Dispose() => _listener.Dispose();

    private MeterListener StartMeterListener()
    {
        var listener = new MeterListener { InstrumentPublished = OnInstrumentPublished };
        listener.SetMeasurementEventCallback<long>(ForwardMeasurement);
        listener.SetMeasurementEventCallback<double>(ForwardMeasurement);
        listener.Start();
        return listener;
    }

    private void OnInstrumentPublished(Instrument instrument, MeterListener listener)
    {
        if (IsSupportedInstrument(instrument) &&
            _servicesByMeterName.TryGetValue(instrument.Meter.Name, out var service))
        {
            listener.EnableMeasurementEvents(instrument, service);
        }
    }

    private void ForwardMeasurement<T>(
        Instrument instrument, T value, ReadOnlySpan<KeyValuePair<string, object>> labels, object serviceState)
        where T : struct
    {
        try
        {
            _pool.Record((ServiceMetricsConfiguration) serviceState, instrument, value, labels);
        }
        catch
        {
            // MeterListener callbacks run synchronously on the caller's RPC thread without catching exceptions, so drop the measurement instead of failing the RPC.
        }
    }

    private static bool IsSupportedInstrument(Instrument instrument) =>
        instrument is Counter<long> or Histogram<double>;
}
