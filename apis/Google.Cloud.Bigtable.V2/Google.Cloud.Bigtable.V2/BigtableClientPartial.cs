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
using Google.Cloud.Bigtable.Common.V2;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using static Google.Cloud.Bigtable.V2.BigtableMutateRowsRequestManager;

namespace Google.Cloud.Bigtable.V2
{
    public abstract partial class BigtableClient
    {
        private static string UserAgent { get; } =
            $"cbt-csharp/v{typeof(BigtableClient).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}";

        // TODO: Auto-generate these if possible/easy after multi-channel support is added.

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="BigtableServiceApiClient"/>s.</param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used by the server.
        /// </param>
        /// <returns>The task representing the created <see cref="BigtableClient"/>.</returns>
        public static async Task<BigtableClient> CreateAsync(ClientCreationSettings clientCreationSettings = null, string appProfileId = null)
        {
            //TODO: Try to generalize all this with Pubsub.
            clientCreationSettings?.Validate();
            var channelCredentials = clientCreationSettings?.Credentials;
            // Use default credentials if none given.
            if (channelCredentials == null)
            {
                var credentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                if (credentials.IsCreateScopedRequired)
                {
                    credentials = credentials.CreateScoped(BigtableServiceApiClient.DefaultScopes);
                }
                channelCredentials = credentials.ToChannelCredentials();
            }
            var clientCount = clientCreationSettings?.ClientCount ?? Environment.ProcessorCount;

            var settings = clientCreationSettings?.BigtableServiceApiSettings;
            var endpoint = clientCreationSettings?.ServiceEndpoint ?? BigtableServiceApiClient.DefaultEndpoint;
            var clients = new BigtableServiceApiClient[clientCount];
            var shutdowns = new Func<Task>[clientCount];
            // Set channel send/recv message size to unlimited.
            var channelOptions = new[]
            {
                new ChannelOption(ChannelOptions.MaxSendMessageLength, -1),
                new ChannelOption(ChannelOptions.MaxReceiveMessageLength, -1),

                // TODO: Figure out if there's a good way to test this
                new ChannelOption(ChannelOptions.PrimaryUserAgentString, UserAgent)
            };
            // Fill clients[] with BigtableServiceApiClient instances, each with specific channel
            for (int i = 0; i < clientCount; i++)
            {
                var channel = new Channel(endpoint.Host, endpoint.Port, channelCredentials, channelOptions);
                clients[i] = BigtableServiceApiClient.Create(channel, settings);
                shutdowns[i] = channel.ShutdownAsync;
            }
            Func<Task> shutdown = () => Task.WhenAll(shutdowns.Select(x => x()));

            return new BigtableClientImpl(clients, appProfileId, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="BigtableServiceApiClient"/>s.</param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used by the server.
        /// </param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create(ClientCreationSettings clientCreationSettings = null, string appProfileId = null) =>
            Task.Run(() => CreateAsync(clientCreationSettings, appProfileId)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Synchronously creates a <see cref="BigtableClient"/> from a set of pre-existing clients.
        /// </summary>
        /// <param name="clients">The <see cref="BigtableServiceApiClient"/>s to use in a <see cref="BigtableClient"/> 
        /// Must not be null.</param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used by the server.
        /// </param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create(IEnumerable<BigtableServiceApiClient> clients, string appProfileId = null) => 
            new BigtableClientImpl(
                GaxPreconditions.CheckNotNull(clients, nameof(clients)).ToArray(),
                appProfileId,
                underlyingClientSettings: null);

        /// <summary>
        /// Gets the value which specifies routing for replication. If null, the "default" application profile will be used by the server.
        /// </summary>
        public virtual string AppProfileId => null;

        /// <summary>
        /// Gets a <see cref="BigtableClient"/> matching this one but with the specified <paramref name="appProfileId"/>.
        /// </summary>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used by the server.
        /// </param>
        /// <returns>The updated <see cref="BigtableClient"/>.</returns>
        public virtual BigtableClient WithAppProfileId(string appProfileId) => this;

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either <paramref name="trueMutations"/> or
        /// <paramref name="falseMutations"/> will be executed. If null, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="falseMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// does not yield any cells when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="trueMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) =>
            CheckAndMutateRow(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations),
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, <paramref name="trueMutations"/> may or may not
        /// be executed. If null, checks that the row contains any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.  Must not be null, or contain null elements.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            params Mutation[] trueMutations) =>
            CheckAndMutateRow(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations: null));

        /// <summary>
        /// Asynchronously mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRowAsync(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either <paramref name="trueMutations"/> or
        /// <paramref name="falseMutations"/> will be executed. If null, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="falseMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// does not yield any cells when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="trueMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations),
                callSettings);

        /// <summary>
        /// Asynchronously mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRowAsync(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, <paramref name="trueMutations"/> may or may not
        /// be executed. If null, checks that the row contains any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.  Must not be null, or contain null elements.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            params Mutation[] trueMutations) =>
            CheckAndMutateRowAsync(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations: null));

