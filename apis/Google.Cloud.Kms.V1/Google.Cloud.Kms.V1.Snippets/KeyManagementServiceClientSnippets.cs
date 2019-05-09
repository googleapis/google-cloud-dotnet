// Copyright 2018 Google LLC
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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.Kms.V1.Snippets
{
    [Collection(nameof(KeyManagementServiceFixture))]
    [SnippetOutputCollector]
    public class KeyManagementServiceClientSnippets
    {
        private readonly KeyManagementServiceFixture _fixture;

        public KeyManagementServiceClientSnippets(KeyManagementServiceFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void ListGlobalKeyRings()
        {
            string projectId = _fixture.ProjectId;

            // Sample: ListGlobalKeyRings
            KeyManagementServiceClient client = KeyManagementServiceClient.Create();
            LocationName globalLocation = new LocationName(projectId, "global");
            foreach (KeyRing keyRing in client.ListKeyRings(globalLocation))
            {
                Console.WriteLine(keyRing.Name);
            }
            // End sample
        }

        [Fact]
        public void ListLocations()
        {
            string projectId = _fixture.ProjectId;

            // Sample: ListLocations
            KeyManagementServiceClient client = KeyManagementServiceClient.Create();
            foreach (var location in client.ListLocations(new ProjectName(projectId).ToString()))
            {
                Console.WriteLine(location.Name);
            }
            // End sample
        }
    }
}
