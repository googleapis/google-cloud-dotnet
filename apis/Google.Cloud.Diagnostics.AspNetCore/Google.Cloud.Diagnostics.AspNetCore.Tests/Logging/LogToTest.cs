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

using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests.Logging
{
    public class LogToTest
    {
        [Fact]
        public void Project()
        {
            string projectId = "pid";
            LogTo logTo = LogTo.Project(projectId);
            Assert.Equal(LogToLocation.Project, logTo.Location);
            Assert.Equal(projectId, logTo.ProjectId);
            Assert.Equal(default(string), logTo.OrganizationId);
        }

        [Fact]
        public void OrganizationId()
        {
            string organizationId = "oid";
            LogTo logTo = LogTo.Organization(organizationId);
            Assert.Equal(LogToLocation.Organization, logTo.Location);
            Assert.Equal(organizationId, logTo.OrganizationId);
            Assert.Equal(default(string), logTo.ProjectId);
        }

        [Fact]
        public void GetFullLogName_Project()
        {
            string projectId = "pid";
            string name = "name";
            LogTo logTo = LogTo.Project(projectId);
            string projectName = logTo.GetFullLogName(name);
            Assert.Contains(name, projectName);
            Assert.Contains(projectId, projectName);
        }

        [Fact]
        public void GetFullLogName_Organization()
        {
            string organizationId = "oid";
            string name = "name";
            LogTo logTo = LogTo.Organization(organizationId);
            string organizationName = logTo.GetFullLogName(name);
            Assert.Contains(name, organizationName);
            Assert.Contains(organizationId, organizationName);
        }
    }
}
