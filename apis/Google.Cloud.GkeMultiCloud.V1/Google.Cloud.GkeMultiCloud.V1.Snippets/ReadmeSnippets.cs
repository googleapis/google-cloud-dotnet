// Copyright 2022 Google LLC
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
using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.GkeMultiCloud.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(GkeMultiCloudFixture))]
    public class ReadmeSnippets
    {
        private readonly GkeMultiCloudFixture _fixture;

        public ReadmeSnippets(GkeMultiCloudFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void Endpoint()
        {
            string projectId = _fixture.ProjectId;
            // Sample: Endpoint
            string region = "us-west1";
            AzureClustersClient client = new AzureClustersClientBuilder
            {
                Endpoint = $"{region}-gkemulticloud.googleapis.com"
            }.Build();

            LocationName location = new LocationName(projectId, region);
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> clusters = client.ListAzureClusters(location);
            foreach (AzureCluster cluster in clusters)
            {
                Console.WriteLine(cluster.Name);
            }
            // End sample
        }
    }
}
