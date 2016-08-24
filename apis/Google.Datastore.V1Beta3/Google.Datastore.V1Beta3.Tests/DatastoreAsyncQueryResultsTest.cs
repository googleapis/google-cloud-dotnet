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

using Google.Protobuf;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Datastore.V1Beta3.QueryResultBatch.Types;

namespace Google.Datastore.V1Beta3.Tests
{
    public class DatastoreAsyncQueryResultsTest
    {
        private static readonly Entity[] _entities = Enumerable
            .Range(0, 20)
            .Select(index => new Entity { ["id"] = index }).ToArray();
        private static readonly EntityResult[] _entityResults = _entities
            .Select(e => new EntityResult { Entity = e, Cursor = ByteString.CopyFromUtf8($"entity-{(int)e["id"]}") })
            .ToArray();

        private static readonly RunQueryResponse[] _responses = new[]
        {
            // Response just skipping first 10 results
            new RunQueryResponse
            {
                Batch = new QueryResultBatch
                {
                    SkippedCursor = ByteString.CopyFromUtf8("skipped10"),
                    SkippedResults = 10,
                    EndCursor = ByteString.CopyFromUtf8("after-batch-1"),
                    MoreResults = MoreResultsType.NotFinished
                }
            },
            // Response skipping 5 results, then returning 5 results
            new RunQueryResponse
            {
                Batch = new QueryResultBatch
                {
                    SkippedCursor = ByteString.CopyFromUtf8("skipped5"),
                    SkippedResults = 5,
                    EndCursor = ByteString.CopyFromUtf8("after-batch-2"),
                    MoreResults = MoreResultsType.NotFinished,
                    EntityResults = { { _entityResults.Take(5) } }
                }
            },
            // Response with 10 results, and more to come.
            new RunQueryResponse
            {
                Batch = new QueryResultBatch
                {
                    EndCursor = ByteString.CopyFromUtf8("after-batch-3"),
                    MoreResults = MoreResultsType.NotFinished,
                    EntityResults = { { _entityResults.Skip(5).Take(10) } }
                }
            },
            // Response with final 5 results.
            new RunQueryResponse
            {
                Batch = new QueryResultBatch
                {
                    EndCursor = ByteString.CopyFromUtf8("after-batch-4"),
                    MoreResults = MoreResultsType.MoreResultsAfterLimit,
                    EntityResults = { { _entityResults.Skip(15) } }
                }
            }
        };

        [Fact]
        public async Task AsEntities()
        {
            var results = new DatastoreAsyncQueryResults(_responses.Select(r => r.Clone()).ToAsyncEnumerable());
            Assert.Equal(_entities, await results.ToList());
        }

        [Fact]
        public async Task AsEntityResults()
        {
            var results = new DatastoreAsyncQueryResults(_responses.Select(r => r.Clone()).ToAsyncEnumerable());
            var expected = _entityResults.ToList();
            expected[4].Cursor = _responses[1].Batch.EndCursor;
            expected[14].Cursor = _responses[2].Batch.EndCursor;
            expected[19].Cursor = _responses[3].Batch.EndCursor;
            Assert.Equal(expected, await results.AsEntityResults().ToList());
        }

        [Fact]
        public async Task AsBatches()
        {
            var results = new DatastoreAsyncQueryResults(_responses.Select(r => r.Clone()).ToAsyncEnumerable());
            var expected = new[] { _responses[0].Batch, _responses[1].Batch, _responses[2].Batch, _responses[3].Batch };
            Assert.Equal(expected, await results.AsBatches().ToList());
        }

        [Fact]
        public async Task AsResponses()
        {
            var results = new DatastoreAsyncQueryResults(_responses.Select(r => r.Clone()).ToAsyncEnumerable());
            Assert.Equal(_responses, await results.AsResponses().ToList());
        }
    }
}
