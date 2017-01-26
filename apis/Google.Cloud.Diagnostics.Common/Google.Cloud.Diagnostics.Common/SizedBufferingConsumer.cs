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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush when
    /// the buffer is full.
    /// </summary>
    internal class SizedBufferingConsumer<T> : IFlushableConsumer<T>
    {
        /// <summary>A semaphore to protect the buffer.</summary>
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);

        /// <summary>The consumer to flush to.</summary>
        private readonly IConsumer<T> _consumer;

        /// <summary>Used to obtain the size of an item.</summary>
        private readonly ISizer<T> _sizer;

        /// <summary>The size of the buffer in bytes.</summary>
        private readonly int _bufferSize;

        /// <summary>The buffered items.</summary>
        private IList<T> _items;

        /// <summary>The current size of the items.</summary>
        private int _size;

        private SizedBufferingConsumer(IConsumer<T> consumer, ISizer<T> sizer, int bufferSize)
        {
            GaxPreconditions.CheckArgument(
                bufferSize > 0, nameof(bufferSize), "bufferSize must be greater than 0");

            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _sizer = GaxPreconditions.CheckNotNull(sizer, nameof(sizer));
            _bufferSize = bufferSize;

            _items = new List<T>();
            _size = 0;
        }

        /// <summary>
        /// Creates a new <see cref="SizedBufferingConsumer{T}"/> that will flush to the
        /// given <see cref="IConsumer{T}"/>. 
        /// </summary>
        /// <param name="consumer">The consumer to flush to, cannot be null.</param>
        /// <param name="bufferSize">The buffer size in bytes.</param>
        public static SizedBufferingConsumer<T> Create(IConsumer<T> consumer, ISizer<T> sizer, int bufferSize)
            => new SizedBufferingConsumer<T>(consumer, sizer, bufferSize);

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            try
            {
                _semaphore.Wait();
                foreach (T item in items)
                {
                    _size += _sizer.GetSize(item);
                    _items.Add(item);
                    if (_size >= _bufferSize)
                    {
                        FlushesWithSemaphoreHeld();
                    }
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <inheritdoc />
        public async Task ReceiveAsync(
            IEnumerable<T> items, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            try
            {
                await _semaphore.WaitAsync(cancellationToken);
                foreach (T item in items)
                {
                    _size += _sizer.GetSize(item);
                    _items.Add(item);
                    if (_size >= _bufferSize)
                    {
                        await FlushesAsyncWithSemaphoreHeld(cancellationToken);
                    }
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <inheritdoc />
        public void Flushes()
        {
            try
            {
                _semaphore.Wait();
                FlushesWithSemaphoreHeld();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <inheritdoc />
        public async Task FlushesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                await _semaphore.WaitAsync();
                await FlushesAsyncWithSemaphoreHeld(cancellationToken);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// Flushes the buffer. The caller is responsible for ensuring the semaphore is held.
        /// </summary>
        private void FlushesWithSemaphoreHeld()
        {
            IList<T> old;
            old = _items;
            _items = new List<T>();
            _size = 0;

            if (old.Count != 0)
            {
                _consumer.Receive(old);
            }
        }

        /// <summary>
        /// Flushes the buffer asynchronously. The caller is responsible for ensuring the semaphore is held.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        private async Task FlushesAsyncWithSemaphoreHeld(CancellationToken cancellationToken)
        {
            IList<T> old;
            old = _items;
            _items = new List<T>();
            _size = 0;

            if (old.Count != 0)
            {
                await _consumer.ReceiveAsync(old, cancellationToken);
            }
        }
    }
}