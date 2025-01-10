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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Google.Cloud.Datastore.V1.ReadOptions.Types;

namespace Google.Cloud.Datastore.V1
{

    public partial class DatastoreClient
    {
        // Allows us to use page streaming from the abstraction below.
        internal virtual ApiCall<RunQueryRequest, RunQueryResponse> RunQueryApiCall { get { throw new NotImplementedException(); } }
    }

    public partial class DatastoreClientImpl
    {
        internal override ApiCall<RunQueryRequest, RunQueryResponse> RunQueryApiCall => _callRunQuery;
    }

    /// <summary>
    /// An abstraction over <see cref="DatastoreClient"/> to simplify operations. Use the <see cref="Create(string, string, DatastoreClient)"/>
    /// method to obtain an instance of this class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The project ID specified on creation is used for all operations, effectively supplying the first parameter of every
    /// operation specified on <see cref="DatastoreClient"/>.
    /// </para>
    /// <para>
    /// The project ID and namespace ID are combined to form a partition ID. This partition ID is used when creating a key
    /// factory or running a query. Operations that take keys or entities do not validate that the keys are within the
    /// partition associated with this object.
    /// </para>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. See <see cref="Create(string, string, DatastoreClient)"/>
    /// to construct instances; alternatively, you can construct a <see cref="DatastoreClient"/> directly.
    /// </para>
    /// </remarks>
    public abstract class DatastoreDb
    {
        internal const string DefaultNamespaceId = "";

        internal const string DefaultDatabaseId = "";

