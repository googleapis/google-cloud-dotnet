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

using System.Collections.Generic;
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

        /// <summary>
        /// Accepts an enumerable of items while the semaphore is held.
        /// </summary>
        /// <param name="items">The items to receive. Cannot be null.</param>
        protected abstract void ReceiveWithSemaphoreHeld(IEnumerable<T> items);

        /// <summary>
        /// Accepts an enumerable of items asynchronously while the semaphore is held.
        /// </summary>
        /// <param name="items">The items to receive. Cannot be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        protected abstract Task ReceiveAsyncWithSemaphoreHeldAsync(
            IEnumerable<T> items, CancellationToken cancellationToken);

        /// <summary>
        /// Flushes the consumer while the semaphore is held.
        /// </summary>
        protected abstract void FlushWithSemaphoreHeld();

        /// <summary>
        /// Flushes the consumer asynchronously while the semaphore is held.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        protected abstract Task FlushAsyncWithSemaphoreHeldAsync(CancellationToken cancellationToken);


        /// <inheritdoc />
        public abstract void Dispose();

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            _semaphore.Wait();
            try
            {
                ReceiveWithSemaphoreHeld(items);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <inheritdoc />
        public async Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken)
        {
            await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                await ReceiveAsyncWithSemaphoreHeldAsync(items, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <inheritdoc />
        public void Flush()
        {
            _semaphore.Wait();
            try
            {
                FlushWithSemaphoreHeld();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <inheritdoc />
        public async Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                await FlushAsyncWithSemaphoreHeldAsync(cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
