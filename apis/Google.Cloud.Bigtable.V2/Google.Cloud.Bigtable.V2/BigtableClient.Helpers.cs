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

using Google.Api.Gax.Grpc;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableClient
    {
        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="RowKey"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either <paramref name="trueMutations"/> or
        /// <paramref name="falseMutations"/> will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="falseMutations"/> is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// does not yield any cells when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="trueMutations"/> is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            TableName tableName,
            RowKey rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="RowKey"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, <paramref name="trueMutations"/> may or may not
        /// be executed. If unset, checks that the row contains any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            TableName tableName,
            RowKey rowKey,
            RowFilter predicateFilter,
            params Mutation[] trueMutations)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="RowKey"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRow(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            TableName tableName,
            RowKey rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="RowKey"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRow(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            TableName tableName,
            RowKey rowKey,
            params Mutation[] mutations)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="MutateRows(MutateRowsRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual MutateRowsStream MutateRows(
            TableName tableName,
            IEnumerable<MutateRowsRequest.Types.Entry> entries, // TODO: Do we want a wrapper type for Entry?
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="MutateRows(MutateRowsRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual MutateRowsStream MutateRows(
            TableName tableName,
            params MutateRowsRequest.Types.Entry[] entries)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the existing version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="RowKey"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            TableName tableName,
            RowKey rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the existing version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="RowKey"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            TableName tableName,
            RowKey rowKey,
            params ReadModifyWriteRule[] rules)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="ReadRows(ReadRowsRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to read.
        /// </param>
        /// <param name="rows">
        /// The row keys and/or ranges to read. If not specified, reads from all rows.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row(s). If unset,
        /// reads the entirety of each row.
        /// </param>
        /// <param name="rowsLimit">
        /// The read will terminate after committing to N rows' worth of results. The
        /// default (zero) is to return all results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ReadRowsStream ReadRows(
            TableName tableName,
            RowSet rows = null,
            RowFilter filter = null,
            long rowsLimit = 0,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="SampleRowKeys(SampleRowKeysRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to sample row keys.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream with the row key samples.
        /// </returns>
        public virtual SampleRowKeysStream SampleRowKeys(
            TableName tableName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        public partial class ReadRowsStream
        {
            /// <summary>
            /// Returns an asynchronous sequence of rows from this set of results.
            /// </summary>
            /// <param name="cancellationToken">
            /// The token to monitor for cancellation requests.
            /// </param>
            /// <returns>An asynchronous sequence of rows from this set of results.</returns>
            public IAsyncEnumerable<Row> GetRowsAsync(CancellationToken cancellationToken = default)
            {
                throw new NotImplementedException();
            }
        }
    }
}
