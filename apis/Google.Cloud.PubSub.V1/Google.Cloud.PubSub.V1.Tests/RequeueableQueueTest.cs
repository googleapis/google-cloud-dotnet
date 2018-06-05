// Copyright 2018, Google Inc. All rights reserved.
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

using System.Linq;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    public class RequeueableQueueTest
    {
        [Theory, CombinatorialData]
        public void EnqueueDequeue([CombinatorialValues(0, 1, 2, 3, 4, 5)] int dequeueCount)
        {
            var q = new SubscriberClientImpl.RequeueableQueue<string>();
            q.Enqueue("a");
            q.Enqueue(new[] { "b", "c" });
            var dequeued = q.Dequeue(dequeueCount, null);
            var expected = new[] { "a", "b", "c" }.Take(dequeueCount);
            Assert.Equal(expected, dequeued);
        }

        [Theory, CombinatorialData]
        public void RequeueDequeue([CombinatorialValues(0, 1, 2, 3, 4, 5)] int dequeueCount)
        {
            var q = new SubscriberClientImpl.RequeueableQueue<string>();
            q.Requeue(new[] { "a" });
            q.Requeue(new[] { "b", "c" });
            var dequeued = q.Dequeue(dequeueCount, null);
            var expected = new[] { "a", "b", "c" }.Take(dequeueCount);
            Assert.Equal(expected, dequeued);
        }

        [Theory, CombinatorialData]
        public void EnqueueRequeueDequeue([CombinatorialValues(0, 1, 2, 3, 4, 5, 6, 7)] int dequeueCount)
        {
            var q = new SubscriberClientImpl.RequeueableQueue<string>();
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
            var q = new SubscriberClientImpl.RequeueableQueue<string>();
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
