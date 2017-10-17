// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.Firestore.V1Beta1;
using System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// Internal helpers for sentinel values.
    /// </summary>
    internal static class SentinelValues
    {
        // These sentinel values are invalid "null" values - the NullValue enum only has a single entry (0), but we're
        // using the fact that there enums are just named numbers to hide extra information there.
        // This is deeply unpleasant, but:
        // - It's extensible to future later sentinel values, so long as they don't require user-specified data (which I don't think they will)
        // - It's "clone-safe" - when you clone a sentinel value, you get the equivalent value. (We clone in a few places,
        //   which means we can't use reference identity to distinguish sentinel values.)
        // - The values are only ever in memory temporarily; they're not exposed to users or included in an RPC.

        private const wkt::NullValue ServerTimestampSentinelNullValue = (wkt::NullValue) SentinelValue.ServerTimestamp;
        private const wkt::NullValue DeleteSentinelNullValue = (wkt::NullValue) SentinelValue.Delete;

        /// <summary>
        /// Sentinel value used to represent server timestamps. This value must not be modified. Visible for testing.
        /// </summary>
        internal static Value ServerTimestampSentinel { get; } = new Value { NullValue = ServerTimestampSentinelNullValue };

        /// <summary>
        /// Sentinel value used to represent a deleted field. This value must not be modified. Visible for testing.
        /// </summary>
        internal static Value DeleteSentinel { get; } = new Value { NullValue = DeleteSentinelNullValue };

        internal static Value ToProtoValue(this SentinelValue value)
        {
            switch (value)
            {
                case SentinelValue.ServerTimestamp:
                    return ServerTimestampSentinel;
                case SentinelValue.Delete:
                    return DeleteSentinel;
                default:
                    throw new ArgumentException($"Unable to convert {nameof(SentinelValue)} value {value}");
            }
        }

        internal static bool IsServerTimestampSentinel(this Value value) =>
            value.ValueTypeCase == Value.ValueTypeOneofCase.NullValue && value.NullValue == ServerTimestampSentinelNullValue;

        internal static bool IsDeleteSentinel(this Value value) =>
            value.ValueTypeCase == Value.ValueTypeOneofCase.NullValue && value.NullValue == DeleteSentinelNullValue;
    }
}
