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
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Resources;

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
        /// </summary>
        public LockHint? LockHint { get; }

        /// <summary>
        /// An option to control the order in which rows are returned from a read.
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
        public ReadOptions WithLockHint(LockHint lockHint) =>
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
        public ReadOptions WithOrderBy(OrderBy orderBy) =>
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
    /// The options abailable for the LockHint mechanism on a ReadRequest.
    /// </summary>
    public enum LockHint
    {
        /// <summary>
        /// Default value.
        ///
        /// `LOCK_HINT_UNSPECIFIED` is equivalent to `LOCK_HINT_SHARED`.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Acquire shared locks.
        ///
        /// By default when you perform a read as part of a read-write transaction,
        /// Spanner acquires shared read locks, which allows other reads to still
        /// access the data until your transaction is ready to commit. When your
        /// transaction is committing and writes are being applied, the transaction
        /// attempts to upgrade to an exclusive lock for any data you are writing.
        /// For more information about locks, see [Lock
        /// modes](https://cloud.google.com/spanner/docs/introspection/lock-statistics#explain-lock-modes).
        /// </summary>
        Shared = 1,

        /// <summary>
        /// Acquire exclusive locks.
        ///
        /// Requesting exclusive locks is beneficial if you observe high write
        /// contention, which means you notice that multiple transactions are
        /// concurrently trying to read and write to the same data, resulting in a
        /// large number of aborts. This problem occurs when two transactions
        /// initially acquire shared locks and then both try to upgrade to exclusive
        /// locks at the same time. In this situation both transactions are waiting
        /// for the other to give up their lock, resulting in a deadlocked situation.
        /// Spanner is able to detect this occurring and force one of the
        /// transactions to abort. However, this is a slow and expensive operation
        /// and results in lower performance. In this case it makes sense to acquire
        /// exclusive locks at the start of the transaction because then when
        /// multiple transactions try to act on the same data, they automatically get
        /// serialized. Each transaction waits its turn to acquire the lock and
        /// avoids getting into deadlock situations.
        ///
        /// Because the exclusive lock hint is just a hint, it shouldn't be
        /// considered equivalent to a mutex. In other words, you shouldn't use
        /// Spanner exclusive locks as a mutual exclusion mechanism for the execution
        /// of code outside of Spanner.
        ///
        /// **Note:** Request exclusive locks judiciously because they block others
        /// from reading that data for the entire transaction, rather than just when
        /// the writes are being performed. Unless you observe high write contention,
        /// you should use the default of shared read locks so you don't prematurely
        /// block other clients from reading the data that you're writing to.
        /// </summary>
        Exclusive = 2
    }

    internal class LockHintConverter
    {
        internal static V1.ReadRequest.Types.LockHint ToProto(LockHint lockHint) => (V1.ReadRequest.Types.LockHint) (int) lockHint;
    }

    /// <summary>
    /// The options available for the OrderBy option for a ReadRequest.
    /// </summary>
    public enum OrderBy
    {
        /// <summary>
        /// Default value.
        ///
        /// `ORDER_BY_UNSPECIFIED` is equivalent to `ORDER_BY_PRIMARY_KEY`.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Read rows are returned in primary key order.
        ///
        /// In the event that this option is used in conjunction with the
        /// `partition_token` field, the API returns an `INVALID_ARGUMENT` error.
        /// </summary>
        PrimaryKey = 1,

        /// <summary>
        /// Read rows are returned in any order.
        /// </summary>
        NoOrder = 2,
    }

    internal class OrderByConverter
    {
        internal static V1.ReadRequest.Types.OrderBy ToProto(OrderBy orderBy) => (V1.ReadRequest.Types.OrderBy) (int) orderBy;
    }
}
