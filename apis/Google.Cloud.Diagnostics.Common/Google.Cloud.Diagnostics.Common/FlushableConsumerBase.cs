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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Base class for the <see cref="IFlushableConsumer{T}"/> that exposes a <see cref="SemaphoreSlim"/> to
    /// protect the buffer.
    /// </summary>
    internal abstract class FlushableConsumerBase<T> : IFlushableConsumer<T>
    {
        /// <summary>A semaphore to protect the buffer.</summary>
        protected readonly SemaphoreSlim Semaphore = new SemaphoreSlim(1);

        /// <summary>The consumer to flush to.</summary>
        protected readonly IConsumer<T> Consumer;

        /// <summary>The buffered items.</summary>
        protected List<T> Items = new List<T>();

        public FlushableConsumerBase(IConsumer<T> consumer)
        {
            Consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
        }

        /// <inheritdoc />
        public abstract void Receive(IEnumerable<T> items);

        /// <inheritdoc />
        public abstract Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken);

        /// <inheritdoc />
        public void Flush()
        {
            Semaphore.Wait();
            try
            {
                FlushWithSemaphoreHeld();
            }
            finally
            {
                Semaphore.Release();
            }
        }

        /// <inheritdoc />
        public async Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Semaphore.WaitAsync(cancellationToken);
            try
            {
                await FlushAsyncWithSemaphoreHeld(cancellationToken);
            }
            finally
            {
                Semaphore.Release();
            }
        }

        /// <summary>
        /// Flushes the buffer. The caller is responsible for ensuring the semaphore is held.
        /// </summary>
        protected virtual void FlushWithSemaphoreHeld()
        {
            if (Items.Count == 0)
            {
                return;
            }

            Consumer.Receive(Items);
            Items = new List<T>();
        }

        /// <summary>
        /// Flushes the buffer asynchronously. The caller is responsible for ensuring the semaphore is held.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        protected virtual async Task FlushAsyncWithSemaphoreHeld(CancellationToken cancellationToken)
        {
            if (Items.Count == 0)
            {
                return;
            }

            await Consumer.ReceiveAsync(Items, cancellationToken);
            Items = new List<T>();
        }
    }
}