        /// <summary>
        /// The <see cref="DatastoreClient"/> used for all remote operations.
        /// </summary>
        public virtual DatastoreClient Client { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The ID of the project this instance operates on.
        /// </summary>
        public virtual string ProjectId { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The ID of the namespace this instance operates on.
        /// </summary>
        public virtual string NamespaceId { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The ID of the database against which the request is to be made.
        /// </summary>
        public virtual string DatabaseId { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Creates a <see cref="DatastoreDb"/> to operate on the partition identified by <paramref name="projectId"/>
        /// and <paramref name="namespaceId"/>, using the <paramref name="client"/> to perform remote operations.
        /// </summary>
        /// <param name="projectId">The project ID to use in all operations.</param>
        /// <param name="namespaceId">The namespace ID to use in operations requiring a partition.</param>
        /// <param name="client">The client to use for remote operations. If this is null, an instance will be created
        /// using default settings.</param>
        /// <returns>A <see cref="DatastoreDb"/> operating on the specified partition.</returns>
        public static DatastoreDb Create(string projectId, string namespaceId = DefaultNamespaceId, DatastoreClient client = null) =>
            new DatastoreDbImpl(projectId, namespaceId, client ?? DatastoreClient.Create());

        /// <summary>
        /// Creates a key factory for root entities in this objects's partition.
        /// </summary>
        /// <param name="kind">The kind of entity key to create. Must not be null.</param>
        /// <returns>A key factory with the specified kind and this object's partition.</returns>
        public virtual KeyFactory CreateKeyFactory(string kind)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given query eagerly, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The complete query results.</returns>
        public virtual DatastoreQueryResults RunQuery(
            AdvancedQuery query, CallSettings callSettings = null) =>
            RunQueryLazily(query, callSettings).GetAllResults();

        /// <summary>
        /// Runs the given query eagerly, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The complete query results.</returns>
        public virtual DatastoreQueryResults RunQuery(
            Query query, ReadConsistency? readConsistency = null, CallSettings callSettings = null) =>
            RunQueryLazily(query, readConsistency, callSettings).GetAllResults();

        /// <summary>
        /// Runs the given query eagerly and asynchronously, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the complete set of query results.</returns>
        public virtual Task<DatastoreQueryResults> RunQueryAsync(AdvancedQuery query, CallSettings callSettings = null) =>
            RunQueryLazilyAsync(query, callSettings).GetAllResultsAsync();

        /// <summary>
        /// Runs the given query eagerly and asynchronously, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the complete set of query results.</returns>
        public virtual Task<DatastoreQueryResults> RunQueryAsync(
            Query query, ReadConsistency? readConsistency = null, CallSettings callSettings = null) =>
            RunQueryLazilyAsync(query, readConsistency, callSettings).GetAllResultsAsync();

        /// <summary>
        /// Executes the given structured query.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AggregationQueryResults"/> holds result of aggregations.</returns>
        public virtual AggregationQueryResults RunAggregationQuery(AggregationQuery query, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the given GQL query.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AggregationQueryResults"/> holds result of aggregations.</returns>
        public virtual AggregationQueryResults RunAggregationQuery(GqlQuery query, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the given structured query.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AggregationQueryResults"/> holds result of aggregations.</returns>
        public virtual Task<AggregationQueryResults> RunAggregationQueryAsync(AggregationQuery query, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the given GQL query.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AggregationQueryResults"/> holds result of aggregations.</returns>
        public virtual Task<AggregationQueryResults> RunAggregationQueryAsync(GqlQuery query, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query.
        /// </summary>
        /// <remarks>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="LazyDatastoreQuery"/> representing the lazy query results.</returns>
        public virtual LazyDatastoreQuery RunQueryLazily(
            AdvancedQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query.
        /// </summary>
        /// <remarks>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="LazyDatastoreQuery"/> representing the lazy query results.</returns>
        public virtual LazyDatastoreQuery RunQueryLazily(
            Query query, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AsyncLazyDatastoreQuery"/> representing the lazy query results.</returns>
        public virtual AsyncLazyDatastoreQuery RunQueryLazilyAsync(AdvancedQuery query, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given structured query for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AsyncLazyDatastoreQuery"/> representing the lazy query results.</returns>
        public virtual AsyncLazyDatastoreQuery RunQueryLazilyAsync(
            Query query, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs the given query eagerly, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>The complete query results.</returns>
        public virtual DatastoreQueryResults RunQuery(
            GqlQuery query, ReadConsistency? readConsistency = null, CallSettings callSettings = null) =>
            RunQueryLazily(query, readConsistency, callSettings).GetAllResults();

        /// <summary>
        /// Runs the given query eagerly and asynchronously, retrieving all results in memory and indicating whether more
        /// results may be available beyond the query's limit. Use this method when your query has a limited
        /// number of results, for example to build a web application which fetches results in pages.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the complete set of query results.</returns>
        public virtual Task<DatastoreQueryResults> RunQueryAsync(
            GqlQuery query, ReadConsistency? readConsistency = null, CallSettings callSettings = null) =>
            RunQueryLazilyAsync(query, readConsistency, callSettings).GetAllResultsAsync();

        /// <summary>
        /// Lazily executes the given GQL query for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </remarks>
        /// <param name="gqlQuery">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A <see cref="LazyDatastoreQuery"/> representing the lazy query results.</returns>
        public virtual LazyDatastoreQuery RunQueryLazily(
            GqlQuery gqlQuery, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lazily executes the given GQL query for asynchronous consumption.
        /// </summary>
        /// <remarks>
        /// The results are requested lazily: no API calls will be made until the application starts
        /// iterating over the results. Iterating over the same <see cref="LazyDatastoreQuery"/> object
        /// multiple times will execute the query again, potentially returning different results.
        /// </remarks>
        /// <param name="gqlQuery">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">If not null, overrides the read consistency of the query.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>An <see cref="AsyncLazyDatastoreQuery"/> representing the lazy query results.</returns>
        public virtual AsyncLazyDatastoreQuery RunQueryLazilyAsync(
            GqlQuery gqlQuery, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a transaction, returning a <see cref="DatastoreTransaction"/> which can be used to operate on the transaction.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A new <see cref="DatastoreTransaction"/> for this object's project.</returns>
        public virtual DatastoreTransaction BeginTransaction(CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a transaction asynchronously, returning a <see cref="DatastoreTransaction"/> which can be used to operate on the transaction.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A new <see cref="DatastoreTransaction"/> for this object's project.</returns>
        public virtual Task<DatastoreTransaction> BeginTransactionAsync(CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a transaction, returning a <see cref="DatastoreTransaction"/> which can be used to operate on the transaction.
        /// </summary>
        /// <param name="options">The options for the new transaction. May be null, for default options.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A new <see cref="DatastoreTransaction"/> for this object's project.</returns>
        public virtual DatastoreTransaction BeginTransaction(TransactionOptions options, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a transaction asynchronously, returning a <see cref="DatastoreTransaction"/> which can be used to operate on the transaction.
        /// </summary>
        /// <param name="options">The options for the new transaction. May be null, for default options.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A new <see cref="DatastoreTransaction"/> for this object's project.</returns>
        public virtual Task<DatastoreTransaction> BeginTransactionAsync(TransactionOptions options, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocates an ID for a single incomplete key.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="AllocateIds(IEnumerable{Key},CallSettings)"/>.</remarks>
        /// <param name="key">The incomplete key to allocate an ID for.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The complete key.</returns>
        public virtual Key AllocateId(Key key, CallSettings callSettings = null) => AllocateIds(new[] { key }, callSettings)[0];

        /// <summary>
        /// Allocates IDs for a collection of incomplete keys.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="AllocateIds(IEnumerable{Key},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="AllocateIds(IEnumerable{Key},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of keys that can be allocated in a single operation. When allocating a large
        /// number of keys, partition the allocations into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The incomplete keys. Must not be null or contain null elements.</param>
        /// <returns>A collection of complete keys with allocated IDs, in the same order as <paramref name="keys"/>.</returns>
        public virtual IReadOnlyList<Key> AllocateIds(params Key[] keys) => AllocateIds(keys, null);

        /// <summary>
        /// Allocates IDs for a collection of incomplete keys.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of keys that can be allocated in a single operation. When allocating a large
        /// number of keys, partition the allocations into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The incomplete keys. Must not be null or contain null elements.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A collection of complete keys with allocated IDs, in the same order as <paramref name="keys"/>.</returns>
        public virtual IReadOnlyList<Key> AllocateIds(IEnumerable<Key> keys, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocates an ID for a single incomplete key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="AllocateIdsAsync(IEnumerable{Key},CallSettings)"/>.</para>
        /// </remarks>
        /// <param name="key">The incomplete key to allocate an ID for.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The complete key.</returns>
        public virtual async Task<Key> AllocateIdAsync(Key key, CallSettings callSettings = null)
        {
            var results = await AllocateIdsAsync(new[] { key }, callSettings).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Allocates IDs for a collection of incomplete keys asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="AllocateIdsAsync(IEnumerable{Key},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="AllocateIdsAsync(IEnumerable{Key},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of keys that can be allocated in a single operation. When allocating a large
        /// number of keys, partition the allocations into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The incomplete keys. Must not be null or contain null elements.</param>
        /// <returns>A collection of complete keys with allocated IDs, in the same order as <paramref name="keys"/>.</returns>
        public virtual Task<IReadOnlyList<Key>> AllocateIdsAsync(params Key[] keys) => AllocateIdsAsync(keys, null);

        /// <summary>
        /// Allocates IDs for a collection of incomplete keys asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of keys that can be allocated in a single operation. When allocating a large
        /// number of keys, partition the allocations into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The incomplete keys. Must not be null or contain null elements.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A collection of complete keys with allocated IDs, in the same order as <paramref name="keys"/>.</returns>
        public virtual Task<IReadOnlyList<Key>> AllocateIdsAsync(IEnumerable<Key> keys, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Looks up a single entity by key.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Lookup(IEnumerable{Key}, ReadConsistency?, CallSettings)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public virtual Entity Lookup(Key key, ReadConsistency? readConsistency = null, CallSettings callSettings = null) => Lookup(new[] { key }, readConsistency, callSettings)[0];

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This call may perform multiple RPC operations in order to look up all keys.
        /// </para>
        /// <para>
        /// This overload does not support the <see cref="ReadConsistency"/> or <see cref="CallSettings "/> to be specified due to restrictions with
        /// methods containing a parameter array and optional parameters.
        /// It simply delegates to <see cref="Lookup(IEnumerable{Key}, ReadConsistency?, CallSettings)"/>, passing in a <c>null</c>
        /// value for the read consistency and call settings.
        /// </para>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual IReadOnlyList<Entity> Lookup(params Key[] keys) => Lookup(keys, null, null);

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <remarks>
        /// <para>This call may perform multiple RPC operations in order to look up all keys.</para>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Looks up a single entity by key asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="LookupAsync(IEnumerable{Key}, ReadConsistency?, CallSettings)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public virtual async Task<Entity> LookupAsync(Key key, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            var results = await LookupAsync(new[] { key }, readConsistency, callSettings).ConfigureAwait(false);
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
        /// This overload does not support the <see cref="ReadConsistency"/> or <see cref="CallSettings "/> to be specified due to restrictions with
        /// methods containing a parameter array and optional parameters.
        /// It simply delegates to <see cref="LookupAsync(IEnumerable{Key}, ReadConsistency?, CallSettings)"/>, passing in a <c>null</c>
        /// value for the read consistency and call settings.
        /// </para>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual Task<IReadOnlyList<Entity>> LookupAsync(params Key[] keys) => LookupAsync(keys, null, null);

        /// <summary>
        /// Looks up a collection of entities by key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This call may perform multiple RPC operations in order to look up all keys.</para>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual Task<IReadOnlyList<Entity>> LookupAsync(IEnumerable<Key> keys, ReadConsistency? readConsistency = null, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        // Static to allow reuse within DatastoreTransaction.
        internal static IReadOnlyList<Entity> LookupImpl(
            DatastoreClient client,
            string projectId,
            string databaseId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings)
        {
            // Normalize the keys, and materialize to a list so we can iterate multiple times safely.
            keys = keys.Select(key => key.NormalizeToProjectId(projectId)).ToList();
            GaxPreconditions.CheckArgument(keys.All(x => x != null), nameof(keys), "Key collection must not contain null elements");
            var keyToIndex = keys.Select((value, index) => new { value, index }).ToLookup(pair => pair.value, pair => pair.index);
            IEnumerable<Key> keysToFetch = new HashSet<Key>(keys);
            Entity[] result = new Entity[keys.Count()];
            // TODO: Limit how many times we go round? Ensure that we make progress on each iteration?
            while (keysToFetch.Count() > 0)
            {
                var lookupRequest = new LookupRequest
                {
                    ProjectId = projectId,
                    DatabaseId = databaseId,
                    ReadOptions = readOptions,
                    Keys = { keysToFetch },
                };

                var response = client.Lookup(lookupRequest, callSettings);
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

        // Static to allow reuse within DatastoreTransaction.
        internal static async Task<IReadOnlyList<Entity>> LookupImplAsync(
            DatastoreClient client,
            string projectId,
            string databaseId,
            ReadOptions readOptions,
            IEnumerable<Key> keys,
            CallSettings callSettings)
        {
            // Just so we can iterate multiple times safely.
            keys = keys.Select(key => key.NormalizeToProjectId(projectId)).ToList();
            GaxPreconditions.CheckArgument(keys.All(x => x != null), nameof(keys), "Key collection must not contain null elements");
            var keyToIndex = keys.Select((value, index) => new { value, index }).ToLookup(pair => pair.value, pair => pair.index);
            IEnumerable<Key> keysToFetch = new HashSet<Key>(keys);
            Entity[] result = new Entity[keys.Count()];
            // TODO: Limit how many times we go round? Ensure that we make progress on each iteration?
            while (keysToFetch.Count() > 0)
            {
                var lookupRequest = new LookupRequest
                {
                    ProjectId = projectId,
                    DatabaseId = databaseId,
                    ReadOptions = readOptions,
                    Keys = { keysToFetch },
                };

                var response = await client.LookupAsync(lookupRequest, callSettings).ConfigureAwait(false);
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

        // Non-transactional mutations

        /// <summary>
        /// Inserts a single entity, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>On success, the entity will be updated in memory with the server-allocated keys.</para>
        /// <para>This method simply delegates to <see cref="Insert(IEnumerable{Entity}, CallSettings)"/>.</para>
        /// </remarks>
        /// <param name="entity">The entity to insert. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The key of the inserted entity if it was allocated by the server, or
        /// <c>null</c> if the inserted entity had a predefined key.</returns>
        public virtual Key Insert(Entity entity, CallSettings callSettings = null) =>
            Insert(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings)[0];
        /// <summary>
        /// Inserts a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>On success, the entities will be updated in memory with the server-allocated keys.</para>
        /// <para>This method simply delegates to <see cref="Insert(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Insert(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to insert. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of inserted entities, in the same order as <paramref name="entities"/>.
        /// Only keys allocated by the server will be returned; any entity with a predefined key will have a null value in
        /// the collection.</returns>
        public virtual IReadOnlyList<Key> Insert(params Entity[] entities) => Insert(entities, null);
        /// <summary>
        /// Inserts a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>On success, the entities will be updated in memory with the server-allocated keys.</para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to insert. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A collection of keys of inserted entities, in the same order as <paramref name="entities"/>.
        /// Only keys allocated by the server will be returned; any entity with a predefined key will have a null value in
        /// the collection.</returns>
        public virtual IReadOnlyList<Key> Insert(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inserts a single entity, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>On success, the entity will be updated in memory with the server-allocated keys.</para>
        /// <para>This method simply delegates to <see cref="InsertAsync(IEnumerable{Entity}, CallSettings)"/>.</para></remarks>
        /// <param name="entity">The entity to insert. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is the key of the inserted entity
        /// if it was allocated by the server, or <c>null</c> if the inserted entity had a predefined key.</returns>
        public virtual async Task<Key> InsertAsync(Entity entity, CallSettings callSettings = null)
        {
            var results = await InsertAsync(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Inserts a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>On success, the entities will be updated in memory with the server-allocated keys.</para>
        /// <para>This method simply delegates to <see cref="InsertAsync(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="InsertAsync(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to insert. Must not be null or contain null entries.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is
        /// a collection of keys of inserted entities, in the same order as <paramref name="entities"/>.
        /// Only keys allocated by the server will be returned; any entity with a predefined key will have a null value in
        /// the collection.</returns>
        public virtual Task<IReadOnlyList<Key>> InsertAsync(params Entity[] entities) => InsertAsync(entities, null);
        /// <summary>
        /// Inserts a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>On success, the entities will be updated in memory with the server-allocated keys.</para>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to insert. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is
        /// a collection of keys of inserted entities, in the same order as <paramref name="entities"/>.
        /// Only keys allocated by the server will be returned; any entity with a predefined key will have a null value in
        /// the collection.</returns>
        public virtual Task<IReadOnlyList<Key>> InsertAsync(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Upserts a single entity, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>On success, if entity has an incomplete key it will be updated in memory with the server-allocated keys.</para>
        /// <para>This method simply delegates to <see cref="Upsert(IEnumerable{Entity}, CallSettings)"/>.</para>
        /// </remarks>
        /// <param name="entity">The entity to upsert. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns><c>null</c> if the entity was updated or was inserted with a predefined key, or the new key if the entity was inserted
        /// and the mutation allocated the key.</returns>
        public virtual Key Upsert(Entity entity, CallSettings callSettings = null) =>
            Upsert(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings)[0];
        /// <summary>
        /// Upserts a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="Upsert(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Upsert(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="entities">The entities to upsert. Must not be null or contain null entries.</param>
        /// <returns>A collection of allocated keys, in the same order as <paramref name="entities"/>. Each inserted entity
        /// which had an incomplete key - requiring the server to allocate a new key - will have a non-null
        /// value in the collection, equal to the new key for the entity. Each updated entity or inserted entity
        /// with a predefined key will have a null value in the collection.</returns>
        public virtual IReadOnlyList<Key> Upsert(params Entity[] entities) => Upsert(entities, null);
        /// <summary>
        /// Upserts a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>On success, any entities with incomplete keys will be updated in memory with the server-allocated keys.</para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to upsert. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A collection of allocated keys, in the same order as <paramref name="entities"/>. Each inserted entity
        /// which had an incomplete key - requiring the server to allocate a new key - will have a non-null
        /// value in the collection, equal to the new key for the entity. Each updated entity or inserted entity
        /// with a predefined key will have a null value in the collection.</returns>
        public virtual IReadOnlyList<Key> Upsert(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Upserts a single entity, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="UpsertAsync(IEnumerable{Entity}, CallSettings)"/>.</remarks>
        /// <param name="entity">The entity to upsert. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is
        /// <c>null</c> if the entity was updated or was inserted with a predefined key, or the
        /// new key if the entity was inserted and the mutation allocated the key.</returns>
        public virtual async Task<Key> UpsertAsync(Entity entity, CallSettings callSettings = null)
        {
            var results = await UpsertAsync(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Upserts a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="UpsertAsync(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="UpsertAsync(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to upsert. Must not be null or contain null entries.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is
        /// a collection of allocated keys, in the same order as <paramref name="entities"/>. Each inserted entity
        /// which had an incomplete key - requiring the server to allocate a new key - will have a non-null
        /// value in the collection, equal to the new key for the entity. Each updated entity or inserted entity
        /// with a predefined key will have a null value in the collection.</returns>
        public virtual Task<IReadOnlyList<Key>> UpsertAsync(params Entity[] entities) => UpsertAsync(entities, null);
        /// <summary>
        /// Upserts a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>On success, any entities with incomplete keys will be updated with the server-allocated keys.</para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to upsert. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. The result of the task is
        /// a collection of allocated keys, in the same order as <paramref name="entities"/>. Each inserted entity
        /// which had an incomplete key - requiring the server to allocate a new key - will have a non-null
        /// value in the collection, equal to the new key for the entity. Each updated entity or inserted entity
        /// with a predefined key will have a null value in the collection.</returns>
        public virtual Task<IReadOnlyList<Key>> UpsertAsync(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a single entity, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Update(IEnumerable{Entity},CallSettings)"/>.</remarks>
        /// <param name="entity">The entity to update. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual void Update(Entity entity, CallSettings callSettings = null) =>
            Update(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings);
        /// <summary>
        /// Updates a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="Update(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Update(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to update. Must not be null or contain null entries.</param>
        public virtual void Update(params Entity[] entities) => Update(entities, null);
        /// <summary>
        /// Updates a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of entities that can be looked up in a single operation. When looking up a large
        /// number of entities, partition the look-ups into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to update. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual void Update(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a single entity, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="UpdateAsync(IEnumerable{Entity},CallSettings)"/>.</remarks>
        /// <param name="entity">The entity to update. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task UpdateAsync(Entity entity, CallSettings callSettings = null) =>
            UpdateAsync(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings);

        /// <summary>
        /// Updates a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="UpdateAsync(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="UpdateAsync(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to update. Must not be null or contain null entries.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task UpdateAsync(params Entity[] entities) => UpdateAsync(entities, null);
        /// <summary>
        /// Updates a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to update. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task UpdateAsync(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a single entity, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Delete(IEnumerable{Entity},CallSettings)"/>.</remarks>
        /// <param name="entity">The entity to delete. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        public virtual void Delete(Entity entity, CallSettings callSettings = null) =>
            Delete(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings);
        /// <summary>
        /// Deletes a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="Delete(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Delete(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to delete. Must not be null or contain null entries.</param>
        public virtual void Delete(params Entity[] entities) => Delete(entities, null);
        /// <summary>
        /// Deletes a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to delete. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual void Delete(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a single entity, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="DeleteAsync(IEnumerable{Entity},CallSettings)"/>.</remarks>
        /// <param name="entity">The entity to delete. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to RPC calls.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteAsync(Entity entity, CallSettings callSettings = null) =>
            DeleteAsync(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) }, callSettings);
        /// <summary>
        /// Deletes a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="DeleteAsync(IEnumerable{Entity},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="DeleteAsync(IEnumerable{Entity},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to delete. Must not be null or contain null entries.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteAsync(params Entity[] entities) => DeleteAsync(entities, null);
        /// <summary>
        /// Deletes a collection of entities, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="entities">The entities to delete. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteAsync(IEnumerable<Entity> entities, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a single key, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Delete(IEnumerable{Key},CallSettings)"/>.</remarks>
        /// <param name="key">The key to delete. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual void Delete(Key key, CallSettings callSettings = null) =>
            Delete(new[] { GaxPreconditions.CheckNotNull(key, nameof(key)) }, callSettings);
        /// <summary>
        /// Deletes a collection of keys, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="Delete(IEnumerable{Key},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="Delete(IEnumerable{Key},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to delete. Must not be null or contain null entries.</param>
        public virtual void Delete(params Key[] keys) => Delete(keys, null);
        /// <summary>
        /// Deletes a collection of keys, non-transactionally.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to delete. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual void Delete(IEnumerable<Key> keys, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a single key, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="DeleteAsync(IEnumerable{Key},CallSettings)"/>.</remarks>
        /// <param name="key">The key to delete. Must not be null.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual Task DeleteAsync(Key key, CallSettings callSettings = null) =>
            DeleteAsync(new[] { GaxPreconditions.CheckNotNull(key, nameof(key)) }, callSettings);
        /// <summary>
        /// Deletes a collection of keys, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This method simply delegates to <see cref="DeleteAsync(IEnumerable{Key},CallSettings)"/>.</para>
        /// <para>
        /// Call settings are not supported on this call due to restrictions with methods containing a parameter array and optional parameters.
        /// To specify options, create a collection or array explicitly, and call <see cref="DeleteAsync(IEnumerable{Key},CallSettings)"/>.
        /// </para>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to delete. Must not be null or contain null entries.</param>
        public virtual Task DeleteAsync(params Key[] keys) => DeleteAsync(keys, null);
        /// <summary>
        /// Deletes a collection of keys, non-transactionally and asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>Datastore limits the number of entities that can be modified in a Commit operation. Although this method does not
        /// use an existing transaction, it still performs all the work in a single Commit operation. When modifying a large
        /// number of entities, partition the changes into batches. See
        /// [Datastore limits](https://cloud.google.com/datastore/docs/concepts/limits) for more details on Datastore limits.</para>
        /// </remarks>
        /// <param name="keys">The keys to delete. Must not be null or contain null entries.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        public virtual Task DeleteAsync(IEnumerable<Key> keys, CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }
    }
}
