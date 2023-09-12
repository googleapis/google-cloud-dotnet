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

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TimedBufferingConsumerTest
    {
        private static readonly TimeSpan _waitTime = TimeSpan.FromSeconds(5);

        [Fact]
        public void Receive()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = TimedBufferingConsumer<int>.Create(simpleConsumer, _waitTime, null);
            consumer.Receive(new[] { 1, 2, 3, 4, 5 });

            Assert.Equal(0, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public void Flush()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = TimedBufferingConsumer<int>.Create(simpleConsumer, _waitTime, null);

            consumer.Receive(intArray);
            Assert.Equal(0, simpleConsumer.ReceiveCount);

            consumer.Flush();
            Assert.Equal(intArray, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public void Flush_NoTraces()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = TimedBufferingConsumer<int>.Create(simpleConsumer, _waitTime, null);

            consumer.Receive(new int[] { });
            consumer.Flush();
            Assert.Equal(0, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = TimedBufferingConsumer<int>.Create(simpleConsumer, _waitTime, null);
            await consumer.ReceiveAsync(new[] { 1, 2, 3, 4, 5 }, CancellationToken.None);
            Assert.Equal(0, simpleConsumer.ReceiveCount);
        }


        [Fact]
        public async Task FlushAsync()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = TimedBufferingConsumer<int>.Create(simpleConsumer, _waitTime, null);

            await consumer.ReceiveAsync(intArray, CancellationToken.None);
            Assert.Equal(0, simpleConsumer.ReceiveCount);

            await consumer.FlushAsync();
            Assert.Equal(intArray, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public async Task FlushAsync_NoTraces()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = TimedBufferingConsumer<int>.Create(simpleConsumer, _waitTime, null);

            await consumer.ReceiveAsync(new int[] { }, CancellationToken.None);
            await consumer.FlushAsync();
            Assert.Equal(0, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public void Timer()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var fakeTimer = new FakeThreadingTimer();
            var consumer = new TimedBufferingConsumer<int>(simpleConsumer, _waitTime, null, fakeTimer);

            var intArray = new[] { 1, 2, 3, 4, 5 };
            consumer.Receive(intArray);
            Assert.Equal(0, simpleConsumer.ReceiveCount);
            fakeTimer.FullTick();
            Assert.Equal(intArray, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);

            var intArrayTwo = new[] { 10, 9, 8, 7, 6 };
            consumer.Receive(intArrayTwo);
            fakeTimer.FullTick();
            Assert.Equal(intArray.Concat(intArrayTwo), simpleConsumer.Items);
            Assert.Equal(2, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public void Timer_SwallowException()
        {
            var throwingConsumer = new ThrowingConsumer<int>(1);
            var fakeTimer = new FakeThreadingTimer();
            var consumer = new TimedBufferingConsumer<int>(throwingConsumer, _waitTime, null, fakeTimer);

            consumer.Receive(new[] { 1, 2, 3, 4, 5 });
            fakeTimer.FullTick();
            Assert.Equal(0, throwingConsumer.ReceiveCount);
        }

        [Fact]
        public void Timer_HandleException()
        {
            var throwingConsumer = new ThrowingConsumer<int>(1);
            var fakeTimer = new FakeThreadingTimer();
            int exceptionsCaught = 0;
            var consumer = new TimedBufferingConsumer<int>(throwingConsumer, _waitTime, HandleException, fakeTimer);

            consumer.Receive(new[] { 1, 2, 3, 4, 5 });
            fakeTimer.FullTick();

            Assert.Equal(1, exceptionsCaught);
            Assert.Equal(0, throwingConsumer.ReceiveCount);

            void HandleException(Exception exception) => exceptionsCaught++;
        }
    }
}
