// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Contains the built-in metrics declarations and metric label extraction logic for the Spanner client.
/// </summary>
internal static partial class SpannerBuiltInMetrics
{
    private const string ServerTimingHeader = "server-timing";
    private const string GfeMetricPrefix = "gfet4t7";

    /// <summary>
    /// The name of the meter used for Spanner built-in metrics.
    /// </summary>
    internal const string MeterName = "Google.Cloud.Spanner.BuiltInMetrics";

    // Metric name constants
    private const string OperationCountName = "operation_count";
    private const string OperationLatenciesName = "operation_latencies";
    private const string AttemptCountName = "attempt_count";
    private const string AttemptLatenciesName = "attempt_latencies";
    private const string GfeLatenciesName = "gfe_latencies";
    private const string GfeConnectivityErrorCountName = "gfe_connectivity_error_count";

    /// <summary>
    /// The meter instance for Spanner client telemetry.
    /// </summary>
    internal static readonly Meter s_spannerMeter = new Meter(MeterName);

    // Metric instrument instances
    internal static readonly Counter<long> s_operationCounter = s_spannerMeter.CreateCounter<long>(OperationCountName);
    internal static readonly Histogram<double> s_operationLatency = s_spannerMeter.CreateHistogram<double>(OperationLatenciesName);
    internal static readonly Counter<long> s_attemptCounter = s_spannerMeter.CreateCounter<long>(AttemptCountName);
    internal static readonly Histogram<double> s_attemptLatency = s_spannerMeter.CreateHistogram<double>(AttemptLatenciesName);
    internal static readonly Histogram<double> s_gfeLatency = s_spannerMeter.CreateHistogram<double>(GfeLatenciesName);
    internal static readonly Counter<long> s_gfeConnectivityErrorCounter = s_spannerMeter.CreateCounter<long>(GfeConnectivityErrorCountName);

    /// <summary>
    /// Records attempt-level metrics including count and latency.
    /// </summary>
    /// <param name="latencyMs">The elapsed duration of the attempt in milliseconds.</param>
    /// <param name="methodName">The name of the gRPC method invoked.</param>
    /// <param name="dbNameProvider">The provider holding database context details.</param>
    /// <param name="status">The resolved status of the attempt.</param>
    /// <param name="clientIdentity">The identity context for the client executing the attempt.</param>
    internal static void RecordAttemptMetrics(double latencyMs, string methodName, IDatabaseNameProvider dbNameProvider, StatusCode status, ClientIdentity clientIdentity)
    {
        try
        {
            var labels = Labeler.GetLabels(methodName, dbNameProvider, status, clientIdentity);
            RecordAttemptMetrics(latencyMs, labels);
        }
        catch
        {
            // Silently swallow exceptions.
        }
    }

    /// <summary>
    /// Records attempt-level metrics including count and latency.
    /// </summary>
    /// <param name="latencyMs">The elapsed duration of the attempt in milliseconds.</param>
    /// <param name="labels">The metric labels to apply to the measurement.</param>
    internal static void RecordAttemptMetrics(double latencyMs, KeyValuePair<string, object>[] labels)
    {
        try
        {
            s_attemptCounter.Add(1, labels);
            s_attemptLatency.Record(latencyMs, labels);
        }
        catch
        {
            // Silently swallow exceptions.
        }
    }

    /// <summary>
    /// Records server-timing metrics asynchronously when the response headers task resolves.
    /// </summary>
    internal static async Task RecordServerTimingMetricsAsync(Task<Metadata> headersTask, KeyValuePair<string, object>[] labels)
    {
        try
        {
            if (headersTask == null)
            {
                return;
            }

            var headers = await headersTask.ConfigureAwait(false);
            RecordServerTimingMetrics(headers, labels);
        }
        catch
        {
            // Silently swallow exceptions.
        }
    }

    /// <summary>
    /// Records server-timing metrics (such as GFE latency) from response headers.
    /// </summary>
    internal static void RecordServerTimingMetrics(Metadata headers, KeyValuePair<string, object>[] labels)
    {
        try
        {
            if (headers == null)
            {
                return;
            }

            foreach (var header in headers.Where(h => string.Equals(h.Key, ServerTimingHeader, StringComparison.OrdinalIgnoreCase)))
            {
                RecordServerTimingMetrics(header.Value, GfeMetricPrefix, duration => s_gfeLatency.Record(duration, labels));
                // TODO: Record AFE timing metrics when they are enabled
            }
        }
        catch
        {
            // Silently swallow exceptions.
        }
    }

