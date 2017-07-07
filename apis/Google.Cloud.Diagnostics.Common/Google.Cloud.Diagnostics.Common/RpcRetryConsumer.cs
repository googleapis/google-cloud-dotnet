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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// An <see cref="IConsumer{T}"/> that will allow for the option to retry RPC failures and buffer
    /// the data while the retries occur.
    /// </summary>
    internal class RpcRetryConsumer<T> : IConsumer<T>
    {
        /// <summary>The options dictating how retries will be handled.</summary>
        private readonly RetryOptions _options;

        /// <summary>A function to obtain the size of an item in bytes.</summary>
        private readonly Func<T, int> _sizer;

        /// <summary>
        /// Function to create a <see cref="ISequentialThreadingTimer"/> that will start the given
        /// action based on retry options.
        /// </summary>
        private readonly Func<Action, RetryOptions, ISequentialThreadingTimer> _timerFactory;

        /// <summary>The timer running in the background to retry failed requests.</summary>
        private readonly ISequentialThreadingTimer _timer;

        /// <summary>An mutex to protect the buffer.</summary>
        private readonly object _mutex = new object();

        /// <summary>The consumer to send items to.</summary>
        internal readonly IConsumer<T> _consumer;

        /// <summary>
        /// The buffered items. This is not readonly as it is replaced when the buffer is successfully send to
        /// the base consumer.
        /// </summary>
        private List<T> _buffer = new List<T>();

        /// <summary>The size of the buffer.</summary>
        private int _sizeInBytes = 0;

        /// <summary>The number of sequential unsuccessful retries.</summary>
        private int _retries = 0;

        internal RpcRetryConsumer(IConsumer<T> consumer, RetryOptions options,
            Func<T, int> sizer, Func<Action, RetryOptions, ISequentialThreadingTimer> timerFactory)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _options = GaxPreconditions.CheckNotNull(options, nameof(options));
            _sizer = GaxPreconditions.CheckNotNull(sizer, nameof(sizer));
            _timerFactory = GaxPreconditions.CheckNotNull(timerFactory, nameof(timerFactory));

            // Start the background timer that will retry failed requests.
            _timer = _timerFactory(FlushBuffer, _options);
        }

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            try
            {
                _consumer.Receive(items);
            }
            catch (RpcException e)
            {
                if (!HandleException(items, e))
                {
                    throw;
                }
            }
        }

        /// <inheritdoc />
        public Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            try
            {
                return _consumer.ReceiveAsync(items, cancellationToken);
            }
            catch (RpcException e)
            {
                if (!HandleException(items, e))
                {
                    throw;
                }
            }

            return CommonUtils.CompletedTask;
        }

        /// <inheritdoc />
        public void Dispose() => _timer?.Dispose();

        /// <summary>
        /// Handles a <see cref="RpcException"/> that occurred during a <see cref="Receive(IEnumerable{T})"/> call.
        /// </summary>
        /// <returns>True if the exception was handled, false otherwise.</returns>
        private bool HandleException(IEnumerable<T> items, RpcException e)
        {
            // If we are not retrying failed calls either propagate or swallow the exception.
            if (_options.RetryType == RetryType.None)
            {
                switch (_options.ExceptionHandling)
                {
                    case ExceptionHandling.Propagate:
                        return false;
                    case ExceptionHandling.Ignore:
                        Debug.WriteLine($"Ignored exception: {e}");
                        return true;
                    default:
                        Debug.Fail($"Invalid ExceptionHandling option: {_options.ExceptionHandling}");
                        return true;
                }
            }

            // Get the size of items to be buffered and retried.
            int size = items.Sum(_sizer);

            // Lock the semaphore and add the new items to the buffer.
            lock (_mutex)
            {
                // If the new items would be greater than the size of the buffer drop them or throw.
                if (size + _sizeInBytes > _options.BufferSizeBytes)
                {
                    switch (_options.BufferOverflow)
                    {
                        case BufferOverflow.IgnoreNewEntries:
                            Debug.WriteLine($"Ignored {items.Count()} entries.");
                            return true;
                        case BufferOverflow.ThrowException:
                            throw new InvalidOperationException("Buffer overflow", e);
                        default:
                            Debug.Fail($"Invalid BufferOverflow option: {_options.BufferOverflow}");
                            return true;
                    }
                }

                _sizeInBytes += size;
                _buffer.AddRange(items);
            }
            return true;
        }

        /// <summary>
        /// Try to flush the buffer if it has any entries.
        /// </summary>
        private void FlushBuffer()
        {
            // Move the current buffer into a new buffer to send.
            List<T> toSend;
            int toSendSize;
            lock (_mutex)
            {
                if (_buffer.Count() == 0)
                {
                    return;
                }
                toSend = _buffer;
                toSendSize = _sizeInBytes;
                _buffer = new List<T>();
                _retries++;
            }

            try
            {
                _consumer.Receive(toSend);
                lock (_mutex)
                {
                    _retries = 0;
                    _sizeInBytes -= toSendSize;
                }
            }
            catch (RpcException e)
            {
                if (_retries >= _options.RetryAttempts)
                {
                    lock (_mutex)
                    {
                        _retries = 0;
                        _sizeInBytes -= toSendSize;
                    }
                    if (_options.ExceptionHandling == ExceptionHandling.Propagate)
                    {
                        throw new InvalidOperationException("Max retries reached", e);
                    }
                }
                else
                {
                    // The call failed, add the items that were not successfully sent back to the buffer.
                    lock (_mutex)
                    {
                        _buffer.AddRange(toSend);
                    }
                }
            }
        }
    }
}