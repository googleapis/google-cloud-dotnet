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

using Google.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;

namespace Google.Logging.Log4Net
{
    internal static class Extensions
    {
        private static readonly DateTime s_epochZero = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime Timestamp(this LogEntry entry) =>
            s_epochZero
                + TimeSpan.FromSeconds(entry.Timestamp.Seconds)
                + TimeSpan.FromTicks(entry.Timestamp.Nanos / 100);

        public static Timestamp ToTimestamp(this DateTime dt)
        {
            TimeSpan sinceEpoch = dt - s_epochZero;
            return new Timestamp
            {
                Seconds = sinceEpoch.Ticks / TimeSpan.TicksPerSecond,
                Nanos = (int)((sinceEpoch.Ticks % TimeSpan.TicksPerSecond) * (1000000000L / TimeSpan.TicksPerSecond))
            };
        }

        public static TimeSpan Scale(this TimeSpan dt, double scale) =>
            new TimeSpan((long)(dt.Ticks * scale));
    }
}
