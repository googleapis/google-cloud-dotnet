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
using static Google.Datastore.V1Beta3.CommitRequest.Types;

namespace Google.Datastore.V1Beta3
{
    public partial class DatastoreClient
    {
        // TODO: This is expected to become part of a thin wrapper over the top of DatastoreClient instead.

        /// <summary>
        /// Creates a <see cref="DatastoreTransaction"/> using this client, beginning a new transaction.
        /// </summary>
        /// <param name="projectId">The project ID to create the transaction in. Must not be null.</param>
        /// <returns>The datastore transaction.</returns>
        public DatastoreTransaction CreateDatastoreTransaction(string projectId)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            var transactionId = BeginTransaction(projectId).Transaction;
            return new DatastoreTransaction(this, projectId, transactionId);
        }

        // TODO: Expose this? Or make it part of a higher level API?

        /// <summary>
        /// Fetch the entities associated with the given keys. This may require multiple requests.
        /// The entities are returned in the same order as the key set. Any missing entities are returned
        /// as null references.
        /// </summary>
        /// <remarks>
        /// The keys should not be mutated while the operation is ongoing.
        /// </remarks>
        internal IReadOnlyList<Entity> LookupAll(string projectId, ReadOptions readOptions, IEnumerable<Key> keys)
        {
            // Just so we can iterate multiple times safely.
            keys = keys.ToList();
            GaxPreconditions.CheckArgument(keys.All(x => x != null), nameof(keys), "Key collection must not contain null elements");
            var keyToIndex = keys.Select((value, index) => new { value, index }).ToLookup(pair => pair.value, pair => pair.index);
            IEnumerable<Key> keysToFetch = new HashSet<Key>(keys);
            Entity[] result = new Entity[keys.Count()];
            // TODO: Limit how many times we go round? Ensure that we make progress on each iteration?
            while (keysToFetch.Count() > 0)
            {
                var response = Lookup(projectId, readOptions, keysToFetch);
                foreach (var found in response.Found)
                {
                    foreach (var index in keyToIndex[found.Entity.Key])
                    {
                        result[index] = found.Entity;
                    }
                }
                keysToFetch = response.Deferred;
            }
            return result;
        }
    }

    // TODO: Async
    // TODO: Take CallSettings on each call?
    // TODO: Determine handling of multiple calls (e.g. Insert + Update + Delete) for same entity
    // TODO: Validate that entities to be updated/deleted have keys.
    // TODO: Document cloning policy.
    // TODO: Change return type of Commit to something simpler?
    // TODO: Make Get return something which can be indexed by Key

    /// <summary>
    /// Convenience wrapper around a Datastore transaction.
    /// </summary>
    public sealed class DatastoreTransaction : IDisposable
    {
        private readonly ByteString _transactionId;
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
            _transactionId = GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
            _readOptions = new ReadOptions { Transaction = _transactionId };
            _active = true; 
        }

        public Entity Lookup(Key key) => _client.LookupAll(_projectId, _readOptions, new[] { key })[0];        
        public IReadOnlyList<Entity> Lookup(params Key[] keys) => Lookup((IEnumerable<Key>)keys);
        public IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys) => _client.LookupAll(_projectId, _readOptions, keys);

        /// <summary>
        /// Runs the specified query in this transaction.
        /// </summary>
        /// <remarks>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </remarks>
        /// <param name="partitionId">The ID of the partition to run the query against. Must not be null.</param>
        /// <param name="query">The query to run. Must not be null.</param>
        /// <returns>The result of the query.</returns>
        public RunQueryResponse RunQuery(PartitionId partitionId, Query query) =>
            _client.RunQuery(
                _projectId,
                GaxPreconditions.CheckNotNull(partitionId, nameof(partitionId)),
                _readOptions,
                GaxPreconditions.CheckNotNull(query, nameof(query)));
        /// <summary>
        /// Runs the specified query in this transaction.
        /// </summary>
        /// <remarks>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </remarks>
        /// <param name="partitionId">The ID of the partition to run the query against. Must not be null.</param>
        /// <param name="query">The query to run. Must not be null.</param>
        /// <returns>The result of the query.</returns>
        public RunQueryResponse RunQuery(PartitionId partitionId, GqlQuery query) =>
            _client.RunQuery(
                _projectId,
                GaxPreconditions.CheckNotNull(partitionId, nameof(partitionId)),
                _readOptions,
                GaxPreconditions.CheckNotNull(query, nameof(query)));

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
        public CommitResponse Commit()
        {
            // TODO: What if there are no mutations? Just rollback?
            CheckActive();
            var response = _client.Commit(_projectId, Mode.Transactional, _transactionId, _mutations);
            _active = false;
            return response;
        }

        /// <summary>
        /// Rolls back this transaction.
        /// </summary>
        /// <remarks>This method is rarely useful explicitly; the <see cref="Dispose"/> method rolls back the transaction if it
        /// is still active, so a <c>using</c> statement is normally preferable to this.</remarks>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        public RollbackResponse Rollback()
        {
            CheckActive();
            var response = _client.Rollback(_projectId, _transactionId);
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
