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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.Datastore.V1.QueryResultBatch.Types;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// A Datastore query which is executed lazily. Iterating over this object will provide a sequence
    /// of entities; alternatively, all the results can be fetched using <see cref="GetAllResults"/>,
    /// or for diagnostic use cases the RPC responses can be viewed using <see cref="AsResponses"/>.
    /// The lazy evaluation is important: if you iterate over the query multiple times, it will execute
    /// multiple times, potentially returning different results each time.
    /// </summary>
    public sealed class LazyDatastoreQuery : IEnumerable<Entity>
    {
        private readonly IEnumerable<RunQueryResponse> _responses;

        /// <summary>
        /// Constructs a new instance from the given sequence of responses. This constructor
        /// is only present to facilitate testing; application code will normally obtain instances
        /// of this class by calling <see cref="DatastoreDb.RunQueryLazily(Query, ReadOptions.Types.ReadConsistency?, CallSettings)"/>.
        /// </summary>
        /// <remarks>
        /// The sequence of responses will be returned directly from <see cref="AsResponses"/>, and
        /// used to lazily construct the other sequences returned by this class. It should not
        /// contain any null references.
        /// </remarks>
        /// <param name="responses">The responses to return.</param>
        public LazyDatastoreQuery(IEnumerable<RunQueryResponse> responses)
        {
            _responses = GaxPreconditions.CheckNotNull(responses, nameof(responses));
        }

        /// <summary>
        /// Reads all the results from this query, until either the query-specified limit or end cursor
        /// is reached, or there is no more data to read. Note that all the entities are read into memory,
        /// so this method is not appropriate for use cases where a query could return a very large number
        /// of results. However, it is the simplest approach to use cases where the query is bounded, such
        /// as displaying a page of results at a time in a web application.
        /// </summary>
        /// <returns>The complete set of query results.</returns>
        public DatastoreQueryResults GetAllResults()
        {
            // This takes slightly more memory than we really need, due to extra
            // cursors etc, but that's likely to be insignificant compared with the
            // entity data, and is immediately eligible for garbage collection.
            var responses = _responses.ToList();
            var entities = responses.SelectMany(r => r.Batch?.EntityResults.Select(er => er.Entity) ?? Enumerable.Empty<Entity>()).ToList().AsReadOnly();
            var lastBatch = responses.Last().Batch;
            var metrics = responses.Last().ExplainMetrics;
            return new DatastoreQueryResults(entities, lastBatch?.MoreResults ?? MoreResultsType.Unspecified, lastBatch?.EndCursor, metrics);
        }

        /// <inheritdoc />
        public IEnumerator<Entity> GetEnumerator() =>
            _responses.SelectMany(r => r.Batch.EntityResults.Select(er => er.Entity)).GetEnumerator();

        /// <summary>
        /// This method is for advanced use cases only, where more diagnostic information is required;
        /// most application code should merely iterate over the query results as <see cref="Entity"/>
        /// values, or call <see cref="GetAllResults()"/>.
        /// The results of this query are returned as a sequence of <see cref="RunQueryResponse"/> values
        /// exactly as returned by the Datastore API.
        /// </summary>
        /// <returns>A sequence of <see cref="RunQueryResponse"/> values.</returns>
        public IEnumerable<RunQueryResponse> AsResponses() => _responses;

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