    internal static void RecordServerTimingMetrics(string header, string metricPrefix, Action<double> recordAction)
    {
        if (string.IsNullOrEmpty(header))
        {
            return;
        }

        int currentStart = 0;
        do
        {
            // Find the first occurrence of the metric from the point we are at.
            int metricIndex = header.IndexOf(metricPrefix, currentStart);
            if (metricIndex < 0)
            {
                return;
            }
            // Ensure the matched metric name starts at a boundary (preceded by start of string, comma, or whitespace).
            // Avoids matching substrings inside other metric names (e.g. "not_gfet4t7; dur=99").
            if (metricIndex > 0 && header[metricIndex - 1] != ',' && !char.IsWhiteSpace(header[metricIndex - 1]))
            {
                currentStart = metricIndex + metricPrefix.Length;
                continue;
            }
            // Move past the first occurennce of the metric.
            currentStart = metricIndex + metricPrefix.Length;
            // Find the first of "dur" or ",".
            bool durMissing = true;
            // We don't need to continue when we have less than 3 characters left.
            for (int i = currentStart; i < header.Length - 2; i++)
            {
                // This signals the end of the metric, so we didn't find 'dur'.
                // We move past this position and attempt to find another occurrence of the metric.
                if (header[i] == ',')
                {
                    currentStart = i + 1;
                    break;
                }
                // We found 'dur'.
                // We move past 'dur' so we can now extract the associated value.
                if (header[i] == 'd' && header[i+1] == 'u' && header[i+2] == 'r')
                {
                    durMissing = false;
                    currentStart = i + 3;
                    break;
                }
            }
            if (durMissing)
            {
                continue;
            }
            // If we are here, we found 'dur' and we now need to extract the associated value.
            // Go past '=' from the point we are at.
            int equalIndex = header.IndexOf('=', currentStart);
            currentStart = equalIndex + 1;
            // The metric value.
            double duration = 0;
            bool hasDigits = false;
            // We use these to build the number as we parse it.
            // Before we find the decimal separator, we multiply our accumulator by 10 for every digit.
            // But after finding the decimal separator, we'll multiply our accumulator by 1 for every digit.
            double integerMultiplier = 10;
            // Before we find the decimal separator, we have no fractional part so each digit is divided by 1.
            // After we find the decimal separator, we have to divide each digit by incremental powers of ten.
            double fractionalDividend = 1;
            double fractionalDividendModifier = 1;
            for (; currentStart < header.Length; currentStart++)
            {
                // Skip spaces, at the beginning and also at the end,
                // because it's just easier to not make the distinction.
                if (char.IsWhiteSpace(header[currentStart]))
                {
                    continue;
                }
                // If we find the decimal point, swap to fractional places.
                if (header[currentStart] == '.')
                {
                    integerMultiplier = 1;
                    fractionalDividend = 10;
                    fractionalDividendModifier = 10;
                }
                // Consume the digits and add them to our accumulator
                else if (char.IsDigit(header, currentStart))
                {
                    hasDigits = true;
                    double digit = char.GetNumericValue(header, currentStart);
                    duration = (duration * integerMultiplier) + (digit / fractionalDividend);
                    fractionalDividend *= fractionalDividendModifier;
                }
                // For any other character, we are done finding the value.
                else
                {
                    break;
                }
            }
            // Ensure at least one numeric digit was parsed before recording the metric.
            // Avoids recording default 0 for invalid non-numeric durations (e.g. "gfet4t7; dur=invalid").
            if (hasDigits)
            {
                recordAction(duration);
            }
        } while (currentStart < header.Length);
    }

