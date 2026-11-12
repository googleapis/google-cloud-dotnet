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

    internal static async Task WaitForMetricsAsync(
        string projectId, IEnumerable<string> metricTypes, string labelFilter)
    {
        var client = await MetricServiceClient.CreateAsync();
        await Task.WhenAll(metricTypes.Select(metricType =>
            WaitForPointsAsync(client, projectId, metricType, labelFilter)));
    }

    internal static async Task<IReadOnlyList<Point>> WaitForPointsAsync(
        MetricServiceClient client,
        string projectId,
        string metricType,
        string labelFilter,
        Func<IReadOnlyList<Point>, bool> condition = null)
    {
        condition ??= points => points.Count > 0;
        var startTime = DateTime.UtcNow;
        var deadline = startTime + s_timeout;
        while (DateTime.UtcNow < deadline)
        {
            var request = new ListTimeSeriesRequest
            {
                Name = $"projects/{projectId}",
                Filter = $"metric.type = \"{metricType}\" AND {labelFilter}",
                // Recompute EndTime on each poll because points appear only after ingestion.
                Interval = new TimeInterval
                {
                    StartTime = Timestamp.FromDateTime(startTime.AddMinutes(-10)),
                    EndTime = Timestamp.FromDateTime(DateTime.UtcNow.AddMinutes(5))
                }
            };

            try
            {
                var response = await client.ListTimeSeriesAsync(request).ReadPageAsync(100);
                var points = response.SelectMany(series => series.Points).ToList();
                if (condition(points))
                {
                    return points;
                }
            }
            catch (RpcException ex) when (ex.StatusCode is StatusCode.NotFound or StatusCode.InvalidArgument)
            {
                // The metric or label index may not exist yet.
            }

            await Task.Delay(s_pollingInterval);
        }

        Assert.Fail($"Timed out after {s_timeout.TotalMinutes} minutes waiting for '{metricType}' points with {labelFilter}.");
        return null;
    }
}
