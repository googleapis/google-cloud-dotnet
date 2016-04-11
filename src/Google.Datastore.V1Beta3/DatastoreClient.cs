// Copyright 2016 Google Inc. All Rights Reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Datastore.V1Beta3
{

    /// <summary>
    /// Extension methods to assist with using <see cref="DatastoreClient"/>.
    /// </summary>
    public static partial class DatastoreExtensions
    {
        /// <summary>
        /// Wrap a GRPC Datastore client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="DatastoreSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="DatastoreClient"/> that wraps the specified GRPC client.</returns>
        public static DatastoreClient ToClient(
            this Datastore.IDatastoreClient grpcClient,
            DatastoreSettings settings = null
        ) => new DatastoreClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Datastore wrapper.
    /// </summary>
    public sealed partial class DatastoreSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DatastoreSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default DatastoreSettings.</returns>
        public static DatastoreSettings GetDefault() => new DatastoreSettings();

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Datastore settings.</returns>
        public DatastoreSettings Clone() => CloneInto(new DatastoreSettings
        {
        });
    }

    /// <summary>
    /// Datastore client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DatastoreClient
    {
        /// <summary>
        /// The default endpoint for the Datastore service, which is a host of "datastore.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("datastore.googleapis.com", 443);

        /// <summary>
        /// The default Datastore scopes
        /// </summary>
        /// <remarks>
        /// The default Datastore scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="DatastoreClient"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The task representing the created <see cref="DatastoreClient"/>.</returns>
        public static async Task<DatastoreClient> CreateAsync(
            ServiceEndpoint endpoint = null,
            DatastoreSettings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = await ClientHelper.CreateChannelAsync(endpoint ?? DefaultEndpoint, credentials).ConfigureAwait(false);
            Datastore.DatastoreClient grpcClient = new Datastore.DatastoreClient(channel);
            return new DatastoreClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DatastoreClient"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The created <see cref="DatastoreClient"/>.</returns>
        public static DatastoreClient Create(
            ServiceEndpoint endpoint = null,
            DatastoreSettings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = ClientHelper.CreateChannel(endpoint ?? DefaultEndpoint, credentials);
            Datastore.DatastoreClient grpcClient = new Datastore.DatastoreClient(channel);
            return new DatastoreClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying GRPC Datastore client.
        /// </summary>
        public virtual Datastore.IDatastoreClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Look up entities by key.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="read_options">Options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Look up entities by key.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="read_options">Options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CancellationToken cancellationToken) => LookupAsync(
                projectId,
                readOptions,
                keys,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Look up entities by key.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="read_options">Options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupResponse Lookup(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CancellationToken cancellationToken) => RunQueryAsync(
                projectId,
                partitionId,
                readOptions,
                query,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="gql_query">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="gql_query">The GQL query to run.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CancellationToken cancellationToken) => RunQueryAsync(
                projectId,
                partitionId,
                readOptions,
                gqlQuery,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="gql_query">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begin a new transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begin a new transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CancellationToken cancellationToken) => BeginTransactionAsync(
                projectId,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Begin a new transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BeginTransactionResponse BeginTransaction(
            string projectId,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">The transaction in which to write.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">The transaction in which to write.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                projectId,
                mode,
                transaction,
                mutations,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">The transaction in which to write.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CancellationToken cancellationToken) => CommitAsync(
                projectId,
                mode,
                mutations,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Roll back a transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [google.datastore.v1beta3.Datastore.BeginTransaction][google.datastore.v1beta3.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Roll back a transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [google.datastore.v1beta3.Datastore.BeginTransaction][google.datastore.v1beta3.Datastore.BeginTransaction].
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CancellationToken cancellationToken) => RollbackAsync(
                projectId,
                transaction,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Roll back a transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [google.datastore.v1beta3.Datastore.BeginTransaction][google.datastore.v1beta3.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackResponse Rollback(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocate IDs for the given keys (useful for referencing an entity before
        /// it is inserted).
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocate IDs for the given keys (useful for referencing an entity before
        /// it is inserted).
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CancellationToken cancellationToken) => AllocateIdsAsync(
                projectId,
                keys,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Allocate IDs for the given keys (useful for referencing an entity before
        /// it is inserted).
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AllocateIdsResponse AllocateIds(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class DatastoreClientImpl : DatastoreClient
    {
        private readonly ClientHelper _clientHelper;

        public DatastoreClientImpl(Datastore.IDatastoreClient grpcClient, DatastoreSettings settings)
        {
            this.GrpcClient = grpcClient;
            DatastoreSettings effectiveSettings = settings ?? DatastoreSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
        }

        public override Datastore.IDatastoreClient GrpcClient { get; }

        /// <summary>
        /// Look up entities by key.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="read_options">Options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LookupResponse> LookupAsync(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            LookupRequest request = new LookupRequest
            {
                ProjectId = projectId,
                ReadOptions = readOptions,
                Keys = { keys },
            };
            return GrpcClient.LookupAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Look up entities by key.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="read_options">Options for this lookup request.</param>
        /// <param name="keys">Keys of entities to look up.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupResponse Lookup(
            string projectId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            LookupRequest request = new LookupRequest
            {
                ProjectId = projectId,
                ReadOptions = readOptions,
                Keys = { keys },
            };
            return GrpcClient.Lookup(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null)
        {
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = readOptions,
                Query = query,
            };
            return GrpcClient.RunQueryAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            Query query,
            CallSettings callSettings = null)
        {
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = readOptions,
                Query = query,
            };
            return GrpcClient.RunQuery(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="gql_query">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<RunQueryResponse> RunQueryAsync(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null)
        {
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = readOptions,
                GqlQuery = gqlQuery,
            };
            return GrpcClient.RunQueryAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Query for entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="partition_id">
        /// Entities are partitioned into subsets, identified by a partition ID.
        /// Queries are scoped to a single partition.
        /// This partition ID is normalized with the standard default context
        /// partition ID.
        /// </param>
        /// <param name="read_options">The options for this query.</param>
        /// <param name="gql_query">The GQL query to run.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunQueryResponse RunQuery(
            string projectId,
            PartitionId partitionId,
            ReadOptions readOptions,
            GqlQuery gqlQuery,
            CallSettings callSettings = null)
        {
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = projectId,
                PartitionId = partitionId,
                ReadOptions = readOptions,
                GqlQuery = gqlQuery,
            };
            return GrpcClient.RunQuery(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Begin a new transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<BeginTransactionResponse> BeginTransactionAsync(
            string projectId,
            CallSettings callSettings = null)
        {
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = projectId,
            };
            return GrpcClient.BeginTransactionAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Begin a new transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BeginTransactionResponse BeginTransaction(
            string projectId,
            CallSettings callSettings = null)
        {
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = projectId,
            };
            return GrpcClient.BeginTransaction(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">The transaction in which to write.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            CommitRequest request = new CommitRequest
            {
                ProjectId = projectId,
                Mode = mode,
                Transaction = transaction,
                Mutations = { mutations },
            };
            return GrpcClient.CommitAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="transaction">The transaction in which to write.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            ByteString transaction,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            CommitRequest request = new CommitRequest
            {
                ProjectId = projectId,
                Mode = mode,
                Transaction = transaction,
                Mutations = { mutations },
            };
            return GrpcClient.Commit(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<CommitResponse> CommitAsync(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            CommitRequest request = new CommitRequest
            {
                ProjectId = projectId,
                Mode = mode,
                Mutations = { mutations },
            };
            return GrpcClient.CommitAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Commit a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="mode">The type of commit to perform. Defaults to `TRANSACTIONAL`.</param>
        /// <param name="mutations">
        /// The mutations to perform.
        ///
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        ///
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(
            string projectId,
            CommitRequest.Types.Mode mode,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null)
        {
            CommitRequest request = new CommitRequest
            {
                ProjectId = projectId,
                Mode = mode,
                Mutations = { mutations },
            };
            return GrpcClient.Commit(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Roll back a transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [google.datastore.v1beta3.Datastore.BeginTransaction][google.datastore.v1beta3.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<RollbackResponse> RollbackAsync(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            RollbackRequest request = new RollbackRequest
            {
                ProjectId = projectId,
                Transaction = transaction,
            };
            return GrpcClient.RollbackAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Roll back a transaction.
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="transaction">
        /// The transaction identifier, returned by a call to
        /// [google.datastore.v1beta3.Datastore.BeginTransaction][google.datastore.v1beta3.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RollbackResponse Rollback(
            string projectId,
            ByteString transaction,
            CallSettings callSettings = null)
        {
            RollbackRequest request = new RollbackRequest
            {
                ProjectId = projectId,
                Transaction = transaction,
            };
            return GrpcClient.Rollback(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Allocate IDs for the given keys (useful for referencing an entity before
        /// it is inserted).
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<AllocateIdsResponse> AllocateIdsAsync(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                ProjectId = projectId,
                Keys = { keys },
            };
            return GrpcClient.AllocateIdsAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Allocate IDs for the given keys (useful for referencing an entity before
        /// it is inserted).
        /// </summary>
        /// <param name="project_id">Project ID against which to make the request.</param>
        /// <param name="keys">
        /// A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AllocateIdsResponse AllocateIds(
            string projectId,
            IEnumerable<Key> keys,
            CallSettings callSettings = null)
        {
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                ProjectId = projectId,
                Keys = { keys },
            };
            return GrpcClient.AllocateIds(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

    }
}