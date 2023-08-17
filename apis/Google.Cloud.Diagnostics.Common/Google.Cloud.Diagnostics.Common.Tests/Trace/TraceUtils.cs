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

using Google.Cloud.Trace.V1;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    internal static class TraceUtils
    {
        /// <summary>
        /// Creates a rate limiter that will allow 1 QPS with <paramref name="elapsedMilliseconds"/>
        /// elapsing between calls.
        /// </summary>
        internal static RateLimiter GetRateLimiter(long elapsedMilliseconds) =>
            new RateLimiter(1, new ConstantIntervalTimer(elapsedMilliseconds));

        /// <summary>
        /// Creates a rate limiter with the given QPS that returns the given elapsed milliseconds
        /// in order.
        /// </summary>
        internal static RateLimiter GetRateLimiter(double qps, long[] elapsedMilliseconds) =>
            new RateLimiter(qps, new PresetResultsTimer(new Queue<long>(elapsedMilliseconds)));

        /// <summary>
        /// Checks if a span's labels are equal to a dictionary of strings.
        /// </summary>
        internal static bool IsValidAnnotation(TraceSpan span, Dictionary<string, string> annotation)
        {
            var labels = span.Labels;
            if (labels.Count != annotation.Count)
            {
                return false;
            }

            foreach (KeyValuePair<string, string> label in labels)
            {
                if (String.Compare(label.Value, annotation[label.Key]) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Timer which progresses virtual time by a constant number of milliseconds
        /// each call.
        /// </summary>
        private class ConstantIntervalTimer : ITimer
        {
            private readonly long _intervalMilliseconds;
            private long _time;

            public ConstantIntervalTimer(long intervalMilliseconds)
            {
                _intervalMilliseconds = intervalMilliseconds;
            }

            public long GetElapsedMilliseconds()
            {
                long current = _time;
                _time += _intervalMilliseconds;
                return current;
            }

            public void Start()
            {
            }
        }

        private class PresetResultsTimer : ITimer
        {
            private readonly Queue<long> _results;

            public PresetResultsTimer(Queue<long> results)
            {
                _results = results;
            }

            public long GetElapsedMilliseconds() => _results.Dequeue();

            public void Start()
            {
            }
        }
    }
}
