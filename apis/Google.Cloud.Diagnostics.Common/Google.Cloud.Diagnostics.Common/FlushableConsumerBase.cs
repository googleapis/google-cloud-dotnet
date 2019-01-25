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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Base class for the <see cref="IFlushableConsumer{T}"/> that uses a <see cref="SemaphoreSlim"/> to
    /// protect the flush and receive calls.
    /// </summary>
    internal abstract class FlushableConsumerBase<T> : IFlushableConsumer<T>
    {
        /// <summary>A semaphore to protect the buffer.</summary>
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);

        // TODO: Consider adding a semaphore to protect the consumer.
        /// <summary>The consumer to flush to.</summary>
        private readonly IConsumer<T> _consumer;

        protected FlushableConsumerBase(IConsumer<T> consumer)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
        }

        // TODO: Consider adding an async version of this method if and when it's needed.
        /// <summary>
        /// Accepts an enumerable of items while the semaphore is held.
        /// </summary>
        /// <param name="items">The items to receive. Must not be null.</param>
        /// <returns><code>true</code> if <see cref="Flush()"/> should be triggered after receiving.
        /// <code>false</code> otherwise.</returns>
        protected abstract bool ReceiveWithSemaphoreHeld(IEnumerable<T> items);

        // TODO: Consider adding an async version of this method if and when it's needed.
        /// <summary>
        /// Shallow copies the list of items currently in the consumer and resets it.
        /// </summary>
        /// <returns>The shallow copy of items.</returns>
        protected abstract IEnumerable<T> GetAndResetItemsWithSemaphoreHeld();

        /// <inheritdoc />
        public abstract void Dispose();

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            IEnumerable<T> flushableItems = null;
            _semaphore.Wait();
            try
            {
                if (ReceiveWithSemaphoreHeld(items))
                {
                    flushableItems = GetAndResetItemsWithSemaphoreHeld();
                }
            }
            finally
            {
                _semaphore.Release();
            }

            Flush(flushableItems);
        }

        /// <inheritdoc />
        public async Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken)
        {
            IEnumerable<T> flushableItems = null;
            await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                if (ReceiveWithSemaphoreHeld(items))
                {
                    flushableItems = GetAndResetItemsWithSemaphoreHeld();
                }
            }
            finally
            {
                _semaphore.Release();
            }

            await FlushAsync(flushableItems, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public void Flush()
        {
            IEnumerable<T> flushableItems = null;
            _semaphore.Wait();
            try
            {
                flushableItems = GetAndResetItemsWithSemaphoreHeld();
            }
            finally
            {
                _semaphore.Release();
            }

            Flush(flushableItems);
        }

        /// <inheritdoc />
        public async Task FlushAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<T> flushableItems = null;
            await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                flushableItems = GetAndResetItemsWithSemaphoreHeld();
            }
            finally
            {
                _semaphore.Release();
            }

            await FlushAsync(flushableItems, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Flushes an enumerable of items.
        /// </summary>
        /// <param name="items">The items to flush.</param>
        private void Flush(IEnumerable<T> items)
        {
            if (items == null || !items.Any())
            {
                return;
            }

            _consumer.Receive(items);
        }

        /// <summary>
        /// Flushes an enumerable of items asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="items">The items to flush.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        private Task FlushAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
        {
            if (items == null || !items.Any())
            {
                return CommonUtils.CompletedTask;
            }

            return _consumer.ReceiveAsync(items, cancellationToken);
        }
    }
}
