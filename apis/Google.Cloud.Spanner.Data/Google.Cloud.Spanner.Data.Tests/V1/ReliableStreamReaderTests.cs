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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Xunit;
using static Google.Cloud.Spanner.V1.SpannerClient;
using static Google.Cloud.Spanner.V1.SpannerClientImpl;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class ReliableStreamReaderTests
    {
        [Fact]
        public async Task Simple()
        {
            var result1 = CreateResultSet("token1", "a", "b", "c");
            var result2 = CreateResultSet("token2", "x", "y", "z");
            var result3 = CreateResultSet("token3", "0", "1", "2");
            var metadata = CreateSingleStringFieldMetadata();

            var client = new FakeSpannerClient(metadata, new[] { result1, result2, result3 });
            var reader = CreateReader(client);

            Assert.True(await reader.HasDataAsync(default));
            Assert.Equal(metadata, await reader.GetMetadataAsync(default));
            var expected = new[] { "a", "b", "c", "x", "y", "z", "0", "1", "2" };
            var actual = (await FetchAllValuesAsync(reader)).Select(v => v.StringValue).ToArray();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task ResumeAfterFailure()
        {
            var result1 = CreateResultSet("token1", "a", "b", "c");
            var result2 = CreateResultSet("token2", "x", "y", "z");
            var result3 = CreateResultSet("token3", "0", "1", "2");
            var metadata = CreateSingleStringFieldMetadata();

            var filter = CreateOneTimeExceptionFilter(prs => prs.ResumeToken.ToStringUtf8() == "token2", new RpcException(new Status(StatusCode.DeadlineExceeded, "Deadline exceeded")));
            var client = new FakeSpannerClient(metadata, new[] { result1, result2, result3 }, filter);
            var reader = CreateReader(client);

            var expected = new[] { "a", "b", "c", "x", "y", "z", "0", "1", "2" };
            var actual = (await FetchAllValuesAsync(reader)).Select(v => v.StringValue).ToArray();
            Assert.Equal(expected, actual);
        }

        private Func<PartialResultSet, PartialResultSet> CreateOneTimeExceptionFilter(Func<PartialResultSet, bool> predicate, RpcException exception)
        {
            bool thrown = false;
            return prs =>
            {
                if (thrown || !predicate(prs))
                {
                    return prs;
                }
                thrown = true;
                throw exception;
            };
        }

        private static async Task<List<Value>> FetchAllValuesAsync(ReliableStreamReader reader)
        {
            var ret = new List<Value>();
            Value nextValue;
            while ((nextValue = await reader.NextAsync(default)) != null)
            {
                ret.Add(nextValue);
            }
            return ret;
        }

        private static ReliableStreamReader CreateReader(SpannerClient client) =>
            new ReliableStreamReader(client, new ExecuteSqlRequest(), new Session(), 60);

        private static PartialResultSet CreateResultSet(string resumeToken, params string[] textValues) =>
            CreateResultSet(resumeToken, textValues.Select(text => Value.ForString(text)));

        private static PartialResultSet CreateResultSet(string resumeToken, IEnumerable<Value> values) =>
            new PartialResultSet
            {
                Values = { values },
                ResumeToken = resumeToken == null ? ByteString.Empty : ByteString.CopyFromUtf8(resumeToken)
            };

        private static ResultSetMetadata CreateSingleStringFieldMetadata() =>
            new ResultSetMetadata
            {
                RowType = new StructType
                {
                    Fields =
                    {
                        new StructType.Types.Field
                        {
                            Name = "text", Type = new V1.Type { Code = TypeCode.String }
                        }
                    }
                }
            };

        private class FakeSpannerClient : SpannerClient
        {
            private readonly IEnumerable<PartialResultSet> _results;
            private readonly ResultSetMetadata _metadata;
            private readonly Func<PartialResultSet, PartialResultSet> _filter;

            public FakeSpannerClient(ResultSetMetadata metadata, IEnumerable<PartialResultSet> results, Func<PartialResultSet, PartialResultSet> filter = null)
            {
                Settings = SpannerSettings.GetDefault();
                _results = results;
                _metadata = metadata;
                // Default to an identity filter
                _filter = filter ?? (x => x);
            }

            public override ExecuteStreamingSqlStream ExecuteStreamingSql(ExecuteSqlRequest request, CallSettings callSettings = null)
            {
                List<PartialResultSet> callResults =
                    // If a resume token is presented, that means we need to skip all responses up to *and including* that one - so skip while we haven't seen it, then skip an extra one.
                    (request.ResumeToken.IsEmpty ? _results : _results.SkipWhile(r => r.ResumeToken != request.ResumeToken).Skip(1))
                    .Select(r => r.Clone())
                    .ToList();
                callResults.First().Metadata = _metadata;
                var asyncResults = new StreamAdapter<PartialResultSet>(callResults.Select(_filter).ToAsyncEnumerable().GetEnumerator());

                var call = new AsyncServerStreamingCall<PartialResultSet>(
                    asyncResults, Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                return new ExecuteStreamingSqlStreamImpl(call);
            }
        }

        // TODO: Move this to GAX?
        /// <summary>
        /// Adapter to wrap an IAsyncEnumerator{T} into the gRPC IAsyncStreamReader{T} type.
        /// </summary>
        private class StreamAdapter<T> : IAsyncStreamReader<T>
        {
            private readonly IAsyncEnumerator<T> _enumerator;

            internal StreamAdapter(IAsyncEnumerator<T> enumerator)
            {
                _enumerator = enumerator;
            }

            public T Current => _enumerator.Current;
            public void Dispose() => _enumerator.Dispose();
            public Task<bool> MoveNext(CancellationToken cancellationToken) => _enumerator.MoveNext(cancellationToken);
        }
    }
}
