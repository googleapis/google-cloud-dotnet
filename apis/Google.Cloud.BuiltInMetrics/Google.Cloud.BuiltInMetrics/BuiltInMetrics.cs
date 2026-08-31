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

using Google.Apis.Auth.OAuth2;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Enables built-in metrics for Google Cloud client libraries.
/// </summary>
public static class BuiltInMetrics
{
    internal static readonly IDisposable NoOpHandle = new ReporterHandle(session: null);

    private static readonly SemaphoreSlim s_reporterGate = new(1, 1);
    private static ReporterSession s_activeSession;

    /// <summary>
    /// Starts collecting built-in metrics and exporting them to Google Cloud Monitoring.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method never throws. It returns a no-op handle if setup fails, the caller cancels
    /// <paramref name="cancellationToken"/>, or <c>OTEL_SDK_DISABLED</c> is <c>true</c>.
    /// </para>
    /// <para>
    /// All active handles share one reporter. Disposing the last active handle exports the final metrics
    /// and stops the reporter. A call with a different <see cref="GoogleCredential"/> instance while
    /// the reporter runs returns a no-op handle.
    /// </para>
    /// </remarks>
    /// <param name="options">The options to use, or <c>null</c> to use default options.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task whose result is an <see cref="IDisposable"/> handle for the reporter.</returns>
    public static Task<IDisposable> EnableAsync(BuiltInMetricsOptions options = null, CancellationToken cancellationToken = default) =>
        EnableAsync(options, GoogleCredential.GetApplicationDefaultAsync, MetricReporter.StartAsync, cancellationToken);

    internal static async Task<IDisposable> EnableAsync(
        BuiltInMetricsOptions options,
        Func<CancellationToken, Task<GoogleCredential>> getDefaultCredential,
        Func<GoogleCredential, CancellationToken, Task<IDisposable>> startReporter,
        CancellationToken cancellationToken)
    {
        try
        {
            if (IsOpenTelemetrySdkDisabled())
            {
                return NoOpHandle;
            }
            var credential = options?.GoogleCredential ?? await getDefaultCredential(cancellationToken).ConfigureAwait(false);
            return await AcquireReporterHandleAsync(credential, startReporter, cancellationToken).ConfigureAwait(false);
        }
        catch
        {
            return NoOpHandle;
        }
    }

    private static async Task<IDisposable> AcquireReporterHandleAsync(
        GoogleCredential credential,
        Func<GoogleCredential, CancellationToken, Task<IDisposable>> startReporter,
        CancellationToken cancellationToken)
    {
        await s_reporterGate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (s_activeSession is null)
            {
                var reporter = await startReporter(credential, cancellationToken).ConfigureAwait(false);
                s_activeSession = new ReporterSession(credential, reporter);
            }
            // GetApplicationDefaultAsync caches one instance per process, so repeated default calls return the same reference.
            else if (!ReferenceEquals(credential, s_activeSession.Credential))
            {
                return NoOpHandle;
            }
            s_activeSession.RefCount++;
            return new ReporterHandle(s_activeSession);
        }
        finally
        {
            s_reporterGate.Release();
        }
    }

    private static bool IsOpenTelemetrySdkDisabled() =>
        bool.TryParse(Environment.GetEnvironmentVariable("OTEL_SDK_DISABLED"), out bool disabled) && disabled;

    private sealed class ReporterSession(GoogleCredential credential, IDisposable reporter)
    {
        internal GoogleCredential Credential { get; } = credential;
        internal int RefCount { get; set; }

        internal void Release()
        {
            s_reporterGate.Wait();
            try
            {
                if (--RefCount == 0)
                {
                    s_activeSession = null;
                    // Dispose under s_reporterGate so a new reporter cannot start before the final export finishes.
                    reporter.Dispose();
                }
            }
            catch
            {
                // Never throw from Dispose during application shutdown.
            }
            finally
            {
                s_reporterGate.Release();
            }
        }
    }

    private sealed class ReporterHandle(ReporterSession session) : IDisposable
    {
        private ReporterSession _session = session;

        public void Dispose() => Interlocked.Exchange(ref _session, null)?.Release();
    }
}