    /// <summary>
    /// Helper class to extract and generate resource tags and metric labels.
    /// </summary>
    internal static class Labeler
    {
        private const string MethodLabelName = "method";
        private const string StatusLabelName = "status";
        private const string ClientUidLabelName = "client_uid";
        private const string LocationLabelName = "location";
        private const string ClientNameLabelName = "client_name";
        private const string InstanceConfigLabelName = "instance_config";
        private const string DirectPathEnabledLabelName = "directpath_enabled";
        private const string DirectPathUsedLabelName = "directpath_used";
        private const string ProjectIdLabelName = "project_id";
        private const string InstanceIdLabelName = "instance_id";
        private const string DatabaseLabelName = "database";
        private const string ClientHashLabelName = "client_hash";
        private const string UnknownLabelValue = "unknown";
        private const string GlobalLocationValue = "global";

        private static readonly Lazy<string> s_cachedLocation = new Lazy<string>(ResolveLocationUncached);
        private static readonly Lazy<string> s_cachedClientName = new Lazy<string>(GetClientNameUncached);

        // Instance config is not fetched by the client to avoid latency from extra Admin API calls.
        private static readonly KeyValuePair<string, object> s_instanceConfigLabel = new(InstanceConfigLabelName, UnknownLabelValue);

        // DirectPath is not supported by the .NET Cloud SDK.
        private static readonly KeyValuePair<string, object> s_directPathEnabledLabel = new(DirectPathEnabledLabelName, "false");
        private static readonly KeyValuePair<string, object> s_directPathUsedLabel = new(DirectPathUsedLabelName, "false");

        /// <summary>
        /// Records operation count and latency metrics.
        /// </summary>
        /// <param name="latencyMs">The elapsed duration of the operation in milliseconds.</param>
        /// <param name="methodName">The name of the gRPC method invoked.</param>
        /// <param name="dbNameProvider">The provider holding database context details.</param>
        /// <param name="status">The resolved status of the operation.</param>
        /// <param name="clientIdentity">The identity context for the client executing the operation.</param>
        internal static void RecordOperationMetrics(double latencyMs, string methodName, IDatabaseNameProvider dbNameProvider, StatusCode status, ClientIdentity clientIdentity)
        {
            try
            {
                var labels = Labeler.GetLabels(methodName, dbNameProvider, status, clientIdentity);
                RecordOperationMetrics(latencyMs, labels);
            }
            catch
            {
                // Silently swallow exceptions.
            }
        }

        /// <summary>
        /// Records operation count and latency metrics.
        /// </summary>
        /// <param name="latencyMs">The elapsed duration of the operation in milliseconds.</param>
        /// <param name="labels">The metric labels to apply to the measurement.</param>
        internal static void RecordOperationMetrics(double latencyMs, KeyValuePair<string, object>[] labels)
        {
            try
            {
                s_operationCounter.Add(1, labels);
                s_operationLatency.Record(latencyMs, labels);
            }
            catch
            {
                // Silently swallow exceptions.
            }
        }

        /// <summary>
        /// Generates the standard set of labels for a metric measurement.
        /// </summary>
        /// <param name="method">The RPC method name.</param>
        /// <param name="provider">The provider used to extract the database name properties.</param>
        /// <param name="status">The status of the operation or attempt.</param>
        /// <param name="clientIdentity">The identity information of the client instance.</param>
        /// <returns>An array of metric labels.</returns>
        internal static KeyValuePair<string, object>[] GetLabels(
            string method,
            IDatabaseNameProvider provider,
            StatusCode status,
            ClientIdentity clientIdentity) => [
                new KeyValuePair<string, object>(ProjectIdLabelName, provider?.ProjectId ?? UnknownLabelValue),
                new KeyValuePair<string, object>(InstanceIdLabelName, provider?.InstanceId ?? UnknownLabelValue),
                new KeyValuePair<string, object>(DatabaseLabelName, provider?.DatabaseId ?? UnknownLabelValue),
                new KeyValuePair<string, object>(ClientHashLabelName, clientIdentity.Hash),
                new KeyValuePair<string, object>(MethodLabelName, method),
                new KeyValuePair<string, object>(StatusLabelName, status.ToString()),
                new KeyValuePair<string, object>(ClientUidLabelName, clientIdentity.Id),
                new KeyValuePair<string, object>(ClientNameLabelName, s_cachedClientName.Value),
                new KeyValuePair<string, object>(LocationLabelName, s_cachedLocation.Value),
                s_instanceConfigLabel,
                s_directPathEnabledLabel,
                s_directPathUsedLabel,
            ];

