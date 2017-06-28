using Google.Cloud.PubSub.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.IntegrationTests
{
    [Collection(nameof(PubsubFixture))]
    public class SimpleTest
    {
        public SimpleTest(PubsubFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly PubsubFixture _fixture;

        [Fact]
        public async Task A()
        {
            var topicId = _fixture.CreateTopicId();
            var subscriptionId = _fixture.CreateSubscriptionId();

            // Create topic
            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var publisher = await PublisherClient.CreateAsync().ConfigureAwait(false);
            await publisher.CreateTopicAsync(topicName).ConfigureAwait(false);

            // Subscribe to the topic
            var subscriber = await SubscriberClient.CreateAsync().ConfigureAwait(false);
            var subscriptionName = new SubscriptionName(_fixture.ProjectId, subscriptionId);
            await subscriber.CreateSubscriptionAsync(subscriptionName, topicName, null, 60).ConfigureAwait(false);

            var msg = new PubsubMessage { Data = ByteString.CopyFromUtf8("a") };
            //await publisher.PublishAsync(topicName, new[] { msg }).ConfigureAwait(false);
            Console.WriteLine("About to create hi-perf pulisher...");
            var hiPublisher = await HiPerfPublisher.CreateAsync(topicName, new HiPerfPublisher.Settings {  }).ConfigureAwait(false);

            Console.WriteLine("Pulling messages...");
            var cts = new CancellationTokenSource();
            var hiSubscriber = HiPerfSubscriber.Create(subscriptionName);
            int msgCount = 0;
            var recvMsgs = new HashSet<string>();
            const int testSize = 1_000_000;
            Task subTask = hiSubscriber.StartAsync((msg1, ct) =>
            {
                if (Interlocked.Increment(ref msgCount) >= testSize)
                {
                    Task unused = hiSubscriber.StopAsync(TimeSpan.FromSeconds(15));
                }
                lock (recvMsgs)
                {
                    recvMsgs.Add(msg1.Data.ToStringUtf8().Substring(0, 20));
                }
                //Console.WriteLine($"[{msgCount}][{msg1.MessageId}] '{msg1.Data.ToStringUtf8()}'");
                return Task.FromResult(HiPerfSubscriber.Reply.Ack);
            });

            Console.WriteLine($"About to publish {testSize} messages...");
            var publishedMsgs = new HashSet<string>();
            var longText = new string('Z', 1000);

            var activePubs = new HashSet<Task>();
            int delayCount = 0;
            int delay1Count = 0;
            int msgSentCount = 0;
            /*var unused0 = Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(500), cts.Token).ConfigureAwait(false);
                    ThreadPool.GetMaxThreads(out var wMax, out var cpMax);
                    ThreadPool.GetAvailableThreads(out var wAvail, out var cpAvail);
                    int recvCount;
                    lock (recvMsgs)
                    {
                        recvCount = recvMsgs.Count;
                    }
                    lock (activePubs)
                    {
                        Console.WriteLine($"Published {msgSentCount} msgs, recvCount: {recvCount}, delays:{delayCount}, activeCount:{activePubs.Count}. MaxT=[{wMax},{cpMax}], AvailT=[{wAvail},{cpAvail}]");
                    }
                }
            });*/
            var t1 = new Thread(() =>
            {
                while (true)
                {
                    if (cts.IsCancellationRequested)
                    {
                        break;
                    }
                    Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                    int recvCount, activeCount;
                    lock (recvMsgs)
                    {
                        recvCount = recvMsgs.Count;
                    }
                    lock (activePubs)
                    {
                        activeCount = activePubs.Count;
                    }
                    var counts = string.Join(",", HiPerfSubscriberImpl.counts);
                    Console.WriteLine($"[Thread] Published {msgSentCount} msgs, recvCount:{recvCount}, delays:[{delayCount},{delay1Count}], pushLoopCount:{HiPerfSubscriberImpl.pushLoopCount}, sub-counts[]:{counts}, activeCount:{activeCount}");
                }
            });
            t1.IsBackground = true;
            t1.Start();
            /*var unused1 = Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1000)).ConfigureAwait(false);
                    Console.WriteLine("Ping");
                }
            });*/

            for (int i = 0; i < testSize; i++)
            {
                var msgText = $"hi {i} ({longText})";
                publishedMsgs.Add(msgText.Substring(0, 20));
                var pubTask = hiPublisher.PublishAsync(msgText);
                msgSentCount += 1;
                lock (activePubs)
                {
                    activePubs.Add(pubTask);
                }
                Task unused = Task.Run(async () =>
                {
                    try
                    {
                        await pubTask.ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exception: {e}");
                    }
                    lock (activePubs)
                    {
                        activePubs.Remove(pubTask);
                    }
                });
                while (true)
                {
                    lock (activePubs)
                    {
                        if (activePubs.Count < 20_000)//10_000)
                        {
                            break;
                        }
                    }
                    delayCount += 1;
                    await Task.Delay(TimeSpan.FromMilliseconds(1)).ConfigureAwait(false);
                    delay1Count += 1;
                }
            }
            Console.WriteLine("Finished publishing messages. Await publish");
            Task[] remaining;
            lock (activePubs)
            {
                remaining = activePubs.ToArray();
            }
            await Task.WhenAll(remaining).ConfigureAwait(false);
            Console.WriteLine("Awaiting sub");
            await subTask.ConfigureAwait(false);
            cts.Cancel();
            Console.WriteLine("DONE");
            Assert.Equal(publishedMsgs, recvMsgs);
        }
    }
}
