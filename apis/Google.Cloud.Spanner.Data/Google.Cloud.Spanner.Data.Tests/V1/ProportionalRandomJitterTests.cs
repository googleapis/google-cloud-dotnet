// Copyright 2018 Google LLC
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

namespace Google.Cloud.Spanner.V1.Tests
{
    public class ProportionalRandomJitterTests
    {
        [Fact]
        public void ValuesWithinRange()
        {
            // We might as well use the example from the docs...
            double randomProportion = 0.1;
            TimeSpan delay = TimeSpan.FromMinutes(60);

            var jitter = new ProportionalRandomJitter(randomProportion);

            var delays = Enumerable.Range(0, 10000)
                .Select(_ => jitter.GetDelay(delay))
                .ToList();
            var min = delays.Min();
            var max = delays.Max();

            // We don't mind if rounding reduces the lowest value to just under 54 minutes
            // With 10,000 iterations there should be at least one value of about 54 minutes
            Assert.InRange(min, TimeSpan.FromMinutes(53.9), TimeSpan.FromMinutes(54.9));

            // With 10,000 iterations there should be at least one value of about 59 minutes
            // We should never go above 60 minutes.
            Assert.InRange(max, TimeSpan.FromMinutes(59), TimeSpan.FromMinutes(60));
        }
    }
}
