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

using Moq;
using System.Collections.Generic;
using Xunit;

namespace Google.Devtools.AspNet.Tests.CloudTrace
{
    public class RateLimiterTest
    {
        [Fact]
        public void CanTrace()
        {
            Mock<ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(1001);

            RateLimiter rateLimiter = new RateLimiter(1, watch.Object);
            Assert.True(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_False()
        {
            Mock<ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(999);

            RateLimiter rateLimiter = new RateLimiter(1, watch.Object);
            Assert.False(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_DecimalQps()
        {
            Queue<long> returnQueue = new Queue<long>(new long[] { 9999, 10001 });
            Mock <ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(() => returnQueue.Dequeue());

            RateLimiter rateLimiter = new RateLimiter(0.1, watch.Object);
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_Multiple()
        {
            Queue<long> returnQueue = new Queue<long>(
                new long[] { 999, 1001, 1790, 1850, 2030, 2700, 5000});
            Mock<ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(() => returnQueue.Dequeue());

            RateLimiter rateLimiter = new RateLimiter(1, watch.Object);
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
        }
    }
}