        /// <summary>
        /// Resolves the compute location of the current environment (e.g., GKE, GCE, Cloud Run).
        /// Returns "global" if the location cannot be determined.
        /// </summary>
        private static string ResolveLocationUncached()
        {
            try
            {
                var platform = Platform.Instance();
                return platform.Type switch
                {
                    PlatformType.Gke => platform.GkeDetails?.Location ?? GlobalLocationValue,
                    PlatformType.Gce => platform.GceDetails?.Location ?? GlobalLocationValue,
                    PlatformType.CloudRun => platform.CloudRunDetails?.Region ?? GlobalLocationValue,
                    PlatformType.CloudRunJob => platform.CloudRunJobDetails?.Region ?? GlobalLocationValue,
                    _ => GlobalLocationValue
                };
            }
            catch
            {
                return GlobalLocationValue;
            }
        }

        /// <summary>
        /// Determines the name and version of the client library.
        /// </summary>
        private static string GetClientNameUncached()
        {
            try
            {
                // Assembly.GetName().Version is practically never null in standard compiled .NET
                // assemblies, but we provide "unknown" as a defensive fallback.
                var version = typeof(SpannerClient).Assembly.GetName().Version?.ToString() ?? UnknownLabelValue;
                return $"spanner-dotnet/{version}";
            }
            catch
            {
                // We do not expect to ever reach here, but we are being defensive.
                return "spanner-dotnet/unknown";
            }
        }

        /// <summary>
        /// Generates the built-in metrics client identity used to tag telemetry data.
        /// </summary>
        internal static ClientIdentity GenerateIdentity()
        {
            var clientId = Guid.NewGuid().ToString();

            // Compute FNV-1a 64-bit hash.
            // https://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function#FNV-1a_hash
            ulong hash = 14695981039346656037UL;
            foreach (char c in clientId)
            {
                hash = (hash ^ c) * 1099511628211UL;
            }

            // Extract the top 10 bits and format as a 6-character hex string.
            string reducedHash = ((int) (hash >> 54)).ToString("x6");
            return new ClientIdentity(clientId, reducedHash);
        }
    }

    /// <summary>
    /// Represents the unique identity of a client, including its ID and generated hash.
    /// </summary>
    internal readonly struct ClientIdentity
    {
        /// <summary>
        /// Constructs a new <see cref="ClientIdentity"/>.
        /// </summary>
        /// <param name="id">The unique client ID.</param>
        /// <param name="hash">The generated hash of the client ID.</param>
        internal ClientIdentity(string id, string hash)
        {
            Id = id;
            Hash = hash;
        }

        /// <summary>
        /// Gets the unique client ID.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the hash of the client ID.
        /// </summary>
        public string Hash { get; }
    }

    /// <summary>
    /// A stopwatch to measure elapesed time.
    /// </summary>
    internal interface IStopwatch
    {
        /// <summary>
        /// Gets the total elapsed time measured by the stopwatch, in milliseconds.
        /// </summary>
        double ElapsedMilliseconds { get; }

        /// <summary>
        /// Stops measuring elapsed time for an interval.
        /// </summary>
        void Stop();
    }

    /// <summary>
    /// A provider that generates new <see cref="IStopwatch"/> instances.
    /// </summary>
    internal interface IStopwatchProvider
    {
        /// <summary>
        /// Initializes and starts a new <see cref="IStopwatch"/>.
        /// </summary>
        /// <returns>A new, running stopwatch.</returns>
        IStopwatch StartNew();
    }

    /// <summary>
    /// The default implementation of <see cref="IStopwatchProvider"/> utilizing <see cref="Stopwatch"/>.
    /// </summary>
    internal sealed class DefaultStopwatchProvider : IStopwatchProvider
    {
        /// <summary>
        /// The singleton instance of the default stopwatch provider.
        /// </summary>
        public static readonly DefaultStopwatchProvider Instance = new();

        /// <inheritdoc/>
        public IStopwatch StartNew() => new StopwatchWrapper(Stopwatch.StartNew());

        /// <inheritdoc/>
        private class StopwatchWrapper(Stopwatch stopwatch) : IStopwatch
        {
            /// <inheritdoc/>
            public double ElapsedMilliseconds => stopwatch.Elapsed.TotalMilliseconds;

            /// <inheritdoc/>
            public void Stop() => stopwatch.Stop();
        }
    }
}
