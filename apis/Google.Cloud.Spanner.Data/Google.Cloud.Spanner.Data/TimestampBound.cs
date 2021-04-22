// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Globalization;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Indicates how Spanner will choose a timestamp at which to read the data for read-only
    /// transactions.
    /// </summary>
    public sealed class TimestampBound : IEquatable<TimestampBound>
    {
        private static readonly DateTime s_utcMinValue = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private TimestampBound(TimestampBoundMode mode, TimeSpan staleness,
                               DateTime timestamp, bool returnReadTimestamp = false)
        {
            if (staleness.Ticks < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(staleness), "Staleness must not be negative");
            }

            GaxPreconditions.CheckArgument(timestamp.Kind == DateTimeKind.Utc, nameof(timestamp), "Timestamps must be expressed in UTC");

            Mode = mode;
            Staleness = staleness;
            Timestamp = timestamp;
            ReturnReadTimestamp = returnReadTimestamp;
        }

        /// <summary>
        /// Indicates how to choose the timestamp at which to read the data for Cloud Spanner read-only transactions.
        /// If your application can tolerate some staleness when reading data, you can use a stale read,
        /// which can execute much faster when compared to reading the latest data.
        /// The types of timestamp bounds are:
        ///  Strong (the default): read the latest data.
        ///  Bounded staleness: read a version of the data that's no staler than a bound.
        ///  Exact staleness: read the version of the data at an exact timestamp.
        /// </summary>
        public TimestampBoundMode Mode { get; }

        /// <summary>
        /// If <see cref="Mode"/> is <see cref="TimestampBoundMode.ExactStaleness"/> or
        /// <see cref="TimestampBoundMode.MaxStaleness"/>, this indicates the duration of time
        /// for the staleness.
        /// </summary>
        public TimeSpan Staleness { get; }

        /// <summary>
        /// If <see cref="Mode"/> is <see cref="TimestampBoundMode.ReadTimestamp"/> or
        /// <see cref="TimestampBoundMode.MinReadTimestamp"/>, this indicates the timestamp to use.
        /// </summary>
        public DateTime Timestamp { get; }

        /// <summary>
        /// If true, the read timestamp is included in the
        /// <see cref="Transaction" /> message that describes the transaction.
        /// <remarks>
        /// The read timestamp is Cloud Spanner-selected unless it's an exact
        /// read, in which case it will be set to the exact read timestamp set
        /// in the request.
        /// </remarks>
        /// </summary>
        public bool ReturnReadTimestamp { get; }

        /// <summary>
        /// Read at a timestamp where all previously committed transactions
        /// are visible.
        /// </summary>
        public static TimestampBound Strong { get; } =
            new TimestampBound(TimestampBoundMode.Strong, TimeSpan.Zero, s_utcMinValue);

        /// <summary>
        /// Executes all reads at a timestamp that is <paramref name="duration"/>
        /// old. The timestamp is chosen soon after the read is started.
        ///
        /// Guarantees that all writes that have committed more than the
        /// specified number of seconds ago are visible. Because Cloud Spanner
        /// chooses the exact timestamp, this mode works even if the client's
        /// local clock is substantially skewed from Cloud Spanner commit
        /// timestamps.
        ///
        /// Useful for reading at nearby replicas without the distributed
        /// timestamp negotiation overhead of <see cref="OfMaxStaleness"/>.
        /// </summary>
        /// <param name="duration">The exact staleness to use. Must not be negative.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfExactStaleness(TimeSpan duration) =>
            new TimestampBound(TimestampBoundMode.ExactStaleness, duration, s_utcMinValue);

        /// <summary>
        /// Read data at a timestamp >= `NOW - <paramref name="duration"/>`. Guarantees that all
        /// writes that have committed more than the specified number of seconds ago are
        /// visible.
        /// Because Cloud Spanner chooses the exact timestamp, this mode works even if
        /// the client's local clock is substantially skewed from Cloud Spanner
        /// commit timestamps.
        ///
        /// Useful for reading the freshest data available at a nearby
        /// replica, while bounding the possible staleness if the local
        /// replica has fallen behind.
        ///
        /// Note that this option can only be used in single-use
        /// transactions.
        /// </summary>
        /// <param name="duration">The maximum duration of staleness to use. Must not be negative.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfMaxStaleness(TimeSpan duration) =>
            new TimestampBound(TimestampBoundMode.MaxStaleness, duration, s_utcMinValue);

        /// <summary>
        /// Executes all reads at a timestamp >= <paramref name="minReadTimestamp"/>.
        ///
        /// This is useful for requesting fresher data than some previous
        /// read, or data that is fresh enough to observe the effects of some
        /// previously committed transaction whose timestamp is known.
        ///
        /// Note that this option can only be used in single-use transactions
        /// </summary>
        /// <param name="minReadTimestamp">The earliest timestamp to read from. Must be in UTC.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfMinReadTimestamp(DateTime minReadTimestamp) =>
            new TimestampBound(TimestampBoundMode.MinReadTimestamp, TimeSpan.Zero, minReadTimestamp);

        /// <summary>
        /// Executes all reads at the given timestamp. Unlike other modes,
        /// reads at a specific timestamp are repeatable; the same read at
        /// the same timestamp always returns the same data. If the
        /// timestamp is in the future, the read will block until the
        /// specified timestamp, modulo the read's deadline.
        ///
        /// Useful for large scale consistent reads such as mapreduces, or
        /// for coordinating many reads against a consistent snapshot of the
        /// data.
        /// </summary>
        /// <param name="timestamp">The timestamp to read from. Must be in UTC.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public static TimestampBound OfReadTimestamp(DateTime timestamp) =>
            new TimestampBound(TimestampBoundMode.ReadTimestamp, TimeSpan.Zero, timestamp);

        /// <summary>
        /// Creates a <see cref="TimestampBound"/> with the given value on
        /// whether to return a read timestamp.
        /// </summary>
        /// <param name="returnReadTimestamp">Whether to return a read timestamp.</param>
        /// <returns>A created <see cref="TimestampBound"/>.</returns>
        public TimestampBound WithReturnReadTimestamp(bool returnReadTimestamp)
        {
            if (this.ReturnReadTimestamp == returnReadTimestamp)
            {
                return this;
            }
            return new TimestampBound(Mode, Staleness, Timestamp, returnReadTimestamp);
        }

        /// <inheritdoc />
        public bool Equals(TimestampBound other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return Mode == other.Mode && Staleness.Equals(other.Staleness) && Timestamp.Equals(other.Timestamp) && ReturnReadTimestamp == other.ReturnReadTimestamp;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TimestampBound);

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int) Mode;
                hashCode = (hashCode * 397) ^ Staleness.GetHashCode();
                hashCode = (hashCode * 397) ^ Timestamp.GetHashCode();
                hashCode = (hashCode * 397) ^ ReturnReadTimestamp.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns a Base64 encoded string that can later be serialized back into a <see cref="TimestampBound"/>
        /// using <see cref="TimestampBound.FromBase64String"/>
        /// </summary>
        /// <returns>The base64 encoded string.</returns>
        public string ToBase64String()
        {
            var structValue = new Struct
            {
                Fields =
                {
                    [nameof(Mode)] = Value.ForString(Mode.ToString()),
                    [nameof(Timestamp)] = Value.ForString(Timestamp.ToString("O")),
                    [nameof(Staleness)] = Value.ForString(Staleness.Ticks.ToString(CultureInfo.InvariantCulture)),
                    [nameof(ReturnReadTimestamp)] = Value.ForBool(ReturnReadTimestamp)
                }
            };
            return structValue.ToByteString().ToBase64();
        }

        /// <summary>
        /// Creates an instance of <see cref="TimestampBound"/> given its Base64 encoded string.
        /// </summary>
        /// <param name="base64String">The string provided by <see cref="TimestampBound.ToBase64String"/>.</param>
        /// <returns>A new instance of <see cref="TimestampBound"/>.</returns>
        public static TimestampBound FromBase64String(string base64String)
        {
            var structValue = Struct.Parser.ParseFrom(ByteString.FromBase64(base64String));
            TimestampBoundMode? mode = null;
            DateTime? timestamp = null;
            TimeSpan? staleness = null;
            bool returnReadTimestamp = false;

            if (structValue.Fields.TryGetValue(nameof(Mode), out Value timestampBoundModeValue))
            {
                mode = (TimestampBoundMode) System.Enum.Parse(typeof(TimestampBoundMode), timestampBoundModeValue.StringValue);
            }
            if (structValue.Fields.TryGetValue(nameof(Timestamp), out Value timestampValue))
            {
                timestamp = DateTime.ParseExact(timestampValue.StringValue, "O", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
            }
            if (structValue.Fields.TryGetValue(nameof(Staleness), out Value stalenessValue))
            {
                staleness = new TimeSpan(long.Parse(stalenessValue.StringValue, CultureInfo.InvariantCulture));
            }
            if (!mode.HasValue)
            {
                throw new InvalidOperationException($"Unable to properly deserialize {nameof(TimestampBound)}.{nameof(Mode)}");
            }
            if (structValue.Fields.TryGetValue(nameof(ReturnReadTimestamp), out Value returnReadTimestampValue))
            {
                returnReadTimestamp = returnReadTimestampValue.BoolValue;
            }
            switch (mode.Value)
            {
                case TimestampBoundMode.ExactStaleness:
                case TimestampBoundMode.MaxStaleness:
                    GaxPreconditions.CheckArgument(staleness.HasValue, nameof(base64String), "Unable to properly deserialize {0}.{1}", nameof(TimestampBound), nameof(Staleness));
                    return new TimestampBound(mode.Value, staleness.Value, s_utcMinValue, returnReadTimestamp);
                case TimestampBoundMode.MinReadTimestamp:
                case TimestampBoundMode.ReadTimestamp:
                    GaxPreconditions.CheckArgument(timestamp.HasValue, nameof(base64String), "Unable to properly deserialize {0}.{1}", nameof(TimestampBound), nameof(Timestamp));
                    return new TimestampBound(mode.Value, TimeSpan.Zero, timestamp.Value, returnReadTimestamp);
                case TimestampBoundMode.Strong:
                    return Strong.WithReturnReadTimestamp(returnReadTimestamp);
                default:
                    throw new ArgumentException($"Invalid mode for timestamp bound: {mode.Value}");
            }
        }

        internal TransactionOptions ToTransactionOptions()
        {
            var innerOptions = new TransactionOptions.Types.ReadOnly();

            switch (Mode)
            {
                case TimestampBoundMode.Strong:
                    innerOptions.Strong = true;
                    break;
                case TimestampBoundMode.ReadTimestamp:
                    innerOptions.ReadTimestamp = wkt::Timestamp.FromDateTime(Timestamp);
                    break;
                case TimestampBoundMode.MinReadTimestamp:
                    innerOptions.MinReadTimestamp = wkt::Timestamp.FromDateTime(Timestamp);
                    break;
                case TimestampBoundMode.ExactStaleness:
                    innerOptions.ExactStaleness = Duration.FromTimeSpan(Staleness);
                    break;
                case TimestampBoundMode.MaxStaleness:
                    innerOptions.MaxStaleness = Duration.FromTimeSpan(Staleness);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            innerOptions.ReturnReadTimestamp = ReturnReadTimestamp;
            return new TransactionOptions { ReadOnly = innerOptions };
        }
    }
}
