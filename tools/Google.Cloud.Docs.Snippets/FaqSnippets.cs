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

using Google.Cloud.PubSub.V1;
using Grpc.Core;
using System;

namespace Google.Cloud.Tools.Snippets
{
    public class FaqSnippets
    {
        public void Emulator()
        {
            // Sample: Emulator
            // For example, "localhost:8615"
            string emulatorHostAndPort = Environment.GetEnvironmentVariable("PUBSUB_EMULATOR_HOST");

            Channel channel = new Channel(emulatorHostAndPort, ChannelCredentials.Insecure);
            PublisherClient client = PublisherClient.Create(channel);
            client.CreateTopic(new TopicName("project", "topic"));
            foreach (var topic in client.ListTopics(new ProjectName("project")))
            {
                Console.WriteLine(topic.Name);
            }
            // End sample
        }
    }
}
