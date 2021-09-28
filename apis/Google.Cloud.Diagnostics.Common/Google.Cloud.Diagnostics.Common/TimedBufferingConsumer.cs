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
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush the buffer after a 
    /// given amount of time.
    /// </summary>
    internal class TimedBufferingConsumer<T> : IFlushableConsumer<T>
    {
        private const int RetryAttempts = 10;

        /// <summary>The consumer to flush to.</summary>
        private readonly IConsumer<T> _consumer;

        private BlockingCollection<T> _receivedItems = new BlockingCollection<T>();

        /// <summary>The timer to automatically flush the buffer.</summary>
        private IThreadingTimer _timer;

        internal TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime, IThreadingTimer timer)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _timer = GaxPreconditions.CheckNotNull(timer, nameof(timer));
            // Initialize the timer to flush ever wait time interval.
            _timer.Initialize((e) => {
                try
                {
                    Flush();
                }
                catch (Exception)
                {
                    // TODO(atarafamas): This is a short term solution to ensure 
                    // we do not kill a process. See issue #2182 (currently in backlog) to track the long solution.
                }
            }, waitTime);
        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will automatically flush the 
        /// buffer to the <see cref="IConsumer{T}"/> after the given wait time.
        /// </summary>
        /// <param name="consumer">The consumer to flush to. Must not be null.</param>
        /// <param name="waitTime">The amount of time between automatic flushes.</param>
        public static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime)
            => new TimedBufferingConsumer<T>(consumer, waitTime, new SimpleThreadingTimer());

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            using var enumerator = items.GetEnumerator();
            if (enumerator.MoveNext())
            {
                Receive(enumerator, RetryAttempts);
            }
        }

        /// <inheritdoc />
        public Task ReceiveAsync(IEnumerable<T> items, CancellationToken cancellationToken)
        {
            // TODO: Should we do something with cancellationToken, like check for cancellation
            // on every iteration?
            Receive(items);
            return Task.CompletedTask;
        }

        private void Receive(IEnumerator<T> remainingItems, int attemptsRemaining)
        {
            try
            {
                do
                {
                    // We very explicitly use _receivedItems here instead of a local
                    // reference. On Flush, _receivedItems will be assigned a new
                    // collection and we want to use the new collection as soon
                    // as possible.
                    // Note that it's still possible that
                    // 1. We read _receivedItems.
                    // 2. We lose execution and a Flush starts.
                    // 3. Flush swaps _receivedItems.
                    // 4. Flush marks the old items (the one we are referencing) as CompleteAdding.
                    // 5. We gain execution and execute Add on a completed collection, which fails.
                    // That's why we catch InvalidOperationException and simply reattempt just
                    // where we left off.
                    // Also note that if we regain execution in between 3 and 4, that's fine.
                    // Our call to Add will happen before the call to CompleteAdding, so it will
                    // succeed before the collection is marked as complete.
                    _receivedItems.Add(remainingItems.Current);
                    attemptsRemaining = RetryAttempts;
                }
                while (remainingItems.MoveNext());
            }
            catch (InvalidOperationException) when (attemptsRemaining > 0)
            {
                Interlocked.MemoryBarrier();
                Receive(remainingItems, --attemptsRemaining);
            }
        }

        /// <inheritdoc />
        public void Flush()
        {
            BlockingCollection<T> flushableItems = Interlocked.Exchange(ref _receivedItems, new BlockingCollection<T>());
            flushableItems.CompleteAdding();
            _consumer.Receive(flushableItems);
        }

        /// <inheritdoc />
        public async Task FlushAsync(CancellationToken cancellationToken = default)
        {
            BlockingCollection<T> flushableItems = Interlocked.Exchange(ref _receivedItems, new BlockingCollection<T>());
            flushableItems.CompleteAdding();
            await _consumer.ReceiveAsync(flushableItems, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _timer.Dispose();
            Flush();
        }
    }
}
