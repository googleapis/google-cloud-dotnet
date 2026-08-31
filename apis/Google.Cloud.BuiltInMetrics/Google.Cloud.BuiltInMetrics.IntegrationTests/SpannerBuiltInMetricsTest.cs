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
using Google.Cloud.ClientTesting;
using Google.Cloud.Monitoring.V3;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.IntegrationTests;

[Collection(IntegrationTestCollection.Name)]
public class SpannerBuiltInMetricsTest
{
    private static readonly string[] s_clientMetrics =
    [
        "spanner.googleapis.com/client/operation_count",
        "spanner.googleapis.com/client/operation_latencies",
        "spanner.googleapis.com/client/attempt_count",
        "spanner.googleapis.com/client/attempt_latencies",
        "spanner.googleapis.com/client/gfe_latencies"
    ];

    private static readonly string[] s_allMetrics =
        s_clientMetrics.Concat(new[] { "spanner.googleapis.com/client/gfe_connectivity_error_count" }).ToArray();

    [Fact]
    public async Task UnaryCalls_ExportSyncAndAsyncMetrics()
    {
        string projectId = TestEnvironment.GetTestProjectId();
        string suffix = Guid.NewGuid().ToString("N").Substring(0, 8);
        string instanceId = $"bim-inst-{suffix}";
        var syncDatabase = DatabaseName.FromProjectInstanceDatabase(projectId, instanceId, $"db-sync-{suffix}");
        var asyncDatabase = DatabaseName.FromProjectInstanceDatabase(projectId, instanceId, $"db-async-{suffix}");

        using (await BuiltInMetrics.EnableAsync())
        {
            var client = await SpannerClient.CreateAsync();
            Assert.Throws<RpcException>(() => client.CreateSession(syncDatabase));
            await Assert.ThrowsAsync<RpcException>(() => client.CreateSessionAsync(asyncDatabase));
        }

        var monitoringClient = await MetricServiceClient.CreateAsync();
        var batches = await Task.WhenAll(
            MonitoringPoller.WaitForMetricsAsync(
                monitoringClient, projectId, s_clientMetrics, $"metric.labels.database = \"{syncDatabase.DatabaseId}\""),
            MonitoringPoller.WaitForMetricsAsync(
                monitoringClient, projectId, s_clientMetrics, $"metric.labels.database = \"{asyncDatabase.DatabaseId}\""));

        AssertSpannerResource(batches.SelectMany(batch => batch), instanceId);
    }

    [Fact]
    public async Task BuiltInMetrics_ExportsAllSpannerTelemetryToMonitoring()
    {
        string projectId = TestEnvironment.GetTestProjectId();
        var credential = await GoogleCredential.GetApplicationDefaultAsync();
        string clientName = CreateClientName();
        string instanceId = $"bim-inst-{Guid.NewGuid().ToString("N").Substring(0, 8)}";
        var labels = CreateLabels(projectId, clientName, instanceId);

        using (await BuiltInMetrics.EnableAsync(new BuiltInMetricsOptions { GoogleCredential = credential }))
        {
            using var meter = new Meter(ServiceMetricsConfiguration.Spanner.SourceMeterName);

            // Export all 6 instruments in one batch so the test waits for ingestion once.
            meter.CreateCounter<long>("operation_count").Add(1, labels);
            meter.CreateHistogram<double>("operation_latencies").Record(125.0, labels);
            meter.CreateCounter<long>("attempt_count").Add(1, labels);
            meter.CreateHistogram<double>("attempt_latencies").Record(80.0, labels);
            meter.CreateHistogram<double>("gfe_latencies").Record(15.0, labels);
            meter.CreateCounter<long>("gfe_connectivity_error_count").Add(1, labels);
        }

        var monitoringClient = await MetricServiceClient.CreateAsync();
        var series = await MonitoringPoller.WaitForMetricsAsync(
            monitoringClient, projectId, s_allMetrics, $"metric.labels.client_name = \"{clientName}\"");

        AssertSpannerResource(series, instanceId);
    }

    internal static string CreateClientName() =>
        $"spanner.net.test.{Guid.NewGuid().ToString("N").Substring(0, 8)}";

    internal static KeyValuePair<string, object>[] CreateLabels(
        string projectId, string clientName, string instanceId = null) =>
    [
        new("project_id", projectId),
        new("instance_id", instanceId ?? $"bim-inst-{Guid.NewGuid().ToString("N").Substring(0, 8)}"),
        new("location", "us-central1"),
        new("instance_config", "unknown"),
        new("client_hash", "0000ff"),
        new("database", "test-database"),
        new("method", "ExecuteSql"),
        new("status", "OK"),
        new("client_name", clientName),
        new("client_uid", Guid.NewGuid().ToString()),
        new("directpath_enabled", "false"),
        new("directpath_used", "false")
    ];

    private static void AssertSpannerResource(IEnumerable<TimeSeries> seriesList, string expectedInstanceId)
    {
        Assert.NotEmpty(seriesList);
        Assert.All(seriesList, series =>
        {
            Assert.Equal("spanner_instance_client", series.Resource.Type);
            Assert.Equal(expectedInstanceId, series.Resource.Labels["instance_id"]);
        });
    }
}
