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
using System;
using System.Collections.Generic;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// ReadOptions define a read operation for a Spanner table.
    /// </summary>
    public sealed class ReadOptions
    {
        /// <summary>
        /// Returns the columns that will be read from the target table. Cannot be null or empty.
        /// </summary>
        public IReadOnlyList<string> Columns { get; }

        /// <summary>
        /// The index to use to search and order rows from the target table if the read
        /// operation should use a different index than the primary key, or null otherwise.
        /// The rows will be returned in the order of the specified index.
        /// </summary>
        public string IndexName { get; }

        /// <summary>
        /// The maximum number of rows to read from the target table, or null if there is no limit.
        /// </summary>
        public long? Limit { get; }

        /// <summary>
        /// A lock hint mechanism for reads done within a transaction.
        /// See <see cref="LockHint"/> for details.
        /// </summary>
        public LockHint? LockHint { get; }

        /// <summary>
        /// An option to control the order in which rows are returned from a read.
        /// See <see cref="OrderBy"/> for details.
        /// </summary>
        public OrderBy? OrderBy { get; }

        /// <summary>
        /// Creates options to read the given columns using a ReadCommand.
        /// </summary>
        /// <param name="columns">The columns to read from the target table. Must not be null or empty.</param>
        public static ReadOptions FromColumns(params string[] columns) => new ReadOptions(columns);

        /// <summary>
        /// Creates options to read the given columns using a ReadCommand.
        /// </summary>
        /// <param name="columns">The columns to read from the target table. Must not be null or empty.</param>
        public static ReadOptions FromColumns(IEnumerable<string> columns) => new ReadOptions(columns);

        private ReadOptions(params string[] columns)
            : this(ConvertAndValidateColumns(columns), null, null, null, null)
        {
        }

        private ReadOptions(IEnumerable<string> columns)
            : this(ConvertAndValidateColumns(columns), null, null, null, null)
        {
        }

        private ReadOptions(IReadOnlyList<string> columns, string indexName, long? limit, LockHint? lockHint, OrderBy? orderBy)
        {
            Columns = columns;
            IndexName = indexName;
            Limit = limit;
            LockHint = lockHint;
            OrderBy = orderBy;
        }

        private static IReadOnlyList<string> ConvertAndValidateColumns(IEnumerable<string> columns) =>
            CheckNotEmpty(new List<string>(GaxPreconditions.CheckNotNull(columns, nameof(columns))), nameof(columns))
                .AsReadOnly();

        /// <summary>
        /// Creates a clone of this ReadOptions with the given limit.
        /// </summary>
        /// <param name="limit">The maximum number of rows to read. Must be larger than 0. Null means no limit.</param>
        /// <returns>A clone of this ReadOptions with the given limit.</returns>
        public ReadOptions WithLimit(long? limit) =>
            new ReadOptions(Columns, IndexName, GaxPreconditions.CheckArgumentRange(limit, nameof(limit), 1L, long.MaxValue), LockHint, OrderBy);

        /// <summary>
        /// Returns a clone of this ReadOptions with the given index name.
        /// </summary>
        /// <param name="indexName">
        /// The index to use to search and order rows from the target table if the read operation
        /// should use a different index than the primary key.
        /// The rows will be returned in the order of the specified index.
        /// May not an empty string. Null means that the primary key of the table should be used for the read operation.
        /// </param>
        /// <returns>A clone of this ReadOptions with the given index name.</returns>
        public ReadOptions WithIndexName(string indexName) =>
            new ReadOptions(Columns, CheckNotEmpty(indexName, nameof(indexName)), Limit, LockHint, OrderBy);

        /// <summary>
        /// Returns a clone of this ReadOptions with the given lockHint value.
        /// </summary>
        /// <param name="lockHint">
        /// The value to use for the lockHint mechanism for the ReadOptions.
        /// Refer to the <see cref="Spanner.Data.LockHint"/> enum to see the available value options.
        /// </param>
        /// <returns>A clone of this ReadOptions with the given lockHint value.</returns>
        public ReadOptions WithLockHint(LockHint? lockHint) =>
            new ReadOptions(Columns, IndexName, Limit, lockHint, OrderBy);

        /// <summary>
        /// Returns a clone of this ReadOptions with the given orderBy value.
        /// </summary>
        /// <param name="orderBy">
        /// The value to use for the orderBy mechanism for the ReadOptions.
        /// Only available for read-write transactions
        /// Refer to the <see cref="Spanner.Data.OrderBy"/> enum to see the available value options.
        /// </param>
        /// <returns>A clone of this ReadOptions with the given ReadOptions value.</returns>
        public ReadOptions WithOrderBy(OrderBy? orderBy) =>
            new ReadOptions(Columns, IndexName, Limit, LockHint, orderBy);

        private static List<T> CheckNotEmpty<T>(List<T> list, string paramName) where T : class =>
            list.Count > 0
                ? list
                : throw new ArgumentException("An empty list was provided, but is not valid", paramName);

        private static string CheckNotEmpty(string val, string paramName) =>
            "".Equals(val)
                ? throw new ArgumentException("An empty string was provided, but is not valid", paramName)
                : val;
    }

    /// <summary>
    /// The options available for the LockHint value on the ReadOptions.
    /// </summary>
    public enum LockHint
    {
        /// <summary>
        /// Default value.
        ///
        /// `Unspecified` is equivalent to `Shared`.
        ///
        /// See https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Spanner.V1/latest/Google.Cloud.Spanner.V1.ReadRequest.Types.LockHint
        /// for further details.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Acquire shared locks.
        ///
        /// See https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Spanner.V1/latest/Google.Cloud.Spanner.V1.ReadRequest.Types.LockHint
        /// for further details.
        /// </summary>
        Shared = 1,

        /// <summary>
        /// Acquire exclusive locks.
        ///
        /// See https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Spanner.V1/latest/Google.Cloud.Spanner.V1.ReadRequest.Types.LockHint
        /// for further details.
        /// </summary>
        Exclusive = 2
    }

    internal static class LockHintConverter
    {
        internal static V1.ReadRequest.Types.LockHint ToProto(LockHint lockHint) => (V1.ReadRequest.Types.LockHint) (int) lockHint;
    }

    /// <summary>
    /// The options available for the OrderBy option for the ReadOptions.
    /// </summary>
    public enum OrderBy
    {
        /// <summary>
        /// Default value.
        ///
        /// `Unspecified` is equivalent to `PrimaryKey`.
        ///
        /// See https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Spanner.V1/latest/Google.Cloud.Spanner.V1.ReadRequest.Types.OrderBy
        /// for further details.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Read rows are returned in primary key order.
        ///
        /// See https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Spanner.V1/latest/Google.Cloud.Spanner.V1.ReadRequest.Types.OrderBy
        /// for further details.
        /// </summary>
        PrimaryKey = 1,

        /// <summary>
        /// Read rows are returned in any order.
        ///
        /// See https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Spanner.V1/latest/Google.Cloud.Spanner.V1.ReadRequest.Types.OrderBy
        /// for further details.
        /// </summary>
        NoOrder = 2,
    }

    internal static class OrderByConverter
    {
        internal static V1.ReadRequest.Types.OrderBy ToProto(OrderBy orderBy) => (V1.ReadRequest.Types.OrderBy) (int) orderBy;
    }
}
