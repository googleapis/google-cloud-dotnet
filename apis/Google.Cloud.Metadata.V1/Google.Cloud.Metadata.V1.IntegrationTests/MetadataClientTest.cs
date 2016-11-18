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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Metadata.V1.IntegrationTests
{
    [Collection(nameof(MetadataFixture))]
    public class MetadataClientTest
    {
        private readonly MetadataFixture _fixture;

        public MetadataClientTest(MetadataFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void GetAccessToken()
        {
            var client = MetadataClient.Create();
            var tokenResponse = client.GetAccessToken();
            Assert.Equal("0123456789ABCDEF", tokenResponse.AccessToken);
            Assert.Equal(3000, tokenResponse.ExpiresInSeconds.Value);
            Assert.Equal("Bearer", tokenResponse.TokenType);
        }

        [Fact]
        public void GetCustomInstanceMetadata()
        {
            var client = MetadataClient.Create();
            var value = client.GetCustomInstanceMetadata("my_instance_key1");
            Assert.Equal("my_instance_value1", value);
        }

        [Fact]
        public void GetCustomProjectMetadata()
        {
            var client = MetadataClient.Create();
            var value = client.GetCustomProjectMetadata("my_project_key1");
            Assert.Equal("my_project_value1", value);
        }

        [Fact]
        public void GetInstanceMetadata()
        {
            var client = MetadataClient.Create();
            var instance = client.GetInstanceMetadata();
            Assert.Equal("Intel Haswell", instance.CpuPlatform);
            Assert.Equal("Fake instance for metadata server emulator", instance.Description);
            Assert.Equal("boot", instance.Disks[0].DeviceName);
            Assert.Equal(0, instance.Disks[0].Index);
            Assert.Equal("READ_WRITE", instance.Disks[0].Mode);
            Assert.Equal("PERSISTENT", instance.Disks[0].Type);
            Assert.Equal(67890ul, instance.Id.Value);
            Assert.Equal("projects/12345/machineTypes/n1-standard-1", instance.MachineType);
            Assert.Equal(1, instance.Metadata.Items.Count);
            Assert.Equal("my_instance_key1", instance.Metadata.Items[0].Key);
            Assert.Equal("my_instance_value1", instance.Metadata.Items[0].Value);
            Assert.Equal("name.project.google.com.internal", instance.Name);
            Assert.Equal(1, instance.NetworkInterfaces.Count);
            Assert.Equal(1, instance.NetworkInterfaces[0].AccessConfigs.Count);
            Assert.Equal("0.0.0.0", instance.NetworkInterfaces[0].AccessConfigs[0].NatIP);
            Assert.Equal("ONE_TO_ONE_NAT", instance.NetworkInterfaces[0].AccessConfigs[0].Type);
            Assert.Equal("projects/12345/networks/default", instance.NetworkInterfaces[0].Network);
            Assert.Equal("0.0.0.0", instance.NetworkInterfaces[0].NetworkIP);
            Assert.Equal(true, instance.Scheduling.AutomaticRestart);
            Assert.Equal("MIGRATE", instance.Scheduling.OnHostMaintenance);
            Assert.Equal(false, instance.Scheduling.Preemptible);
            Assert.Equal(2, instance.ServiceAccounts.Count);
            Assert.Equal("12345-compute@developer.gserviceaccount.com", instance.ServiceAccounts[0].Email);
            Assert.Equal(2, instance.ServiceAccounts[0].Scopes.Count);
            Assert.Equal("https://www.googleapis.com/auth/cloud-platform", instance.ServiceAccounts[0].Scopes[0]);
            Assert.Equal("https://www.googleapis.com/auth/userinfo.email", instance.ServiceAccounts[0].Scopes[1]);
            Assert.Equal("default", instance.ServiceAccounts[1].Email);
            Assert.Equal(2, instance.ServiceAccounts[1].Scopes.Count);
            Assert.Equal("https://www.googleapis.com/auth/cloud-platform", instance.ServiceAccounts[1].Scopes[0]);
            Assert.Equal("https://www.googleapis.com/auth/userinfo.email", instance.ServiceAccounts[1].Scopes[1]);
            Assert.Equal(3, instance.Tags.Items.Count);
            Assert.Equal("a", instance.Tags.Items[0]);
            Assert.Equal("b", instance.Tags.Items[1]);
            Assert.Equal("c", instance.Tags.Items[2]);
            Assert.Equal("projects/12345/zones/us-central1-f", instance.Zone);
        }

        [Fact]
        public void GetMaintenanceStatus()
        {
            var client = MetadataClient.Create();
            var status = client.GetMaintenanceStatus();
            Assert.Equal(MaintenanceStatus.None, status);
        }

        [Fact]
        public void GetProjectMetadata()
        {
            var client = MetadataClient.Create();
            var project = client.GetProjectMetadata();
            Assert.Equal(1, project.CommonInstanceMetadata.Items.Count);
            Assert.Equal("my_project_key1", project.CommonInstanceMetadata.Items[0].Key);
            Assert.Equal("my_project_value1", project.CommonInstanceMetadata.Items[0].Value);
            Assert.Equal(12345ul, project.Id.Value);
            Assert.Equal("fake-project", project.Name);
        }

        [Fact]
        public void IsServerAvailable()
        {
            var client = MetadataClient.Create();
            Assert.True(client.IsServerAvailable());
        }

        [Fact]
        public void WaitForChange()
        {
            const string key = "my_instance_key1";

            var client = MetadataClient.Create();
            var originalValue = client.GetCustomInstanceMetadata(key);

            var task = Task.Run(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                await _fixture.UpdateMetadata($"instance/attributes/{key}", "foo");
                await _fixture.UpdateMetadata($"instance/attributes/{key}", originalValue);
            });
            try
            {
                var result = client.WaitForChange("instance/attributes");
                Assert.Equal(result, "{\"my_instance_key1\":\"foo\"}");
            }
            finally
            {
                task.Wait();
            }
        }

        [Fact]
        public void WaitForChangeTimeout()
        {
            var client = MetadataClient.Create();

            // Wait for change on a value key
            var sw = Stopwatch.StartNew();
            var result = client.WaitForChange("instance/tags", TimeSpan.FromSeconds(7));
            sw.Stop();
            Assert.Equal(result, "[\"a\",\"b\",\"c\"]");
            Assert.True(sw.Elapsed.TotalSeconds >= 7);

            // Wait for change on a directory key
            sw = Stopwatch.StartNew();
            result = client.WaitForChange("instance/attributes", TimeSpan.FromSeconds(5));
            sw.Stop();
            Assert.Equal(result, "{\"my_instance_key1\":\"my_instance_value1\"}");
            Assert.True(sw.Elapsed.TotalSeconds >= 5);
        }
    }
}
