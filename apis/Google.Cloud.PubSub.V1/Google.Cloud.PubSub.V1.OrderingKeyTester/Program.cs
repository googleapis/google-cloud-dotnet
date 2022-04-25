using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.OrderingKeyTester
{
    /// <summary>
    /// Tests the "ordering-keys" public client implementation.
    /// Use the `ordering_key_generator` to generate the input CSV file, then run this program, then verify
    /// the output CSV file using the `ordering_key_verifier`.
    /// The input and output CSV files contain lines in the format:
    ///   "{ordering key, or empty string for no ordering key}","{message text}"
    /// Before running this test the pubsub emulator must be started on localhost using ipv4 (not ipv6).
    /// </summary>
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

            // Read inputs.
            var port = int.Parse(args[0]);
            var inputLines = File.ReadAllLines(args[1]).Select(line => new InputLine(line)).ToList();
            // Setup gRPC channel to pubsub emulator.
            var options = new GrpcChannelOptions { Credentials = ChannelCredentials.Insecure };
            var channel = GrpcChannel.ForAddress($"http://127.0.0.1:{port}", options);

            // Create topic and subscription names.
            var topicName = new TopicName("project", $"topic-{Guid.NewGuid()}");
            var subscriptionName = new SubscriptionName("project", $"subscription-{Guid.NewGuid()}");
            // List that records all received messages.
            var recvMsgs = new List<PubsubMessage>();

            // Run test.
            CreateTopicAndSubscription();
            Task subTask = Subscribe();
            IEnumerable<Task> pubTasks = Publish();

            // Wait for publish and subscribe tasks to complete.
            Console.WriteLine("Waiting for all publish tasks to complete");
            Task.WaitAll(pubTasks.ToArray());
            Console.WriteLine("All publish tasks completed");
            Console.WriteLine("Waiting for subscribe task to complete");
            subTask.Wait();
            Console.WriteLine("Subscribe task completed");

            // Output ordered CSV file of recevied messages, for the validator.
            var csvLines = recvMsgs.Select(x => $"\"{x.OrderingKey}\",\"{x.Data.ToStringUtf8()}\"").ToList();
            File.WriteAllLines(args[2], csvLines);
            Console.WriteLine("Output file written; all done :)");

            return 0;

            void CreateTopicAndSubscription()
            {
                Console.WriteLine("Creating topic and subscription");
                var pubApi = CreatePublisher();
                var topic = pubApi.CreateTopic(topicName);
                var subApi = CreateSubscriber();
                subApi.CreateSubscription(new Subscription
                {
                    EnableMessageOrdering = true,
                    TopicAsTopicName = topicName,
                    SubscriptionName = subscriptionName,
                    AckDeadlineSeconds = 120,
                });
            }

            Task Subscribe()
            {
                Console.WriteLine("Creating subscribers");
                var subs = new[]
                {
                    CreateSubscriber(),
                    CreateSubscriber(),
                    CreateSubscriber()
                };
                var sub = new SubscriberClientImpl(subscriptionName, subs, new SubscriberClient.Settings(), null);
                var recvCount = 0;
                var rnd = new Random();
                Console.WriteLine("Starting subscriber callback");
                return sub.StartAsync(async (msg, ct) =>
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
            }

            IEnumerable<Task> Publish()
            {
                Console.WriteLine("Creating publishers");
                var pubs = new[]
                {
                    CreatePublisher(),
                    CreatePublisher(),
                    CreatePublisher()
                };
                var pub = new PublisherClientImpl(topicName, pubs, new PublisherClient.Settings { EnableMessageOrdering = true }, null);
                var publishTasks = new List<Task>();
                Console.WriteLine("Starting to publish");
                foreach (var inputLine in inputLines)
                {
                    var pubTask = pub.PublishAsync(inputLine.OrderingKey, inputLine.Message);
                    publishTasks.Add(pubTask);
                }
                Console.WriteLine("Publishing complete");
                return publishTasks;
            }

            PublisherServiceApiClient CreatePublisher() => new PublisherServiceApiClientBuilder { CallInvoker = channel.CreateCallInvoker() }.Build();
            SubscriberServiceApiClient CreateSubscriber() => new SubscriberServiceApiClientBuilder { CallInvoker = channel.CreateCallInvoker() }.Build();
        }
    }
}
