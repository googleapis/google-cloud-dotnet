// Copyright 2018 Google Inc. All Rights Reserved.
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

using System;
using Google.Api;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ProjectTest
    {
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
            Assert.Equal(projectId, Project.GetAndCheckProjectId(projectId, monitoredResource));

            // The string project id is not null and the MonitoredResource does not contain a project id
            // so the string project id is returned.
            Assert.Equal(projectId, Project.GetAndCheckProjectId(projectId, new MonitoredResource()));

            // The string project id is null and the MonitoredResource does contains a project id
            // so the project id from the MonitoredResource is returned.
            Assert.Equal(resourceProjectId, Project.GetAndCheckProjectId(null, monitoredResource));

            // The string project id is null and the MonitoredResource does not contain a project id
            // so we throw an InvalidOperationException.
            var ex = Assert.Throws<InvalidOperationException>(() => Project.GetAndCheckProjectId(null, new MonitoredResource()));
            Assert.Equal("No Google Cloud project ID was passed in or detected.", ex.Message);
        }

        [Fact]
        public void GetAndCheckServiceName()
        {
            var serviceName = "my-app";
            var resourceServiceName = "my-app";
            var monitoredResource = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "module_id", resourceServiceName }
                }
            };

            // The string service name is not null and the MonitoredResource contains a service name
            // so the string service name is returned.  We do this as the explicitly set service name should be
            // defaulted to.
            Assert.Equal(serviceName, Project.GetAndCheckServiceName(serviceName, monitoredResource));

            // The string service name is not null and the MonitoredResource does not contain a service name
            // so the string service name is returned.
            Assert.Equal(serviceName, Project.GetAndCheckServiceName(serviceName, new MonitoredResource()));

            // The string service name is null and the MonitoredResource does contains a service name
            // so the service name from the MonitoredResource is returned.
            Assert.Equal(resourceServiceName, Project.GetAndCheckServiceName(null, monitoredResource));

            // The string service name is null and the MonitoredResource does not contain a service name
            // so we throw an InvalidOperationException.
            var ex = Assert.Throws<InvalidOperationException>(() => Project.GetAndCheckServiceName(null, new MonitoredResource()));
            Assert.Equal("No Google App Engine service name was passed in or detected.", ex.Message);
        }

        [Fact]
        public void GetServiceName()
        {
            var serviceName = "my-app";
            var resourceServiceName = "my-app";
            var monitoredResource = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "module_id", resourceServiceName }
                }
            };

            // The string service name is not null and the MonitoredResource contains a service name
            // so the string service name is returned.  We do this as the explicitly set service name should be
            // defaulted to.
            Assert.Equal(serviceName, Project.GetServiceName(serviceName, monitoredResource));

            // The string service name is not null and the MonitoredResource does not contain a service name
            // so the string service name is returned.
            Assert.Equal(serviceName, Project.GetServiceName(serviceName, new MonitoredResource()));

            // The string service name is null and the MonitoredResource does contains a service name
            // so the service name from the MonitoredResource is returned.
            Assert.Equal(resourceServiceName, Project.GetServiceName(null, monitoredResource));

            // The string service name is null and the MonitoredResource does not contain a service name
            // so the service name is null.
            Assert.Null(Project.GetServiceVersion(null, new MonitoredResource()));
        }

        [Fact]
        public void GetAndCheckServiceVersion()
        {
            var serviceVersion = "1.0.0";
            var resourceServiceVersion = "1.0.0";
            var monitoredResource = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "version_id", resourceServiceVersion }
                }
            };

            // The string service version is not null and the MonitoredResource contains a service version
            // so the string service version is returned.  We do this as the explicitly set service version should be
            // defaulted to.
            Assert.Equal(serviceVersion, Project.GetAndCheckServiceVersion(serviceVersion, monitoredResource));

            // The string service version is not null and the MonitoredResource does not contain a service version
            // so the string service version is returned.
            Assert.Equal(serviceVersion, Project.GetAndCheckServiceVersion(serviceVersion, new MonitoredResource()));

            // The string service version is null and the MonitoredResource does contains a service version
            // so the service version from the MonitoredResource is returned.
            Assert.Equal(resourceServiceVersion, Project.GetAndCheckServiceVersion(null, monitoredResource));

            // The string service version is null and the MonitoredResource does not contain a service version
            // so we throw an InvalidOperationException.
            var ex = Assert.Throws<InvalidOperationException>(() => Project.GetAndCheckServiceVersion(null, new MonitoredResource()));
            Assert.Equal("No Google App Engine service version was passed in or detected.", ex.Message);
        }

        [Fact]
        public void GetServiceVersion()
        {
            var serviceVersion = "1.0.0";
            var resourceServiceVersion = "1.0.0";
            var monitoredResource = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "version_id", resourceServiceVersion }
                }
            };

            // The string service version is not null and the MonitoredResource contains a service version
            // so the string service version is returned.  We do this as the explicitly set service version should be
            // defaulted to.
            Assert.Equal(serviceVersion, Project.GetServiceVersion(serviceVersion, monitoredResource));

            // The string service version is not null and the MonitoredResource does not contain a service version
            // so the string service version is returned.
            Assert.Equal(serviceVersion, Project.GetServiceVersion(serviceVersion, new MonitoredResource()));

            // The string service version is null and the MonitoredResource does contains a service version
            // so the service version from the MonitoredResource is returned.
            Assert.Equal(resourceServiceVersion, Project.GetServiceVersion(null, monitoredResource));

            // The string service version is null and the MonitoredResource does not contain a service version
            // so the service version is null.
            Assert.Null(Project.GetServiceVersion(null, new MonitoredResource()));
        }

        [Fact]
        public void DoesNotCacheSpecifiedMonitoredResourceInstance()
        {
            var projectId1 = "pid-1";
            var resourceProjectId1 = "pid-1";
            var monitoredResource1 = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "project_id", resourceProjectId1 }
                }
            };
            Assert.Equal(projectId1, Project.GetAndCheckProjectId(null, monitoredResource1));

            // Create a second MonitoredResource instance and pass it to GetAndCheckProjectId.
            // Assert that the first MonitoredResource instance is not cached by checking if the project ID is correct.
            // Only auto-detected MonitoredResource instances should be cached.
            var projectId2 = "pid-2";
            var resourceProjectId2 = "pid-2";
            var monitoredResource2 = new MonitoredResource
            {
                Type = "some-type",
                Labels =
                {
                    { "project_id", resourceProjectId2 }
                }
            };
            Assert.Equal(projectId2, Project.GetAndCheckProjectId(null, monitoredResource2));
        }
    }
}
