// Copyright 2021 Google Inc. All Rights Reserved.
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
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Immutable class that defines a set of keys to select from a table or index.
    /// KeySets are used for Read operations to specify the rows that should be returned
    /// by the read. A KeySet can be created from a set of individual keys or a set of
    /// key ranges. The <see cref="KeySet.All"/> instance can be used for read operations
    /// that should return all rows.
    /// </summary>
    ///
    /// <example>
    /// Example usage:
    /// <code>
    /// using var cmd = connection.CreateReadCommand(
    ///     "MyTable",
    ///     ReadOptions.FromColumns("MyCol1", "MyCol2"),
    ///     KeySet.FromKeys(new Key("k1"), new Key("k2")));
    /// using var reader = await cmd.ExecuteReaderAsync();
    /// </code>
    /// </example>
    public sealed class KeySet
    {
        /// <summary>
        /// True for key sets that select all keys in the table or index, and false for all other key sets.
        /// </summary>
        public bool AllKeys { get; }

        /// <summary>
        /// The collection of specific keys to select.
        /// </summary>
        public IEnumerable<Key> Keys { get; }

        /// <summary>
        /// The list of key ranges to select. All rows that are in at least one of the key ranges will be selected.
        /// </summary>
        public IEnumerable<KeyRange> Ranges { get; }

        private Lazy<V1.KeySet> LazyProtobuf => new Lazy<V1.KeySet>(ToProtobuf);
        internal V1.KeySet Protobuf => LazyProtobuf.Value;

        /// <summary>
        /// Returns a key set that selects all keys in the table or index.
        /// </summary>
        public static KeySet All { get; } = new KeySet(true, null, null);

        /// <summary>
        /// Creates a new key set from a collection of parameters that represent exactly one key.
        /// </summary>
        /// <param name="parameters">A parameter collection containing the values of the key</param>
        /// <returns>A key set for one specific key</returns>
        public static KeySet FromParameters(SpannerParameterCollection parameters) => FromKeys(new Key(parameters));

        /// <summary>
        /// Creates a new key set for a collection of keys.
        /// </summary>
        /// <param name="keys">The keys to select</param>
        /// <returns>A key set for a collection of keys</returns>
        public static KeySet FromKeys(params Key[] keys) => new KeySet(false, new List<Key>(GaxPreconditions.CheckNotNull(keys, nameof(keys))).AsReadOnly(), null);

        /// <summary>
        /// Creates a new key set for a collection of key ranges.
        /// </summary>
        /// <param name="ranges">The key ranges to select</param>
        /// <returns>A key set for a collection of key ranges</returns>
        public static KeySet FromRanges(params KeyRange[] ranges) => new KeySet(false, null, new List<KeyRange>(GaxPreconditions.CheckNotNull(ranges, nameof(ranges))).AsReadOnly());

        private KeySet(bool allKeys, IEnumerable<Key> keys, IEnumerable<KeyRange> ranges)
        {
            GaxPreconditions.CheckArgument(
                allKeys && keys == null && ranges == null ||
                !allKeys && keys != null && ranges == null ||
                !allKeys && keys == null && ranges != null,
                "allKeys, keys, ranges",
                "Only one of allKeys, keys, and ranges may be set"
            );
            AllKeys = allKeys;
            Keys = keys;
            Ranges = ranges;
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
            => other is KeySet keySet && Protobuf.Equals(keySet.Protobuf);

        /// <inheritdoc/>
        public override int GetHashCode() => Protobuf.GetHashCode();

        /// <inheritdoc/>
        public override string ToString()
        {
            if (AllKeys)
            {
                return "KeySet {AllKeys = true}";
            }

            // The KeySet is a collection of individual keys.
            if (Keys != null)
            {
                return $"KeySet {{Keys = [{string.Join(", ", Keys)}]}}";
            }

            // The KeySet is a collection of key ranges.
            if (Ranges != null)
            {
                return $"KeySet {{Ranges = [{string.Join(", ", Ranges)}]}}";
            }

            throw new InvalidOperationException("Implementation error, we should never have gotten here.");
        }

        private V1.KeySet ToProtobuf()
        {
            if (AllKeys)
            {
                return new V1.KeySet { All = true };
            }

            // The KeySet is a collection of individual keys.
            if (Keys != null)
            {
                var protobufKeys = Keys.Select(k => k.KeyParts);
                return new V1.KeySet { Keys = { protobufKeys } };
            }

            // The KeySet is a collection of key ranges.
            if (Ranges != null)
            {
                var protobufRanges = Ranges.Select(r => r.Protobuf);
                return new V1.KeySet { Ranges = { protobufRanges } };
            }

            throw new InvalidOperationException("Implementation error, we should never have gotten here.");
        }
    }

    /// <summary>
    /// Immutable class that defines a range of keys to select from a table or index.
    /// </summary>
    public sealed class KeyRange
    {
        /// <summary>
        /// The start of the key range. It can be inclusive or exclusive, depending on the value of <see cref="BeginInclusive"/>.
        /// </summary>
        public Key BeginAt { get; }

        /// <summary>
        /// True if the start of the key range is inclusive, and false otherwise.
        /// </summary>
        public bool BeginInclusive { get; }

        /// <summary>
        /// The end of the key range. It can be inclusive or exclusive, depending on the value of <see cref="EndInclusive"/>.
        /// </summary>
        public Key End { get; }

        /// <summary>
        /// True if the end of the key range is inclusive, and false if the end is exclusive.
        /// </summary>
        public bool EndInclusive { get; }

        private Lazy<V1.KeyRange> LazyProtobuf => new Lazy<V1.KeyRange>(ToProtobuf);
        internal V1.KeyRange Protobuf => LazyProtobuf.Value;

        /// <summary>
        /// Creates a new KeyRange with an inclusive begin and exclusive end.
        /// </summary>
        /// <param name="begin">The begin of the key range (inclusive)</param>
        /// <param name="end">The end of the key range (exclusive)</param>
        /// <returns>A new KeyRange for the keys [begin, end)</returns>
        public static KeyRange ClosedOpen(Key begin, Key end) => new KeyRange(begin, true, end, false);

        /// <summary>
        /// Creates a new KeyRange with an exclusive begin and inclusive end.
        /// </summary>
        /// <param name="begin">The begin of the key range (exclusive)</param>
        /// <param name="end">The end of the key range (inclusive)</param>
        /// <returns>A new KeyRange for the keys (begin, end]</returns>
        public static KeyRange OpenClosed(Key begin, Key end) => new KeyRange(begin, false, end, true);

        /// <summary>
        /// Creates a new KeyRange with an inclusive begin and inclusive end.
        /// </summary>
        /// <param name="begin">The begin of the key range (inclusive)</param>
        /// <param name="end">The end of the key range (inclusive)</param>
        /// <returns>A new KeyRange for the keys [begin, end]</returns>
        public static KeyRange ClosedClosed(Key begin, Key end) => new KeyRange(begin, true, end, true);

        /// <summary>
        /// Creates a new KeyRange with an exclusive begin and exclusive end.
        /// </summary>
        /// <param name="begin">The begin of the key range (exclusive)</param>
        /// <param name="end">The end of the key range (exclusive)</param>
        /// <returns>A new KeyRange for the keys (begin, end)</returns>
        public static KeyRange OpenOpen(Key begin, Key end) => new KeyRange(begin, false, end, false);

        private KeyRange(
            Key begin,
            bool beginInclusive,
            Key end,
            bool endInclusive)
        {
            BeginAt = GaxPreconditions.CheckNotNull(begin, nameof(begin));
            BeginInclusive = beginInclusive;
            End = GaxPreconditions.CheckNotNull(end, nameof(end));
            EndInclusive = endInclusive;
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
            => other is KeyRange range && Protobuf.Equals(range.Protobuf);

        /// <inheritdoc/>
        public override int GetHashCode() => Protobuf.GetHashCode();

        /// <inheritdoc/>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(BeginInclusive ? '[' : '(');
            builder.Append(BeginAt.KeyParts);
            builder.Append(", ");
            builder.Append(End.KeyParts);
            builder.Append(EndInclusive ? ']' : ')');

            return builder.ToString();
        }

        private V1.KeyRange ToProtobuf()
        {
            var range = new V1.KeyRange();
            if (BeginInclusive)
            {
                range.StartClosed = BeginAt.KeyParts;
            }
            else
            {
                range.StartOpen = BeginAt.KeyParts;
            }

            if (EndInclusive)
            {
                range.EndClosed = End.KeyParts;
            }
            else
            {
                range.EndOpen = End.KeyParts;
            }
            return range;
        }
    }

    /// <summary>
    /// Immutable class that defines a key for a single row in a table or index.
    /// </summary>
    public sealed class Key
    {
        /// <summary>
        /// The values of this key.
        /// </summary>
        internal ListValue KeyParts { get; }

        /// <summary>
        /// Creates a key from the values in the parameter collection.
        /// </summary>
        /// <param name="keyParts">The values that define the key</param>
        internal Key(SpannerParameterCollection keyParts)
        {
            KeyParts = ToListValue(keyParts);
        }

        /// <summary>
        /// Creates a key consisting of the given key parts.
        /// </summary>
        /// <param name="keyParts">The values that define the key</param>
        public Key(params object[] keyParts)
        {
            var protobufValues = keyParts.Select(
                v => SpannerDbType.FromClrType(v?.GetType())?.ToProtobufValue(v, SpannerConversionOptions.Default) ?? Value.ForNull());
            KeyParts = new ListValue { Values = { protobufValues } };
        }

        /// <inheritdoc/>
        public override bool Equals(object other)
            => other is Key key && KeyParts.Equals(key.KeyParts);

        /// <inheritdoc/>
        public override int GetHashCode() => KeyParts.GetHashCode();

        /// <inheritdoc/>
        public override string ToString() => KeyParts.ToString();

        private static ListValue ToListValue(SpannerParameterCollection parameters)
        {
            // See comment at the top of GetMutations in SpannerCommand.ExecutableCommand.
            // These options are currently not in use, but are required in the API.
            SpannerConversionOptions options = null;
            return new ListValue
            {
                Values =
                {
                    parameters.Select(
                        x => x.SpannerDbType.ToProtobufValue(x.GetValidatedValue(), options))
                }
            };
        }
    }
}
