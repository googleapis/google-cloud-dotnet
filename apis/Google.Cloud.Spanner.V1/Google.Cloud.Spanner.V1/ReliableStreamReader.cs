// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Provides streaming access to a Spanner SQL query that automatically retries, handles
    /// chunking and recoverable errors.
    /// </summary>
    public sealed class ReliableStreamReader : IDisposable
    {
        private readonly IAsyncStreamReader<PartialResultSet> _resultStream;
        private readonly ILogger _logger;

        private bool _initialized = false;
        private PartialResultSet _currentResultSet;
        private ResultSetMetadata _metadata;
        private int _nextIndex;

        // In order to make HasDataAsync work properly, we need to cache the value fetched by that method,
        // and then pop the cache again in NextAsync.
        private bool _cachedValueIsValid;
        private Value _cachedValue;

        internal ReliableStreamReader(IAsyncStreamReader<PartialResultSet> resultStream, ILogger logger)
        {
            _resultStream = GaxPreconditions.CheckNotNull(resultStream, nameof(resultStream));
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
        }

        /// <summary>
        /// Indicates whether the reader is closed or not.
        /// </summary>
        public bool IsClosed { get; private set; }

        /// <summary>
        /// The statistics for the results, if present. These are only present on the last RPC
        /// response from the server. They can be observed while that final response is being consumed, or afterwards.
        /// </summary>
        public ResultSetStats Stats { get; private set; }

        /// <inheritdoc />
        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Closes the stream reader.
        /// </summary>
        public void Close()
        {
            if (IsClosed)
            {
                return;
            }
            IsClosed = true;
            StreamClosed?.Invoke(this, new StreamClosedEventArgs());
        }

        /// <inheritdoc />
        ~ReliableStreamReader()
        {
            // If our finalizer runs, it means we were not disposed properly.
            _logger.LogWarning("ReliableStreamReader was not disposed of properly.  A Session may have been leaked.");
        }

        /// <summary>
        /// Asynchronously retrieves the metadata associated with this stream.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A task which, when completed, will contain the metadata for the stream.</returns>
        public async Task<ResultSetMetadata> GetMetadataAsync(CancellationToken cancellationToken)
        {
            await EnsureInitializedAsync(cancellationToken).ConfigureAwait(false);
            return _metadata;
        }

        /// <summary>
        /// Event invoked when the stream is closed.
        /// </summary>
        public event EventHandler<StreamClosedEventArgs> StreamClosed;

        /// <summary>
        /// Determines whether this stream has any more data or not.
        /// This is equivalent to calling <see cref="NextAsync(CancellationToken)"/> to see whether the return
        /// value is null, but without consuming the value from the stream.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A task which, when completed, will indicate whether the stream contains data.</returns>
        public async Task<bool> HasDataAsync(CancellationToken cancellationToken)
        {
            _cachedValue = await NextAsync(cancellationToken).ConfigureAwait(false);
            _cachedValueIsValid = true;
            return _cachedValue != null;
        }

        /// <summary>
        /// Asynchronously reads the next value from the stream. A null value indicates the end of the stream.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the asynchronous operation.</param>
        /// <returns>A task which, when completed, will provide the next value read from the stream.</returns>
        public async Task<Value> NextAsync(CancellationToken cancellationToken)
        {
            await EnsureInitializedAsync(cancellationToken).ConfigureAwait(false);

            // If we previously cached a value in HasDataAsync, return it now (and clear the cache).
            if (_cachedValueIsValid)
            {
                var ret = _cachedValue;
                _cachedValue = null;
                _cachedValueIsValid = false;
                return ret;
            }

            Value result = await NextChunkAsync(cancellationToken).ConfigureAwait(false);
            // If we have a chunk, and it's the last value within the current response, and it's marked as a chunked
            // value, we need to merge it with the first value in the next response. We may need to do this multiple
            // times, if a single value is split across multiple responses.
            while (result != null &&
                   _nextIndex >= _currentResultSet.Values.Count &&
                   _currentResultSet.ChunkedValue)
            {
                Value nextChunk = await NextChunkAsync(cancellationToken).ConfigureAwait(false);
                if (nextChunk == null)
                {
                    throw new IOException("Reached end of stream when expecting to merge another chunk");
                }
                MergeChunk(result, nextChunk);
            }
            return result;

            async Task<Value> NextChunkAsync(CancellationToken innerCancellationToken)
            {                
                // This needs to be a while loop to handle chunked streams with no results (e.g. for partitioned DML)
                while (_currentResultSet != null && _nextIndex >= _currentResultSet.Values.Count)
                {
                    await MoveNextAsync(innerCancellationToken).ConfigureAwait(false);
                    // Logger.Warn($"Merging chunk after {_valueCount} values. We need to read again.");
                    // We've exhausted this response; move to the next one.
                }
                return _currentResultSet == null ? null : _currentResultSet.Values[_nextIndex++];
            }
        }

        // Note: internal infrastructure will optimize this to return a singleton completed task when
        // we're already initialized.
        private async Task EnsureInitializedAsync(CancellationToken cancellationToken)
        {
            if (_initialized)
            {
                return;
            }
            await MoveNextAsync(cancellationToken).ConfigureAwait(false);
            _metadata = _currentResultSet?.Metadata;
            _initialized = true;
        }

        private async Task MoveNextAsync(CancellationToken cancellationToken)
        {
            bool result = await _resultStream.MoveNext(cancellationToken).ConfigureAwait(false);
            _currentResultSet = result ? _resultStream.Current : null;
            _nextIndex = 0;
            if (Stats == null)
            {
                Stats = _currentResultSet?.Stats;
            }
        }

        /// <summary>
        /// Merges <paramref name="nextValue"/> into <paramref name="currentValue"/>.
        /// </summary>
        private static void MergeChunk(Value currentValue, Value nextValue)
        {
            switch (currentValue.KindCase)
            {
                case Value.KindOneofCase.StringValue:
                    // Simple concatentation
                    currentValue.StringValue = currentValue.StringValue + nextValue.StringValue;
                    break;
                case Value.KindOneofCase.StructValue:
                    foreach (var fieldValue in nextValue.StructValue.Fields)
                    {
                        Value thisChildField;
                        if (currentValue.StructValue.Fields.TryGetValue(fieldValue.Key, out thisChildField))
                        {
                            // Merge duplicated keys
                            MergeChunk(thisChildField, fieldValue.Value);
                        }
                        else
                        {
                            currentValue.StructValue.Fields[fieldValue.Key] = fieldValue.Value;
                        }
                    }
                    break;
                case Value.KindOneofCase.ListValue:
                    // When merging a ListValue, we examine the last item in the list.
                    // If that item is mergeable and if the other list is non-empty, we then merge that item with the first item in the other list.
                    // An empty list at this point is used as a way of stopping an overly-recursive merge.
                    var childItemValue = currentValue.ListValue.Values.LastOrDefault();
                    int iterator = 0;
                    var nextList = nextValue.ListValue.Values;
                    if (IsMergeable(childItemValue) && nextList.Count > 0)
                    {
                        MergeChunk(childItemValue, nextList[0]);
                        iterator++;
                    }
                    for (; iterator < nextList.Count; iterator++)
                    {
                        currentValue.ListValue.Values.Add(nextList[iterator]);
                    }
                    break;
                default:
                    throw new IOException($"The value of type {currentValue.KindCase} cannot be merged as a chunk.");
            }

            bool IsMergeable(Value value)
            {
                if (value == null)
                {
                    return false;
                }
                switch (value.KindCase)
                {
                    case Value.KindOneofCase.StringValue:
                    case Value.KindOneofCase.StructValue:
                    case Value.KindOneofCase.ListValue:
                        return true;
                    default:
                        return false;
                }
            }
        }
    }

    /// <summary>
    /// Event argument type for <see cref="ReliableStreamReader.StreamClosed"/>.
    /// </summary>
    public sealed class StreamClosedEventArgs : EventArgs
    {
    }
}