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
using Xunit;

namespace Google.Devtools.AspNet.Tests.CloudTrace
{
    public class RateLimitingTraceOptionsFactoryTest
    {
        // Creates a rate limiter that will allow 1 QPS with the elapsed milliseconds.
        private RateLimiter GetRateLimiter(long elapsedMilliseconds)
        {
            Mock<ITimer> watch = new Mock<ITimer>();
            watch.Setup(w => w.GetElapsedMilliseconds()).Returns(elapsedMilliseconds);
            return new RateLimiter(1, watch.Object);
        }

        [Fact]
        public void CreateOptions_ShouldTrace()
        {
            RateLimiter rateLimiter = GetRateLimiter(1001);
            RateLimitingTraceOptionsFactory factory = new RateLimitingTraceOptionsFactory(rateLimiter);
            Assert.True(factory.CreateOptions().ShouldTrace);
        }

        [Fact]
        public void CreateOptions_ShouldNotTrace()
        {
            RateLimiter rateLimiter = GetRateLimiter(999);
            RateLimitingTraceOptionsFactory factory = new RateLimitingTraceOptionsFactory(rateLimiter);
            Assert.False(factory.CreateOptions().ShouldTrace);
        }
    }
}
