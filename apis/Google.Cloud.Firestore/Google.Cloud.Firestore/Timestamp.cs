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

using Google.Api.Gax;
using System;
using System.Globalization;
using System.Text;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A nanosecond-precision immutable timestamp. When this is stored as part of a document in Firestore,
    /// it is truncated to the microsecond, towards the start of time.
    /// </summary>
    public struct Timestamp : IEquatable<Timestamp>, IComparable, IComparable<Timestamp>
    {
        private static readonly DateTime s_unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // Constants copied from Timestamp in Protobuf
        internal const long MinSeconds = -62135596800;
        internal const long MaxSeconds = 253402300799;
        private const long BclSecondsAtUnixEpoch = 62135596800;
        private const int NanosecondsPerTick = 100;

        // See https://github.com/google/protobuf/blob/master/src/google/protobuf/timestamp.proto for
        // more details.

        /// <summary>
        /// Seconds since the Unix epoch. Negative values indicate timestamps before the Unix epoch.
        /// </summary>
        private readonly long _seconds;
        /// <summary>
        /// Nanoseconds within the second; always non-negative. (For example, the nanosecond before the Unix epoch
        /// has a seconds value of -1, and a nanoseconds value of 999,999,999.
        /// </summary>
        private readonly int _nanoseconds;

        internal Timestamp(long seconds, int nanoseconds)
        {
            GaxPreconditions.CheckArgumentRange(seconds, nameof(seconds), MinSeconds, MaxSeconds);
            GaxPreconditions.CheckArgumentRange(nanoseconds, nameof(nanoseconds), 0, 999_999_999);
            _seconds = seconds;
            _nanoseconds = nanoseconds;
        }

        /// <summary>
        /// Converts this timestamp to a <see cref="DateTime"/> with a kind of
        /// <see cref="DateTimeKind.Utc"/>. This can lose information as DateTime has a precision of
        /// a tick (100 nanoseconds). If the timestamp is not a precise number of ticks, it will be
        /// truncated towards the start of time.
        /// </summary>
        /// <returns>A <see cref="DateTime"/> representation of this timestamp.</returns>
        public DateTime ToDateTime() => s_unixEpoch.AddSeconds(_seconds).AddTicks(_nanoseconds / NanosecondsPerTick);

        /// <summary>
        /// Converts this timestamp into a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <remarks>
        /// The resulting <c>DateTimeOffset</c> will always have an <c>Offset</c> of zero.
        /// If the timestamp is not a precise number of ticks, it will be truncated towards the start
        /// of time.
        /// <see cref="DateTimeOffset"/> value precisely on a second.
        /// </remarks>
        /// <returns>This timestamp as a <c>DateTimeOffset</c>.</returns>
        public DateTimeOffset ToDateTimeOffset() => new DateTimeOffset(ToDateTime(), TimeSpan.Zero);

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a <see cref="Timestamp"/>.
        /// </summary>
        /// <param name="dateTime">The value to convert; its kind must be <see cref="DateTimeKind.Utc"/>.</param>
        /// <returns>A <see cref="Timestamp"/> representation of <paramref name="dateTime"/>.</returns>
        public static Timestamp FromDateTime(DateTime dateTime)
        {
            GaxPreconditions.CheckArgument(dateTime.Kind == DateTimeKind.Utc,
                nameof(dateTime), "Conversion from DateTime to Timestamp requires the DateTime kind to be Utc");
            // Do the arithmetic using DateTime.Ticks, which is always non-negative, making things simpler.
            long secondsSinceBclEpoch = dateTime.Ticks / TimeSpan.TicksPerSecond;
            int nanoseconds = (int)(dateTime.Ticks % TimeSpan.TicksPerSecond) * NanosecondsPerTick;
            return new Timestamp(secondsSinceBclEpoch - BclSecondsAtUnixEpoch, nanoseconds);
        }


        /// <summary>
        /// Converts the given <see cref="DateTimeOffset"/> to a <see cref="Timestamp"/>
        /// </summary>
        /// <remarks>The offset is taken into consideration when converting the value (so the same instant in time
        /// is represented) but is not a separate part of the resulting value. In other words, there is no
        /// roundtrip operation to retrieve the original <c>DateTimeOffset</c>.</remarks>
        /// <param name="dateTimeOffset">The date and time (with UTC offset) to convert to a timestamp.</param>
        /// <returns>The converted timestamp.</returns>
        public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset) => FromDateTime(dateTimeOffset.UtcDateTime);

        /// <summary>
        /// Returns the current timestamp according to the system clock. The system time zone
        /// is irrelevant, as a timestamp represents an instant in time.
        /// </summary>
        /// <returns>The current timestamp according to the system clock.</returns>
        public static Timestamp GetCurrentTimestamp() => FromDateTime(DateTime.UtcNow);

        /// <summary>
        /// Creates a Protobuf <see cref="wkt::Timestamp"/> representation of this
        /// timestamp. Modifications to the returned message will not be reflected in this object.
        /// </summary>
        /// <returns>A Protobuf timestamp representation.</returns>
        public wkt::Timestamp ToProto() => new wkt.Timestamp { Seconds = _seconds, Nanos = _nanoseconds };

        /// <summary>
        /// Creates an instance from a Protobuf <see cref="wkt::Timestamp"/> representation.
        /// Later modifications to the Protobuf representation will not affect the returned oject.
        /// </summary>
        /// <param name="proto">A Protobuf timestamp representation. Must not be null.</param>
        /// <returns>An immutable timestamp.</returns>
        public static Timestamp FromProto(wkt::Timestamp proto)
        {
            GaxPreconditions.CheckNotNull(proto, nameof(proto));
            return new Timestamp(proto.Seconds, proto.Nanos);
        }

        /// <summary>
        /// Creates an instance from a Protobuf <see cref="wkt::Timestamp"/> representation
        /// if present, or returns a null value on null input.
        /// </summary>
        /// <param name="proto">A Protobuf timestamp representation, or null.</param>
        /// <returns>A null value if <paramref name="proto"/> is null; otherwise, the converted Timestamp.</returns>
        internal static Timestamp? FromProtoOrNull(wkt::Timestamp proto) =>
            proto == null ? default(Timestamp?) : FromProto(proto);

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Timestamp blob && Equals(blob);

        /// <inheritdoc />
        public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(_seconds.GetHashCode(), _nanoseconds.GetHashCode());

        /// <inheritdoc />
        public bool Equals(Timestamp other) => _seconds == other._seconds && _nanoseconds == other._nanoseconds;

        /// <inheritdoc />
        public int CompareTo(Timestamp other)
        {
            // Note: assumes normalized form.
            int secondsComparison = _seconds.CompareTo(other._seconds);
            return secondsComparison != 0 ? secondsComparison : _nanoseconds.CompareTo(other._nanoseconds);
        }

        /// <inheritdoc />
        public int CompareTo(object obj) =>
            obj == null ? 1 // Everything comes after null
            : obj is Timestamp ts ? CompareTo(ts)
            : throw new ArgumentException("Can only compare timestamps with each other", nameof(obj));

        /// <summary>
        /// Operator overload to compare two Blob values for equality.
        /// </summary>
        /// <param name="lhs">Left value to compare</param>
        /// <param name="rhs">Right value to compare</param>
        /// <returns>true if <paramref name="lhs"/> is equal to <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator ==(Timestamp lhs, Timestamp rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Operator overload to compare two Blob values for inequality.
        /// </summary>
        /// <param name="lhs">Left value to compare</param>
        /// <param name="rhs">Right value to compare</param>
        /// <returns>false if <paramref name="lhs"/> is equal to <paramref name="rhs"/>; otherwise true.</returns>
        public static bool operator !=(Timestamp lhs, Timestamp rhs) => !lhs.Equals(rhs);

        /// <summary>
        /// Compares two timestamps.
        /// </summary>
        /// <param name="lhs">The left timestamp to compare.</param>
        /// <param name="rhs">The right timestamp to compare.</param>
        /// <returns>true is <paramref name="lhs"/> is strictly earlier than <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator <(Timestamp lhs, Timestamp rhs) => lhs.CompareTo(rhs) < 0;

        /// <summary>
        /// Compares two timestamps.
        /// </summary>
        /// <param name="lhs">The left timestamp to compare.</param>
        /// <param name="rhs">The right timestamp to compare.</param>
        /// <returns>true is <paramref name="lhs"/> is earlier than or equal to <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator <=(Timestamp lhs, Timestamp rhs) => lhs.CompareTo(rhs) <= 0;

        /// <summary>
        /// Compares two timestamps.
        /// </summary>
        /// <param name="lhs">The left timestamp to compare.</param>
        /// <param name="rhs">The right timestamp to compare.</param>
        /// <returns>true is <paramref name="lhs"/> is strictly later than <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator >(Timestamp lhs, Timestamp rhs) => lhs.CompareTo(rhs) > 0;

        /// <summary>
        /// Compares two timestamps.
        /// </summary>
        /// <param name="lhs">The left timestamp to compare.</param>
        /// <param name="rhs">The right timestamp to compare.</param>
        /// <returns>true is <paramref name="lhs"/> is later than or equal to <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator >=(Timestamp lhs, Timestamp rhs) => lhs.CompareTo(rhs) >= 0;

        /// <inheritdoc />
        public override string ToString()
        {
            // Code taken from Protobuf TimestampPartial/DurationPartial. We could create a proto, format that
            // and then strip the quotes, but it seems a little unnecessary.
            DateTime dateTime = s_unixEpoch.AddSeconds(_seconds);
            var builder = new StringBuilder("Timestamp: ");
            builder.Append(dateTime.ToString("yyyy'-'MM'-'dd'T'HH:mm:ss", CultureInfo.InvariantCulture));

            if (_nanoseconds != 0)
            {
                builder.Append('.');
                // Output to 3, 6 or 9 digits.
                if (_nanoseconds % 1000000 == 0)
                {
                    builder.Append((_nanoseconds / 1000000).ToString("d3", CultureInfo.InvariantCulture));
                }
                else if (_nanoseconds % 1000 == 0)
                {
                    builder.Append((_nanoseconds / 1000).ToString("d6", CultureInfo.InvariantCulture));
                }
                else
                {
                    builder.Append(_nanoseconds.ToString("d9", CultureInfo.InvariantCulture));
                }
            }
            builder.Append("Z");
            return builder.ToString();
        }
    }
}
