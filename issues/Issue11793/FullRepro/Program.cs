// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.PubSub.V1;
using Google.Protobuf;
using Microsoft.Extensions.Logging;
using Reply = Google.Cloud.PubSub.V1.SubscriberClient.Reply;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: ");
    Console.WriteLine("  To create the topic and subscription: <project-id> setup");
    Console.WriteLine("  To test the topic and subsciption: <project-id> <id>");
    Console.WriteLine("    (The ID for the second command is printed by the first.");
    return;
}

if (args[1] == "setup")
{
    CreateTopicAndSubscription(args[0]);
}
else
{
    await RunTest(args[0], args[1]);
}

async Task RunTest(string projectId, string id)
{
    var loggerFactory = LoggerFactory.Create(builder => builder.AddSimpleConsole(options =>
    {
        options.SingleLine = true;
        options.TimestampFormat = "yyyy-MM-dd'T'HH:mm:ss.fff'Z '";
        options.UseUtcTimestamp = true;
    }));

    var task = await Task.WhenAny(Subscribe(), Publish());
    await task;

    async Task Subscribe()
    {
        var subscriber = new SubscriberClientBuilder
        {
            SubscriptionName = new SubscriptionName(projectId, id),
            Logger = loggerFactory.CreateLogger("Subscriber")
        }.Build();

        var handlerLogger = loggerFactory.CreateLogger("Handler");

        handlerLogger.LogInformation("Starting subscriber");
        await subscriber.StartAsync(HandleMessages);

        Task<Reply> HandleMessages(PubsubMessage message, CancellationToken cancellationToken)
        {
            var reply = message.OrderingKey.StartsWith("nack") ? Reply.Nack : Reply.Ack;
            handlerLogger.LogInformation("Received message with ordering key '{key}' and text '{text}'. Returning '{reply}'. MessageID='{id}'",
                message.OrderingKey, message.Data.ToStringUtf8(), reply, message.MessageId);
            return Task.FromResult(reply);
        }
    }

    async Task Publish()
    {
        var publisher = new PublisherClientBuilder
        {
            TopicName = new TopicName(projectId, id),
            Logger = loggerFactory.CreateLogger("PublisherClient"),
            Settings = new() { EnableMessageOrdering = true }
        }.Build();


        var logger = loggerFactory.CreateLogger("Publish");
        await Task.Delay(5000);
        logger.LogInformation("Starting publishing.");
        await PublishAsync("Normal 1", "normal");
        await Task.Delay(2000);
        await PublishAsync("Normal 2", "normal");
        await Task.Delay(2000);
        await PublishAsync("Nack 1", "nack");
        await Task.Delay(15000);
        await PublishAsync("Normal 3", "normal");
        await PublishAsync("Nack 2", "nack");
        logger.LogInformation("Publishing complete. Waiting for 2 minutes");
        await Task.Delay(TimeSpan.FromMinutes(2));

        async Task PublishAsync(string text, string orderingKey)
        {
            logger.LogInformation("Publishing message with text '{text}' and ordering key '{orderingKey}'",
                text, orderingKey);
            await publisher.PublishAsync(new PubsubMessage
            {
                Data = ByteString.CopyFromUtf8(text),
                OrderingKey = orderingKey
            });
        }
    }
}

void CreateTopicAndSubscription(string projectId)
{
    var id = $"issue11793-{DateTime.UtcNow:yyyyMMddTHHmmss}";
    var topicName = new TopicName(projectId, id);
    var deadLetterTopicName = new TopicName(projectId, $"{id}-deadletter");
    var subscriptionName = new SubscriptionName(projectId, id);
    var deadLetterSubscriptionName = new SubscriptionName(projectId, $"{id}-deadletter");

    var publisherClient = PublisherServiceApiClient.Create();
    publisherClient.CreateTopic(topicName);
    publisherClient.CreateTopic(deadLetterTopicName);

    var subscriberClient = SubscriberServiceApiClient.Create();
    var subscription = new Subscription
    {
        SubscriptionName = subscriptionName,
        TopicAsTopicName = topicName,
        DeadLetterPolicy = new DeadLetterPolicy { DeadLetterTopic = deadLetterTopicName.ToString(), MaxDeliveryAttempts = 5 },
        EnableExactlyOnceDelivery = true,
        EnableMessageOrdering = true        
    };
    subscriberClient.CreateSubscription(subscription);
    subscriberClient.CreateSubscription(deadLetterSubscriptionName, deadLetterTopicName, pushConfig: null, ackDeadlineSeconds: 10);

    Console.WriteLine($"Test ID: {id}");
    Console.WriteLine("Created:");
    Console.WriteLine($"  Topic: {topicName}");
    Console.WriteLine($"  Topic: {deadLetterTopicName}");
    Console.WriteLine($"  Subscription: {subscriptionName}");
    Console.WriteLine($"  Subscription: {deadLetterSubscriptionName}");
    Console.WriteLine();
    Console.WriteLine("First grant dead letter access at:");
    Console.WriteLine($"https://console.cloud.google.com/cloudpubsub/subscription/detail/{topicName.TopicId}?project={projectId}&tab=diagnostic");
    Console.WriteLine();
    Console.WriteLine("Then run test with:");
    Console.WriteLine($"dotnet run -- {projectId} {id}");
}
