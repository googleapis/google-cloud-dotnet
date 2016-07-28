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
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Google.Datastore.V1Beta3
{
    /// <summary>
    /// A Datastore query which is executed lazily and which be viewed in multiple ways.
    /// The lazy evaluation is important: if you iterate over the query multiple times, it will execute
    /// multiple times, potentially returning different results each time.
    /// </summary>
    public sealed class DatastoreQueryResults : IEnumerable<EntityResult>
    {
        private readonly IEnumerable<RunQueryResponse> _responses;

        /// <summary>
        /// Constructs a new instance from the given sequence of responses. This constructor
        /// is only present to facilitate testing; application code will normally obtain instances
        /// of this class by calling <see cref="DatastoreDb.RunQuery"/>.
        /// </summary>
        /// <remarks>
        /// The sequence of responses will be returned directly from <see cref="AsRpcResponses"/>, and
        /// used to lazily construct the other sequences returned by this class. It should not
        /// contain any null references.
        /// </remarks>
        /// <param name="responses">The responses to return.</param>
        public DatastoreQueryResults(IEnumerable<RunQueryResponse> responses)
        {
            _responses = GaxPreconditions.CheckNotNull(responses, nameof(responses));
        }

        /// <inheritdoc />
        public IEnumerator<EntityResult> GetEnumerator() => AsEntityResults().GetEnumerator();

        /// <summary>
        /// Returns the results of this query as a sequence of <see cref="EntityResult"/> values.
        /// The final result from each batch is modified to use the batch's end cursor instead of
        /// the original <see cref="EntityResult.Cursor"/> value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <returns>A sequence of <see cref="EntityResult"/> values.</returns>
        private IEnumerable<EntityResult> AsEntityResults() =>
            AsRpcResponses().SelectMany(response =>
            {
                var batch = response.Batch;
                var lastResult = batch.EntityResults.LastOrDefault();
                if (lastResult != null)
                {
                    lastResult.Cursor = batch.EndCursor;
                }
                return batch.EntityResults;
            });

        /// <summary>
        /// This method is for advanced use cases only, where more diagnostic information is required;
        /// most application code should merely iterate over the query results as <see cref="EntityResult"/>
        /// values. The results of this query are returned as a sequence of <see cref="RunQueryResponse"/> values
        /// exactly as returned by the Datastore API.
        /// </summary>
        /// <returns>A sequence of <see cref="RunQueryResponse"/> values.</returns>
        public IEnumerable<RunQueryResponse> AsRpcResponses() => _responses;

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
