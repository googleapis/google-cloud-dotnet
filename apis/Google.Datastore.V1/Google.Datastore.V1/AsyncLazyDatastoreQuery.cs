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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Datastore.V1
{
    /// <summary>
    /// A Datastore query which is executed lazily. Iterating over this object will provide a sequence
    /// of entities; alternatively, all the results can be fetched using <see cref="GetAllResultsAsync"/>,
    /// or for diagnostic use cases the RPC responses can be viewed using <see cref="AsResponses"/>.
    /// The lazy evaluation is important: if you iterate over the query multiple times, it will execute
    /// multiple times, potentially returning different results each time.
    /// </summary>
    public sealed class AsyncLazyDatastoreQuery : IAsyncEnumerable<Entity>
    {
        private readonly IAsyncEnumerable<RunQueryResponse> _responses;

        /// <summary>
        /// Constructs a new instance from the given sequence of responses. This constructor
        /// is only present to facilitate testing; application code will normally obtain instances
        /// of this class by calling <see cref="DatastoreDb.RunQueryLazily"/>.
        /// </summary>
        /// <remarks>
        /// The sequence of responses will be returned directly from <see cref="AsResponses"/>, and
        /// used to lazily construct the other sequences returned by this class. It should not
        /// contain any null references.
        /// </remarks>
        /// <param name="responses">The responses to return.</param>
        public AsyncLazyDatastoreQuery(IAsyncEnumerable<RunQueryResponse> responses)
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
        /// <returns>A task representing the asynchronous operation. When completed, the result of the task
        /// is the complete set of query results.</returns>
        public async Task<DatastoreQueryResults> GetAllResultsAsync()
        {
            // This takes slightly more memory than we really need, due to extra
            // cursors etc, but that's likely to be insignificant compared with the
            // entity data, and is immediately eligible for garbage collection.
            var responses = await _responses.ToList().ConfigureAwait(false);
            var entities = responses.SelectMany(r => r.Batch.EntityResults.Select(er => er.Entity)).ToList().AsReadOnly();
            var lastBatch = responses.Last().Batch;
            return new DatastoreQueryResults(entities, lastBatch.MoreResults, lastBatch.EndCursor);
        }

        /// <inheritdoc />
        public IAsyncEnumerator<Entity> GetEnumerator() => AsEntities().GetEnumerator();

        /// <summary>
        /// Returns the results of this query as a sequence of <see cref="Entity"/> values.
        /// </summary>
        /// <remarks>
        /// This method only exists for symmetry with the other "As*" methods, to make the fact that
        /// the class implements IEnumerable{Entity} more incidental.
        /// </remarks>
        private IAsyncEnumerable<Entity> AsEntities() => AsEntityResults().Select(er => er.Entity);

        /// <summary>
        /// Returns the results of this query as a sequence of <see cref="EntityResult"/> values.
        /// The final result from each batch is modified to use the batch's end cursor instead of
        /// the original <see cref="EntityResult.Cursor"/> value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns>A sequence of <see cref="EntityResult"/> values.</returns>
        private IAsyncEnumerable<EntityResult> AsEntityResults() =>
            AsBatches().SelectMany(batch =>
            {
                var lastResult = batch.EntityResults.LastOrDefault();
                if (lastResult != null)
                {
                    lastResult.Cursor = batch.EndCursor;
                }
                return batch.EntityResults.ToAsyncEnumerable();
            });

        /// <summary>
        /// Returns the results of this query as a sequence of <see cref="RunQueryResponse"/> values
        /// exactly as returned by the Datastore API. This method is only useful if the application
        /// wishes to examine the <see cref="RunQueryResponse.Query"/> property; otherwise, use
        /// <see cref="AsBatches"/> to obtain the sequence of batches.
        /// </summary>
        /// <returns>A sequence of <see cref="RunQueryResponse"/> values.</returns>
        public IAsyncEnumerable<RunQueryResponse> AsResponses() => _responses;

        /// <summary>
        /// Returns the results of this query as a sequence of <see cref="QueryResultBatch"/> values.
        /// This method is only useful if the application wishes to process a batch at a time; if the
        /// details of how the API splits the results into batches is not needed, use <see cref="AsEntityResults"/>
        /// or simply iterate over the entities.
        /// </summary>
        /// <returns>A sequence of <see cref="QueryResultBatch"/> values.</returns>
        public IAsyncEnumerable<QueryResultBatch> AsBatches() => _responses.Select(r => r.Batch);
    }
}
