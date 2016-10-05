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

using Google.Apis.Compute.v1.Data;
using Google.Cloud.Metadata.V1;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Metadata.V1.Snippets
{
    [Collection(nameof(MetadataSnippetFixture))]
    public class MetadataClientSnippets
    {
        private readonly MetadataSnippetFixture _fixture;

        public MetadataClientSnippets(MetadataSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void GetCustomInstanceMetadata()
        {
            // Snippet: GetCustomInstanceMetadata
            MetadataClient client = MetadataClient.Create();
            string customValue = client.GetCustomInstanceMetadata("my_instance_key1");
            Console.WriteLine(customValue);
            // End snippet

            Assert.Equal("my_instance_value1", customValue);
        }

        [Fact]
        public void GetInstanceMetadata()
        {
            // Snippet: GetInstanceMetadata
            MetadataClient client = MetadataClient.Create();
            Instance instance = client.GetInstanceMetadata();
            Console.Write(instance.Zone);
            // End snippet

            Assert.Equal(instance.Zone, "projects/12345/zones/us-central1-f");
        }

        [Fact]
        public void GetMaintenanceStatus()
        {
            // Snippet: GetMaintenanceStatus
            MetadataClient client = MetadataClient.Create();
            MaintenanceStatus status = client.GetMaintenanceStatus();
            if (status == MaintenanceStatus.Migrate)
            {
                // Backup data
            }
            // End snippet
            
            Assert.Equal(MaintenanceStatus.None, status);
        }

        [Fact]
        public void WaitForChange()
        {
            // Snippet: WaitForChange
            MetadataClient client = MetadataClient.Create();
            string result = client.WaitForChange("instance/attributes", timeout: TimeSpan.FromSeconds(5));
            JObject currentCustomMetadata = JObject.Parse(result);
            foreach(JProperty customMetadata in currentCustomMetadata.Properties())
            {
                Console.WriteLine(customMetadata.Name + " = " + customMetadata.Value);
            }
            // End snippet
            Assert.Equal("{\"my_instance_key1\":\"my_instance_value1\"}", result);
        }
    }
}
