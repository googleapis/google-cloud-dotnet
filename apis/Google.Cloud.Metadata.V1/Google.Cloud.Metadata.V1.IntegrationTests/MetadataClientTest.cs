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
        [Fact]
        public void GetAccessToken()
        {
            var client = MetadataClient.Create();
            var tokenResponse = client.GetAccessToken();
            Assert.Equal(tokenResponse.AccessToken, "0123456789ABCDEF");
            Assert.Equal(tokenResponse.ExpiresInSeconds.Value, 3000);
            Assert.Equal(tokenResponse.TokenType, "Bearer");
        }

        [Fact]
        public void GetCustomInstanceMetadata()
        {
            var client = MetadataClient.Create();
            var value = client.GetCustomInstanceMetadata("my_instance_key1");
            Assert.Equal(value, "my_instance_value1");
        }

        [Fact]
        public void GetCustomProjectMetadata()
        {
            var client = MetadataClient.Create();
            var value = client.GetCustomProjectMetadata("my_project_key1");
            Assert.Equal(value, "my_project_value1");
        }

        [Fact]
        public void GetInstanceMetadata()
        {
            var client = MetadataClient.Create();
            var instance = client.GetInstanceMetadata();
            Assert.Equal(instance.CpuPlatform, "Intel Haswell");
            Assert.Equal(instance.Description, "Fake instance for metadata server emulator");
            Assert.Equal(instance.Disks[0].DeviceName, "boot");
            Assert.Equal(instance.Disks[0].Index, 0);
            Assert.Equal(instance.Disks[0].Mode, "READ_WRITE");
            Assert.Equal(instance.Disks[0].Type, "PERSISTENT");
            Assert.Equal(instance.Id.Value, 67890ul);
            Assert.Equal(instance.MachineType, "projects/12345/machineTypes/n1-standard-1");
            Assert.Equal(instance.Metadata.Items.Count, 1);
            Assert.Equal(instance.Metadata.Items[0].Key, "my_instance_key1");
            Assert.Equal(instance.Metadata.Items[0].Value, "my_instance_value1");
            Assert.Equal(instance.Name, "name.project.google.com.internal");
            Assert.Equal(instance.NetworkInterfaces.Count, 1);
            Assert.Equal(instance.NetworkInterfaces[0].AccessConfigs.Count, 1);
            Assert.Equal(instance.NetworkInterfaces[0].AccessConfigs[0].NatIP, "0.0.0.0");
            Assert.Equal(instance.NetworkInterfaces[0].AccessConfigs[0].Type, "ONE_TO_ONE_NAT");
            Assert.Equal(instance.NetworkInterfaces[0].Network, "projects/12345/networks/default");
            Assert.Equal(instance.NetworkInterfaces[0].NetworkIP, "0.0.0.0");
            Assert.Equal(instance.Scheduling.AutomaticRestart, true);
            Assert.Equal(instance.Scheduling.OnHostMaintenance, "MIGRATE");
            Assert.Equal(instance.Scheduling.Preemptible, false);
            Assert.Equal(instance.ServiceAccounts.Count, 2);
            Assert.Equal(instance.ServiceAccounts[0].Email, "12345-compute@developer.gserviceaccount.com");
            Assert.Equal(instance.ServiceAccounts[0].Scopes.Count, 2);
            Assert.Equal(instance.ServiceAccounts[0].Scopes[0], "https://www.googleapis.com/auth/cloud-platform");
            Assert.Equal(instance.ServiceAccounts[0].Scopes[1], "https://www.googleapis.com/auth/userinfo.email");
            Assert.Equal(instance.ServiceAccounts[1].Email, "default");
            Assert.Equal(instance.ServiceAccounts[1].Scopes.Count, 2);
            Assert.Equal(instance.ServiceAccounts[1].Scopes[0], "https://www.googleapis.com/auth/cloud-platform");
            Assert.Equal(instance.ServiceAccounts[1].Scopes[1], "https://www.googleapis.com/auth/userinfo.email");
            Assert.Equal(instance.Tags.Items.Count, 3);
            Assert.Equal(instance.Tags.Items[0], "a");
            Assert.Equal(instance.Tags.Items[1], "b");
            Assert.Equal(instance.Tags.Items[2], "c");
            Assert.Equal(instance.Zone, "projects/12345/zones/us-central1-f");
        }

        [Fact]
        public void GetMaintenanceStatus()
        {
            var client = MetadataClient.Create();
            var status = client.GetMaintenanceStatus();
            Assert.Equal(status, MaintenanceStatus.None);
        }

        [Fact]
        public void GetProjectMetadata()
        {
            var client = MetadataClient.Create();
            var project = client.GetProjectMetadata();
            Assert.Equal(project.CommonInstanceMetadata.Items.Count, 1);
            Assert.Equal(project.CommonInstanceMetadata.Items[0].Key, "my_project_key1");
            Assert.Equal(project.CommonInstanceMetadata.Items[0].Value, "my_project_value1");
            Assert.Equal(project.Id.Value, 12345ul);
            Assert.Equal(project.Name, "fake-project");
        }

        [Fact]
        public void IsServerAvailable()
        {
            var client = MetadataClient.Create();
            Assert.True(client.IsServerAvailable());
        }

        [Fact]
        public void WaitForChanges()
        {
            var client = MetadataClient.Create();
            var sw = Stopwatch.StartNew();
            var result = client.WaitForChange("instance/tags", TimeSpan.FromSeconds(7));
            sw.Stop();
            Assert.Equal(result, "[\"a\",\"b\",\"c\"]");
            Assert.True(sw.Elapsed.TotalSeconds >= 7);
        }
    }
}
