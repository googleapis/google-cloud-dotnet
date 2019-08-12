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
using System.Collections.Generic;
using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ProjectTest
    {
        private static readonly Dictionary<string, MonitoredResource> s_resources =
            new Dictionary<string, MonitoredResource>
            {
                // Note: keyed by string so we'll be able to cope with GKE having multiple
                // representations.
                { "gae_app", MonitoredResourceBuilder.FromPlatform(new Platform(
                    new GaePlatformDetails("project-id", "instance", "service", "version"))) },
                { "gce_instance", MonitoredResourceBuilder.FromPlatform(new Platform(
                    new GcePlatformDetails("json", "project-id", "instance", "projects/12345/zones/zone"))) },
                { "container", CreateGkeResource("container") },
                { "gke_container", CreateGkeResource("gke_container") },
                { "k8s_container", CreateGkeResource("k8s_container") },
                { "cloud_run_revision", MonitoredResourceBuilder.FromPlatform(new Platform(
                    new CloudRunPlatformDetails("json", "project-id", "location", "service", "revision", "configuration"))) },
                { "unknown", new MonitoredResource { Type = "unknown", Labels = { { "project_id", "project-id" } } } }
            };

        // There are three different potential resource representations for GKE. We handle them all
        // the same way, but we need to test that.
        private static MonitoredResource CreateGkeResource(string resourceType)
        {
            var resource = MonitoredResourceBuilder.FromPlatform(new Platform(
                new GkePlatformDetails("json", "project-id", "cluster", "location", "host", "instance", "zone", "namespace", "pod", "container")));
            resource.Type = resourceType;
            return resource;
        }
        
        [Theory]
        [InlineData("gae_app", "project-id")]
        [InlineData("gce_instance", "project-id")]
        [InlineData("container", "project-id")]
        [InlineData("gke_container", "project-id")]
        [InlineData("k8s_container", "project-id")]
        [InlineData("cloud_run_revision", "project-id")]
        [InlineData("unknown", null)]
        public void GetProjectId(string type, string expectedProjectId)
        {
            var resource = s_resources[type];
            Assert.Equal("explicit", Project.GetProjectId("explicit", resource));
            Assert.Equal("explicit", Project.GetAndCheckProjectId("explicit", resource));

            Assert.Equal(expectedProjectId, Project.GetProjectId(null, resource));
            if (expectedProjectId is null)
            {
                Assert.Throws<InvalidOperationException>(() => Project.GetAndCheckProjectId(null, resource));
            }
            else
            {
                Assert.Equal(expectedProjectId, Project.GetAndCheckProjectId(null, resource));
            }
        }

        [Theory]
        [InlineData("gae_app", "service")]
        [InlineData("gce_instance", null)]
        [InlineData("container", "container")]
        [InlineData("gke_container", "container")]
        [InlineData("k8s_container", "container")]
        [InlineData("cloud_run_revision", "service")]
        [InlineData("unknown", null)]
        public void GetServiceName(string type, string expectedServiceName)
        {
            var resource = s_resources[type];
            Assert.Equal("explicit", Project.GetServiceName("explicit", resource));
            Assert.Equal("explicit", Project.GetAndCheckServiceName("explicit", resource));

            Assert.Equal(expectedServiceName, Project.GetServiceName(null, resource));
            if (expectedServiceName is null)
            {
                Assert.Throws<InvalidOperationException>(() => Project.GetAndCheckServiceName(null, resource));
            }
            else
            {
                Assert.Equal(expectedServiceName, Project.GetAndCheckServiceName(null, resource));
            }
        }


        [Theory]
        [InlineData("gae_app", "version")]
        [InlineData("gce_instance", null)]
        [InlineData("container", null)]
        [InlineData("gke_container", null)]
        [InlineData("k8s_container", null)]
        [InlineData("cloud_run_revision", "revision")]
        [InlineData("unknown", null)]
        public void GetServiceVersion(string type, string expectedServiceVersion)
        {
            var resource = s_resources[type];
            Assert.Equal("explicit", Project.GetServiceVersion("explicit", resource));
            Assert.Equal("explicit", Project.GetAndCheckServiceVersion("explicit", resource));

            Assert.Equal(expectedServiceVersion, Project.GetServiceVersion(null, resource));
            if (expectedServiceVersion is null)
            {
                Assert.Throws<InvalidOperationException>(() => Project.GetAndCheckServiceVersion(null, resource));
            }
            else
            {
                Assert.Equal(expectedServiceVersion, Project.GetAndCheckServiceVersion(null, resource));
            }
        }

        [Fact]
        public void DoesNotCacheSpecifiedMonitoredResourceInstance()
        {
            var monitoredResource1 = s_resources["gae_app"];
            Assert.Equal("version", Project.GetServiceVersion(null, monitoredResource1));

            // Assert that the first MonitoredResource instance is not cached by checking if the version is correct.
            // Only auto-detected MonitoredResource instances should be cached.
            var monitoredResource2 = s_resources["cloud_run_revision"];
            Assert.Equal("revision", Project.GetServiceVersion(null, monitoredResource2));
        }
    }
}
