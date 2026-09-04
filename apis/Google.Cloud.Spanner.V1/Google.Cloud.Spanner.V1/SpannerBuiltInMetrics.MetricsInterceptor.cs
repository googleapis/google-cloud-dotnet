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

using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Intercepts gRPC calls to record attempt-level metrics.
    /// </summary>
    /// <remarks>
    /// ClientStreaming and Duplex streaming are explicitly not instrumented, no methods currently use these protocols.
    /// </remarks>
    internal class MetricsInterceptor(ClientIdentity clientIdentity, IStopwatchProvider stopwatchProvider = null) : Interceptor
    {
        private const string ServerTimingHeader = "server-timing";
        private const string GfeMetricPrefix = "gfet4t7";

        private readonly ClientIdentity _clientIdentity = clientIdentity;
        private readonly IStopwatchProvider _stopwatchProvider = stopwatchProvider ?? DefaultStopwatchProvider.Instance;

        /// <inheritdoc/>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            if (request is not IDatabaseNameProvider dbNameProvider)
            {
                return continuation(request, context);
            }

            AsyncUnaryCall<TResponse> call;
            IStopwatch stopwatch = _stopwatchProvider.StartNew();
            try
            {
                call = continuation(request, context);
                return new AsyncUnaryCall<TResponse>(
                    InstrumentCallAsync(),
                    call.ResponseHeadersAsync,
                    call.GetStatus,
                    call.GetTrailers,
                    call.Dispose);
            }
            catch (Exception ex)
            {
                double elapsedMs = stopwatch.ElapsedMilliseconds;
                // No headers are available if continuation fails, but we can record status (if RpcException) and latency.
                // An RpcException here is unexpected but defensively handled in case a previous interceptor throws it.
                string status = ex is RpcException rpcEx ? rpcEx.StatusCode.ToString() : s_statusUnknown;
                RecordAttemptMetrics(elapsedMs, context.Method.Name, dbNameProvider, status, _clientIdentity);
                throw;
            }

            async Task<TResponse> InstrumentCallAsync()
            {
                double elapsedMs = 0;
                try
                {
                    return await call.ResponseAsync.ConfigureAwait(false);
                }
                finally
                {
                    elapsedMs = stopwatch.ElapsedMilliseconds;
                    var statusString = call.GetStatus().StatusCode.ToString() ?? s_statusUnknown;
                    var labels = Labeler.GetLabels(context.Method.Name, dbNameProvider, statusString, _clientIdentity);
                    RecordAttemptMetrics(elapsedMs, labels);
                    await RecordServerTimingMetricsAsync(call.ResponseHeadersAsync, labels).ConfigureAwait(false);
                }
            }
        }

        /// <inheritdoc/>
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            if (request is not IDatabaseNameProvider dbNameProvider)
            {
                return continuation(request, context);
            }

            IStopwatch stopwatch = _stopwatchProvider.StartNew();
            string status = s_statusOk;
            double elapsedMs;
            try
            {
                return continuation(request, context);
            }
            catch (Exception ex)
            {
                elapsedMs = stopwatch.ElapsedMilliseconds;
                // Synchronous calls do not expose GetStatus(), making this exception the only way to retrieve the status on failure.
                status = ex is RpcException rpcEx ? rpcEx.StatusCode.ToString() : s_statusUnknown;
                throw;
            }
            finally
            {
                elapsedMs = stopwatch.ElapsedMilliseconds;
                // We bypass GFE metrics since blocking gRPC calls don't natively expose response headers.
                RecordAttemptMetrics(elapsedMs, context.Method.Name, dbNameProvider, status, _clientIdentity);
            }
        }

        /// <summary>
        /// Methods whose overarching operation metrics are tracked by the high-level <see cref="ResultStream"/>
        /// wrapper across transparent resumes and retries, rather than at the individual RPC attempt layer.
        /// </summary>
        private static readonly HashSet<string> s_resultStreamTrackedMethods = new HashSet<string>(StringComparer.Ordinal)
        {
            "ExecuteStreamingSql",
            "StreamingRead"
        };

        /// <inheritdoc/>
        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            if (request is not IDatabaseNameProvider dbNameProvider)
            {
                return continuation(request, context);
            }

            IStopwatch stopwatch = _stopwatchProvider.StartNew();
            AsyncServerStreamingCall<TResponse> call;
            try
            {
                call = continuation(request, context);
            }
            catch (Exception ex)
            {
                double elapsedMs = stopwatch.ElapsedMilliseconds;
                string status = ex is RpcException rpcEx ? rpcEx.StatusCode.ToString() : s_statusUnknown;
                RecordAttemptMetrics(elapsedMs, context.Method.Name, dbNameProvider, status, _clientIdentity);
                throw;
            }

            var instrumentedStreamReader = new InstrumentedAsyncStreamReader<TResponse>(
                call.ResponseStream,
                stopwatch,
                (elapsedMs, status) =>
                {
                    var labels = Labeler.GetLabels(context.Method.Name, dbNameProvider, status, _clientIdentity);
                    RecordAttemptMetrics(elapsedMs, labels);

                    // Single-shot streaming calls (e.g. BatchWrite, FetchCacheUpdate) do not use ResultStream retry
                    // logic, so their operation metrics map directly 1:1 to their single RPC attempt.
                    if (!s_resultStreamTrackedMethods.Contains(context.Method.Name))
                    {
                        RecordOperationMetrics(elapsedMs, labels);
                    }
                    _ = RecordServerTimingMetricsAsync(call.ResponseHeadersAsync, labels);
                });

            return new AsyncServerStreamingCall<TResponse>(
                instrumentedStreamReader,
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                () =>
                {
                    instrumentedStreamReader.OnDispose(call.GetStatus);
                    call.Dispose();
                });
        }

        internal static async Task RecordServerTimingMetricsAsync(Task<Metadata> headersTask, KeyValuePair<string, object>[] labels)
        {
            try
            {
                if (headersTask == null)
                {
                    return;
                }

                var headers = await headersTask.ConfigureAwait(false);
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

            static void RecordServerTimingMetrics(string header, string metricPrefix, Action<double> recordAction)
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
        }
    }
}
