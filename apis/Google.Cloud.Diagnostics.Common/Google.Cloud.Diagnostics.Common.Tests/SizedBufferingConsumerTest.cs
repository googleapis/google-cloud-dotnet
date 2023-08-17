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

using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class SizedBufferingConsumerTest
    {
        private const int _bufferSize = 10;

        private IFlushableConsumer<int> GetConsumer(IConsumer<int> consumer) =>
            SizedBufferingConsumer<int>.Create(consumer, Utils.ConstantSizer<int>.GetSize, _bufferSize);

        [Fact]
        public void Receive()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = GetConsumer(simpleConsumer);
            consumer.Receive(new[] { 1, 2 });

            // Ensure ints have not been sent as they are not bigger then the buffer.
            Assert.Equal(0, simpleConsumer.ReceiveCount);

            // Fill the buffer so it will be flushed.
            consumer.Receive(new[] { 3, 4, 5 });

            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public void Flush()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = GetConsumer(simpleConsumer);

            consumer.Receive(intArray);
            Assert.Equal(0, simpleConsumer.ReceiveCount);

            consumer.Flush();
            Assert.Equal(new[] { 1, 2, 3, 4 }, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public void Flush_NoTraces()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = GetConsumer(simpleConsumer);

            consumer.Receive(new int[] { });
            consumer.Flush();
            Assert.Equal(0, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = GetConsumer(simpleConsumer);
            await consumer.ReceiveAsync(new[] { 1, 2 }, CancellationToken.None);

            // Ensure ints have not been sent as they are not bigger then the buffer.
            Assert.Equal(0, simpleConsumer.ReceiveCount);

            // Fill the buffer so it will be flushed.
            await consumer.ReceiveAsync(new[] { 3, 4, 5 }, CancellationToken.None);

            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public async Task FlushAsync()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = GetConsumer(simpleConsumer);

            await consumer.ReceiveAsync(intArray);
            Assert.Equal(0, simpleConsumer.ReceiveCount);

            await consumer.FlushAsync();
            Assert.Equal(new[] { 1, 2, 3, 4 }, simpleConsumer.Items);
            Assert.Equal(1, simpleConsumer.ReceiveCount);
        }

        [Fact]
        public async Task FlushAsync_NoTraces()
        {
            var simpleConsumer = new SimpleConsumer<int>();
            var consumer = GetConsumer(simpleConsumer);

            await consumer.ReceiveAsync(new int[] { });
            consumer.Flush();

            Assert.Equal(0, simpleConsumer.ReceiveCount);
        }
    }
}
