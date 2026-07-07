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
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Contains the built-in metrics declarations and metric label extraction logic for the Spanner client.
/// </summary>
internal static partial class SpannerBuiltInMetrics
{
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
            string status,
            ClientIdentity clientIdentity) => [
                new KeyValuePair<string, object>(ProjectIdLabelName, provider?.ProjectId ?? UnknownLabelValue),
                new KeyValuePair<string, object>(InstanceIdLabelName, provider?.InstanceId ?? UnknownLabelValue),
                new KeyValuePair<string, object>(DatabaseLabelName, provider?.DatabaseId ?? UnknownLabelValue),
                new KeyValuePair<string, object>(ClientHashLabelName, clientIdentity.Hash),
                new KeyValuePair<string, object>(MethodLabelName, method),
                new KeyValuePair<string, object>(StatusLabelName, status),
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
}
