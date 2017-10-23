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
using Google.Api.Gax.Grpc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableClient
    {
        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRow(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) =>
            MutateRow(
                CreateMutateRowRequest(tableName, rowKey, mutations),
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRow(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            params Mutation[] mutations) =>
            MutateRow(
                CreateMutateRowRequest(tableName, rowKey, mutations));

        /// <summary>
        /// Asynchronously mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRowAsync(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) =>
            MutateRowAsync(
                CreateMutateRowRequest(tableName, rowKey, mutations),
                callSettings);

        /// <summary>
        /// Asynchronously mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRowAsync(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) =>
            MutateRowAsync(
                CreateMutateRowRequest(tableName, rowKey, mutations),
                CallSettings.FromCancellationToken(cancellationToken));

        private static MutateRowRequest CreateMutateRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");
            GaxPreconditions.CheckNotNull(mutations, nameof(mutations));
            var mutationsChecked = mutations.Select(mutation =>
            {
                GaxPreconditions.CheckArgument(mutation != null, nameof(mutations), "Entries must not be null");
                return mutation;
            });

            return new MutateRowRequest
            {
                TableName = tableName.ToString(),
                RowKey = rowKey,
                Mutations = { mutationsChecked }
            };
        }
    }

    public partial class BigtableClientImpl
    {
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, string resource)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, resource);
        }
    }
}
