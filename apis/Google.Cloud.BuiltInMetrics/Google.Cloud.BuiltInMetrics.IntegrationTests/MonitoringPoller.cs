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

using Google.Cloud.Monitoring.V3;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.IntegrationTests;

internal static class MonitoringPoller
{
    private static readonly TimeSpan s_timeout = TimeSpan.FromMinutes(5);
    private static readonly TimeSpan s_pollingInterval = TimeSpan.FromSeconds(15);

    internal static async Task<IReadOnlyList<TimeSeries>> WaitForMetricsAsync(
        MetricServiceClient client, string projectId, IEnumerable<string> metricTypes, string labelFilter)
    {
        var batches = await Task.WhenAll(metricTypes.Select(metricType =>
            WaitForTimeSeriesAsync(client, projectId, metricType, labelFilter)));
        return batches.SelectMany(batch => batch).ToList();
    }

    internal static async Task<IReadOnlyList<Point>> WaitForPointsAsync(
        MetricServiceClient client,
        string projectId,
        string metricType,
        string labelFilter,
        Func<IReadOnlyList<Point>, bool> isSatisfied = null)
    {
        isSatisfied ??= points => points.Count > 0;
        var series = await WaitForTimeSeriesAsync(
            client,
            projectId,
            metricType,
            labelFilter,
            candidate => isSatisfied(candidate.SelectMany(item => item.Points).ToList()));
        return series.SelectMany(item => item.Points).ToList();
    }

    private static async Task<IReadOnlyList<TimeSeries>> WaitForTimeSeriesAsync(
        MetricServiceClient client,
        string projectId,
        string metricType,
        string labelFilter,
        Func<IReadOnlyList<TimeSeries>, bool> isSatisfied = null)
    {
        isSatisfied ??= series => series.Any(item => item.Points.Count > 0);
        var startTimeUtc = DateTime.UtcNow;
        var deadlineUtc = startTimeUtc + s_timeout;
        while (DateTime.UtcNow < deadlineUtc)
        {
            var series = await FetchTimeSeriesOrEmptyAsync(client, projectId, metricType, labelFilter, startTimeUtc);
            if (isSatisfied(series))
            {
                return series;
            }
            await Task.Delay(s_pollingInterval);
        }

        Assert.Fail($"Timed out after {s_timeout.TotalMinutes} minutes waiting for '{metricType}' series with {labelFilter}.");
        return null;
    }

    private static async Task<IReadOnlyList<TimeSeries>> FetchTimeSeriesOrEmptyAsync(
        MetricServiceClient client, string projectId, string metricType, string labelFilter, DateTime startTimeUtc)
    {
        try
        {
            var request = CreateTimeSeriesRequest(projectId, metricType, labelFilter, startTimeUtc);
            var response = await client.ListTimeSeriesAsync(request).ReadPageAsync(100);
            return response.ToList();
        }
        catch (RpcException ex) when (ex.StatusCode is StatusCode.NotFound or StatusCode.InvalidArgument)
        {
            // The metric or label index may not exist yet.
            return Array.Empty<TimeSeries>();
        }
    }

    private static ListTimeSeriesRequest CreateTimeSeriesRequest(
        string projectId, string metricType, string labelFilter, DateTime startTimeUtc) => new()
    {
        Name = $"projects/{projectId}",
        Filter = $"metric.type = \"{metricType}\" AND {labelFilter}",
        // Recompute EndTime on each poll because points appear only after ingestion.
        Interval = new TimeInterval
        {
            StartTime = Timestamp.FromDateTime(startTimeUtc.AddMinutes(-10)),
            EndTime = Timestamp.FromDateTime(DateTime.UtcNow.AddMinutes(5))
        }
    };
}
