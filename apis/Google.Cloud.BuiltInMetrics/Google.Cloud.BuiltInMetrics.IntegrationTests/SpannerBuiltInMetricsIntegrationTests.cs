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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.IntegrationTests;

public class SpannerBuiltInMetricsIntegrationTests
{
    private static readonly TimeSpan s_pollingTimeout = TimeSpan.FromMinutes(3);
    private static readonly TimeSpan s_pollingInterval = TimeSpan.FromSeconds(10);

    private static readonly string[] s_expectedMetrics =
    [
        "spanner.googleapis.com/client/operation_count",
        "spanner.googleapis.com/client/operation_latencies",
        "spanner.googleapis.com/client/attempt_count",
        "spanner.googleapis.com/client/attempt_latencies",
        "spanner.googleapis.com/client/gfe_latencies",
        "spanner.googleapis.com/client/gfe_connectivity_error_count"
    ];

    [Fact]
    public async Task BuiltInMetrics_ExportsAllSpannerTelemetryToMonitoring()
    {
        // Arrange the metrics to be emittted along with their labels
        string projectId = TestEnvironment.GetTestProjectId();
        var credential = await GoogleCredential.GetApplicationDefaultAsync();
        string testClientName = $"spanner.net.test.{Guid.NewGuid().ToString().Substring(0, 5)}";
        string testUid = Guid.NewGuid().ToString();

        using var meterProvider = Sdk.CreateMeterProviderBuilder()
            .SetResourceBuilder(ResourceBuilder.CreateDefault()
                .AddService("spanner-built-in-metrics-integration-test", "test")
                .AddAttributes(
                [
                    new KeyValuePair<string, object>("gcp.resource_type", "spanner_instance_client"),
                    new KeyValuePair<string, object>("gcp.project_id", projectId),
                    new KeyValuePair<string, object>("project_id", projectId),
                    new KeyValuePair<string, object>("location", "us-central1"),
                    new KeyValuePair<string, object>("instance_id", "test-spanner-instance"),
                    new KeyValuePair<string, object>("instance_config", "unknown"),
                    new KeyValuePair<string, object>("client_hash", "1234abcd"),
                ]))
            .AddGoogleCloudBuiltInMetrics(credential)
            .Build();

        var meter = new Meter(SpannerMetricsConfiguration.MeterName);

        var operationCounter = meter.CreateCounter<long>("operation_count");
        var operationLatency = meter.CreateHistogram<double>("operation_latencies");
        var attemptCounter = meter.CreateCounter<long>("attempt_count");
        var attemptLatency = meter.CreateHistogram<double>("attempt_latencies");
        var gfeLatency = meter.CreateHistogram<double>("gfe_latencies");
        var gfeErrorCounter = meter.CreateCounter<long>("gfe_connectivity_error_count");

        var labels = new KeyValuePair<string, object>[]
        {
            new("database", "test-database"),
            new("method", "ExecuteSql"),
            new("status", "OK"),
            new("client_name", testClientName),
            new("client_uid", testUid),
            new("directpath_enabled", false),
            new("directpath_used", false)
        };

        // Emit all metrics together so they export in a single batch,
        // running tests individualy would be too slow (1-3 minutes each)
        for (int i = 0; i < 5; i++)
        {
            operationCounter.Add(1, labels);
            operationLatency.Record(125.0, labels);
            attemptCounter.Add(1, labels);
            attemptLatency.Record(80.0, labels);
            gfeLatency.Record(15.0, labels);
            gfeErrorCounter.Add(1, labels);
            await Task.Delay(200);
        }

        meterProvider.ForceFlush();

        var client = new MetricServiceClientBuilder
        {
            Credential = credential
        }.Build();

        // Ensure all metrics were registered to the spanner built in metrics resource
        var verificationTasks = s_expectedMetrics.Select(metricType =>
            WaitForMetricAsync(client, projectId, metricType, testClientName));
        await Task.WhenAll(verificationTasks);
    }

    private static async Task WaitForMetricAsync(
        MetricServiceClient client,
        string projectId,
        string metricType,
        string expectedClientName)
    {
        var startTime = DateTime.UtcNow;
        var deadline = startTime + s_pollingTimeout;

        var request = new ListTimeSeriesRequest
        {
            Name = $"projects/{projectId}",
            Filter = $"metric.type = \"{metricType}\" AND metric.labels.client_name = \"{expectedClientName}\"",
            Interval = new TimeInterval
            {
                StartTime = Timestamp.FromDateTime(startTime.AddMinutes(-5)),
                EndTime = Timestamp.FromDateTime(startTime.AddMinutes(5))
            }
        };

        while (DateTime.UtcNow < deadline)
        {
            try
            {
                var response = await client.ListTimeSeriesAsync(request).ReadPageAsync(100);
                if (response.Any(series => series.Points.Count != 0))
                {
                    return;
                }
            }
            catch (RpcException ex) when (ex.StatusCode == StatusCode.NotFound || ex.StatusCode == StatusCode.InvalidArgument)
            {
                // Metric not yet ingested or indexed
            }

            await Task.Delay(s_pollingInterval);
        }

        Assert.Fail($"Timed out waiting {s_pollingTimeout.TotalMinutes} minutes for metric '{metricType}' with client_name='{expectedClientName}' to appear in Cloud Monitoring.");
    }
}
