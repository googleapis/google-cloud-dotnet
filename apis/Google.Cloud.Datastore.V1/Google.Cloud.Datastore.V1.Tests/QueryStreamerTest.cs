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
using Google.Api.Gax.Grpc.Testing;
using Google.Api.Gax.Testing;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Datastore.V1.QueryResultBatch.Types;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class QueryStreamerTest
    {
        [Fact]
        public void GqlQueryIsTransformed()
        {
            var structured = new Query
            {
                Limit = 10,
                Projection = { "foo", "bar" }
            };
            // No, this isn't real GQL. But it's an easy way of testing things.
            var gql = new GqlQuery { QueryString = structured.ToString() };
            var server = new FakeServer(4);
            var streamer = new QueryStreamer(new RunQueryRequest { GqlQuery = gql }, server.CreateApiCall(), null);
            AssertEntities(streamer, 0, 10);
            var firstStructured = new Query(structured) { Limit = 6, StartCursor = ByteString.CopyFromUtf8("4") };
            Assert.Equal(firstStructured, server.Requests[1].Query);
        }
        
        [Fact]
        public void LimitAndOffset()
        {
            var query = new Query
            {
                Limit = 7,
                Offset = 5
            };
            var server = new FakeServer(4);
            var streamer = new QueryStreamer(new RunQueryRequest { Query = query }, server.CreateApiCall(), null);
            AssertEntities(streamer, 5, 7);
            AssertLimits(server, 7, 7, 4);
            AssertOffsets(server, 5, 1, 0);
        }

        [Fact]
        public void NoLimit()
        {
            var query = new Query { Offset = 5 };
            var server = new FakeServer(11);
            var streamer = new QueryStreamer(new RunQueryRequest { Query = query }, server.CreateApiCall(), null);
            AssertEntities(streamer, 5, 15);
            AssertLimits(server, null, null);
            AssertOffsets(server, 5, 0);
        }

        [Fact]
        public async Task GqlQueryIsTransformedAsync()
        {
            var structured = new Query
            {
                Limit = 10,
                Projection = { "foo", "bar" }
            };
            // No, this isn't real GQL. But it's an easy way of testing things.
            var gql = new GqlQuery { QueryString = structured.ToString() };
            var server = new FakeServer(4);
            var streamer = new QueryStreamer(new RunQueryRequest { GqlQuery = gql }, server.CreateApiCall(), null);
            await AssertEntitiesAsync(streamer, 0, 10);
            var firstStructured = new Query(structured) { Limit = 6, StartCursor = ByteString.CopyFromUtf8("4") };
            Assert.Equal(firstStructured, server.Requests[1].Query);
        }

        [Fact]
        public async Task LimitAndOffsetAsync()
        {
            var query = new Query
            {
                Limit = 7,
                Offset = 5
            };
            var server = new FakeServer(4);
            var streamer = new QueryStreamer(new RunQueryRequest { Query = query }, server.CreateApiCall(), null);
            await AssertEntitiesAsync(streamer, 5, 7);
            AssertLimits(server, 7, 7, 4);
            AssertOffsets(server, 5, 1, 0);
        }

        [Fact]
        public async Task NoLimitAsync()
        {
            var query = new Query { Offset = 5 };
            var server = new FakeServer(11);
            var streamer = new QueryStreamer(new RunQueryRequest { Query = query }, server.CreateApiCall(), null);
            await AssertEntitiesAsync(streamer, 5, 15);
            AssertLimits(server, null, null);
            AssertOffsets(server, 5, 0);
        }

        private void AssertLimits(FakeServer server, params int?[] expectedLimits)
        {
            Assert.Equal(expectedLimits, server.Requests.Select(r => r.Query?.Limit));
        }

        private void AssertOffsets(FakeServer server, params int[] expectedOffsets)
        {
            Assert.Equal(expectedOffsets, server.Requests.Select(r => r.Query.Offset));
        }

        private void AssertEntities(QueryStreamer streamer, int offset, int limit)
        {
            var entities = streamer.Sync().SelectMany(response => response.Batch.EntityResults).Select(er => er.Entity).ToList();
            Assert.Equal(FakeServer.Entities.Skip(offset).Take(limit), entities);
        }

        private async Task AssertEntitiesAsync(QueryStreamer streamer, int offset, int limit)
        {
            var entities = await streamer.Async().SelectMany(response => response.Batch.EntityResults.ToAsyncEnumerable()).Select(er => er.Entity).ToListAsync();
            Assert.Equal(FakeServer.Entities.Skip(offset).Take(limit), entities);
        }

        private class FakeServer
        {

            internal static List<Entity> Entities { get; } = Enumerable
                .Range(0, 20)
                .Select(index => new Entity { ["id"] = index }).ToList();
            private static List<EntityResult> EntityResults { get; } = Entities
                .Select((value, index) => new EntityResult {
                    Entity = value,
                    // The +1 is because we want the position *after* the entity.
                    Cursor = ByteString.CopyFromUtf8((index + 1).ToString()) })
                .ToList();

            private readonly int _resultsToProcessPerCall;
            internal List<RunQueryRequest> Requests { get; } = new List<RunQueryRequest>();

            /// <summary>
            /// Creates a server that "processes" (skips or returns) a given number of results per call
            /// before returning the response.
            /// </summary>
            internal FakeServer(int resultsToProcessPerCall)
            {
                _resultsToProcessPerCall = resultsToProcessPerCall;
            }

            internal ApiCall<RunQueryRequest, RunQueryResponse> CreateApiCall()
            {
                return FakeApiCall.Create<RunQueryRequest, RunQueryResponse>(RunQuery);
            }

            private RunQueryResponse RunQuery(RunQueryRequest request, CallOptions options)
            {
                Requests.Add(request.Clone());
                var response = new RunQueryResponse { Batch = new QueryResultBatch() };
                if (request.GqlQuery != null)
                {
                    response.Query = Query.Parser.ParseJson(request.GqlQuery.QueryString);
                    request.Query = response.Query;
                }
                var query = request.Query;
                var batch = response.Batch;
                batch.MoreResults = MoreResultsType.NotFinished;
                int leftToSkip = query.Offset;
                int position = query.StartCursor.IsEmpty ? 0 : int.Parse(query.StartCursor.ToStringUtf8());
                for (int i = 0; i < _resultsToProcessPerCall; i++)
                {
                    if (position >= EntityResults.Count)
                    {
                        batch.MoreResults = MoreResultsType.NoMoreResults;
                        break;
                    }
                    if (EntityResults[position].Cursor == query.EndCursor)
                    {
                        batch.MoreResults = MoreResultsType.MoreResultsAfterCursor;
                        break;
                    }
                    if (batch.EntityResults.Count == query.Limit)
                    {
                        // Status will be set after the loop.
                        break;
                    }
                    if (leftToSkip > 0)
                    {
                        leftToSkip--;
                        batch.SkippedResults++;
                        batch.SkippedCursor = EntityResults[position].Cursor;
                    }
                    else
                    {
                        batch.EntityResults.Add(EntityResults[position]);
                    }
                    position++;
                }
                batch.EndCursor = batch.EntityResults.LastOrDefault()?.Cursor ?? batch.SkippedCursor;
                // Mustn't do this just in the loop, as we might ask for exactly the number processed.
                if (batch.EntityResults.Count == query.Limit)
                {
                    batch.MoreResults = MoreResultsType.MoreResultsAfterLimit;
                }
                return response;
            }
        }
    }
}
