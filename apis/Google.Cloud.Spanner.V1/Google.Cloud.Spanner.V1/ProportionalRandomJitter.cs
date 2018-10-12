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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Spanner.V1
{
    // TODO: Consider moving this to GAX.

    /// <summary>
    /// Jitter that is random for some proportion of the given delay, but fixed for the rest.
    /// For example, if an instance created with a proportion of 0.1 (corresponding to 10%) is
    /// asked for a delay with an input of 1 hour, the result will be uniformly random between 54 minutes and 60 minutes.
    /// (10% of one hour is 6 minutes.) Note that the result is never greater than the specified maximum delay.
    /// </summary>
    internal sealed class ProportionalRandomJitter : RetrySettings.IJitter
    {
        // See http://stackoverflow.com/questions/36376888 for why we don't have a thread-local RNG.
        // While it's slightly annoying to have a global lock, it's better than worrying about whether multiple instances
        // will be created in close proximity with the same seed.
        private static readonly Random s_random = new Random();
        private static readonly object s_lock = new object();

        private readonly double _randomProportion;

        internal ProportionalRandomJitter(double randomProportion)
        {
            _randomProportion = GaxPreconditions.CheckArgumentRange(randomProportion, nameof(randomProportion), 0.0, 1.0);
        }

        /// <inheritdoc/>
        public TimeSpan GetDelay(TimeSpan maxDelay)
        {
            // All our jitters are permissive like this. It can make some maths simpler, but
            // means the caller needs to use the result carefully.
            // TODO: Document in GAX.
            if (maxDelay <= TimeSpan.Zero)
            {
                return maxDelay;
            }

            long totalTicks = maxDelay.Ticks;
            // The part of the delay which we'll compute randomly
            long randomProportionTicks = (long) (totalTicks * _randomProportion);
            // The part of the delay which will be fixed
            long fixedTicks = totalTicks - randomProportionTicks;

            // The randomized value within the range [0, randomProportionTicks]
            long randomTicks;
            lock (s_lock)
            {
                randomTicks = (long)(randomProportionTicks * s_random.NextDouble());
            }
            return new TimeSpan(fixedTicks + randomTicks);
        }
    }
}
