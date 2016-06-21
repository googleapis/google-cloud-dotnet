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
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Google.Datastore.V1Beta3.CommitRequest.Types;

namespace Google.Datastore.V1Beta3
{
    // TODO: Determine handling of multiple calls (e.g. Insert + Update + Delete) for same entity
    // TODO: Validate that entities to be updated/deleted have keys.
    // TODO: Document cloning policy.
    // TODO: Change return type of Commit to something simpler?
    // TODO: Make Lookup return something which can be indexed by Key
    // TODO: Give the transaction itself a partition ID rather than just a project ID?

    /// <summary>
    /// <para>
    /// Convenience wrapper around a Datastore transaction. All mutation operations (<see cref="Insert(IEnumerable{Entity})"/>,
    /// <see cref="Delete(IEnumerable{Key})"/>, <see cref="Update(IEnumerable{Entity})"/> and <see cref="Upsert(IEnumerable{Entity})"/>)
    /// merely add to a list of mutations which are performed in a single <see cref="Commit(CallSettings)"/> or <see cref="CommitAsync(CallSettings)"/>
    /// operation. This means the mutation methods are all synchronous and do not take call settings, as they don't perform any
    /// API operations.
    /// </para>
    /// <para>
    /// Disposing of a transaction calls <see cref="Rollback(CallSettings)"/> if the transaction has not already been committed
    /// or rolled back.
    /// </para>
    /// </summary>
    public sealed class DatastoreTransaction : IDisposable
    {
        /// <summary>
        /// The ID of the transaction, used implicitly in operations performed with this object.
        /// </summary>
        public ByteString TransactionId { get; }

        private readonly DatastoreClient _client;
        private readonly string _projectId;
        private readonly List<Mutation> _mutations = new List<Mutation>();
        private readonly ReadOptions _readOptions;
        private bool _active;

        /// <summary>
        /// Constructs a <see cref="DatastoreTransaction"/> from a client, project ID and transaction ID.
        /// </summary>
        /// <param name="client">The client to use for Datastore operations.</param>
        /// <param name="projectId">The ID of the project of the Datastore operations.</param>
        /// <param name="transactionId">The transaction obtained by an earlier <see cref="DatastoreClient.BeginTransaction(string, CallSettings)"/>
        /// or the asynchronous equivalent.</param>
        public DatastoreTransaction(DatastoreClient client, string projectId, ByteString transactionId)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TransactionId = GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
            _readOptions = new ReadOptions { Transaction = TransactionId };
            _active = true;
        }

        /// <summary>
        /// Executes the given structured query in this transaction, returning a result set that can be viewed as a sequence of
        /// entities, entity results (with cursors), batches, or raw API responses.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="DatastoreQueryResults"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="partitionId">The partition in which to execute the query. May be null, in which case
        /// the query is executed in the partition associated with the empty namespace in the project used by this transaction.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="DatastoreQueryResults"/> representing the result of the query.</returns>
        public DatastoreQueryResults RunQuery(Query query, PartitionId partitionId, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = partitionId,
                Query = query,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new DatastoreQueryResults(streamer.Sync());
        }


        /// <summary>
        /// Executes the given structured query in this transaction, returning a result set that can be viewed as an asynchronous
        /// sequence of entities, entity results (with cursors), batches, or raw API responses.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="DatastoreQueryResults"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="partitionId">The partition in which to execute the query. May be null, in which case
        /// the query is executed in the partition associated with the empty namespace in the project used by this transaction.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="DatastoreQueryResults"/> representing the result of the query.</returns>
        public DatastoreAsyncQueryResults RunQueryAsync(Query query, PartitionId partitionId, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = partitionId,
                Query = query,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new DatastoreAsyncQueryResults(streamer.Async());
        }

        /// <summary>
        /// Executes the given GQL query in this transaction, returning a result set that can be viewed as a sequence of
        /// entities, entity results (with cursors), batches, or raw API responses.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="DatastoreQueryResults"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="partitionId">The partition in which to execute the query. May be null, in which case
        /// the query is executed in the partition associated with the empty namespace in the project used by this transaction.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="DatastoreQueryResults"/> representing the result of the query.</returns>
        public DatastoreQueryResults RunQuery(GqlQuery gqlQuery, PartitionId partitionId, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(gqlQuery, nameof(gqlQuery));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = partitionId,
                GqlQuery = gqlQuery,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new DatastoreQueryResults(streamer.Sync());
        }

        /// <summary>
        /// Executes the given GQL query in this transaction, returning a result set that can be viewed as an asynchronous
        /// sequence of entities, entity results (with cursors), batches, or raw API responses.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="DatastoreQueryResults"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="partitionId">The partition in which to execute the query. May be null, in which case
        /// the query is executed in the partition associated with the empty namespace in the project used by this transaction.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="DatastoreQueryResults"/> representing the result of the query.</returns>
        public DatastoreAsyncQueryResults RunQueryAsync(GqlQuery gqlQuery, PartitionId partitionId, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(gqlQuery, nameof(gqlQuery));
            var request = new RunQueryRequest
            {
                ProjectId = _projectId,
                PartitionId = partitionId,
                GqlQuery = gqlQuery,
                ReadOptions = _readOptions
            };
            var streamer = new QueryStreamer(request, _client.RunQueryApiCall, callSettings);
            return new DatastoreAsyncQueryResults(streamer.Async());
        }

