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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Entry point for enabling Google Cloud client built-in metrics.
/// </summary>
public static class BuiltInMetrics
{
    private const string MonitoringAuthScope = "https://www.googleapis.com/auth/monitoring.write";

    /// <summary>
    /// The handle returned when <see cref="EnableAsync(BuiltInMetricsOptions, CancellationToken)"/> does not start
    /// collection. Disposing it has no effect.
    /// </summary>
    internal static readonly IDisposable NoOpHandle = new Handle(isNoOp: true);

    // Serializes setup and final handle release. One forwarder serves all active handles.
    private static readonly SemaphoreSlim s_gate = new(1, 1);
    private static MetricForwarder s_forwarder;
    private static GoogleCredential s_credential;
    private static int s_handleCount;

    /// <summary>
    /// Enables built-in metrics collection and starts exporting metrics to Google Cloud Monitoring.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method never throws. It returns a no-op handle if setup fails or the caller cancels
    /// <paramref name="cancellationToken"/>. It also returns a no-op handle if <c>OTEL_SDK_DISABLED</c> is <c>true</c>
    /// or an exporter environment variable is invalid.
    /// </para>
    /// <para>
    /// Each call returns a new handle, and all active handles share one pipeline. Disposing the last active handle
    /// stops collection and exports the final metrics. A call with a different <see cref="GoogleCredential"/>
    /// instance while collection runs returns a no-op handle.
    /// </para>
    /// </remarks>
    /// <param name="options">The options for enabling built-in metrics, or <c>null</c> to use default options.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task whose result is an <see cref="IDisposable"/> handle for the active pipeline.</returns>
    public static Task<IDisposable> EnableAsync(BuiltInMetricsOptions options = null, CancellationToken cancellationToken = default) =>
        EnableAsync(options, GoogleCredential.GetApplicationDefaultAsync, () => new HttpClientHandler(), SystemClock.Instance, cancellationToken);

    internal static async Task<IDisposable> EnableAsync(
        BuiltInMetricsOptions options,
        Func<CancellationToken, Task<GoogleCredential>> getDefaultCredential,
        Func<HttpMessageHandler> handlerFactory,
        IClock clock,
        CancellationToken cancellationToken)
    {
        try
        {
            if (bool.TryParse(Environment.GetEnvironmentVariable("OTEL_SDK_DISABLED"), out bool sdkDisabled) && sdkDisabled)
            {
                return NoOpHandle;
            }
            // GetApplicationDefaultAsync returns a cached instance, so null and explicit ADC match below.
            var credential = options?.GoogleCredential ?? await getDefaultCredential(cancellationToken).ConfigureAwait(false);
            await s_gate.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                if (s_forwarder is null)
                {
                    var scopedCredential = credential.IsCreateScopedRequired ? credential.CreateScoped(MonitoringAuthScope) : credential;
                    var handler = handlerFactory();
                    try
                    {
                        CheckExporterSettings(handler, scopedCredential);
                        s_forwarder = new MetricForwarder(ServiceMetricsConfiguration.All, handler, scopedCredential, clock);
                    }
                    catch
                    {
                        handler.Dispose();
                        throw;
                    }
                    s_credential = credential;
                }
                else if (!ReferenceEquals(credential, s_credential))
                {
                    return NoOpHandle;
                }
                s_handleCount++;
                return new Handle(isNoOp: false);
            }
            finally
            {
                s_gate.Release();
            }
        }
        catch
        {
            // Built-in metrics must never break the application.
            return NoOpHandle;
        }
    }

    // Validate OTEL_* exporter environment variables once at setup instead of failing on each measurement.
    private static void CheckExporterSettings(HttpMessageHandler handler, ITokenAccessWithHeaders credential)
    {
        using var httpClient = new HttpClient(handler, disposeHandler: false);
        using var exporter = new AuthorizingOtlpMetricExporter(httpClient, credential);
    }

    private static void Release()
    {
        s_gate.Wait();
        try
        {
            if (--s_handleCount == 0)
            {
                var forwarder = s_forwarder;
                s_forwarder = null;
                s_credential = null;
                // Dispose under the gate so a new forwarder cannot start a series during final export.
                forwarder?.Dispose();
            }
        }
        catch
        {
            // Built-in metrics must never break the application.
        }
        finally
        {
            s_gate.Release();
        }
    }

    private sealed class Handle : IDisposable
    {
        private int _disposed;

        internal Handle(bool isNoOp) => _disposed = isNoOp ? 1 : 0;

        public void Dispose()
        {
            if (Interlocked.Exchange(ref _disposed, 1) == 0)
            {
                Release();
            }
        }
    }
}
