// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.Container.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(ContainerSnippetFixture))]
    public class ClusterManagerClientSnippets
    {
        private readonly ContainerSnippetFixture _fixture;

        public ClusterManagerClientSnippets(ContainerSnippetFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void ListAllClusters()
        {
            string projectId = _fixture.ProjectId;
            // Sample: ListAllClusters
            ClusterManagerClient client = ClusterManagerClient.Create();
            // You can list clusters in a single zone, or specify "-" for all zones.
            LocationName location = new LocationName(projectId, locationId: "-");
            ListClustersResponse zones = client.ListClusters(location.ToString());
            foreach (Cluster cluster in zones.Clusters)
            {
                Console.WriteLine($"Cluster {cluster.Name} in {cluster.Location}");
            }
            // End sample
        }
    }
}
