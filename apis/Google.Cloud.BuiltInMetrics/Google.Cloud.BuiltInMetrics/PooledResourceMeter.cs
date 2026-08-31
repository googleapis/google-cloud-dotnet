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
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Threading;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Wraps a <see cref="ResourceMeter"/> in <see cref="ResourceMeterPool"/> and coordinates lock-free recording with idle eviction.
/// </summary>
internal sealed class PooledResourceMeter : IDisposable
{
    private readonly ResourceMeter _meter;
    private readonly IClock _clock;
    private long _lastUsedTicks;
    private int _inFlight;
    private int _closing;

    internal PooledResourceMeter(ResourceMeter meter, IClock clock)
    {
        _meter = GaxPreconditions.CheckNotNull(meter, nameof(meter));
        _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
        _lastUsedTicks = _clock.GetCurrentDateTimeUtc().Ticks;
    }

    /// <summary>
    /// Records a measurement when this entry is open, or returns <c>false</c> when eviction closes it.
    /// </summary>
    internal bool TryRecord<T>(Instrument source, T value, in TagList tags) where T : struct
    {
        Interlocked.Increment(ref _inFlight);
        try
        {
            if (Volatile.Read(ref _closing) != 0)
            {
                return false;
            }
            Volatile.Write(ref _lastUsedTicks, _clock.GetCurrentDateTimeUtc().Ticks);
            _meter.Record(source, value, in tags);
            return true;
        }
        finally
        {
            Interlocked.Decrement(ref _inFlight);
        }
    }

    /// <summary>
    /// Closes this entry for idle eviction when no measurement arrived after <paramref name="cutoffTicks"/>.
    /// </summary>
    internal bool TryClose(long cutoffTicks)
    {
        if (Volatile.Read(ref _lastUsedTicks) > cutoffTicks)
        {
            return false;
        }
        Interlocked.Exchange(ref _closing, 1);
        var spinWait = new SpinWait();
        while (Volatile.Read(ref _inFlight) != 0)
        {
            spinWait.SpinOnce();
        }
        // A measurement that entered before TryClose set _closing may have refreshed _lastUsedTicks.
        if (Volatile.Read(ref _lastUsedTicks) > cutoffTicks)
        {
            Volatile.Write(ref _closing, 0);
            return false;
        }
        _meter.DisableExport();
        return true;
    }

    /// <inheritdoc />
    public void Dispose() => _meter.Dispose();
}
