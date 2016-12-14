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

        [Fact]
        public void Receive()
        {
            Mock<IClock> mockClock = new Mock<IClock>();
            mockClock.Setup(c => c.GetCurrentDateTimeUtc()).Returns(_start);
            Mock<IConsumer<int>> mockConsumer = new Mock<IConsumer<int>>();
            TimedBufferingConsumer<int> consumer = GetConsumer(mockConsumer.Object, mockClock.Object);
            consumer.Receive(new[] { 1, 2 });

            // Ensure ints have not been sent as they are not bigger then the buffer.
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            // Add the initial ints the list.  This ensures we verify the right 
            // values where received.
            mockConsumer.Setup(c => c.Receive(new[] { 1, 2, 3, 4, 5 }));

            // Fill the buffer so it will be flushed.
            consumer.Receive(new[] { 3, 4, 5 });
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush()
        {
            int[] intArray = { 1, 2, 3, 4 };
            Mock<IConsumer<int>> mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(intArray));
            TimedBufferingConsumer<int> consumer = GetConsumer(mockConsumer.Object);

            consumer.Receive(intArray);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            consumer.Flush();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush_NoTraces()
        {
            Mock<IConsumer<int>> mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(new int[] { }));
            TimedBufferingConsumer<int> consumer = GetConsumer(mockConsumer.Object);

            consumer.Receive(new int[] { });
            consumer.Flush();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());
        }
    }
}
