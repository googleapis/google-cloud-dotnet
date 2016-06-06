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
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Datastore.V1Beta3.CommitRequest.Types;
using static Google.Datastore.V1Beta3.ReadOptions.Types;

namespace Google.Datastore.V1Beta3
{
    /// <summary>
    /// Wrapper around <see cref="DatastoreClient"/> to provide simpler operations.
    /// </summary>
    /// <remarks>
    /// This is the "default" implementation of <see cref="DatastoreDb"/>. Most client code
    /// should refer to <see cref="DatastoreDb"/>, creating instances with
    /// <see cref="BigqueryClient.Create(string, string, DatastoreClient)"/>. The constructor
    /// of this class is public for the sake of constructor-based dependency injection.
    /// </remarks>
    public sealed class DatastoreDbImpl : DatastoreDb
    {
        /// <inheritdoc/>
        public override DatastoreClient Client { get; }

        /// <inheritdoc/>
        public override string ProjectId { get; }

        /// <inheritdoc/>
        public override string NamespaceId { get; }

        private readonly PartitionId _partitionId;

        /// <summary>
        /// Constructs an instance from the given project ID, namespace ID and client.
        /// </summary>
        /// <remarks>This constructor is primarily provided for constructor-based dependency injection.
        /// The static <see cref="DatastoreDb.Create(string, string, DatastoreClient)"/> method is provided
        /// for manually obtaining an instance, including automatic client creation.</remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="namespaceId">The namespace ID. Must not be null.</param>
        /// <param name="client">The client to use for underlying operations. Must not be null.</param>
        public DatastoreDbImpl(string projectId, string namespaceId, DatastoreClient client) : base()
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            NamespaceId = GaxPreconditions.CheckNotNull(namespaceId, nameof(namespaceId));
            _partitionId = new PartitionId(projectId, namespaceId);
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
        }

        /// <inheritdoc/>
        public override KeyFactory CreateKeyFactory(string kind) => new KeyFactory(_partitionId, kind);

        /// <inheritdoc/>
        public override RunQueryResponse RunQuery(Query query, ReadConsistency? readConsistency = null) =>
            Client.RunQuery(ProjectId, _partitionId, GetReadOptions(readConsistency), query);

        /// <inheritdoc/>
        public override RunQueryResponse RunQuery(GqlQuery query, ReadConsistency? readConsistency = null) =>
            Client.RunQuery(ProjectId, _partitionId, GetReadOptions(readConsistency), query);

        /// <inheritdoc/>
        public override IPagedEnumerable<RunQueryResponse, Entity> RunQueryPageStream(Query query, ReadConsistency? readConsistency = null)
        {
            var request = new RunQueryRequest
            {
                ProjectId = ProjectId,
                PartitionId = _partitionId,
                Query = query,
                ReadOptions = GetReadOptions(readConsistency)
            };
            return new PagedEnumerable<RunQueryRequest, RunQueryResponse, Entity>(Client.RunQueryApiCall, request, null);
        }

        /// <inheritdoc/>
        public override DatastoreTransaction BeginTransaction() =>
            new DatastoreTransaction(Client, ProjectId, Client.BeginTransaction(ProjectId).Transaction);

        /// <inheritdoc/>
        public override IReadOnlyList<Key> AllocateIds(IEnumerable<Key> keys)
        {
            // TODO: Validation. All keys should be non-null, and have a filled in path element
            // until the final one, which should just have a kind. Or we could just let the server validate...
            keys = GaxPreconditions.CheckNotNull(keys, nameof(keys)).ToList();
            var response = Client.AllocateIds(ProjectId, keys);
            return response.Keys.ToList();
        }

        /// <inheritdoc/>
        public override IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, ReadConsistency? readConsistency = null)
            => LookupImpl(Client, ProjectId, GetReadOptions(readConsistency), keys);

        // Non-transactional mutations

        /// <inheritdoc/>
        public override IReadOnlyList<Key> Insert(IEnumerable<Entity> entities) => Commit(entities, e => e.ToInsert(), nameof(entities));

        /// <inheritdoc/>
        public override IReadOnlyList<Key> Upsert(IEnumerable<Entity> entities) => Commit(entities, e => e.ToUpsert(), nameof(entities));

        /// <inheritdoc/>
        public override IReadOnlyList<Key> Update(IEnumerable<Entity> entities) => Commit(entities, e => e.ToUpdate(), nameof(entities));

        /// <inheritdoc/>
        public override void Delete(IEnumerable<Entity> entities) => Commit(entities, e => e.ToDelete(), nameof(entities));

        /// <inheritdoc/>
        public override void Delete(IEnumerable<Key> keys) => Commit(keys, e => e.ToDelete(), nameof(keys));

        private IReadOnlyList<Key> Commit<T>(IEnumerable<T> values, Func<T, Mutation> conversion, string parameterName)
        {
            // TODO: Validation
            var response = Client.Commit(ProjectId, Mode.NonTransactional, values.Select(conversion));
            return response.MutationResults.Select(mr => mr.Key).ToList();
        }

        private static ReadOptions GetReadOptions(ReadConsistency? readConsistency) =>
            readConsistency == null ? null : new ReadOptions { ReadConsistency = readConsistency.Value };
    }
}
