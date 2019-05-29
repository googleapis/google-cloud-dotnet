using Grpc.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.OrderingKeyTester
{
    class Program
    {
        private class InputLine
        {
            public InputLine(string line)
            {
                var parts = line.Split(',');
                if (parts.Length != 2)
                {
                    throw new Exception("Expected two parts in input file.");
                }
                OrderingKey = parts[0].Trim('"');
                Message = parts[1].Trim('"');
            }

            public string OrderingKey { get; }
            public string Message { get; }
        }

        static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Call with three args: <emulator port> <input file> <output file>");
                Console.WriteLine("This connects to host 127.0.0.1, so requires the emulator to be started using ipv4, not ipv6:");
                Console.WriteLine("  E.g. cloud-pubsub-emulator.bat --host=127.0.0.1 --port=8700");
                Console.WriteLine("It reads and writes CSV files as specified in the 'Testing Ordering Keys' section of the");
                Console.WriteLine("  'Pub/Sub Ordering Key Client Libraries' doc.");
                Console.WriteLine();
                return 1;
            }

            var port = int.Parse(args[0]);
            var channel = new Channel("127.0.0.1", port, ChannelCredentials.Insecure);

            var inputLines = File.ReadAllLines(args[1]).Select(line => new InputLine(line)).ToList();

            var topicName = new TopicName("project", $"topic-{Guid.NewGuid()}");
            var subscriptionName = new SubscriptionName("project", $"subscription-{Guid.NewGuid()}");

            Console.WriteLine("Creating topic and subscription");
            var pubApi = PublisherServiceApiClient.Create(channel);
            var topic = pubApi.CreateTopic(topicName);
            var subApi = SubscriberServiceApiClient.Create(channel);
            var subscription = subApi.CreateSubscription(new Subscription
            {
                EnableMessageOrdering = true,
                TopicAsTopicNameOneof = TopicNameOneof.From(topicName),
                SubscriptionName = subscriptionName,
                AckDeadlineSeconds = 120,
            });

            Console.WriteLine("Creating subscribers");
            var subs = new[]
            {
                SubscriberServiceApiClient.Create(channel),
                SubscriberServiceApiClient.Create(channel),
                SubscriberServiceApiClient.Create(channel)
            };
            var sub = new SubscriberClientImpl(subscriptionName, subs, new SubscriberClient.Settings(), null);
            var recvCount = 0;
            var recvMsgs = new List<PubsubMessage>();
            var rnd = new Random();
            Console.WriteLine("Starting subscriber callback");
            var subTask = sub.StartAsync(async (msg, ct) =>
            {
                lock (recvMsgs)
                {
                    recvMsgs.Add(msg.Clone());
                    recvCount += 1;
                    if (recvCount == inputLines.Count)
                    {
                        Console.WriteLine("Received all messages, shutting down");
                        var dummyTask = sub.StopAsync(CancellationToken.None);
                    }
                }
                if (rnd.Next(3) == 0)
                {
                    await Task.Delay(rnd.Next(3));
                }
                return SubscriberClient.Reply.Ack;
            });

            Console.WriteLine("Creating publishers");
            var pubs = new[]
            {
                PublisherServiceApiClient.Create(channel),
                PublisherServiceApiClient.Create(channel),
                PublisherServiceApiClient.Create(channel)
            };
            var pub = new PublisherClientImpl(topicName, pubs, new PublisherClient.Settings { EnableMessageOrdering = true }, null);
            var pubTasks = new List<Task>();
            Console.WriteLine("Starting to publish");
            foreach (var inputLine in inputLines)
            {
                var pubTask = pub.PublishAsync(inputLine.OrderingKey, inputLine.Message);
                pubTasks.Add(pubTask);
            }
            Console.WriteLine("Publishing complete");

            Console.WriteLine("Waiting for all publish tasks to complete");
            Task.WaitAll(pubTasks.ToArray());
            Console.WriteLine("All publish tasks completed");

            Console.WriteLine("Waiting for subscribe task to complete");
            subTask.Wait();
            Console.WriteLine("Subscribe task completed");

            var csvLines = recvMsgs.Select(x => $"\"{x.OrderingKey}\",\"{x.Data.ToStringUtf8()}\"").ToList();
            File.WriteAllLines(args[2], csvLines);
            Console.WriteLine("Output file written; all done :)");

            return 0;
        }
    }
}
