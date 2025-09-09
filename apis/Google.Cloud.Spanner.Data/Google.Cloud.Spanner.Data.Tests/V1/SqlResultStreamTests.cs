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

        private static readonly CallSettings s_simpleCallSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(30)));
        private static readonly RetrySettings s_retrySettings = RetrySettings.FromExponentialBackoff(
            maxAttempts: int.MaxValue,
            initialBackoff: TimeSpan.FromSeconds(1),
            maxBackoff: TimeSpan.FromSeconds(15),
            backoffMultiplier: 2.0,
            retryFilter: ignored => false,
            RetrySettings.NoJitter);

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task SimpleSuccess(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var client = new FakeSpannerClient(results);
            var stream = CreateResultStream(type, client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(1, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task ResumeAfterFailure(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var filter = CreateExceptionFilter("token2", RetriableStatusCode);
            var client = new FakeSpannerClient(results, filter);
            var stream = CreateResultStream(type, client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(2, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task ResumeWithBuffering(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "", "", "token3");

            var filter = CreateExceptionFilter("token3", RetriableStatusCode);
            var client = new FakeSpannerClient(results, filter);
            var stream = CreateResultStream(type, client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(2, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task MultipleErrors_WithSuccessBetween(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3", "token4");

            var filter1 = CreateExceptionFilter("token2", RetriableStatusCode);
            var filter2 = CreateExceptionFilter("token3", RetriableStatusCode);

            // Note: if we do this a lot, we might want a way of specifying multiple filters easily.
            var client = new FakeSpannerClient(results, prs => filter2(filter1(prs)));
            var stream = CreateResultStream(type, client);

            await AssertResultsAsync(stream, results);
            Assert.Equal(3, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task MultipleErrors_ForSameResumeToken(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3", "token4");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token2", RetriableStatusCode, 2));
            var stream = CreateResultStream(type, client);

            // We expect calls of:
            // - Start: no token, MoveNext(yes), MoveNext(throw)
            // - Start: token1, MoveNext(throw)
            // - Start: token1, succeeds until the end of the stream.
            await AssertResultsAsync(stream, results);
            Assert.Equal(3, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task BufferOverflow_NoErrors(System.Type type)
        {
            // No resume tokens, so we buffer for a while, then we're forced to return the results anyway.
            var results = CreateResultSets("", "", "", "");
            var client = new FakeSpannerClient(results);
            var stream = CreateResultStream(type, client, maxBufferSize: 3);
            await AssertResultsAsync(stream, results);
            Assert.Equal(1, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task BufferOverflow_ErrorBeforeFlushing(System.Type type)
        {
            // No resume tokens, so we buffer for a while, then we're forced to return the results anyway.
            // We encounter a server error before we get the resume token, so we have to abandon the stream.
            var results = CreateResultSets("", "", "", "", "token1", "token2");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token1", RetriableStatusCode));
            var stream = CreateResultStream(type, client, maxBufferSize: 3);
            await AssertResultsThenExceptionAsync(stream, results, 4);
            Assert.Equal(1, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task BufferOverflow_ErrorAfterFlushing(System.Type type)
        {
            // No resume tokens, so we buffer for a while... but then we flush when we see the first resume token,
            // at which point it's okay for the server to fail, as we can resume safely.
            var results = CreateResultSets("", "", "", "", "token1", "token2");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token2", RetriableStatusCode));
            var stream = CreateResultStream(type, client, maxBufferSize: 3);
            await AssertResultsAsync(stream, results);
            Assert.Equal(2, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task NonRetriableException(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3", "token4");
            var client = new FakeSpannerClient(results, CreateExceptionFilter("token2", NonRetriableStatusCode));
            var stream = CreateResultStream(type, client);

            await AssertResultsThenExceptionAsync(stream, results, 1);
            Assert.Equal(1, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task RetryableError_ExceedsTimeout(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var filter = CreateExceptionFilter("token2", RetriableStatusCode);
            var client = new FakeSpannerClient(results, filter);
            var clock = new FakeClock();
            client.Settings.Clock = clock;
            client.Settings.Scheduler = new AdvanceFakeClockScheduler(clock);
            // Create a call that will timeout if it has to backoff and retry once.
            var callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(10)));
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromSeconds(20),
                maxBackoff: TimeSpan.FromSeconds(30),
                backoffMultiplier: 2.0,
                retryFilter: ignored => false,
                RetrySettings.NoJitter);

            var stream = CreateResultStream(type, client, maxBufferSize: 10, callSettings, retrySettings);

            await AssertResultsThenExceptionAsync(stream, results, 1);
            Assert.Equal(1, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task MultipleRetryableErrors_ForDifferentResumeTokens_ResetsTimeout(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var filter1 = CreateExceptionFilter("token2", RetriableStatusCode);
            var filter2 = CreateExceptionFilter("token3", RetriableStatusCode);
            var client = new FakeSpannerClient(results, prs => filter2(filter1(prs)));
            var clock = new FakeClock();
            client.Settings.Clock = clock;
            client.Settings.Scheduler = new AdvanceFakeClockScheduler(clock);

            // The call will have a timeout of 15 seconds and a backoff of 10 seconds.
            // One retry will therefore not cause it to fail. Two retries for different
            // calls will also not cause it to fail, as the timeout is reset after each
            // successful RPC.
            var callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(15)));
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromSeconds(10),
                maxBackoff: TimeSpan.FromSeconds(10),
                backoffMultiplier: 1.0,
                retryFilter: ignored => false,
                RetrySettings.NoJitter);

            var stream = CreateResultStream(type, client, maxBufferSize: 10, callSettings, retrySettings);

            await AssertResultsAsync(stream, results);
            Assert.Equal(3, client.Calls);
        }

        [InlineData(typeof(ReadRequest))]
        [InlineData(typeof(ExecuteSqlRequest))]
        [Theory]
        public async Task MultipleRetryableErrors_ForSameResumeToken_CausesTimeout(System.Type type)
        {
            var results = CreateResultSets("token1", "token2", "token3");

            var filter = CreateExceptionFilter("token3", RetriableStatusCode, 2);
            var client = new FakeSpannerClient(results, filter);
            var clock = new FakeClock();
            client.Settings.Clock = clock;
            client.Settings.Scheduler = new AdvanceFakeClockScheduler(clock);

            // The call will have a timeout of 15 seconds and a backoff of 10 seconds.
            // token3 will return two consecutive retryable errors. After the second backoff
            // the timeout of the call has been exceeded and a DeadlineExceeded error is thrown.
            var callSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(15)));
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromSeconds(10),
                maxBackoff: TimeSpan.FromSeconds(10),
                backoffMultiplier: 1.0,
                retryFilter: ignored => false,
                RetrySettings.NoJitter);

            var stream = CreateResultStream(type, client, maxBufferSize: 10, callSettings, retrySettings);

            await AssertResultsThenExceptionAsync(stream, results, 2);
            // 2 calls == 1 initial call + 1 retry of token3.
            // A second retry of token3 is never executed as the deadline has already been exceeded.
            Assert.Equal(2, client.Calls);
        }

        private async Task AssertResultsAsync(ResultStream stream, IEnumerable<PartialResultSet> expectedResults)
        {
            var ret = new List<PartialResultSet>();
            while (await stream.MoveNext(default))
            {
                ret.Add(stream.Current);
            }
            Assert.Equal(expectedResults.ToList(), ret);
        }

        private async Task AssertResultsThenExceptionAsync(ResultStream stream, List<PartialResultSet> allResults, int expectedSuccesses)
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

        private ResultStream CreateResultStream(
            System.Type type,
            SpannerClient client,
            int maxBufferSize = 10,
            CallSettings callSettings = null,
            RetrySettings retrySettings = null)
            => new ResultStream(
                client,
                ReadOrQueryRequest.FromRequest(type == typeof(ExecuteSqlRequest) ? new ExecuteSqlRequest() : new ReadRequest() as IReadOrQueryRequest),
                PooledSession.FromSessionName(new PooledSessionTests.FakeSessionPool(), SessionName.FromProjectInstanceDatabaseSession("projectId", "instanceId", "databaseId", "sessionId")),
                callSettings ?? s_simpleCallSettings,
                maxBufferSize,
                retrySettings ?? s_retrySettings);

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
            private readonly IEnumerable<PartialResultSet> _results;
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
                return new ExecuteStreamingSqlStreamImpl(CreateStreamingCall(request.ResumeToken));
            }

            public override StreamingReadStream StreamingRead(ReadRequest request, CallSettings callSettings = null)
            {
                return new StreamingReadStreamImpl(CreateStreamingCall(request.ResumeToken));
            }

            private AsyncServerStreamingCall<PartialResultSet> CreateStreamingCall(ByteString resumeToken)
            {
                Calls++;
                IEnumerable<PartialResultSet> callResults = resumeToken.IsEmpty
                    ? _results
                    // If a resume token is presented, that means we need to skip all responses up to *and including* that one - so skip while we haven't seen it, then skip an extra one.
                    : _results.SkipWhile(r => r.ResumeToken != resumeToken).Skip(1);
                callResults = callResults.Select(_filter);
                var asyncResults = new AsyncStreamAdapter<PartialResultSet>(callResults.ToAsyncEnumerable().GetAsyncEnumerator(default));

                return new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                    // These arguments are all for aspects of gRPC streaming we don't care about.
                    Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
            }
        }

        /// <summary>
        /// Simple scheduler that automatically advances the fake clock when Delay is called.
        /// </summary>
        internal sealed class AdvanceFakeClockScheduler : IScheduler
        {
            private readonly FakeClock _clock;

            public AdvanceFakeClockScheduler(FakeClock clock) => _clock = clock;

            public Task Delay(TimeSpan delay, CancellationToken cancellationToken)
            {
                _clock.Advance(delay);
                return Task.CompletedTask;
            }
        }
    }
}
