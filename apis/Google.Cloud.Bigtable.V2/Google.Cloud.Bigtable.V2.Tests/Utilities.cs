// Copyright 2018 Google LLC
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

using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using Google.Rpc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public static class Utilities
    {
        public static MutateRowsResponse.Types.Entry CreateMutateRowsResponseEntry(int index, Code code) =>
            CreateMutateRowsResponseEntry(index, new Status { Code = (int)code });

        public static MutateRowsResponse.Types.Entry CreateMutateRowsResponseEntry(int index, Status status) =>
            new MutateRowsResponse.Types.Entry { Index = index, Status = status };

        public static BigtableClient CreateMutateRowsMockClient(
            MutateRowsRequest initialRequest,
            MutateRowsResponse.Types.Entry[] entriesForInitialStream,
            MutateRowsResponse.Types.Entry[][] entriesForRetryStreams = null,
            BigtableServiceApiSettings settings = null) =>
            CreateMockClientForStreamingRpc(
                initialRequest,
                c => c.MutateRows(
                    It.Is<MutateRowsRequest>(r => ReferenceEquals(r, initialRequest)),
                    It.IsAny<CallSettings>()),
                c => c.MutateRows(
                    It.IsAny<MutateRowsRequest>(),
                    It.IsAny<CallSettings>()),
                entriesForInitialStream,
                entriesForRetryStreams,
                itemsToStream: entries => new MockMutateRowsStream(new MutateRowsResponse { Entries = { entries } }),
                validator: (request, response) =>
                {
                    // Make sure the request is properly formulated for the mock stream being returned.
                    if (request.Entries.Count != response.Responses.SelectMany(r => r.Entries).Count())
                    {
                        throw new InvalidOperationException("The specified request is invalid for the mock stream about to be returned.");
                    }
                },
                settings);

        public static BigtableClient CreateReadRowsMockClient(
            ReadRowsRequest initialRequest,
            ReadRowsResponse[] initialStreamResponse,
            ReadRowsResponse[][] responsesForRetryStreams = null,
            bool errorAtEndOfLastStream = false,
            BigtableServiceApiSettings settings = null)
        {
            MockReadRowsStream lastStream = null;
            var result = CreateMockClientForStreamingRpc(
                initialRequest,
                c => c.ReadRows(
                    It.Is<ReadRowsRequest>(r => ReferenceEquals(r, initialRequest)),
                    It.IsAny<CallSettings>()),
                c => c.ReadRows(
                    It.IsAny<ReadRowsRequest>(),
                    It.IsAny<CallSettings>()),
                initialStreamResponse,
                responsesForRetryStreams,
                itemsToStream: entries =>
                    lastStream = new MockReadRowsStream(entries) { ShouldErrorAtEnd = true },
                validator: (request, response) =>
                {
                    // Make sure the request is properly formulated for the mock stream being returned.
                    // Each response chunk should be a continuation of a previous chunk or from a row
                    // that was requested.
                    if (!response.Responses.SelectMany(r => r.Chunks).All(
                            c => c.RowKey.IsEmpty || IsRequested(request, c.RowKey)))
                    {
                        throw new InvalidOperationException("The specified request is invalid for the mock stream about to be returned.");
                    }
                },
                settings);

            // All but the last stream should end with an RpcException which permits retrying with the
            // default RetrySettings so the higher level ReadRowsStream keeps retrying
            // (see `ShouldErrorAtEnd = true` above). The last stream should end normally, unless
            // errorAtEndOfLastStream is true, in which case it should end with an error as well.
            lastStream.ShouldErrorAtEnd = errorAtEndOfLastStream;

            return result;

            bool IsRequested(ReadRowsRequest request, BigtableByteString rowKey)
            {
                return
                    request.Rows.RowRanges.Any(IsInRange) ||
                    request.Rows.RowKeys.Contains((ByteString)rowKey);

                bool IsInRange(RowRange range)
                {
                    switch (range.StartKeyCase)
                    {
                        case RowRange.StartKeyOneofCase.StartKeyClosed:
                            if (rowKey < range.StartKeyClosed)
                            {
                                return false;
                            }
                            break;
                        case RowRange.StartKeyOneofCase.StartKeyOpen:
                            if (rowKey <= range.StartKeyOpen)
                            {
                                return false;
                            }
                            break;
                    }
                    if (!range.EndKeyClosed.IsEmpty)
                    {
                        switch (range.EndKeyCase)
                        {
                            case RowRange.EndKeyOneofCase.EndKeyClosed:
                                if (range.EndKeyClosed < rowKey)
                                {
                                    return false;
                                }
                                break;
                            case RowRange.EndKeyOneofCase.EndKeyOpen:
                                if (range.EndKeyOpen <= rowKey)
                                {
                                    return false;
                                }
                                break;
                        }
                    }
                    return true;
                }
            }
        }

        private static BigtableClient CreateMockClientForStreamingRpc<TRequest, TStream, TMockStream, TStreamItems>(
            TRequest initialRequest,
            Expression<Func<BigtableServiceApiClient, TStream>> initialSetup,
            Expression<Func<BigtableServiceApiClient, TStream>> retrySetup,
            TStreamItems[] entriesForInitialStream,
            TStreamItems[][] entriesForRetryStreams,
            Func<TStreamItems[], TMockStream> itemsToStream,
            Action<TRequest, TMockStream> validator,
            BigtableServiceApiSettings settings)
            where TMockStream : class, TStream
        {
            var mock = new Mock<BigtableServiceApiClient>();
            mock.SetupGet(x => x.DefaultSettings).Returns(settings);

            // Even though we want to setup the initial call last, we should call the stream conversion for it
            // first so `itemsToStream` is called in the order the streams will be returned, just in case the
            // order matters to the caller.
            var initialResponse = itemsToStream(entriesForInitialStream);

            var retryStreams = entriesForRetryStreams != null
                ? new Queue<TMockStream>(entriesForRetryStreams.Select(items => items == null ? null : itemsToStream(items)))
                : new Queue<TMockStream>();

            mock.Setup(retrySetup).Returns<TRequest, CallSettings>((request, callSettings) =>
            {
                Assert.NotEmpty(retryStreams);
                var respose = retryStreams.Dequeue();
                if (respose == null)
                {
                    throw new Grpc.Core.RpcException(
                        new Grpc.Core.Status(Grpc.Core.StatusCode.Unavailable, "Unavailable"));
                }
                validator?.Invoke(request, respose);
                return respose;
            });

            // Setup the initial response last so the catch-all setup doesn't overwrite it.
            // Check for reference equality to retry requests that happen to be a duplicate of the original don't match here.
            mock.Setup(initialSetup).Returns<TRequest, CallSettings>((request, callSettings) =>
            {
                validator?.Invoke(request, initialResponse);
                return initialResponse;
            });

            return new BigtableClientImpl(mock.Object);
        }
    }
}
