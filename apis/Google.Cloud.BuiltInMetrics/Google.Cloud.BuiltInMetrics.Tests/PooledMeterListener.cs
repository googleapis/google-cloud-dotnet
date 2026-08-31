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
using System.Threading;

namespace Google.Cloud.BuiltInMetrics.Tests;

public enum InstrumentKind
{
    Counter,
    Histogram
}

/// <summary>
/// Captures the measurements that a forwarder records on its pooled meters.
/// </summary>
internal sealed class PooledMeterListener : IDisposable
{
    private readonly ConcurrentQueue<ForwardedMeasurement> _measurements = new();
    private readonly ConcurrentQueue<(int ThreadId, bool IsThreadPoolThread)> _disposeThreads = new();
    private readonly MeterListener _listener;

    internal PooledMeterListener()
    {
        _listener = new MeterListener
        {
            InstrumentPublished = EnableIfPooledInstrument,
            MeasurementsCompleted = RecordDisposeThread
        };
        _listener.SetMeasurementEventCallback<long>(RecordMeasurement);
        _listener.SetMeasurementEventCallback<double>(RecordMeasurement);
        _listener.Start();
    }

    internal IReadOnlyList<ForwardedMeasurement> Measurements => _measurements.ToArray();
    internal IReadOnlyList<(int ThreadId, bool IsThreadPoolThread)> DisposeThreads => _disposeThreads.ToArray();

    public void Dispose() => _listener.Dispose();

    private static void EnableIfPooledInstrument(Instrument instrument, MeterListener listener)
    {
        if (instrument.Meter.Name.StartsWith(ResourceMeter.MeterNamePrefix, StringComparison.Ordinal))
        {
            listener.EnableMeasurementEvents(instrument);
        }
    }

    private void RecordDisposeThread(Instrument instrument, object state) =>
        _disposeThreads.Enqueue((Environment.CurrentManagedThreadId, Thread.CurrentThread.IsThreadPoolThread));

    private void RecordMeasurement<T>(Instrument instrument, T value, ReadOnlySpan<KeyValuePair<string, object>> labels, object state)
        where T : struct =>
        _measurements.Enqueue(new(instrument, value, labels));
}

internal sealed class ForwardedMeasurement
{
    internal ForwardedMeasurement(Instrument instrument, object value, ReadOnlySpan<KeyValuePair<string, object>> labels)
    {
        MeterName = instrument.Meter.Name;
        InstrumentName = instrument.Name;
        Unit = instrument.Unit;
        Value = value;
        Labels = labels.ToArray().ToDictionary(label => label.Key, label => label.Value);
    }

    internal string MeterName { get; }
    internal string InstrumentName { get; }
    internal string Unit { get; }
    internal object Value { get; }
    internal IReadOnlyDictionary<string, object> Labels { get; }
}
