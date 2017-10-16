// Copyright 2017 Google Inc. All rights reserved.
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

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// A version which uniquely identifies a cell within a column.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Note: when using ReadModifyWriteRow, modified columns automatically use a server version, which
    /// is based on the current timestamp micros. For those columns, other reads and writes should
    /// use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed to using
    /// a custom versioning scheme with 64-bit values.
    /// </para>
    /// </remarks>
    public struct BigtableVersion : IComparable, IComparable<BigtableVersion>, IEquatable<BigtableVersion>
    {
        private const long TicksPerMicro = 10;

        // Visible for testing
        internal static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Creates a new <see cref="BigtableVersion"/> value from a 64-bit value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note: when using ReadModifyWriteRow, modified columns automatically use a server version, which
        /// is based on the current timestamp micros. For those columns, other reads and writes should
        /// use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed to using
        /// a custom versioning scheme with 64-bit values.
        /// </para>
        /// </remarks>
        /// <param name="value">
        /// The non-negative version value, or -1 to initialize from the microseconds of DateTime.UtcNow.
        /// </param>
        public BigtableVersion(long value)
        {
            GaxPreconditions.CheckArgumentRange(value, nameof(value), -1, long.MaxValue);
            Value = value == -1 ? DateTime.UtcNow.Ticks / TicksPerMicro : value;
        }

        /// <summary>
        /// Creates a new <see cref="BigtableVersion"/> value from the microseconds of a timestamp since the Unix epoch.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note: when using ReadModifyWriteRow, modified columns automatically use a server version, which
        /// is based on the current timestamp micros. For those columns, other reads and writes should
        /// use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed to using
        /// a custom versioning scheme with 64-bit values.
        /// </para>
        /// </remarks>
        /// <param name="timestamp">
        /// The timestamp whose microseconds since the Unix epoch should be used as the version value. It must be specified in UTC.
        /// </param>
        public BigtableVersion(DateTime timestamp)
        {
            GaxPreconditions.CheckArgument(
                timestamp.Kind == DateTimeKind.Utc,
                nameof(timestamp),
                $"The {nameof(BigtableVersion)} timestamp must be specified in UTC.");

            Value = (timestamp.Ticks - UnixEpoch.Ticks) / TicksPerMicro;
        }

        /// <summary>
        /// Gets the version value. Greater version values indicate newer cell values.
        /// </summary>
        public long Value { get; }

        /// <summary>
        /// Gets the DateTime equivalent to the version assuming the value is a timestamp micros value since the Unix epoch.
        /// </summary>
        /// <returns>The DateTime representing the version timestamp.</returns>
        public DateTime ToDateTime() => new DateTime((Value * TicksPerMicro) + UnixEpoch.Ticks, DateTimeKind.Utc);

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj is BigtableVersion other)
            {
                return CompareTo(other);
            }
            throw new ArgumentException($"The specified object cannot be compared with {nameof(BigtableVersion)}", nameof(obj));
        }

        /// <inheritdoc />
        public int CompareTo(BigtableVersion other) => Value.CompareTo(other.Value);

        /// <summary>
        /// Compares two nullable <see cref="BigtableVersion"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is less than <paramref name="y"/>; otherwise false.</returns>
        public static int Compare(BigtableVersion? x, BigtableVersion? y)
        {
            if (x == null)
            {
                return y == null ? 0 : -1;
            }
            else if (y == null)
            {
                return 1;
            }

            return x.Value.CompareTo(y.Value);
        }

        /// <inheritdoc />
        public bool Equals(BigtableVersion other) => CompareTo(other) == 0;

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is BigtableVersion other && Equals(other);

        /// <inheritdoc />
        public override int GetHashCode() => Value.GetHashCode();

        /// <inheritdoc />
        public override string ToString() => $"{nameof(BigtableVersion)}: {Value}";

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableVersion"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is less than <paramref name="y"/>; otherwise false.</returns>
        public static bool operator <(BigtableVersion x, BigtableVersion y) => x.Value < y.Value;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableVersion"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is less than or equal <paramref name="y"/>; otherwise false.</returns>
        public static bool operator <=(BigtableVersion x, BigtableVersion y) => x.Value <= y.Value;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableVersion"/> values for equality.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is equal to <paramref name="y"/>; otherwise false.</returns>
        public static bool operator ==(BigtableVersion x, BigtableVersion y) => x.Value == y.Value;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableVersion"/> values for inequality.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is not equal to <paramref name="y"/>; otherwise false.</returns>
        public static bool operator !=(BigtableVersion x, BigtableVersion y) => x.Value != y.Value;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableVersion"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is greater than or equal <paramref name="y"/>; otherwise false.</returns>
        public static bool operator >=(BigtableVersion x, BigtableVersion y) => x.Value >= y.Value;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableVersion"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is greater than <paramref name="y"/>; otherwise false.</returns>
        public static bool operator >(BigtableVersion x, BigtableVersion y) => x.Value > y.Value;
    }

    internal static class BigtableVersionExtensions
    {
        public static long ToTimestampMicros(this BigtableVersion? version) =>
            version == null ? 0 : version.Value.Value;

        public static BigtableVersion? ToVersion(this long? timestampMicros) =>
            timestampMicros == null ?
                default(BigtableVersion?) :
                new BigtableVersion(timestampMicros.Value);

        public static BigtableVersion? ToVersion(this DateTime? timestamp) =>
            timestamp == null ?
                default(BigtableVersion?) :
                new BigtableVersion(timestamp.Value);
    }
}