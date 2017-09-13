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

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Monitoring.V3
{
    [SnippetOutputCollector]
    [Collection(nameof(MonitoringFixture))]
    public class GroupServiceClientSnippets
    {
        private readonly MonitoringFixture _fixture;

        public GroupServiceClientSnippets(MonitoringFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListGroups()
        {
            string projectId = _fixture.ProjectId;

            // Sample: ListGroups
            // Additional: ListGroups(*,*)
            GroupServiceClient client = GroupServiceClient.Create();
            ProjectName projectName = new ProjectName(projectId);
            ListGroupsRequest request = new ListGroupsRequest { Name = projectName.ToString() };
            PagedEnumerable<ListGroupsResponse, Group> groups = client.ListGroups(request);
            foreach (Group group in groups.Take(10))
            {
                Console.WriteLine($"{group.Name}: {group.DisplayName}");
            }
            // End sample
        }
    }
}
