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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Google.Cloud.BuiltInMetrics.Tests;

/// <summary>
/// Captures the measurements that a forwarder records on its pooled meters.
/// </summary>
internal sealed class PooledMeterListener : IDisposable
{
    private const string PooledMeterPrefix = "BuiltInMetrics.Pool#";

    private readonly ConcurrentQueue<ForwardedMeasurement> _measurements = new();
    private readonly MeterListener _listener;

    internal PooledMeterListener()
    {
        _listener = new MeterListener
        {
            InstrumentPublished = (instrument, listener) =>
            {
                if (instrument.Meter.Name.StartsWith(PooledMeterPrefix, StringComparison.Ordinal))
                {
                    listener.EnableMeasurementEvents(instrument);
                }
            }
        };
        _listener.SetMeasurementEventCallback<long>((instrument, value, labels, _) => _measurements.Enqueue(new(instrument, value, labels)));
        _listener.SetMeasurementEventCallback<double>((instrument, value, labels, _) => _measurements.Enqueue(new(instrument, value, labels)));
        _listener.Start();
    }

    internal IReadOnlyList<ForwardedMeasurement> Measurements => _measurements.ToArray();

    public void Dispose() => _listener.Dispose();
}

/// <summary>
/// One measurement that a forwarder recorded on a pooled meter.
/// </summary>
internal sealed class ForwardedMeasurement
{
    internal ForwardedMeasurement(Instrument instrument, object value, ReadOnlySpan<KeyValuePair<string, object>> labels)
    {
        MeterName = instrument.Meter.Name;
        InstrumentName = instrument.Name;
        Unit = instrument.Unit;
        Value = value;
        // Copy the span because it is valid only during the callback.
        Labels = labels.ToArray().ToDictionary(label => label.Key, label => label.Value);
    }

    internal string MeterName { get; }
    internal string InstrumentName { get; }
    internal string Unit { get; }
    internal object Value { get; }
    internal IReadOnlyDictionary<string, object> Labels { get; }
}
