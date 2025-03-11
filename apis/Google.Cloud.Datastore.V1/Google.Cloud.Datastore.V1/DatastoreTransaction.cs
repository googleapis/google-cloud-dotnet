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
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Cloud.Datastore.V1
{
    // TODO: Determine handling of multiple calls (e.g. Insert + Update + Delete) for same entity
    // TODO: Validate that entities to be updated/deleted have keys.
    // TODO: Document cloning policy.
    // TODO: Change return type of Commit to something simpler?
    // TODO: Make Lookup return something which can be indexed by Key

    /// <summary>
    /// <para>
    /// Convenience wrapper around a Datastore transaction. All mutation operations (<see cref="Insert(IEnumerable{Entity})"/>,
    /// <see cref="Delete(IEnumerable{Key})"/>, <see cref="Update(IEnumerable{Entity})"/> and <see cref="Upsert(IEnumerable{Entity})"/>)
    /// merely add to a list of mutations which are performed in a single <see cref="Commit(CallSettings)"/> or <see cref="CommitAsync(CallSettings)"/>
    /// operation. This means the mutation methods are all synchronous and do not take call settings, as they don't perform any
    /// API operations.
    /// </para>
    /// <para>Datastore limits the number of entities that can be modified in a Commit operation, and therefore one transaction. When modifying a large
    /// number of entities, partition the changes into multiple transactions. See
    /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
    /// <para>
    /// Even though transactions aren't inherently related to a specific partition ID, the expected usage is that queries run inside
    /// a transaction are likely to be in a single partition, specified in a <see cref="DatastoreDb"/> used to create the transaction.
    /// </para>
    /// <para>
    /// Disposing of a transaction calls <see cref="Rollback(CallSettings)"/> if the transaction has not already been committed
    /// or rolled back.
    /// </para>
    /// <para>
    /// This is an abstract class, implemented by <see cref="DatastoreTransactionImpl"/> for production use. Users creating their own
    /// <see cref="DatastoreDb"/> subclasses may choose to create fake implementations for testing purposes. There are no abstract
    /// methods in this class; instead, all methods either delegate to another or throw <see cref="NotImplementedException"/>.
    /// </para>
    /// </summary>
    public abstract class DatastoreTransaction : IDisposable
    {
        /// <summary>
        /// The ID of the transaction, used implicitly in operations performed with this object.
        /// </summary>
        public virtual ByteString TransactionId { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Constructs an instance of <see cref="DatastoreClientImpl"/> with the given arguments.
        /// Clients using the <see cref="DatastoreDb"/> abstraction layer would normally call
        /// <see cref="DatastoreDb.BeginTransaction(CallSettings)"/> or <see cref="DatastoreDb.BeginTransactionAsync(CallSettings)"/>
        /// instead of calling this method directly.
        /// </summary>
        /// <param name="client">The client to use for Datastore operations. Must not be null.</param>
        /// <param name="projectId">The ID of the project of the Datastore operations. Must not be null.</param>
        /// <param name="namespaceId">The ID of the namespace which is combined with <paramref name="projectId"/> to form a partition ID
        /// to use in query operations. May be null.</param>
        /// <param name="transactionId">The transaction obtained by an earlier <see cref="DatastoreClient.BeginTransaction(string, CallSettings)"/>
        /// or the asynchronous equivalent. Must not be null</param>
        /// <returns>A <see cref="DatastoreTransaction"/> representation of the specified transaction.</returns>
        public static DatastoreTransaction Create(DatastoreClient client, string projectId, string namespaceId, ByteString transactionId) =>
            new DatastoreTransactionImpl(client, projectId, namespaceId, transactionId);

        /// <summary>
        /// Constructs an instance of <see cref="DatastoreClientImpl"/> with the given arguments.
        /// Clients using the <see cref="DatastoreDb"/> abstraction layer would normally call
        /// <see cref="DatastoreDb.BeginTransaction(CallSettings)"/> or <see cref="DatastoreDb.BeginTransactionAsync(CallSettings)"/>
        /// instead of calling this method directly.
        /// </summary>
        /// <param name="client">The client to use for Datastore operations. Must not be null.</param>
        /// <param name="projectId">The ID of the project of the Datastore operations. Must not be null.</param>
        /// <param name="namespaceId">The ID of the namespace which is combined with <paramref name="projectId"/> and <paramref name="databaseId"/> to form a partition ID
        /// to use in query operations. May be null.</param>
        /// <param name="databaseId">The ID of the database which is combined with <paramref name="projectId"/> and <paramref name="namespaceId"/> to form a partition ID
        /// to use in query operations. May be null.</param>
        /// <param name="transactionId">The transaction obtained by an earlier <see cref="DatastoreClient.BeginTransaction(string, CallSettings)"/>
        /// or the asynchronous equivalent. Must not be null</param>
        /// <returns>A <see cref="DatastoreTransaction"/> representation of the specified transaction.</returns>,
        public static DatastoreTransaction Create(DatastoreClient client, string projectId, string namespaceId, string databaseId, ByteString transactionId) =>
            new DatastoreTransactionImpl(client, projectId, namespaceId, databaseId, transactionId);

        /// <summary>
        /// Runs the given query eagerly in this transaction, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>The default implementation of this method delegates to <see cref="RunQueryLazily(Query, CallSettings)"/>
        /// and calls <see cref="LazyDatastoreQuery.GetAllResults"/> on the return value.</para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The complete query results.</returns>
        public virtual DatastoreQueryResults RunQuery(DatastoreQuery query, CallSettings callSettings = null) =>
            RunQueryLazily(query, callSettings).GetAllResults();

        /// <summary>
        /// Runs the given query eagerly in this transaction, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>The default implementation of this method delegates to <see cref="RunQueryLazily(Query, CallSettings)"/>
        /// and calls <see cref="LazyDatastoreQuery.GetAllResults"/> on the return value.</para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The complete query results.</returns>
        public virtual DatastoreQueryResults RunQuery(Query query, CallSettings callSettings = null) =>
            RunQueryLazily(query, callSettings).GetAllResults();

        /// <summary>
        /// Runs the given query eagerly and asynchronously in this transaction, retrieving all results in memory
        /// and indicating whether more results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>The default implementation of this method delegates to <see cref="RunQueryLazilyAsync(Query, CallSettings)"/>
        /// and calls <see cref="AsyncLazyDatastoreQuery.GetAllResultsAsync"/> on the return value.</para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the complete set of query results.</returns>
        public virtual Task<DatastoreQueryResults> RunQueryAsync(DatastoreQuery query, CallSettings callSettings = null) =>
            RunQueryLazilyAsync(query, callSettings).GetAllResultsAsync();

        /// <summary>
        /// Runs the given query eagerly and asynchronously in this transaction, retrieving all results in memory
        /// and indicating whether more results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>The default implementation of this method delegates to <see cref="RunQueryLazilyAsync(Query, CallSettings)"/>
        /// and calls <see cref="AsyncLazyDatastoreQuery.GetAllResultsAsync"/> on the return value.</para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the complete set of query results.</returns>
        public virtual Task<DatastoreQueryResults> RunQueryAsync(Query query, CallSettings callSettings = null) =>
            RunQueryLazilyAsync(query, callSettings).GetAllResultsAsync();

        /// <summary>
        /// Runs the given <see cref="DatastoreQuery"/> in this transaction.
        /// </summary>
        /// <param name="query">The <see cref="AggregationQuery"/> to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The result of aggregation query.</returns>
        public virtual AggregationQueryResults RunAggregationQuery(DatastoreQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given <see cref="AggregationQuery"/> in this transaction.
        /// </summary>
        /// <param name="query">The <see cref="AggregationQuery"/> to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The result of aggregation query.</returns>
        public virtual AggregationQueryResults RunAggregationQuery(AggregationQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given <see cref="GqlQuery"/> in this transaction.
        /// </summary>
        /// <param name="query">The <see cref="GqlQuery"/> to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The result of aggregation query.</returns>
        public virtual AggregationQueryResults RunAggregationQuery(GqlQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given <see cref="DatastoreQuery"/> in this transaction.
        /// </summary>
        /// <param name="query">The <see cref="AggregationQuery"/> to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the result of the aggregation query.</returns>
        public virtual Task<AggregationQueryResults> RunAggregationQueryAsync(DatastoreQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given <see cref="AggregationQuery"/> in this transaction.
        /// </summary>
        /// <param name="query">The <see cref="AggregationQuery"/> to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the result of the aggregation query.</returns>
        public virtual Task<AggregationQueryResults> RunAggregationQueryAsync(AggregationQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given <see cref="GqlQuery"/> in this transaction.
        /// </summary>
        /// <param name="query">The <see cref="GqlQuery"/> to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the result of the aggregation query.</returns>
        public virtual Task<AggregationQueryResults> RunAggregationQueryAsync(GqlQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query in this transaction.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="LazyDatastoreQuery"/> representing the the lazy query results.</returns>
        public virtual LazyDatastoreQuery RunQueryLazily(DatastoreQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query in this transaction.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="LazyDatastoreQuery"/> representing the the lazy query results.</returns>
        public virtual LazyDatastoreQuery RunQueryLazily(Query query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query in this transaction for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AsyncLazyDatastoreQuery"/> representing the result of the query.</returns>
        public virtual AsyncLazyDatastoreQuery RunQueryLazilyAsync(DatastoreQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query in this transaction for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AsyncLazyDatastoreQuery"/> representing the result of the query.</returns>
        public virtual AsyncLazyDatastoreQuery RunQueryLazilyAsync(Query query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given query eagerly in this transaction, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>The default implementation of this method delegates to <see cref="RunQueryLazily(GqlQuery, CallSettings)"/>
        /// and calls <see cref="LazyDatastoreQuery.GetAllResults"/> on the return value.</para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The complete query results.</returns>
        public virtual DatastoreQueryResults RunQuery(GqlQuery query, CallSettings callSettings = null) =>
            RunQueryLazily(query, callSettings).GetAllResults();

        /// <summary>
        /// Runs the given query eagerly and asynchronously in this transaction, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>The default implementation of this method delegates to <see cref="RunQueryLazilyAsync(GqlQuery, CallSettings)"/>
        /// and calls <see cref="AsyncLazyDatastoreQuery.GetAllResultsAsync"/> on the return value.</para>
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the complete set of query results.</returns>
        public virtual Task<DatastoreQueryResults> RunQueryAsync(GqlQuery query, CallSettings callSettings = null) =>
            RunQueryLazilyAsync(query, callSettings).GetAllResultsAsync();

        /// <summary>
        /// Lazily executes the given GQL query in this transaction.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="gqlQuery">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="LazyDatastoreQuery"/> representing the result of the query.</returns>
        public virtual LazyDatastoreQuery RunQueryLazily(GqlQuery gqlQuery, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query in this transaction for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Using a transaction ensures that a commit operation will fail if any of the entities returned
        /// by this query have been modified while the transaction is active. Note that modifications performed
        /// as part of this operation are not reflected in the query results.
        /// </para>
        /// <para>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </para>
        /// </remarks>
        /// <param name="gqlQuery">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AsyncLazyDatastoreQuery"/> representing the result of the query.</returns>
        public virtual AsyncLazyDatastoreQuery RunQueryLazilyAsync(GqlQuery gqlQuery, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Looks up a single entity by key.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Lookup(IEnumerable{Key}, CallSettings)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public virtual Entity Lookup(Key key, CallSettings callSettings = null) => Lookup(new[] { key }, callSettings)[0];

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
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual IReadOnlyList<Entity> Lookup(params Key[] keys) => Lookup(keys, null);

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <remarks>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </remarks>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Looks up a single entity by key asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="LookupAsync(IEnumerable{Key}, CallSettings)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public virtual async Task<Entity> LookupAsync(Key key, CallSettings callSettings = null)
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
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual Task<IReadOnlyList<Entity>> LookupAsync(params Key[] keys) => LookupAsync(keys, null);

        /// <summary>
        /// Looks up a collection of entities by key asynchronously.
        /// </summary>
        /// <remarks>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </remarks>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual Task<IReadOnlyList<Entity>> LookupAsync(IEnumerable<Key> keys, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds upsert operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to upsert. Must not be null.</param>
        public virtual void Upsert(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Adds upsert operations for all the specified keys to this transaction.
        /// </summary>
        /// <remarks>This method delegates to <see cref="Upsert(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to upsert. Must not be null.</param>
        public virtual void Upsert(params Entity[] entities) => Upsert((IEnumerable<Entity>) entities);

        /// <summary>
        /// Adds update operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to update. Must not be null.</param>
        public virtual void Update(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Adds update operations for all the specified keys to this transaction.
        /// </summary>
        /// <remarks>This method delegates to <see cref="Update(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to update. Must not be null.</param>
        public virtual void Update(params Entity[] entities) => Update((IEnumerable<Entity>) entities);

        /// <summary>
        /// Adds insert operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to insert. Must not be null.</param>
        public virtual void Insert(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Adds insert operations for all the specified keys to this transaction.
        /// </summary>
        /// <remarks>This method delegates to <see cref="Insert(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to insert. Must not be null.</param>
        public virtual void Insert(params Entity[] entities) => Insert((IEnumerable<Entity>) entities);

        /// <summary>
        /// Adds delete operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="entities">The entities to delete. Must not be null.</param>
        public virtual void Delete(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Adds delete operations for all the specified keys to this transaction.
        /// </summary>
        /// <remarks>This method delegates to <see cref="Delete(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to delete. Must not be null.</param>
        public virtual void Delete(params Entity[] entities) => Delete((IEnumerable<Entity>) entities);

        /// <summary>
        /// Adds deletion operations for all the specified keys to this transaction.
        /// </summary>
        /// <param name="keys">The keys to delete. Must not be null.</param>
        public virtual void Delete(IEnumerable<Key> keys)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Adds deletion operations for all the specified keys to this transaction.
        /// </summary>
        /// <remarks>This method delegates to <see cref="Delete(IEnumerable{Key})"/>.</remarks>
        /// <param name="keys">The keys to delete. Must not be null.</param>
        public virtual void Delete(params Key[] keys) => Delete((IEnumerable<Key>) keys);

        /// <summary>
        /// Commits all mutations in this transaction.
        /// </summary>
        /// <remarks>
        /// <para>Any entities with incomplete keys that are assigned keys by this operation will be updated in memory
        /// with the server-allocated keys.</para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation, and therefore one transaction. When modifying a large
        /// number of entities, partition the changes into multiple transactions. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        /// <returns>The response from the commit operation. This can be used to determine server-allocated keys.</returns>
        public virtual CommitResponse Commit(CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits all mutations in this transaction asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>Any entities with incomplete keys that are assigned keys by this operation will be updated in memory
        /// with the server-allocated keys.</para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation, and therefore one transaction. When modifying a large
        /// number of entities, partition the changes into multiple transactions. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        /// <returns>The response from the commit operation. This can be used to determine server-allocated keys.</returns>
        public virtual Task<CommitResponse> CommitAsync(CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back this transaction.
        /// </summary>
        /// <remarks>This method is rarely useful explicitly; the <see cref="Dispose"/> method rolls back the transaction if it
        /// is still active, so a <c>using</c> statement is normally preferable to this.</remarks>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        public virtual RollbackResponse Rollback(CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back this transaction asynchronously.
        /// </summary>
        /// <remarks>This method is rarely useful explicitly; the <see cref="Dispose"/> method rolls back the transaction if it
        /// is still active, so a <c>using</c> statement is normally preferable to this.</remarks>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <exception cref="InvalidOperationException">The transaction has already been committed or rolled back.</exception>
        public virtual Task<RollbackResponse> RollbackAsync(CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// If the transaction has already been committed, this operation is a no-op.
        /// Otherwise, it rolls back the transaction.
        /// </summary>
        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
