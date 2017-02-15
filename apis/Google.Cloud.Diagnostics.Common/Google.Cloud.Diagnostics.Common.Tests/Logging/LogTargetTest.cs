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

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class LogTargetTest
    {
        [Fact]
        public void Project()
        {
            string projectId = "pid";
            LogTarget logTarget = LogTarget.ForProject(projectId);
            Assert.Equal(LogTargetKind.Project, logTarget.Kind);
            Assert.Equal(projectId, logTarget.ProjectId);
            Assert.Null(logTarget.OrganizationId);
        }

        [Fact]
        public void OrganizationId()
        {
            string organizationId = "oid";
            LogTarget logTarget = LogTarget.ForOrganization(organizationId);
            Assert.Equal(LogTargetKind.Organization, logTarget.Kind);
            Assert.Equal(organizationId, logTarget.OrganizationId);
            Assert.Null(logTarget.ProjectId);
        }

        [Fact]
        public void GetFullLogName_Project()
        {
            string projectId = "pid";
            string name = "name";
            LogTarget logTarget = LogTarget.ForProject(projectId);
            string projectName = logTarget.GetFullLogName(name);
            Assert.Contains(name, projectName);
            Assert.Contains(projectId, projectName);
        }

        [Fact]
        public void GetFullLogName_Organization()
        {
            string organizationId = "oid";
            string name = "name";
            LogTarget logTarget = LogTarget.ForOrganization(organizationId);
            string organizationName = logTarget.GetFullLogName(name);
            Assert.Contains(name, organizationName);
            Assert.Contains(organizationId, organizationName);
        }
    }
}
