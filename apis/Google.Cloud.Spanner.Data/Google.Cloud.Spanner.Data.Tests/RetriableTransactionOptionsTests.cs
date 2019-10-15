// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class RetriableTransactionOptionsTests
    {
        [Fact]
        public void DefaultJitter()
        {
            var options = RetriableTransactionOptions.CreateDefault();

            var delay = TimeSpan.FromTicks(TimeSpan.TicksPerMillisecond);
            var delayTicks = (int)delay.Ticks;
            // The jitter on RetriableTransactionOptions should jitter between
            // delay and delay * 2.
            var expectedMinDelayTicks = delayTicks;
            var expectedMaxDelayTicks = delayTicks * 2;
            var expectedMedianDelayTicks = (expectedMinDelayTicks + expectedMaxDelayTicks) / 2;

            var delays = Enumerable.Range(0, 10_000)
                .Select(_ => options.Jitter(delay))
                .ToList();
            var underMedianCount = delays.LongCount(ts => ts.Ticks <= expectedMedianDelayTicks);

            Assert.InRange(underMedianCount, 4_000, 6_000);
        }

        [Fact]
        public void NoJitter()
        {
            var options = RetriableTransactionOptions.CreateWithNoJitter();
            var delay = TimeSpan.FromTicks(TimeSpan.TicksPerMillisecond);
            var delayTicks = (int)delay.Ticks;
            var expectedJitteredTicks = delayTicks;

            // This shouldn't jitter at all, 50_000 seems a good enough sample
            // to test that.
            var delays = Enumerable.Range(0, 50_000)
                .Select(_ => options.Jitter(delay))
                .ToList();
            var min = delays.Min();
            var max = delays.Max();

            Assert.Equal(expectedJitteredTicks, min.Ticks);
            Assert.Equal(expectedJitteredTicks, max.Ticks);
        }
    }
}
