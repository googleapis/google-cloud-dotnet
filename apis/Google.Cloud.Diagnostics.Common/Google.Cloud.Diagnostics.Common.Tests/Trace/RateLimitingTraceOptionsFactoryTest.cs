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

using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class RateLimitingTraceOptionsFactoryTest
    {
       

        [Fact]
        public void CreateOptions_ShouldTrace()
        {
            var rateLimiter = TraceUtils.GetRateLimiter(1001);
            var factory = new RateLimitingTraceOptionsFactory(rateLimiter);
            Assert.True(factory.CreateOptions().ShouldTrace); // t=0ms
            Assert.True(factory.CreateOptions().ShouldTrace); // t=1001ms
        }

        [Fact]
        public void CreateOptions_ShouldNotTrace()
        {
            var rateLimiter = TraceUtils.GetRateLimiter(999);
            var factory = new RateLimitingTraceOptionsFactory(rateLimiter);
            Assert.True(factory.CreateOptions().ShouldTrace);  // t=0ms
            Assert.False(factory.CreateOptions().ShouldTrace); // t=999ms
        }
    }
}