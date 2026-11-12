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
using OpenTelemetry;
using OpenTelemetry.Exporter;
using OpenTelemetry.Metrics;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// An OTLP exporter that sends metrics to <c>telemetry.googleapis.com</c> using a Google credential.
/// </summary>
/// <remarks>
/// The base exporter calls synchronous <c>HttpClient.Send</c> on modern .NET runtimes, so a delegating handler cannot
/// intercept exports across all target frameworks. Instead, this exporter updates default request headers before each
/// export. Each <see cref="MetricReader"/> serializes its exports, so no request runs while headers change.
/// </remarks>
internal sealed class AuthorizingOtlpMetricExporter : OtlpMetricExporter
{
    private static readonly Uri s_endpoint = new("https://telemetry.googleapis.com/v1/metrics");

    internal static readonly TimeSpan ExportTimeout = TimeSpan.FromSeconds(10);

    private readonly HttpClient _httpClient;
    private readonly ITokenAccessWithHeaders _credential;
    private volatile bool _skipExport;

    internal AuthorizingOtlpMetricExporter(HttpClient httpClient, ITokenAccessWithHeaders credential)
        : base(CreateOptions(GaxPreconditions.CheckNotNull(httpClient, nameof(httpClient))))
    {
        _httpClient = httpClient;
        _credential = GaxPreconditions.CheckNotNull(credential, nameof(credential));
    }

    /// <summary>
    /// When <c>true</c>, exports return <see cref="ExportResult.Success"/> without sending requests.
    /// Eviction sets this so a final export cannot advance a cumulative series end time past a recreated entry.
    /// </summary>
    internal bool SkipExport
    {
        get => _skipExport;
        set => _skipExport = value;
    }

    /// <inheritdoc />
    public override ExportResult Export(in Batch<Metric> metrics)
    {
        if (_skipExport || metrics.Count == 0)
        {
            return ExportResult.Success;
        }

        try
        {
            AccessTokenWithHeaders token = Task.Run(GetTokenAsync).ResultWithUnwrappedExceptions();
            var headers = _httpClient.DefaultRequestHeaders;
            // OtlpExportClient sets its own headers per request, so DefaultRequestHeaders holds only credential headers.
            headers.Clear();
            token.AddHeaders(headers);
            headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        }
        catch
        {
            return ExportResult.Failure;
        }
        return base.Export(metrics);
    }

    /// <inheritdoc />
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Shutdown(0);
        }
        base.Dispose(disposing);
    }

    private async Task<AccessTokenWithHeaders> GetTokenAsync()
    {
        using var cts = new CancellationTokenSource(ExportTimeout);
        return await _credential.GetAccessTokenWithHeadersForRequestAsync(cancellationToken: cts.Token).ConfigureAwait(false);
    }

    private static OtlpExporterOptions CreateOptions(HttpClient httpClient) => new()
    {
        Endpoint = s_endpoint,
        Protocol = OtlpExportProtocol.HttpProtobuf,
        Headers = string.Empty,
        Compression = OtlpExportCompression.None,
        TimeoutMilliseconds = (int) ExportTimeout.TotalMilliseconds,
        HttpClientFactory = () => httpClient
    };
}
