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
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TimedBufferingConsumerTest
    {
        private static TimeSpan _waitTime = TimeSpan.FromSeconds(5);

        private DateTime _start = DateTime.UtcNow;

        private TimedBufferingConsumer<int> GetConsumer(IConsumer<int> consumer, IClock clock)
        {
            return TimedBufferingConsumer<int>.Create(consumer, _waitTime, clock);
        }

        /// <summary>
        /// Creates an <see cref="IClock"/> that returns the given times in order.
        /// </summary>
        private IClock GetClock(DateTime[] times) {
            var returnQueue = new Queue<DateTime>(times);
            var mockClock = new Mock<IClock>();
            mockClock.Setup(w => w.GetCurrentDateTimeUtc()).Returns(() => returnQueue.Dequeue());
            return mockClock.Object;
        }
        
        [Fact]
        public void Receive()
        {
            var clock = GetClock(new[] { _start, _start, _start.AddSeconds(_waitTime.TotalSeconds + 1) });
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = GetConsumer(mockConsumer.Object, clock);
            consumer.Receive(new[] { 1, 2 });

            // Ensure ints have not been sent as the wait time hasn't been passed.
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            // Add the initial ints the list.  This ensures we verify the right 
            // values where received.
            mockConsumer.Setup(c => c.Receive(new[] { 1, 2, 3, 4, 5 }));
            consumer.Receive(new[] { 3, 4, 5 });
            mockConsumer.VerifyAll();
        }
        

        [Fact]
        public void Flush()
        {
            var clock = GetClock(new[] { _start, _start });
            int[] intArray = { 1, 2, 3, 4 };
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(intArray));
            var consumer = GetConsumer(mockConsumer.Object, clock);

            consumer.Receive(intArray);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            consumer.Flush();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush_NoTraces()
        {
            var clock = GetClock(new[] { _start, _start });
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(new int[] { }));
            var consumer = GetConsumer(mockConsumer.Object, clock);

            consumer.Receive(new int[] { });
            consumer.Flush();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var clock = GetClock(new[] { _start, _start, _start.AddSeconds(_waitTime.TotalSeconds + 1) });
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = GetConsumer(mockConsumer.Object, clock);
            await consumer.ReceiveAsync(new[] { 1, 2 });

            // Ensure ints have not been sent as the wait time hasn't been passed.
            mockConsumer.Verify(c => c.ReceiveAsync(It.IsAny<IEnumerable<int>>()), Times.Never());

            // Add the initial ints the list.  This ensures we verify the right 
            // values where received.
            mockConsumer.Setup(c => c.ReceiveAsync(new[] { 1, 2, 3, 4, 5 })).Returns(Task.CompletedTask);
            await consumer.ReceiveAsync(new[] { 3, 4, 5 });
            mockConsumer.VerifyAll();
        }


        [Fact]
        public async Task FlushAsync()
        {
            var clock = GetClock(new[] { _start, _start });
            int[] intArray = { 1, 2, 3, 4 };
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.ReceiveAsync(intArray)).Returns(Task.CompletedTask);
            var consumer = GetConsumer(mockConsumer.Object, clock);

            await consumer.ReceiveAsync(intArray);
            mockConsumer.Verify(c => c.ReceiveAsync(It.IsAny<IEnumerable<int>>()), Times.Never());

            await consumer.FlushAsync();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task FlushAsync_NoTraces()
        {
            var clock = GetClock(new[] { _start, _start });
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.ReceiveAsync(new int[] { }));
            var consumer = GetConsumer(mockConsumer.Object, clock);

            await consumer.ReceiveAsync(new int[] { });
            await consumer.FlushAsync();
            mockConsumer.Verify(c => c.ReceiveAsync(It.IsAny<IEnumerable<int>>()), Times.Never());
        }
    }
}
