// Copyright 2025 Google Inc. All Rights Reserved.
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

using Google.Cloud.PubSub.V1;
using Google.Protobuf.WellKnownTypes;
using Xunit;

namespace Google.Cloud.Tools.Snippets;

[Collection(nameof(SnippetFixture))]
public class UpdateMaskSnippets
{
    private readonly SnippetFixture _fixture;

    public UpdateMaskSnippets(SnippetFixture fixture) => _fixture = fixture;

    [Fact]
    public void UpdateMasks()
    {
        var topicName = _fixture.CreateTopic();

        // Sample: UpdateMasks
        PublisherServiceApiClient client = PublisherServiceApiClient.Create();

        // Create a resource with the values you want to update
        Topic topic = new Topic
        {
            // Set the full resource name
            Name = topicName,
            // Populate the fields we intend to change
            Labels = { { "env", "production" } }
        };

        // Create the FieldMask
        FieldMask updateMask = new FieldMask
        {
            // Add the original protobuf field name.
            // In this example, the C# property is 'Labels', but the protobuf field name is 'labels'.
            Paths = { "labels" }
        };

        client.UpdateTopic(topic, updateMask);
        // End sample
    }
}
