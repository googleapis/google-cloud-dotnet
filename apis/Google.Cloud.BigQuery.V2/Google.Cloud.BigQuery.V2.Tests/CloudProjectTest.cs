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

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Moq;
using Xunit;
using static Google.Apis.Bigquery.v2.Data.ProjectList;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CloudProjectTest
    {
        [Fact]
        public void Properties()
        {
            string id = "hard-to-remember";
            string name = "Fluffy";
            var data = new ProjectsData
            {
                FriendlyName = name,
                Id = id,
                ProjectReference = new ProjectReference { ProjectId = id }
            };
            var project = new CloudProject(new Mock<BigQueryClient>().Object, data);
            Assert.Equal(name, project.FriendlyName);
            Assert.Equal(id, project.ProjectId);
            Assert.Equal(id, project.Reference.ProjectId);
        }

        [Fact]
        public void CreateClient()
        {
            string projectId = "project";
            var data = new ProjectsData
            {
                Id = projectId,
                ProjectReference = new ProjectReference { ProjectId = projectId }
            };
            var originalClient = new SimpleClient();
            var project = new CloudProject(originalClient, data);
            var newClient = project.CreateClient();
            Assert.Equal(projectId, newClient.ProjectId);
            Assert.Same(originalClient.Service, newClient.Service);
        }

        private class SimpleClient : BigQueryClient
        {
            public override BigqueryService Service { get; } = new FakeBigqueryService();
        }
    }
}
