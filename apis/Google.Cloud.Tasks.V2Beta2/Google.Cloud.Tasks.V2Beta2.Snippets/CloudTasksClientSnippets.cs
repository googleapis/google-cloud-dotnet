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
using loc = Google.Cloud.Location;
using System;
using Xunit;
using System.Linq;

namespace Google.Cloud.Tasks.V2Beta2.Snippets
{
    [Collection(nameof(CloudTasksFixture))]
    [SnippetOutputCollector]
    public class CloudTasksClientSnippets
    {
        private readonly CloudTasksFixture _fixture;

        public CloudTasksClientSnippets(CloudTasksFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void ListLocations()
        {
            CloudTasksClient client = CloudTasksClient.Create();
            ProjectName projectName = new ProjectName(_fixture.ProjectId);

            // Using an alias as the type name (Location) conflicts with the namespace (Google.Cloud.Location)
            foreach (loc::Location location in client.ListLocations(projectName))
            {
                Console.WriteLine(location);
            }
        }

        [Fact]
        public void GetLocation()
        {
            CloudTasksClient client = CloudTasksClient.Create();
            ProjectName projectName = new ProjectName(_fixture.ProjectId);

            loc::Location location = client.ListLocations(projectName).FirstOrDefault();

            if (location != null)
            {
                loc::Location fetchedLocation = client.GetLocation(location.NameAsResourceName);
                Console.WriteLine($"Fetched location: {fetchedLocation}");
            }
            else
            {
                Console.WriteLine("No location returned by ListLocations, so no GetLocation call was made");
            }
        }
    }
}
