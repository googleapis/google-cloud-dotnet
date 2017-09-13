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
using Google.Cloud.ClientTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Metadata.V1.Snippets
{
    [SnippetOutputCollector]
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

            Assert.Equal("projects/12345/zones/us-central1-f", instance.Zone);
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
        public void GetMetadata()
        {
            // Snippet: GetMetadata
            MetadataClient client = MetadataClient.Create();

            MetadataResult result = client.GetMetadata("instance/attributes");
            JObject initialMetadata = JObject.Parse(result.Content);
            foreach (JProperty property in initialMetadata.Properties())
            {
                Console.WriteLine(property.Name + " = " + property.Value);
            }
            // End snippet
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

            // Snippet: WaitForChange
            MetadataClient client = MetadataClient.Create();

            // Get the original metadata and its ETag so we know when the metadata changes.
            MetadataResult initialResult = client.GetMetadata("instance/attributes");
            Console.WriteLine("Initial Metadata:");
            JObject initialMetadata = JObject.Parse(initialResult.Content);
            foreach (JProperty property in initialMetadata.Properties())
            {
                Console.WriteLine(property.Name + " = " + property.Value);
            }
            string lastETag = initialResult.ETag;

            MetadataResult changeResult;
            while (true)
            {
                // Wait in 30 second blocks until the value actually changes.
                changeResult = client.WaitForChange("instance/attributes", lastETag, TimeSpan.FromSeconds(30));
                if (changeResult.ETag != lastETag)
                {
                    Console.WriteLine("Changed Metadata:");
                    JObject currentMetadata = JObject.Parse(changeResult.Content);
                    foreach (JProperty property in currentMetadata.Properties())
                    {
                        Console.WriteLine(property.Name + " = " + property.Value);
                    }
                    break;
                }
            }
            // End snippet

            dynamic obj = JsonConvert.DeserializeObject(changeResult.Content);
            Assert.Equal(newValue, obj[key].Value);
            await task;
        }
    }
}
