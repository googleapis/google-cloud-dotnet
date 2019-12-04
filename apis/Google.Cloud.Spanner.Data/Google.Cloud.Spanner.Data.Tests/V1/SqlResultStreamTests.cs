// Copyright 2019 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
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
using Google.Cloud.ClientTesting;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.SpannerClientImpl;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class SqlResultStreamTests
    {
        private const StatusCode RetriableStatusCode = StatusCode.Unavailable;
        private const StatusCode NonRetriableStatusCode = StatusCode.PermissionDenied;

        private static readonly CallSettings s_simpleCallSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(1)));
        private static readonly RetrySettings s_retrySettings = RetrySettings.FromExponentialBackoff(
            maxAttempts: int.MaxValue,
            initialBackoff: TimeSpan.FromSeconds(1),
            maxBackoff: TimeSpan.FromSeconds(15),
            backoffMultiplier: 2.0,
            retryFilter: ignored => false,
            RetrySettings.NoJitter);

        [Fact]
        public async Task SimpleSuccess()
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var client = new FakeSpannerClient(results);
            var stream = CreateStream(client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(1, client.Calls);
        }

        [Fact]
        public async Task ResumeAfterFailure()
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var filter = CreateExceptionFilter("token2", RetriableStatusCode);
            var client = new FakeSpannerClient(results, filter);
            var stream = CreateStream(client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(2, client.Calls);
        }

        [Fact]
        public async Task ResumeWithBuffering()
        {
            var results = CreateResultSets("token1", "token2", "", "", "token3");

            var filter = CreateExceptionFilter("token3", RetriableStatusCode);
            var client = new FakeSpannerClient(results, filter);
            var stream = CreateStream(client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(2, client.Calls);
        }

        [Fact]
        public async Task MultipleErrors_WithSuccessBetween()
        {
            var results = CreateResultSets("token1", "token2", "token3", "token4");

            var filter1 = CreateExceptionFilter("token2", RetriableStatusCode);
            var filter2 = CreateExceptionFilter("token3", RetriableStatusCode);

            // Note: if we do this a lot, we might want a way of specifying multiple filters easily.
            var client = new FakeSpannerClient(results, prs => filter2(filter1(prs)));
            var stream = CreateStream(client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(3, client.Calls);
        }

        [Fact]
        public async Task MultipleErrors_ForSameResumeToken()
        {
            var results = CreateResultSets("token1", "token2", "token3", "token4");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token2", RetriableStatusCode, 2));
            var stream = CreateStream(client);

            // We expect calls of:
            // - Start: no token, MoveNext(yes), MoveNext(throw)
            // - Start: token1, MoveNext(throw)
            // - No further calls, due to second failure
            // Only the result with token1 is returned
            await AssertResultsThenExceptionAsync(stream, results, 1);
            Assert.Equal(2, client.Calls);
        }

        [Fact]
        public async Task BufferOverflow_NoErrors()
        {
            // No resume tokens, so we buffer for a while, then we're forced to return the results anyway.
            var results = CreateResultSets("", "", "", "");
            var client = new FakeSpannerClient(results);
            var stream = CreateStream(client, maxBufferSize: 3);
            await AssertResultsAsync(stream, results);
            Assert.Equal(1, client.Calls);
        }

        [Fact]
        public async Task BufferOverflow_ErrorBeforeFlushing()
        {
            // No resume tokens, so we buffer for a while, then we're forced to return the results anyway.
            // We encounter a server error before we get the resume token, so we have to abandon the stream.
            var results = CreateResultSets("", "", "", "", "token1", "token2");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token1", RetriableStatusCode));
            var stream = CreateStream(client, maxBufferSize: 3);
            await AssertResultsThenExceptionAsync(stream, results, 4);
            Assert.Equal(1, client.Calls);
        }

        [Fact]
        public async Task BufferOverflow_ErrorAfterFlushing()
        {
            // No resume tokens, so we buffer for a while... but then we flush when we see the first resume token,
            // at which point it's okay for the server to fail, as we can resume safely.
            var results = CreateResultSets("", "", "", "", "token1", "token2");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token2", RetriableStatusCode));
            var stream = CreateStream(client, maxBufferSize: 3);
            await AssertResultsAsync(stream, results);
            Assert.Equal(2, client.Calls);
        }

        [Fact]
        public async Task NonRetriableException()
        {
            var results = CreateResultSets("token1", "token2", "token3", "token4");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token2", NonRetriableStatusCode));
            var stream = CreateStream(client);

            await AssertResultsThenExceptionAsync(stream, results, 1);
            Assert.Equal(1, client.Calls);
        }

        private async Task AssertResultsAsync(SqlResultStream stream, IEnumerable<PartialResultSet> expectedResults)
        {
            var ret = new List<PartialResultSet>();
            while (await stream.MoveNext(default))
            {
                ret.Add(stream.Current);
            }
            Assert.Equal(expectedResults.ToList(), ret);
        }

        private async Task AssertResultsThenExceptionAsync(SqlResultStream stream, List<PartialResultSet> allResults, int expectedSuccesses)
        {
            for (int i = 0; i < expectedSuccesses; i++)
            {
                Assert.True(await stream.MoveNext(default));
                Assert.Equal(allResults[i], stream.Current);
            }
            await Assert.ThrowsAsync<RpcException>(() => stream.MoveNext(default));
        }

        private Func<PartialResultSet, PartialResultSet> CreateExceptionFilter(string resumeToken, StatusCode statusCode, int timesToThrow = 1) =>
            CreateExceptionFilter(resumeToken, new RpcException(new Status(statusCode, "Bang")), timesToThrow);

        private Func<PartialResultSet, PartialResultSet> CreateExceptionFilter(string resumeToken, RpcException exception, int timesToThrow = 1)
        {
            ByteString resumeTokenByteString = ByteString.CopyFromUtf8(resumeToken);
            return prs =>
            {
                if (prs.ResumeToken != resumeTokenByteString || timesToThrow == 0)
                {
                    return prs;
                }
                timesToThrow--;
                throw exception;
            };
        }

        private static SqlResultStream CreateStream(SpannerClient client, int maxBufferSize = 10) =>
            new SqlResultStream(client, new ExecuteSqlRequest(), new Session(), s_simpleCallSettings, maxBufferSize, s_retrySettings);

        private static List<PartialResultSet> CreateResultSets(params string[] resumeTokens) =>
            resumeTokens
                .Select((resumeToken, index) => new PartialResultSet
                {
                    ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                    // Each result set is unique (within this call) so that they don't accidentally compare equal.
                    Values = { Value.ForNumber(index) }
                })
                .ToList();

        // Note: a more realistic client would populate the metadata on the first response of each stream, but
        // SqlResultStream doesn't use the metadata anyway, so it's just simpler to just return the result sets as they are.
        private sealed class FakeSpannerClient : SpannerClient
        {
            private IEnumerable<PartialResultSet> _results;
            public int Calls { get; private set; }
            private readonly Func<PartialResultSet, PartialResultSet> _filter;

            public FakeSpannerClient(IEnumerable<PartialResultSet> results, Func<PartialResultSet, PartialResultSet> filter = null)
            {
                Settings = SpannerSettings.GetDefault().Clone();
                Settings.Scheduler = new NoOpScheduler();
                _results = results;
                // Default to an identity filter
                _filter = filter ?? (x => x);
            }

            public override ExecuteStreamingSqlStream ExecuteStreamingSql(ExecuteSqlRequest request, CallSettings callSettings = null)
            {
                FileLogger.Log($"Called with token {request.ResumeToken.ToStringUtf8()}");
                Calls++;
                IEnumerable<PartialResultSet> callResults = request.ResumeToken.IsEmpty
                    ? _results
                    // If a resume token is presented, that means we need to skip all responses up to *and including* that one - so skip while we haven't seen it, then skip an extra one.
                    : _results.SkipWhile(r => r.ResumeToken != request.ResumeToken).Skip(1);
                callResults = callResults.Select(_filter);
                var asyncResults = new AsyncStreamAdapter<PartialResultSet>(callResults.ToAsyncEnumerable().GetAsyncEnumerator(default));

                var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                    // These arguments are all for aspects of gRPC streaming we don't care about.
                    Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                return new ExecuteStreamingSqlStreamImpl(call);
            }
        }
    }
}
