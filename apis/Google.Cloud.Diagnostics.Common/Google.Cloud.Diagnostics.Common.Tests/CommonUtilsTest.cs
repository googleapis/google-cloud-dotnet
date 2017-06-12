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

using Google.Api;
using System;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class CommonUtilsTest
    {
        [Fact]
        public void AgentNameAndVersion()
        {
            Assert.Contains(CommonUtils.AgentName, CommonUtils.AgentNameAndVersion);
            Assert.Contains(CommonUtils.GetVersion(typeof(CommonUtils)), CommonUtils.AgentNameAndVersion);
        }

        [Fact]
        public void GetAndCheckProjectId()
        {
            var projectId = "pid";
            var resourceProjectId = "pid";
            var monitoredResource = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "project_id", resourceProjectId }
                }
            };

            // The string project id is not null and the MonitoredResource contains a project id
            // so the string project id is returned.  We do this as the explicitly set project id should be
            // defaulted to.
            Assert.Equal(projectId, CommonUtils.GetAndCheckProjectId(projectId, monitoredResource));

            // The string project id is not null and the MonitoredResource does not contain a project id
            // so the string project id is returned.
            Assert.Equal(projectId, CommonUtils.GetAndCheckProjectId(projectId, new MonitoredResource()));

            // The string project id is null and the MonitoredResource does contains a project id
            // so the project id from the MonitoredResource is returned.
            Assert.Equal(resourceProjectId, CommonUtils.GetAndCheckProjectId(null, monitoredResource));

            // The string project id is null and the MonitoredResource does not contain a project id
            // so we throw an InvalidOperationException.
            Assert.Throws<InvalidOperationException>(
                () => CommonUtils.GetAndCheckProjectId(null, new MonitoredResource()));
        }
    }
}
