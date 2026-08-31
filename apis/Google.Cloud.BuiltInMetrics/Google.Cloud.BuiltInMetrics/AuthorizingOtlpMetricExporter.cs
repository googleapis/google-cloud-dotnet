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
using OpenTelemetry;
using OpenTelemetry.Exporter;
using OpenTelemetry.Metrics;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Exports OTLP metrics to <c>telemetry.googleapis.com</c> using a background-refreshed Google credential token.
/// </summary>
internal sealed class AuthorizingOtlpMetricExporter : OtlpMetricExporter
{
    private static readonly Uri s_endpoint = new("https://telemetry.googleapis.com/v1/metrics");
    internal static readonly TimeSpan ExportTimeout = TimeSpan.FromSeconds(10);

    private readonly HttpClient _httpClient;
    private readonly Func<AccessTokenWithHeaders> _getToken;
    private volatile bool _exportDisabled;

    private AuthorizingOtlpMetricExporter(HttpClient httpClient, Func<AccessTokenWithHeaders> getToken)
        : base(CreateOptions(httpClient))
    {
        _httpClient = httpClient;
        _getToken = getToken;
    }

    internal static AuthorizingOtlpMetricExporter Create(
        HttpMessageHandler httpHandler,
        Func<AccessTokenWithHeaders> getToken)
    {
        var httpClient = new HttpClient(httpHandler, disposeHandler: false) { Timeout = ExportTimeout };
        try
        {
            return new AuthorizingOtlpMetricExporter(httpClient, getToken);
        }
        catch
        {
            httpClient.Dispose();
            throw;
        }
    }

    internal static void CheckEnvironmentSettings()
    {
        // OtlpMetricExporter's constructor validates experimental OTEL_* environment variables eagerly at startup.
        using var httpClient = new HttpClient();
        using var exporter = new OtlpMetricExporter(CreateOptions(httpClient));
        // OtlpMetricExporter stops its retry thread in OnShutdown rather than Dispose.
        exporter.Shutdown(0);
    }

    internal void DisableExport()
    {
        _exportDisabled = true;
        // Cancel any in-flight periodic export immediately when evicting an idle meter.
        Shutdown(0);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Shutdown(0);
            _httpClient.Dispose();
        }
        base.Dispose(disposing);
    }

    public override ExportResult Export(in Batch<Metric> metrics)
    {
        if (_exportDisabled || metrics.Count == 0)
        {
            return ExportResult.Success;
        }
        // Skip export until a token is cached, because cumulative metrics include accumulated totals on the next pass.
        if (_getToken() is not { } token)
        {
            return ExportResult.Failure;
        }
        ApplyCredentials(token);
        return base.Export(metrics);
    }

    private void ApplyCredentials(AccessTokenWithHeaders token)
    {
        var headers = _httpClient.DefaultRequestHeaders;
        // Clear previous credential headers on this exporter's dedicated HttpClient because AddHeaders appends values across serialized exports.
        headers.Clear();
        token.AddHeaders(headers);
        headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
    }

    // Set every option explicitly so OtlpExporterOptions does not inherit ambient OTEL_EXPORTER_OTLP_* variables.
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