        /// <summary>
        /// Looks up a single entity by key.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Lookup(IEnumerable{Key}, ReadConsistency?, CallSettings)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public Entity Lookup(Key key, CallSettings callSettings = null) => Lookup(new[] { key }, callSettings)[0];

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </para>
        /// <para>
        /// This overload does not support the <see cref="CallSettings "/> to be specified due to restrictions with
        /// methods containing a parameter array and optional parameters.
        /// It simply delegates to <see cref="Lookup(IEnumerable{Key}, CallSettings)"/>, passing in a <c>null</c>
        /// value for the call settings.
        /// </para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public IReadOnlyList<Entity> Lookup(params Key[] keys) => Lookup(keys, null);

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <remarks>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, CallSettings callSettings = null) =>
            DatastoreDb.LookupImpl(_client, _projectId, _readOptions, keys, callSettings);

        /// <summary>
        /// Looks up a single entity by key asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="LookupAsync(IEnumerable{Key}, ReadConsistency?, CallSettings)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public async Task<Entity> LookupAsync(Key key, CallSettings callSettings = null)
        {
            var results = await LookupAsync(new[] { key }, callSettings).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Looks up a collection of entities by key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </para>
        /// <para>
        /// This overload does not support the <see cref="CallSettings "/> to be specified due to restrictions with
        /// methods containing a parameter array and optional parameters.
        /// It simply delegates to <see cref="LookupAsync(IEnumerable{Key}, CallSettings)"/>, passing in a <c>null</c>
        /// value for the call settings.
        /// </para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public Task<IReadOnlyList<Entity>> LookupAsync(params Key[] keys) => LookupAsync(keys, null);

        /// <summary>
        /// Looks up a collection of entities by key asynchronously.
        /// </summary>
        /// <remarks>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public Task<IReadOnlyList<Entity>> LookupAsync(IEnumerable<Key> keys, CallSettings callSettings = null) =>
            DatastoreDb.LookupImplAsync(_client, _projectId, _readOptions, keys, callSettings);        

        private void AddMutations<T>(IEnumerable<T> values, Func<T, Mutation> conversion, string paramName)
        {
            GaxPreconditions.CheckNotNull(values, paramName);
            _mutations.AddRange(values.Select(conversion));
        }

        /// <summary>
        /// Adds upsert operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to upsert. Must not be null.</param>
        public void Upsert(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToUpsert(), nameof(entities));
        /// <summary>
        /// Adds upsert operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to upsert. Must not be null.</param>
        public void Upsert(params Entity[] entities) => Upsert((IEnumerable<Entity>)entities);

        /// <summary>
        /// Adds update operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to update. Must not be null.</param>
        public void Update(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToUpdate(), nameof(entities));
        /// <summary>
        /// Adds update operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to update. Must not be null.</param>
        public void Update(params Entity[] entities) => Update((IEnumerable<Entity>)entities);

        /// <summary>
        /// Adds insert operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to insert. Must not be null.</param>
        public void Insert(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToInsert(), nameof(entities));
        /// <summary>
        /// Adds insert operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to insert. Must not be null.</param>
        public void Insert(params Entity[] entities) => Insert((IEnumerable<Entity>)entities);

        /// <summary>
        /// Adds delete operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to delete. Must not be null.</param>
        public void Delete(IEnumerable<Entity> entities) => AddMutations(entities, e => e.ToDelete(), nameof(entities));
        /// <summary>
        /// Adds delete operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to delete. Must not be null.</param>
        public void Delete(params Entity[] entities) => Delete((IEnumerable<Entity>)entities);

        /// <summary>
        /// Adds deletion operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="keys">The keys to delete. Must not be null.</param>
        public void Delete(IEnumerable<Key> keys) => AddMutations(keys, e => e.ToDelete(), nameof(keys));
        /// <summary>
        /// Adds deletion operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="keys">The keys to delete. Must not be null.</param>
        public void Delete(params Key[] keys) => Delete((IEnumerable<Key>)keys);

        /// <summary>
        /// Commits all mutations in this transaction.
        /// </summary>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        /// <returns>The response from the commit operation. This can be used to determine server-allocated keys.</returns>
        public CommitResponse Commit(CallSettings callSettings = null)
        {
            // TODO: What if there are no mutations? Just rollback?
            CheckActive();
            var response = _client.Commit(_projectId, Mode.Transactional, TransactionId, _mutations);
            _active = false;
            return response;
        }

        /// <summary>
        /// Commits all mutations in this transaction asynchronously.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        /// <returns>The response from the commit operation. This can be used to determine server-allocated keys.</returns>
        public async Task<CommitResponse> CommitAsync(CallSettings callSettings = null)
        {
            // TODO: What if there are no mutations? Just rollback?
            CheckActive();
            var response = await _client.CommitAsync(_projectId, Mode.Transactional, TransactionId, _mutations, callSettings);
            _active = false;
            return response;
        }

        /// <summary>
        /// Rolls back this transaction.
        /// </summary>
        /// <remarks>This method is rarely useful explicitly; the <see cref="Dispose"/> method rolls back the transaction if it
        /// is still active, so a <c>using</c> statement is normally preferable to this.</remarks>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        public RollbackResponse Rollback(CallSettings callSettings = null)
        {
            CheckActive();
            var response = _client.Rollback(_projectId, TransactionId, callSettings);
            _active = false;
            return response;
        }

        /// <summary>
        /// Rolls back this transaction asynchronously.
        /// </summary>
        /// <remarks>This method is rarely useful explicitly; the <see cref="Dispose"/> method rolls back the transaction if it
        /// is still active, so a <c>using</c> statement is normally preferable to this.</remarks>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        public async Task<RollbackResponse> RollbackAsync(CallSettings callSettings = null)
        {
            CheckActive();
            var response = await _client.RollbackAsync(_projectId, TransactionId, callSettings);
            _active = false;
            return response;
        }

        /// <summary>
        /// If the transaction has already been committed, this operation is a no-op.
        /// Otherwise, it rolls back the transaction.
        /// </summary>
        public void Dispose()
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
    }
}
