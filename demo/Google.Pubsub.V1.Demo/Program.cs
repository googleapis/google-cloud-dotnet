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

using Google.Api.Gax;
using Google.Protobuf;
using Microsoft.Framework.Runtime.Common.CommandLine;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Pubsub.V1.Demo
{
    /// <summary>
    /// Command line application to demonstrate features of the Google Cloud PubSub library.
    /// </summary>
    public class Program
    {
        // Note: these templates will be in the generated library, with helper methods to expand/parse names.
        private static readonly PathTemplate ProjectTemplate = new PathTemplate("projects/{project}");
        private static readonly PathTemplate TopicTemplate = new PathTemplate("projects/{project}/topics/{topic}");
        private static readonly PathTemplate SubscriptionTemplate = new PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>
        /// Entry point for the application.
        /// </summary>
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "pubsub-demo",
                Description = "Demonstrates the Google Cloud PubSub library",
                FullName = "pubsub-demo - simple demonstration application for the Google Cloud PubSub",
            };

            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 2;
            });

            app.Command("list-topics", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "List topics in a Google Cloud Project";
                var project = config.Argument("project", "Google Cloud Project ID to list topics from");
                ConfigureForExecution(config, client => ListTopics(client, project.Value));
            });

            app.Command("create-topic", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Create a topic in a Google Cloud Project";
                var project = config.Argument("project", "Google Cloud Project ID to create topic in");
                var topic = config.Argument("topic", "Name of topic to create");

                ConfigureForExecution(config, client => CreateTopic(client, project.Value, topic.Value));
            });

            app.Command("publish-message", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Publish a message in a Pubsub topic";
                var project = config.Argument("project", "Google Cloud Project ID containing the topic");
                var topic = config.Argument("topic", "ID of topic to publish a message in");
                var message = config.Argument("message", "Message to publish");
                ConfigureForExecution(config, client => PublishMessage(client, project.Value, topic.Value, message.Value));
            });

            app.Command("subscribe", config => {
                config.HelpOption("-?|-h|--help");
                config.Description = "Subscribe to a topic, printing out messages until a QUIT message is received";
                var project = config.Argument("project", "Google Cloud Project ID containing the topic");
                var topic = config.Argument("topic", "ID of topic to subscribe to");
                ConfigureForExecution(config, client => Subscribe(client, project.Value, topic.Value));
            });

            return app.Execute(args);
        }

        /// <summary>
        /// Helper method to validate that all arguments have been provided, obtain a Publisher and a Subscriber,
        /// and then call the given command. We might want to make this an extension method at some point.
        /// </summary>
        private static void ConfigureForExecution(CommandLineApplication config, Func<PublisherClient, Task> command)
        {
            ConfigureForExecution(config, () => PublisherClient.CreateAsync(), command);
        }

        private static void ConfigureForExecution(CommandLineApplication config, Func<SubscriberClient, Task> command)
        {
            ConfigureForExecution(config, () => SubscriberClient.CreateAsync(), command);
        }

        private static void ConfigureForExecution<TClient>(CommandLineApplication config, Func<Task<TClient>> clientProvider, Func<TClient, Task> command)
        {
            config.OnExecute(async () =>
            {
                foreach (var argument in config.Arguments)
                {
                    if (argument.Values.Count == 0)
                    {
                        Console.WriteLine($"Argument '{argument.Name}' not specified");
                        return 1;
                    }
                }
                try
                {
                    var client = await clientProvider();
                    await command(client);
                    return 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return 1;
                }
            });
        }

        private static Task ListTopics(PublisherClient client, string projectId)
        {
            var topics = client.ListTopicsAsync(ProjectTemplate.Expand(projectId));
            Console.WriteLine($"Topics in {projectId}:");
            return topics.ForEachAsync(topic => Console.WriteLine($"  {topic.Name}"));
        }

        private static Task CreateTopic(PublisherClient client, string projectId, string topicId)
        {
            return client.CreateTopicAsync(TopicTemplate.Expand(projectId, topicId));
        }

        private static Task PublishMessage(PublisherClient client, string projectId, string topicId, string message)
        {
            var messages = new[] { new PubsubMessage { Data = ByteString.CopyFromUtf8(message) } };
            return client.PublishAsync(TopicTemplate.Expand(projectId, topicId), messages);
        }

        private static async Task Subscribe(SubscriberClient client, string projectId, string topicId)
        {
            string topicName = TopicTemplate.Expand(projectId, topicId);
            var subscriptionName = SubscriptionTemplate.Expand(projectId, "sub-" + Guid.NewGuid());
            var subscription = await client.CreateSubscriptionAsync(subscriptionName, topicName, null, 10);
            try
            {
                bool keepGoing = true;
                while (keepGoing)
                {
                    var pullResponse = await client.PullAsync(subscription.Name, false, 10);
                    await client.AcknowledgeAsync(subscription.Name, pullResponse.ReceivedMessages.Select(resp => resp.AckId));
                    foreach (var message in pullResponse.ReceivedMessages)
                    {
                        var text = message.Message.Data.ToStringUtf8();
                        if (text == "QUIT")
                        {
                            keepGoing = false; // Stop *after* the end of this set of messages
                        }
                        Console.WriteLine(text);
                    }
                }
            }
            finally
            {
                await client.DeleteSubscriptionAsync(subscription.Name);
            }
        }
    }
}
