using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    public class ReQueueTest
    {
        [Theory, CombinatorialData]
        public void EnqueueDequeue([CombinatorialValues(0, 1, 2, 3, 4, 5)] int dequeueCount)
        {
            var q = new SubscriberClientImpl.ReQueue<string>();
            q.Enqueue("a");
            q.Enqueue(new[] { "b", "c" });
            var dequeued = q.Dequeue(dequeueCount, null);
            var expected = new[] { "a", "b", "c" }.Take(dequeueCount);
            Assert.Equal(expected, dequeued);
        }

        [Theory, CombinatorialData]
        public void RequeueDequeue([CombinatorialValues(0, 1, 2, 3, 4, 5)] int dequeueCount)
        {
            var q = new SubscriberClientImpl.ReQueue<string>();
            q.Requeue(new[] { "a" });
            q.Requeue(new[] { "b", "c" });
            var dequeued = q.Dequeue(dequeueCount, null);
            var expected = new[] { "a", "b", "c" }.Take(dequeueCount);
            Assert.Equal(expected, dequeued);
        }

        [Theory, CombinatorialData]
        public void EnqueueRequeueDequeue([CombinatorialValues(0, 1, 2, 3, 4, 5, 6, 7)] int dequeueCount)
        {
            var q = new SubscriberClientImpl.ReQueue<string>();
            q.Enqueue("d");
            q.Requeue(new[] { "a", "b" });
            q.Enqueue(new[] { "e", "f" });
            q.Requeue(new[] { "c" });
            var dequeued = q.Dequeue(dequeueCount, null);
            var expected = new[] { "a", "b", "c", "d", "e", "f" }.Take(dequeueCount);
            Assert.Equal(expected, dequeued);
        }

        [Fact]
        public void Count()
        {
            var q = new SubscriberClientImpl.ReQueue<string>();
            Assert.Equal(0, q.Count);
            q.Enqueue("a");
            Assert.Equal(1, q.Count);
            q.Requeue(new[] { "b" });
            Assert.Equal(2, q.Count);
            q.Requeue(new[] { "c", "d" });
            Assert.Equal(4, q.Count);
            q.Dequeue(1, null);
            Assert.Equal(3, q.Count);
            q.Dequeue(2, null);
            Assert.Equal(1, q.Count);
            q.Enqueue("e");
            q.Requeue(new[] { "f" });
            Assert.Equal(3, q.Count);
            q.Dequeue(10, null);
            Assert.Equal(0, q.Count);
        }
    }
}
