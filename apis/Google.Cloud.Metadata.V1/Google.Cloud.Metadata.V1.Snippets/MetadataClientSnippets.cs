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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task WaitForChange()
        {
            const string newValue = "foo";
            string key = _fixture.GenerateCustomKey();

            await _fixture.UpdateMetadataAsync($"instance/attributes/{key}", "initial value");

            var task = Task.Run(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
                await _fixture.UpdateMetadataAsync($"instance/attributes/{key}", newValue);
            });

            // TODO: This pattern to get the original ETag seems messy. Maybe add something to get an ETag.

            // Snippet: WaitForChange
            MetadataClient client = MetadataClient.Create();

            // Get the original ETag so we know when the metadata changes.
            string lastETag = client.WaitForChange("instance/attributes", timeout: TimeSpan.FromMilliseconds(1)).ETag;

            WaitForChangeResult result;
            while (true)
            {
                // Wait in 30 second blocks until the value actually changes.
                result = client.WaitForChange("instance/attributes", lastETag, TimeSpan.FromSeconds(30));
                if (result.ETag != lastETag)
                {
                    JObject currentCustomMetadata = JObject.Parse(result.Content);
                    foreach (JProperty customMetadata in currentCustomMetadata.Properties())
                    {
                        Console.WriteLine(customMetadata.Name + " = " + customMetadata.Value);
                    }
                    break;
                }
            }
            // End snippet

            dynamic obj = JsonConvert.DeserializeObject(result.Content);
            Assert.Equal(newValue, obj[key].Value);
            await task;
        }
    }
}
