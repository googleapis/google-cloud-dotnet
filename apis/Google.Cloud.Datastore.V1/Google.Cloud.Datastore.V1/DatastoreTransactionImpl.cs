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
using System.Linq;
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
        public DatastoreTransactionImpl(DatastoreClient client, string projectId, string namespaceId, ByteString transactionId)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _partitionId = new PartitionId(projectId, namespaceId);
            TransactionId = GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
            _readOptions = new ReadOptions { Transaction = TransactionId };
            _active = true;
        }

        /// <inheritdoc />
        public override LazyDatastoreQuery RunQueryLazily(Query query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = _partitionId,
                Query = query,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new LazyDatastoreQuery(streamer.Sync());
        }

        /// <inheritdoc />
        public override AsyncLazyDatastoreQuery RunQueryLazilyAsync(Query query, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = _partitionId,
                Query = query,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new AsyncLazyDatastoreQuery(streamer.Async());
        }

        /// <inheritdoc />
        public override LazyDatastoreQuery RunQueryLazily(GqlQuery gqlQuery, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(gqlQuery, nameof(gqlQuery));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = _partitionId,
                GqlQuery = gqlQuery,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new LazyDatastoreQuery(streamer.Sync());
        }

        /// <inheritdoc />
        public override AsyncLazyDatastoreQuery RunQueryLazilyAsync(GqlQuery gqlQuery, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(gqlQuery, nameof(gqlQuery));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = _partitionId,
                GqlQuery = gqlQuery,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new AsyncLazyDatastoreQuery(streamer.Async());
        }

        /// <inheritdoc />
        public override IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, CallSettings callSettings = null) =>
            DatastoreDb.LookupImpl(_client, _projectId, _readOptions, keys, callSettings);        

        /// <inheritdoc />
        public override Task<IReadOnlyList<Entity>> LookupAsync(IEnumerable<Key> keys, CallSettings callSettings = null) =>
            DatastoreDb.LookupImplAsync(_client, _projectId, _readOptions, keys, callSettings);

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
            var response = _client.Commit(_projectId, Mode.Transactional, TransactionId, _mutations, callSettings);
            PropagateKeys(response);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override async Task<CommitResponse> CommitAsync(CallSettings callSettings = null)
        {
            // TODO: What if there are no mutations? Just rollback?
            CheckActive();
            var response = await _client.CommitAsync(_projectId, Mode.Transactional, TransactionId, _mutations, callSettings).ConfigureAwait(false);
            PropagateKeys(response);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override RollbackResponse Rollback(CallSettings callSettings = null)
        {
            CheckActive();
            var response = _client.Rollback(_projectId, TransactionId, callSettings);
            _active = false;
            return response;
        }

        /// <inheritdoc />
        public override async Task<RollbackResponse> RollbackAsync(CallSettings callSettings = null)
        {
            CheckActive();
            var response = await _client.RollbackAsync(_projectId, TransactionId, callSettings).ConfigureAwait(false);
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