        private static CheckAndMutateRowRequest CreateCheckAndMutateRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");

            var request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = rowKey.Value,
                PredicateFilter = predicateFilter,
                TrueMutations = { Utilities.ValidateCollection(trueMutations, nameof(trueMutations), allowNullCollection: true) },
                FalseMutations = { Utilities.ValidateCollection(falseMutations, nameof(falseMutations), allowNullCollection: true) }
            };

            GaxPreconditions.CheckArgument(
                request.TrueMutations.Count + request.FalseMutations.Count != 0,
                nameof(trueMutations),
                "There must be at least one mutation.");
            return request;
        }

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
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            params Mutation[] mutations) =>
            MutateRowAsync(
                CreateMutateRowRequest(tableName, rowKey, mutations));

        private static MutateRowRequest CreateMutateRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");
            
            var request = new MutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = rowKey.Value,
                Mutations = { Utilities.ValidateCollection(mutations, nameof(mutations)) }
            };

            GaxPreconditions.CheckArgument(
                request.Mutations.Count != 0, nameof(mutations), "There must be at least one entry.");
            return request;
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
        /// The unique name of the table to which the mutations should be applied. Must not be null.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the rows.
        /// </returns>
        public virtual MutateRowsResponse MutateRows(
            TableName tableName,
            IEnumerable<MutateRowsRequest.Types.Entry> entries,
            CallSettings callSettings = null) =>
            MutateRows(CreateMutateRowRequest(tableName, entries), callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="MutateRows(TableName, IEnumerable{MutateRowsRequest.Types.Entry}, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied. Must not be null.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <returns>
        /// The response from mutating the rows.
        /// </returns>
        public virtual MutateRowsResponse MutateRows(
            TableName tableName,
            params MutateRowsRequest.Types.Entry[] entries) =>
            MutateRows(tableName, entries, callSettings: null);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="MutateRowsAsync(MutateRowsRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied. Must not be null.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the rows.
        /// </returns>
        public virtual Task<MutateRowsResponse> MutateRowsAsync(
            TableName tableName,
            IEnumerable<MutateRowsRequest.Types.Entry> entries,
            CallSettings callSettings = null) =>
            MutateRowsAsync(CreateMutateRowRequest(tableName, entries), callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="MutateRowsAsync(TableName, IEnumerable{MutateRowsRequest.Types.Entry}, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied. Must not be null.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <returns>
        /// The response from mutating the rows.
        /// </returns>
        public virtual Task<MutateRowsResponse> MutateRowsAsync(
            TableName tableName,
            params MutateRowsRequest.Types.Entry[] entries) =>
            MutateRowsAsync(tableName, entries, callSettings: null);

        private static MutateRowsRequest CreateMutateRowRequest(TableName tableName, IEnumerable<MutateRowsRequest.Types.Entry> entries)
        {
            var request = new MutateRowsRequest
            {
                TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                Entries = { Utilities.ValidateCollection(entries, nameof(entries)) }
            };
            GaxPreconditions.CheckArgument(
                request.Entries.Count != 0, nameof(entries), "There must be at least one entry.");
            return request;
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.  Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) =>
            ReadModifyWriteRow(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules),
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            TableName tableName,
            BigtableByteString rowKey,
            params ReadModifyWriteRule[] rules) =>
            ReadModifyWriteRow(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules));

        /// <summary>
        /// Asynchronously modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.  Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules),
                callSettings);

        /// <summary>
        /// Asynchronously modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            params ReadModifyWriteRule[] rules) =>
            ReadModifyWriteRowAsync(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules));

        private static ReadModifyWriteRowRequest CreateReadModifyWriteRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");
            
            var request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = rowKey.Value,
                Rules = { Utilities.ValidateCollection(rules, nameof(rules)) }
            };

            GaxPreconditions.CheckArgument(
                request.Rules.Count != 0, nameof(rules), "There must be at least one entry.");
            return request;
        }

        /// <summary>
        /// Returns the contents of the requested row, optionally applying the specified Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="ReadRowAsync(TableName, BigtableByteString, RowFilter, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to read. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to read. Must not be empty.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row. If null,
        /// reads the entirety of the row.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The row from the server or null if it does not exist.
        /// </returns>
        public virtual Row ReadRow(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter filter = null,
            CallSettings callSettings = null) =>
            Task.Run(() => ReadRowAsync(tableName, rowKey, filter, callSettings)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Asynchronously returns the contents of the requested row, optionally applying the specified Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="ReadRows(TableName, RowSet, RowFilter, long?, CallSettings)"/>
        /// and takes the single row result or null if no rows are returned.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to read. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to read. Must not be empty.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row. If null,
        /// reads the entirety of the row.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The row from the server or null if it does not exist.
        /// </returns>
        public virtual async Task<Row> ReadRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter filter = null,
            CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");

            var response = ReadRows(
                tableName,
                new RowSet { RowKeys = { rowKey.Value } },
                filter,
                callSettings: callSettings);

            return await response.SingleOrDefault().ConfigureAwait(false);
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
        /// The unique name of the table from which to read. Must not be null.
        /// </param>
        /// <param name="rows">
        /// The row keys and/or ranges to read. If null, reads from all rows.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row(s). If null,
        /// reads the entirety of each row.
        /// </param>
        /// <param name="rowsLimit">
        /// The read will terminate after committing to N rows' worth of results.
        /// If null or 0, returns all results.
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
            long? rowsLimit = null,
            CallSettings callSettings = null) =>
            ReadRows(
                new ReadRowsRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    Rows = rows,
                    Filter = filter,
                    RowsLimit = GaxPreconditions.CheckArgumentRange(rowsLimit ?? 0, nameof(rowsLimit), 0, long.MaxValue)
                },
                callSettings);

        // TODO: Remove when generator supports flattening of server streaming methods.
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
        /// The unique name of the table from which to sample row keys. Must not be null.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream with the row key samples.
        /// </returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(
            TableName tableName,
            CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName))
                },
                callSettings);

        private protected BigtableServiceApiSettings UnderlyingClientSettings { get; set; }

        /// <summary>
        /// Settings for creating <see cref="BigtableServiceApiClient"/>s.
        /// </summary>
        public sealed class ClientCreationSettings
        {
            /// <summary>
            /// Instantiate with the specified settings.
            /// </summary>
            /// <param name="clientCount">Optional.
            /// The number of <see cref="BigtableServiceApiClient"/>s to create and use within a <see cref="BigtableClient"/> instance.
            /// If not set will default to number of processors.</param>
            /// <param name="bigtableServiceApiSettings">Optional. The settings to use when creating <see cref="BigtableServiceApiClient"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use when creating <see cref="BigtableServiceApiClient"/> instances.</param>
            /// <param name="serviceEndpoint">Optional.
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="BigtableServiceApiClient"/> instances.</param>
            public ClientCreationSettings(
                int? clientCount = null,
                BigtableServiceApiSettings bigtableServiceApiSettings = null,
                ChannelCredentials credentials = null,
                ServiceEndpoint serviceEndpoint = null)
            {
                ClientCount = clientCount;
                BigtableServiceApiSettings = bigtableServiceApiSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
            }

            /// <summary>
            /// The number of <see cref="BigtableServiceApiClient"/>s to create and use within a <see cref="BigtableClient"/> instance.
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="BigtableServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see2 cref="BigtableServiceApiSettings.GetDefault"/>.
            /// </summary>
            public BigtableServiceApiSettings BigtableServiceApiSettings { get; }

            /// <summary>
            /// Credentials to use when creating <see cref="BigtableServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

            /// <summary>
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="BigtableServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="BigtableServiceApiClient.DefaultEndpoint"/>.
            /// </summary>
            public ServiceEndpoint ServiceEndpoint { get; }

            /// <summary>
            /// Creates <see cref="ClientCreationSettings"/> to be used in creation of <see cref="BigtableClient"/> for use with Emulator.
            /// <param name="target"> Service enpoint target in the yourhost:yourport form.</param>
            /// </summary>
            internal static ClientCreationSettings FromEndpointTarget(string target)
            {
                string[] endpointValues = target.Split(':');
                return new ClientCreationSettings(null, null, ChannelCredentials.Insecure, new ServiceEndpoint(endpointValues[0], Convert.ToInt32(endpointValues[1])));
            }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
        }
    }

    public partial class BigtableClientImpl
    {
        private readonly string _appProfileId;
        private readonly BigtableServiceApiClient[] _clients;
        private int _clientNumber = -1;

        // TODO: Add a public constructor after multi-channel support?
        internal BigtableClientImpl(
            BigtableServiceApiClient[] clients,
            string appProfileId,
            BigtableServiceApiSettings underlyingClientSettings)
        {
            _clients = clients;
            _appProfileId = appProfileId;

            Clock = underlyingClientSettings?.Clock ?? SystemClock.Instance;
            Scheduler = underlyingClientSettings?.Scheduler ?? SystemScheduler.Instance;
            UnderlyingClientSettings = underlyingClientSettings?.Clone();
        }

        /// <inheritdoc/>
        private BigtableServiceApiClient GetUnderlyingClient() => _clients[GetClientIndex()];

        /// <summary>
        /// Returns index of the next <see cref="BigtableClient"/> instance from <see cref="_clients"/>.
        /// </summary>
        private int GetClientIndex() => Interlocked.Increment(ref _clientNumber) % _clients.Length;

        /// <inheritdoc/>
        public override string AppProfileId => _appProfileId;

        /// <inheritdoc/>
        public override BigtableClient WithAppProfileId(string appProfileId) =>
            new BigtableClientImpl(_clients, appProfileId, UnderlyingClientSettings);

        internal IClock Clock { get; }
        internal IScheduler Scheduler { get; }

        internal BigtableServiceApiClient.ReadRowsStream ReadRowsInternal(ReadRowsRequest request, CallSettings callSettings) =>
            GetUnderlyingClient().ReadRows(request, callSettings);

        // TODO: These retry approaches don't retry if the initial request fails. We should probably handle these cases as well.

        private ReadRowsStream ConvertResult(
            ReadRowsRequest request,
            CallSettings callSettings,
            BigtableServiceApiClient.ReadRowsStream result)
        {
            var defaultSettings = UnderlyingClientSettings ?? new BigtableServiceApiSettings();
            var effectiveCallSettings = defaultSettings.ReadRowsSettings.MergedWith(callSettings);
            // TODO(mdour): Do we want to try to support per-call retry settings?
            var effectiveRetrySettings = defaultSettings.ReadRowsRetrySettings;

            return new ReadRowsStream(this, request, effectiveCallSettings, effectiveRetrySettings, result);
        }

        private async Task<MutateRowsResponse> ConvertResult(
            MutateRowsRequest request,
            CallSettings callSettings,
            BigtableServiceApiClient.MutateRowsStream result)
        {
            var defaultSettings = UnderlyingClientSettings ?? new BigtableServiceApiSettings();
            var effectiveCallSettings = defaultSettings.MutateRowsSettings.MergedWith(callSettings);
            // TODO(mdour): Do we want to try to support per-call retry settings?
            var effectiveRetrySettings = defaultSettings.MutateRowsRetrySettings;

            // TODO: Should the request manager be using the retry filter? We would need to fabricate RpcExceptions
            StatusCode[] retryStatuses = { StatusCode.DeadlineExceeded, StatusCode.Unavailable };
            var requestManager = new BigtableMutateRowsRequestManager(retryStatuses, request);

            var currentStream = result;
            var status = await ProcessCurrentStream().ConfigureAwait(false);
            if (effectiveRetrySettings != null && status == ProcessingStatus.Retryable)
            {
                await ApiCallRetryExtensions.RetryOperationUntilCompleted(
                    async () =>
                    {
                        currentStream = GetUnderlyingClient().MutateRows(requestManager.RetryRequest, callSettings);
                        return await ProcessCurrentStream().ConfigureAwait(false) != ProcessingStatus.Retryable;
                    },
                    Clock,
                    Scheduler,
                    effectiveCallSettings,
                    effectiveRetrySettings).ConfigureAwait(false);
            }
            return requestManager.BuildResponse();

            async Task<ProcessingStatus> ProcessCurrentStream()
            {
                var cancellationToken = effectiveCallSettings.CancellationToken ?? default;
                var responseStream = currentStream.ResponseStream;
                while (await responseStream.MoveNext(cancellationToken).ConfigureAwait(false))
                {
                    requestManager.SetStatus(responseStream.Current);
                }
                return requestManager.OnOk();
            }
        }
    }
}
