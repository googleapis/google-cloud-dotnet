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

using Google.Api;
using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Monitoring.V3
{
    [SnippetOutputCollector]
    [Collection(nameof(MonitoringFixture))]
    public class MetricServiceClientSnippets
    {
        private readonly MonitoringFixture _fixture;

        public MetricServiceClientSnippets(MonitoringFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListMetricDescriptors()
        {
            string projectId = _fixture.ProjectId;

            // Sample: ListMetricDescriptors
            // Additional: ListMetricDescriptors(*,*,*,*)
            MetricServiceClient client = MetricServiceClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> metrics = client.ListMetricDescriptors(projectName);
            foreach (MetricDescriptor metric in metrics.Take(10))
            {
                Console.WriteLine($"{metric.Name}: {metric.DisplayName}");
            }
            // End sample
        }
    }
}
