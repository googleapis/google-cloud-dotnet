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
using System;
using System.Threading.Tasks;
using System.Threading;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IFlushableConsumer{T}"/> that will automatically flush after
    /// a given span of time.
    /// </summary>
    internal class TimedBufferingConsumer<T> : IFlushableConsumer<T>
    {
        /// <summary>A semaphore to protect the buffer.</summary>
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1); 

        /// <summary>The consumer to flush to.</summary>
        private readonly IConsumer<T> _consumer;

        /// <summary>The minimum amount of time to wait between automatically flushing the buffer.</summary>
        private readonly TimeSpan _waitTime;

        /// <summary>A clock for getting the current timestamp.</summary>
        private readonly IClock _clock;

        /// <summary>The buffered items.</summary>
        private List<T> _items;

        /// <summary>The earliest time of the next automatica flush.</summary>
        private DateTime _nextFlush;

        private TimedBufferingConsumer(IConsumer<T> consumer, TimeSpan waitTime, IClock clock)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _waitTime = waitTime;
            _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
            _items = new List<T>();
            _nextFlush = _clock.GetCurrentDateTimeUtc().Add(_waitTime);

        }

        /// <summary>
        /// Creates a new <see cref="TimedBufferingConsumer{T}"/> that will flush to the
        /// given <see cref="IConsumer{T}"/> during a <see cref="Receive(IEnumerable{T})"/> call after
        /// the preset wait time since the last flush has passed.
        /// </summary>
        /// <param name="consumer">The consumer to flush to, cannot be null.</param>
        /// <param name="waitTime">The minimum amount of time between automatic flushes.</param>
        /// <param name="clock">A clock for getting the current timestamp.</param>
        public static TimedBufferingConsumer<T> Create(IConsumer<T> consumer, TimeSpan waitTime, IClock clock = null)
            => new TimedBufferingConsumer<T>(consumer, waitTime, clock ?? SystemClock.Instance);

        /// <inheritdoc />
        public void Receive(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            semaphore.Wait();
            _items.AddRange(items);
            if (_clock.GetCurrentDateTimeUtc() >= _nextFlush)
            { 
                Flush(waitForSemaphore: false);
            }
            semaphore.Release();
        }

        /// <inheritdoc />
        public async Task ReceiveAsync(IEnumerable<T> items)
        {
            GaxPreconditions.CheckNotNull(items, nameof(items));
            await semaphore.WaitAsync();
            _items.AddRange(items);
            if (_clock.GetCurrentDateTimeUtc() >= _nextFlush)
            {
                await FlushAsync(waitForSemaphore: false);
            }
            semaphore.Release();
        }

        /// <inheritdoc />
        public void Flush() => Flush(waitForSemaphore: true);

        /// <inheritdoc />
        public async Task FlushAsync() => await FlushAsync(waitForSemaphore: true);

        /// <summary>
        /// Flush the buffer.
        /// </summary>
        /// <param name="waitForSemaphore">If true the flush will wait for the semaphore.</param>
        private void Flush(bool waitForSemaphore)
        {
            IList<T> old;
            if (waitForSemaphore) semaphore.Wait();
            old = _items;
            _items = new List<T>();
            _nextFlush = DateTime.UtcNow.Add(_waitTime);
            if (waitForSemaphore) semaphore.Release();

            if (old.Count != 0)
            {
                _consumer.Receive(old);
            }
        }

        /// <summary>
        /// Flush the buffer asynchronously.
        /// </summary>
        /// <param name="waitForSemaphore">If true the flush will wait for the semaphore.</param>
        private async Task FlushAsync(bool waitForSemaphore)
        {
            IList<T> old;
            if (waitForSemaphore) await semaphore.WaitAsync();
            old = _items;
            _items = new List<T>();
            _nextFlush = DateTime.UtcNow.Add(_waitTime);
            if (waitForSemaphore) semaphore.Release();

            if (old.Count != 0)
            {
                await _consumer.ReceiveAsync(old);
            }
        }
    }
}
