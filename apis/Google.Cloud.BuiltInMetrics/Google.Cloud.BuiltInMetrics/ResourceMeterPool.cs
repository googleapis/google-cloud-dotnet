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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Caches one <see cref="ResourceMeter"/> per monitored resource because OpenTelemetry fixes each <c>MeterProvider</c> resource at build time.
/// </summary>
internal sealed class ResourceMeterPool : IDisposable
{
    private const int MaxConcurrentFlushes = 16;

    internal static readonly TimeSpan IdleTimeout = TimeSpan.FromSeconds(120);
    private static readonly TimeSpan s_evictionInterval = TimeSpan.FromSeconds(60);
    // Flush meters in parallel with a 10-second export timeout plus 5 seconds of scheduling headroom.
    private static readonly TimeSpan s_disposeTimeout = TimeSpan.FromSeconds(15);

    private readonly IClock _clock;
    private readonly Func<ServiceMetricsConfiguration, IReadOnlyList<string>, ResourceMeter> _createMeter;
    private readonly Timer _evictionTimer;
    private readonly object _lock = new();
    private readonly Dictionary<(ServiceMetricsConfiguration Service, string[] Values), (ResourceMeter Meter, DateTime LastUsedUtc)> _meters =
        new(ResourceKeyComparer.Instance);
    private bool _disposed;

    internal int Count
    {
        get
        {
            lock (_lock)
            {
                return _meters.Count;
            }
        }
    }

    internal ResourceMeterPool(IClock clock, Func<ServiceMetricsConfiguration, IReadOnlyList<string>, ResourceMeter> createMeter)
    {
        _clock = clock;
        _createMeter = createMeter;
        _evictionTimer = new Timer(OnEvictionTimer, null, s_evictionInterval, s_evictionInterval);
    }

    public void Dispose()
    {
        ResourceMeter[] meters;
        lock (_lock)
        {
            if (_disposed)
            {
                return;
            }
            _disposed = true;
            meters = _meters.Values.Select(item => item.Meter).ToArray();
            _meters.Clear();
        }
        _evictionTimer.Dispose();
        FlushAndDisposeAll(meters);
    }

    internal void Record<T>(
        ServiceMetricsConfiguration service, Instrument sourceInstrument, T value, ReadOnlySpan<KeyValuePair<string, object>> labels) where T : struct
    {
        if (!service.TrySplitLabels(labels, out string[] resourceValues, out TagList metricTags))
        {
            return;
        }
        lock (_lock)
        {
            if (!_disposed)
            {
                GetOrCreateMeter(service, resourceValues).Record(sourceInstrument, value, in metricTags);
            }
        }
    }

    internal void EvictIdleEntries()
    {
        DateTime cutoffUtc = _clock.GetCurrentDateTimeUtc() - IdleTimeout;
        ResourceMeter[] idleMeters;
        lock (_lock)
        {
            var idle = _meters.Where(pair => pair.Value.LastUsedUtc <= cutoffUtc).ToArray();
            foreach (var pair in idle)
            {
                // Skip the shutdown export so eviction does not advance the cumulative end time and overlap a recreated series.
                pair.Value.Meter.SkipFinalExport();
                _meters.Remove(pair.Key);
            }
            idleMeters = Array.ConvertAll(idle, static pair => pair.Value.Meter);
        }
        // Dispose outside _lock so recording on active resources never waits on reader shutdown.
        Array.ForEach(idleMeters, static meter => meter.Dispose());
    }

    private ResourceMeter GetOrCreateMeter(ServiceMetricsConfiguration service, string[] resourceValues)
    {
        var key = (service, resourceValues);
        var meter = _meters.TryGetValue(key, out var existing) ? existing.Meter : _createMeter(service, resourceValues);
        _meters[key] = (meter, _clock.GetCurrentDateTimeUtc());
        return meter;
    }

    private static void FlushAndDisposeAll(ResourceMeter[] meters)
    {
        if (meters.Length == 0)
        {
            return;
        }
        var queue = new ConcurrentQueue<ResourceMeter>(meters);
        var tasks = new Task[Math.Min(meters.Length, MaxConcurrentFlushes)];
        // Run off the thread pool because MetricReader.Shutdown blocks synchronously during export.
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Factory.StartNew(
                () =>
                {
                    while (queue.TryDequeue(out var meter))
                    {
                        DisposeMeter(meter);
                    }
                },
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                TaskScheduler.Default);
        }
        Task.WaitAll(tasks, s_disposeTimeout);
    }

    private static void DisposeMeter(ResourceMeter meter)
    {
        try
        {
            meter.Dispose();
        }
        catch
        {
            // Catch inside each worker so a task that outlives s_disposeTimeout cannot fault unobserved.
        }
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
    }

    private sealed class ResourceKeyComparer : IEqualityComparer<(ServiceMetricsConfiguration Service, string[] Values)>
    {
        internal static readonly ResourceKeyComparer Instance = new();

        public bool Equals((ServiceMetricsConfiguration Service, string[] Values) x, (ServiceMetricsConfiguration Service, string[] Values) y) =>
            ReferenceEquals(x.Service, y.Service) && GaxEqualityHelpers.ListsEqual(x.Values, y.Values);

        public int GetHashCode((ServiceMetricsConfiguration Service, string[] Values) key) =>
            GaxEqualityHelpers.CombineHashCodes(key.Service.GetHashCode(), GaxEqualityHelpers.GetListHashCode(key.Values));
    }
}
