// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using ListTimeSeriesRequest.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Monitoring.V3.Snippets
{
    public class GeneratedMetricServiceClientSnippets
    {
        public async Task ListMonitoredResourceDescriptorsAsync()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(string,string,int?,CallSettings)
            // Additional: ListMonitoredResourceDescriptorsAsync(string,string,int?,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse,MonitoredResourceDescriptor> response =
                metricServiceClient.ListMonitoredResourceDescriptorsAsync(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<MonitoredResourceDescriptor>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<MonitoredResourceDescriptor> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListMonitoredResourceDescriptors()
        {
            // Snippet: ListMonitoredResourceDescriptors(string,string,int?,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedEnumerable<ListMonitoredResourceDescriptorsResponse,MonitoredResourceDescriptor> response =
                metricServiceClient.ListMonitoredResourceDescriptors(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<MonitoredResourceDescriptor> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task GetMonitoredResourceDescriptorAsync()
        {
            // Snippet: GetMonitoredResourceDescriptorAsync(string,CallSettings)
            // Additional: GetMonitoredResourceDescriptorAsync(string,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatMonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            // Make the request
            MonitoredResourceDescriptor response = await metricServiceClient.GetMonitoredResourceDescriptorAsync(formattedName);
            // End snippet
        }

        public void GetMonitoredResourceDescriptor()
        {
            // Snippet: GetMonitoredResourceDescriptor(string,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatMonitoredResourceDescriptorName("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            // Make the request
            MonitoredResourceDescriptor response = metricServiceClient.GetMonitoredResourceDescriptor(formattedName);
            // End snippet
        }

        public async Task ListMetricDescriptorsAsync()
        {
            // Snippet: ListMetricDescriptorsAsync(string,string,int?,CallSettings)
            // Additional: ListMetricDescriptorsAsync(string,string,int?,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedAsyncEnumerable<ListMetricDescriptorsResponse,MetricDescriptor> response =
                metricServiceClient.ListMetricDescriptorsAsync(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<MetricDescriptor>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<MetricDescriptor> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListMetricDescriptors()
        {
            // Snippet: ListMetricDescriptors(string,string,int?,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            // Make the request
            IPagedEnumerable<ListMetricDescriptorsResponse,MetricDescriptor> response =
                metricServiceClient.ListMetricDescriptors(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<MetricDescriptor> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task GetMetricDescriptorAsync()
        {
            // Snippet: GetMetricDescriptorAsync(string,CallSettings)
            // Additional: GetMetricDescriptorAsync(string,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatMetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            MetricDescriptor response = await metricServiceClient.GetMetricDescriptorAsync(formattedName);
            // End snippet
        }

        public void GetMetricDescriptor()
        {
            // Snippet: GetMetricDescriptor(string,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatMetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            MetricDescriptor response = metricServiceClient.GetMetricDescriptor(formattedName);
            // End snippet
        }

        public async Task CreateMetricDescriptorAsync()
        {
            // Snippet: CreateMetricDescriptorAsync(string,MetricDescriptor,CallSettings)
            // Additional: CreateMetricDescriptorAsync(string,MetricDescriptor,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(formattedName, metricDescriptor);
            // End snippet
        }

        public void CreateMetricDescriptor()
        {
            // Snippet: CreateMetricDescriptor(string,MetricDescriptor,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(formattedName, metricDescriptor);
            // End snippet
        }

        public async Task DeleteMetricDescriptorAsync()
        {
            // Snippet: DeleteMetricDescriptorAsync(string,CallSettings)
            // Additional: DeleteMetricDescriptorAsync(string,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatMetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            await metricServiceClient.DeleteMetricDescriptorAsync(formattedName);
            // End snippet
        }

        public void DeleteMetricDescriptor()
        {
            // Snippet: DeleteMetricDescriptor(string,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatMetricDescriptorName("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            metricServiceClient.DeleteMetricDescriptor(formattedName);
            // End snippet
        }

        public async Task ListTimeSeriesAsync()
        {
            // Snippet: ListTimeSeriesAsync(string,string,TimeInterval,TimeSeriesView,string,int?,CallSettings)
            // Additional: ListTimeSeriesAsync(string,string,TimeInterval,TimeSeriesView,string,int?,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            TimeSeriesView view = TimeSeriesView.Full;
            // Make the request
            IPagedAsyncEnumerable<ListTimeSeriesResponse,TimeSeries> response =
                metricServiceClient.ListTimeSeriesAsync(formattedName, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<TimeSeries>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<TimeSeries> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListTimeSeries()
        {
            // Snippet: ListTimeSeries(string,string,TimeInterval,TimeSeriesView,string,int?,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            TimeSeriesView view = TimeSeriesView.Full;
            // Make the request
            IPagedEnumerable<ListTimeSeriesResponse,TimeSeries> response =
                metricServiceClient.ListTimeSeries(formattedName, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<TimeSeries> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task CreateTimeSeriesAsync()
        {
            // Snippet: CreateTimeSeriesAsync(string,IEnumerable<TimeSeries>,CallSettings)
            // Additional: CreateTimeSeriesAsync(string,IEnumerable<TimeSeries>,CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new List<TimeSeries>();
            // Make the request
            await metricServiceClient.CreateTimeSeriesAsync(formattedName, timeSeries);
            // End snippet
        }

        public void CreateTimeSeries()
        {
            // Snippet: CreateTimeSeries(string,IEnumerable<TimeSeries>,CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = MetricServiceClient.FormatProjectName("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new List<TimeSeries>();
            // Make the request
            metricServiceClient.CreateTimeSeries(formattedName, timeSeries);
            // End snippet
        }

    }
}
