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

using Google.Pubsub.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PublisherClientSnippets
{
    public void ListTopics()
    {
        // <ListTopics>
        PublisherClient client = PublisherClient.Create();
        // Alternative: use a known project resource name:
        // projects/{PROJECT_ID}
        string projectName = PublisherClient.GetProjectName("PROJECT_ID");
        foreach (Topic topic in client.ListTopics(projectName))
        {
            Console.WriteLine(topic.Name);
        }
        // </ListTopics>
    }

    public async Task ListTopicsAsync()
    {
        // <ListTopicsAsync>
        PublisherClient client = PublisherClient.Create();
        // Alternative: use a known project resource name:
        // projects/{PROJECT_ID}
        string projectName = PublisherClient.GetProjectName("{PROJECT_ID}");
        IAsyncEnumerable<Topic> topics = client.ListTopicsAsync(projectName);
        await topics.ForEachAsync(topic =>
        {
            Console.WriteLine(topic.Name);
        });
        // </ListTopicsAsync>
    }

    public void CreateTopic()
    {
        // <CreateTopic>
        PublisherClient client = PublisherClient.Create();
        // Alternative: use a known topic resource name
        // projects/{PROJECT_ID}/topics/{TOPIC_ID}
        string topicName = PublisherClient.GetTopicName("{PROJECT_ID}", "{TOPIC_ID}");
        Topic topic = client.CreateTopic(topicName);
        Console.WriteLine($"Created {topic.Name}");
        // </CreateTopic>
    }

    public async Task CreateTopicAsync()
    {
        // <CreateTopicAsync>
        PublisherClient client = PublisherClient.Create();
        // Alternative: use a known topic resource name
        // projects/{PROJECT_ID}/topics/{TOPIC_ID}
        string topicName = PublisherClient.GetTopicName("{PROJECT_ID}", "{TOPIC_ID}");
        Topic topic = await client.CreateTopicAsync(topicName);
        Console.WriteLine($"Created {topic.Name}");
        // </CreateTopicAsync>
    }
}