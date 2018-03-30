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
using Google.Protobuf;
using System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Static class with convenience methods for creating various kinds of <see cref="Mutation"/> instances.
    /// </summary>
    public static class Mutations
    {
        /// <summary>
        /// Creates a <see cref="MutateRowsRequest.Types.Entry"/> to use with MutateRows requests.
        /// Each Entry is an atomic, ordered set of mutations for a particular row.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="rowKey">
        /// The key of the row to which the <paramref name="mutations"/> should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Mutations are
        /// applied in order, meaning that earlier mutations can be masked by
        /// later ones. You must specify at least one mutation. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>The MutateRows entry describing mutations for a single row.</returns>
        /// <seealso cref="BigtableClient.MutateRows(MutateRowsRequest, Api.Gax.Grpc.CallSettings)"/>
        /// <seealso cref="BigtableClient.MutateRows(TableName, MutateRowsRequest.Types.Entry[])"/>
        /// <seealso cref="BigtableClient.MutateRows(TableName, System.Collections.Generic.IEnumerable{MutateRowsRequest.Types.Entry}, Api.Gax.Grpc.CallSettings)"/>
        /// <seealso cref="BigtableClient.MutateRowsAsync(MutateRowsRequest, Api.Gax.Grpc.CallSettings)"/>
        /// <seealso cref="BigtableClient.MutateRowsAsync(TableName, MutateRowsRequest.Types.Entry[])"/>
        /// <seealso cref="BigtableClient.MutateRowsAsync(TableName, System.Collections.Generic.IEnumerable{MutateRowsRequest.Types.Entry}, Api.Gax.Grpc.CallSettings)"/>
        public static MutateRowsRequest.Types.Entry CreateEntry(BigtableByteString rowKey, params Mutation[] mutations)
        {
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");
            var entry = new MutateRowsRequest.Types.Entry
            {
                RowKey = (ByteString)rowKey,
                Mutations = { Utilities.ValidateCollection(mutations, nameof(mutations)) }
            };
            GaxPreconditions.CheckArgument(
                entry.Mutations.Count != 0, nameof(mutations), "There must be at least one entry.");
            return entry;
        }

        /// <summary>
        /// Creates a <see cref="Mutation"/> which deletes cells from the specified column, optionally
        /// restricting the deletions to a given version range.
        /// </summary>
        /// <remarks>
        /// <para> 
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>,
        /// so <paramref name="columnQualifier"/> can be specified using a string as well and
        /// its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the family from which cells should be deleted.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="columnQualifier">
        /// The qualifier of the column from which cells should be deleted.
        /// Can be any byte string, including the empty string.
        /// </param>
        /// <param name="versionRange">
        /// [Optional] The range of versions within which cells should be deleted.
        /// If unspecified, all versions will be deleted.
        /// </param>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation DeleteFromColumn(
            string familyName,
            BigtableByteString columnQualifier,
            BigtableVersionRange versionRange = null) =>
            new Mutation
            {
                DeleteFromColumn = new Mutation.Types.DeleteFromColumn
                {
                    FamilyName = Utilities.ValidateFamilyName(familyName),
                    ColumnQualifier = columnQualifier.Value,
                    TimeRange = versionRange?.ToTimestampRange()
                }
            };

        /// <summary>
        /// Creates a <see cref="Mutation"/> which deletes all cells from the specified column family.
        /// </summary>
        /// <param name="familyName">
        /// The name of the family from which cells should be deleted.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation DeleteFromFamily(string familyName) =>
            new Mutation
            {
                DeleteFromFamily = new Mutation.Types.DeleteFromFamily
                {
                    FamilyName = Utilities.ValidateFamilyName(familyName)
                }
            };

        /// <summary>
        /// Creates a <see cref="Mutation"/> which deletes all cells from the containing row.
        /// </summary>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation DeleteFromRow() =>
            new Mutation
            {
                DeleteFromRow = new Mutation.Types.DeleteFromRow()
            };

        /// <summary>
        /// Creates a <see cref="Mutation"/> which sets the value of the specified cell.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>,
        /// so <paramref name="columnQualifier"/> or <paramref name="value"/> can be specified
        /// using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the family into which new data should be written.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="columnQualifier">
        /// The qualifier of the column into which new data should be written.
        /// Can be any byte string, including the empty string.
        /// </param>
        /// <param name="value">
        /// The value to be written into the specified cell.
        /// </param>
        /// <param name="version">
        /// [Optional] The version of the cell into which new data should be written.
        /// If unspecified, the version will be initialized from the current UTC time.
        /// </param>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation SetCell(
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version = null) =>
            new Mutation
            {
                SetCell = new Mutation.Types.SetCell
                {
                    FamilyName = Utilities.ValidateFamilyName(familyName),
                    ColumnQualifier = columnQualifier.Value,
                    Value = value.Value,
                    TimestampMicros = (version ?? new BigtableVersion(DateTime.UtcNow)).Micros
                }
            };
    }
}
