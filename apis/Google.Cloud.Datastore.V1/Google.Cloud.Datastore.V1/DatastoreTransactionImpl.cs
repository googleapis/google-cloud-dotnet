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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Google.Cloud.Datastore.V1.CommitRequest.Types;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// Production implementation of <see cref="DatastoreTransaction"/>, using a <see cref="DatastoreClient"/>
    /// to implement the operations.
    /// </summary>
    public sealed class DatastoreTransactionImpl : DatastoreTransaction
    {
        /// <inheritdoc />
        public override ByteString TransactionId { get; }

        private readonly DatastoreClient _client;
        private readonly string _projectId;
        private readonly string _databaseId;
        private readonly PartitionId _partitionId;
        private readonly List<Mutation> _mutations = new List<Mutation>();
        private readonly List<Action<Key>> _keyPropagations = new List<Action<Key>>();
        private readonly ReadOptions _readOptions;
        private bool _active;

        /// <summary>
        /// Constructs a <see cref="DatastoreTransactionImpl"/> from a client, project ID and transaction ID.
        /// </summary>
        /// <remarks>
        /// While this can be constructed manually, the expectation is that instances of this class are obtained via
        /// <see cref="DatastoreDb.BeginTransaction(CallSettings)"/> or <see cref="DatastoreDb.BeginTransactionAsync(CallSettings)"/>.
        /// </remarks>
        /// <param name="client">The client to use for Datastore operations. Must not be null.</param>
        /// <param name="projectId">The ID of the project of the Datastore operations. Must not be null.</param>
        /// <param name="namespaceId">The ID of the namespace which is combined with <paramref name="projectId"/> to form a partition ID
        /// to use in query operations. May be null.</param>
        /// <param name="transactionId">The transaction obtained by an earlier <see cref="DatastoreClient.BeginTransaction(string, CallSettings)"/>
        /// or the asynchronous equivalent. Must not be null</param>
        public DatastoreTransactionImpl(DatastoreClient client, string projectId, string namespaceId, ByteString transactionId) :
            this(client, projectId, namespaceId, DatastoreDb.DefaultDatabaseId, transactionId)
        { }

        /// <summary>
        /// Constructs a <see cref="DatastoreTransactionImpl"/> from a client, project ID and transaction ID.
        /// </summary>
        /// <remarks>
        /// While this can be constructed manually, the expectation is that instances of this class are obtained via
        /// <see cref="DatastoreDb.BeginTransaction(CallSettings)"/> or <see cref="DatastoreDb.BeginTransactionAsync(CallSettings)"/>.
        /// </remarks>
        /// <param name="client">The client to use for Datastore operations. Must not be null.</param>
        /// <param name="projectId">The ID of the project of the Datastore operations. Must not be null.</param>
        /// <param name="namespaceId">The ID of the namespace which is combined with <paramref name="projectId"/> and <paramref name="databaseId"/> to form a partition ID
        /// to use in query operations. May be null.</param>
        /// <param name="databaseId">The ID of the databse which is combined with <paramref name="projectId"/> and <paramref name="namespaceId"/> to form a partition ID
        /// to use in query operations. May be null.</param>
        /// <param name="transactionId">The transaction obtained by an earlier <see cref="DatastoreClient.BeginTransaction(string, CallSettings)"/>
        /// or the asynchronous equivalent. Must not be null</param>
        public DatastoreTransactionImpl(DatastoreClient client, string projectId, string namespaceId, string databaseId, ByteString transactionId)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _databaseId = GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            _partitionId = new PartitionId(projectId, namespaceId, databaseId);
            TransactionId = GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
            _readOptions = new ReadOptions { Transaction = TransactionId };
            _active = true;
        }

        /// <inheritdoc />
        public override LazyDatastoreQuery RunQueryLazily(DatastoreQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = query.ToRequest(_projectId, _databaseId, _partitionId);
            request.ReadOptions = _readOptions;
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new LazyDatastoreQuery(streamer.Sync());
        }

        /// <inheritdoc />
        public override AsyncLazyDatastoreQuery RunQueryLazilyAsync(DatastoreQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = query.ToRequest(_projectId, _databaseId, _partitionId);
            request.ReadOptions = _readOptions;
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new AsyncLazyDatastoreQuery(streamer.Async());
        }

        /// <inheritdoc />
        public override LazyDatastoreQuery RunQueryLazily(Query query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            return RunQueryLazily(new DatastoreQuery { Query = query }, callSettings);
        }

        /// <inheritdoc />
        public override AsyncLazyDatastoreQuery RunQueryLazilyAsync(Query query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            return RunQueryLazilyAsync(new DatastoreQuery { Query = query }, callSettings);
        }

        /// <inheritdoc />
        public override LazyDatastoreQuery RunQueryLazily(GqlQuery gqlQuery, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(gqlQuery, nameof(gqlQuery));
            return RunQueryLazily(new DatastoreQuery { GqlQuery = gqlQuery }, callSettings);
        }

        /// <inheritdoc />
        public override AsyncLazyDatastoreQuery RunQueryLazilyAsync(GqlQuery gqlQuery, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(gqlQuery, nameof(gqlQuery));
            return RunQueryLazilyAsync(new DatastoreQuery { GqlQuery = gqlQuery }, callSettings);
        }

        /// <inheritdoc/>
        public override AggregationQueryResults RunAggregationQuery(DatastoreQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = query.ToAggregationRequest(_projectId, _databaseId, _partitionId);
            request.ReadOptions = _readOptions;
            var runAggregationQueryResponse = _client.RunAggregationQuery(request, callSettings);
            return AggregationQueryResults.FromRunAggregationQueryResponse(runAggregationQueryResponse);
        }

        /// <inheritdoc/>
        public override AggregationQueryResults RunAggregationQuery(AggregationQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            return RunAggregationQuery(new DatastoreQuery { AggregationQuery = query }, callSettings);
        }

        /// <inheritdoc/>
        public override AggregationQueryResults RunAggregationQuery(GqlQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            return RunAggregationQuery(new DatastoreQuery { GqlQuery = query }, callSettings);
        }

        /// <inheritdoc/>
        public override async Task<AggregationQueryResults> RunAggregationQueryAsync(DatastoreQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = query.ToAggregationRequest(_projectId, _databaseId, _partitionId);
            request.ReadOptions = _readOptions;
            var runAggregationQueryResponse = await _client.RunAggregationQueryAsync(request, callSettings).ConfigureAwait(false);
            return AggregationQueryResults.FromRunAggregationQueryResponse(runAggregationQueryResponse);
        }

        /// <inheritdoc/>
        public override Task<AggregationQueryResults> RunAggregationQueryAsync(AggregationQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            return RunAggregationQueryAsync(new DatastoreQuery { AggregationQuery = query }, callSettings);
        }

        /// <inheritdoc/>
        public override Task<AggregationQueryResults> RunAggregationQueryAsync(GqlQuery query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            return RunAggregationQueryAsync(new DatastoreQuery { GqlQuery = query }, callSettings);
        }

        /// <inheritdoc />
        public override IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, CallSettings callSettings = null) =>
            DatastoreDb.LookupImpl(_client, _projectId, _databaseId, _readOptions, keys, callSettings);

        /// <inheritdoc />
        public override Task<IReadOnlyList<Entity>> LookupAsync(IEnumerable<Key> keys, CallSettings callSettings = null) =>
            DatastoreDb.LookupImplAsync(_client, _projectId, _databaseId, _readOptions, keys, callSettings);

        private void AddMutations<T>(IEnumerable<T> values, Func<T, Mutation> conversion, Func<T, Action<Key>> keyPropagationProvider, string paramName)
        {
            GaxPreconditions.CheckNotNull(values, paramName);
            foreach (var value in values)
            {
                _mutations.Add(conversion(value));
                _keyPropagations.Add(keyPropagationProvider?.Invoke(value));
            }
        }

        /// <inheritdoc />
        public override void Upsert(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToUpsert(), entity => key => entity.Key = key, nameof(entities));

        /// <inheritdoc />
        public override void Update(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToUpdate(), null, nameof(entities));

        /// <inheritdoc />
        public override void Insert(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToInsert(), entity => key => entity.Key = key, nameof(entities));

        /// <inheritdoc />
        public override void Delete(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToDelete(), null, nameof(entities));

        /// <inheritdoc />
        public override void Delete(IEnumerable<Key> keys) => AddMutations(keys, e => e.ToDelete(), null, nameof(keys));

        /// <inheritdoc />
        public override CommitResponse Commit(CallSettings callSettings = null)
        {
            // TODO: What if there are no mutations? Just rollback?
            CheckActive();
            var request = new CommitRequest
            {
                ProjectId = _projectId,
                DatabaseId = _databaseId,
                Mode = Mode.Transactional,
                Transaction = TransactionId,
                Mutations = { _mutations }
            };
            var response = _client.Commit(request);
            PropagateKeys(response);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override async Task<CommitResponse> CommitAsync(CallSettings callSettings = null)
        {
            // TODO: What if there are no mutations? Just rollback?
            CheckActive();
            var request = new CommitRequest
            {
                ProjectId = _projectId,
                DatabaseId = _databaseId,
                Mode = Mode.Transactional,
                Transaction = TransactionId,
                Mutations = { _mutations }
            };
            var response = await _client.CommitAsync(request, callSettings).ConfigureAwait(false);
            PropagateKeys(response);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override RollbackResponse Rollback(CallSettings callSettings = null)
        {
            CheckActive();
            var request = new RollbackRequest { ProjectId = _projectId, DatabaseId = _databaseId, Transaction = TransactionId };
            var response = _client.Rollback(request, callSettings);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override async Task<RollbackResponse> RollbackAsync(CallSettings callSettings = null)
        {
            CheckActive();
            var request = new RollbackRequest { ProjectId = _projectId, DatabaseId = _databaseId, Transaction = TransactionId };
            var response = await _client.RollbackAsync(request, callSettings).ConfigureAwait(false);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override void Dispose()
        {
            if (_active)
            {
                Rollback();
            }
        }

        private void CheckActive()
        {
            if (!_active)
            {
                throw new InvalidOperationException("Transaction has already been committed or rolled back");
            }
        }

        private void PropagateKeys(CommitResponse response)
        {
            for (int i = 0; i < response.MutationResults.Count; i++)
            {
                var key = response.MutationResults[i].Key;
                var propagation = _keyPropagations[i];
                if (key != null && propagation != null)
                {
                    propagation(key);
                }
            }
        }
    }
}
