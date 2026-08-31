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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Pools one <see cref="PooledResourceMeter"/> for each monitored resource and evicts idle entries.
/// </summary>
/// <remarks>
/// OpenTelemetry fixes the resource of a meter provider at build time, so each monitored resource gets its own entry.
/// </remarks>
internal sealed class ResourceMeterPool : IDisposable
{
    internal static readonly TimeSpan IdleTimeout = TimeSpan.FromSeconds(120);
    // Entries flush in parallel with a 10-second export timeout plus 5 seconds of scheduling headroom.
    private static readonly TimeSpan s_disposeTimeout = TimeSpan.FromSeconds(15);

    private readonly HttpMessageHandler _handler;
    private readonly ITokenAccessWithHeaders _credential;
    private readonly IClock _clock;
    private readonly Timer _evictionTimer;
    private readonly ConcurrentDictionary<ResourceKey, PooledResourceMeter> _entries = new();
    private readonly object _creationLock = new();
    private bool _disposed;

    internal ResourceMeterPool(HttpMessageHandler handler, ITokenAccessWithHeaders credential, IClock clock)
    {
        _handler = GaxPreconditions.CheckNotNull(handler, nameof(handler));
        _credential = GaxPreconditions.CheckNotNull(credential, nameof(credential));
        _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
        _evictionTimer = new Timer(OnEvictionTimer, null, ResourceMeter.ExportInterval, Timeout.InfiniteTimeSpan);
    }

    internal int Count => _entries.Count;

    internal void Record<T>(ResourceKey key, Instrument source, T value, in TagList tags) where T : struct
    {
        var entry = _entries.TryGetValue(key, out var existing) ? existing : GetOrCreate(key);
        while (entry is not null && !entry.TryRecord(source, value, in tags))
        {
            // The entry is closing for eviction. Wait under the lock and get the replacement entry.
            entry = GetOrCreate(key);
        }
    }

    private PooledResourceMeter GetOrCreate(ResourceKey key)
    {
        lock (_creationLock)
        {
            if (_disposed)
            {
                return null;
            }
            if (!_entries.TryGetValue(key, out var entry))
            {
                entry = new PooledResourceMeter(ResourceMeter.Create(key, _handler, _credential), _clock);
                _entries[key] = entry;
            }
            return entry;
        }
    }

    /// <summary>
    /// Evicts entries that received no measurements for <see cref="IdleTimeout"/>.
    /// </summary>
    internal void EvictIdleEntries()
    {
        long cutoffTicks = (_clock.GetCurrentDateTimeUtc() - IdleTimeout).Ticks;
        var evicted = new List<PooledResourceMeter>();
        lock (_creationLock)
        {
            if (_disposed)
            {
                return;
            }
            foreach (var pair in _entries)
            {
                if (pair.Value.TryClose(cutoffTicks))
                {
                    ((ICollection<KeyValuePair<ResourceKey, PooledResourceMeter>>) _entries).Remove(pair);
                    evicted.Add(pair.Value);
                }
            }
        }
        // Dispose outside the lock so new resources do not wait on eviction shutdown.
        DisposeAll(evicted);
    }

    private void OnEvictionTimer(object state)
    {
        try
        {
            EvictIdleEntries();
        }
        catch
        {
            // An unhandled exception on a timer thread stops the process.
        }
        // Reschedule after the pass finishes so eviction passes never overlap.
        lock (_creationLock)
        {
            if (!_disposed)
            {
                _evictionTimer.Change(ResourceMeter.ExportInterval, Timeout.InfiniteTimeSpan);
            }
        }
    }

    private static void DisposeAll(IReadOnlyCollection<PooledResourceMeter> entries)
    {
        if (entries.Count == 0)
        {
            return;
        }
        try
        {
            Task.WaitAll(entries.Select(entry => Task.Run(entry.Dispose)).ToArray(), s_disposeTimeout);
        }
        catch (AggregateException)
        {
            // A failed dispose loses only the final metrics of that entry.
        }
    }

    /// <summary>
    /// Stops idle eviction, exports remaining metrics from pooled entries, and disposes the shared transport.
    /// </summary>
    public void Dispose()
    {
        PooledResourceMeter[] entries;
        lock (_creationLock)
        {
            if (_disposed)
            {
                return;
            }
            _disposed = true;
            entries = _entries.Values.ToArray();
            _entries.Clear();
        }
        // Wait for any running eviction pass before disposing the shared handler.
        using (var timerDisposed = new ManualResetEvent(false))
        {
            if (_evictionTimer.Dispose(timerDisposed))
            {
                timerDisposed.WaitOne();
            }
        }
        DisposeAll(entries);
        // If DisposeAll timed out, OpenTelemetry catches ObjectDisposedException from late exports.
        _handler.Dispose();
    }
}
